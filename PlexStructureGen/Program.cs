using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;

namespace PlexStructureGen
{
  internal class Program
  {


    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      string opFolder = ConfigurationManager.AppSettings["PATH_BaseOutput"];
      SQLCodeGen.Repository r = new SQLCodeGen.Repository(new SQLCodeGen.Context());
      var tbls = r.Table_GetAll();

      var typesused = r.GetAllDataTypesUsedOnDb(tbls);
      var lup = r.GenerateTypeLookupDictionary(typesused);
      r.WriteModels("PlexDBLib.Models", @$"{opFolder}\Models\", tbls);
      r.WriteRepos("PlexDBLib.Repositories", "PlexDBLib.Models", "PlexDBLib.Context", @$"{opFolder}\Repositories\", tbls);

    }
  }

  public class SQLCodeGen
  {

    public class table_info
    {
      public int cid { get; set; }
      public string name { get; set; }
      public string type { get; set; }
      public bool notnull { get; set; }
      public string dflt_value { get; set; }
      public bool pk { get; set; }
    }

    public class TableMeta
    {
      public string type { get; set; }
      public string name { get; set; }
      public string tbl_name { get; set; }
      public int rootpage { get; set; }
      public string sql { get; set; }
    }

    public static Dictionary<string, Type> typeLookup = new Dictionary<string, Type>() {
{ "INTEGER",typeof(int) },
{ "varchar(255)",typeof(string) },
{ "dt_integer(8)",typeof(long) },
{ "boolean",typeof(bool) },
{ "timestamp",typeof(DateTime) },
{ "BLOB",typeof(byte[]) },
{ "string",typeof(string) },
{ "float",typeof(double) },
{ "TEXT",typeof(string) },
{ "integer(8)",typeof(long) },
{ "VARCHAR(255)",typeof(string) },
{ "INT",typeof(int) },
{ "REAL",typeof(double) },
{ "FLOAT",typeof(double) }
};



    public class Repository
    {
      public Context c;

      public Repository(Context c)
      {
        this.c = c;
      }

      public IEnumerable<TableMeta> Table_GetAll()
      {
        return c.con.Query<TableMeta>("SELECT * FROM sqlite_master WHERE type = 'table' AND name NOT LIKE 'sqlite_%' ORDER BY name ASC; ");
      }

      public IEnumerable<table_info> GetTableInfo(string tableName)
      {

        IEnumerable<table_info> r = null;
        try
        {
          r = c.con.Query<table_info>($"PRAGMA table_info({tableName})");
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.Message);
        }

        return r;

      }

      /// <summary>
      /// generate a blank types lookup table.
      /// </summary>
      /// <param name="FromAllTypesOnDB"></param>
      /// <returns></returns>
      public string GenerateTypeLookupDictionary(List<string> FromAllTypesOnDB)
      {


        StringBuilder sb = new StringBuilder();
        Dictionary<string, Type> d = new Dictionary<string, Type>() {
        { "string", typeof(string)}
        };

        sb.AppendLine("public static Dictionary<string, Type> typeLookup = new Dictionary<string, Type>() {");
        foreach (string i in FromAllTypesOnDB)
        {
          string cma = (i != FromAllTypesOnDB.Last()) ? "," : "";
          sb.AppendLine($"{{ \"{i}\",typeof(string) }}{cma}");
        }
        sb.AppendLine("};");

        return sb.ToString();
      }

      public List<string> GetAllDataTypesUsedOnDb(IEnumerable<TableMeta> tm)
      {
        List<string> r = new List<string>();

        foreach (var i in tm)
        {

          var ti = GetTableInfo(i.name);
          if (ti == null) continue;
          if (ti.Any(o => o.type == "")) continue;
          foreach (var t in ti)
          {

            if (!r.Contains(t.type))
            {
              r.Add(t.type);
            }
          }
        }




        return r;

      }


      public void WriteModels(string ns, string folder, IEnumerable<TableMeta> tables)
      {
        if (!Directory.Exists(folder))
          throw new Exception("WriteModel: Folder does note exist ");

        foreach (var tm in tables)
        {

          string code = WriteModelClass(ns, tm);
          string fn = Path.Join(folder, tm.name + ".cs");
          File.WriteAllText(fn, code);
        }

      }

      private string WriteModelClass(string ns, TableMeta tm)
      {
        int tab = 0;

        StringBuilder sb = new StringBuilder();
        void wrl(string txt)
        {
          sb.AppendLine($"{new string('\t', tab)}{txt}");
        }
        string namespaces =
@"using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;
using System.ComponentModel;
";
        wrl(namespaces);
        wrl("#pragma warning disable CS8618");
        wrl("#pragma warning disable CS8981");
        wrl($"namespace {ns} {{");
        tab++;
        wrl($"public class {tm.name} {{");
        tab++;

        var types = this.GetTableInfo(tm.name);
        if (types == null || types.Any(o => o.type == ""))
        {

          wrl("//unsupported datatype found");
          wrl("}}");
          wrl("#pragma warning restore CS8618");
          wrl("#pragma warning restore CS8981");
          return sb.ToString();
        }

        wrl("public List<string> changedProperties = new List<string>();");
        wrl("#region fields");
        tab++;
        foreach (var t in types)
        {
          var csType = PlexStructureGen.SQLCodeGen.typeLookup[t.type];

          wrl($"private {csType.Name} _{t.name};// sqllite type = {t.type}");



        }
        tab--;
        wrl("#endregion");
        wrl("#region props");
        tab++;
        foreach (var t in types)
        {
          var csType = PlexStructureGen.SQLCodeGen.typeLookup[t.type];
          wrl($"public {csType.Name} @{t.name}");
          wrl("{");
          tab++;
          wrl("get");
          wrl("{"); //start get
          tab++;
          wrl($"return this._{t.name};");
          tab--;
          wrl("}"); //end get

          wrl("set");
          wrl("{");
          tab++;
          wrl($"if (_{t.name} != value)");
          wrl("{");
          tab++;
          wrl($"_{t.name} = value;");
          wrl($"this.changedProperties.Add(\"{t.name}\");");
          tab--;
          wrl("}");
          tab--;
          wrl("}");

          tab--;
          wrl("}");

          // wrl($"public {csType.Name} @{t.name}  {{get;set;}} // sqllite type = {t.type}");
          wrl("");

          //if its a date time give a c# compat alternative
          if (t.type.ToLower() == "dt_integer(8)")
          {
            wrl($"public DateTime? dte_{t.name}");
            wrl("{");
            tab++;
            wrl("get");
              wrl("{");
              tab++;
              wrl("try");
                wrl("{");
                tab++;
                  wrl($"var r = @{t.name}.ToDateTimeLocal();");
                  wrl("return r;");
                tab--;
                wrl("}");
              wrl("catch(Exception ex)");
                wrl("{");
                tab++;
                  wrl("return null;");
                tab--;
                wrl("}");
              tab--;
              wrl("}");

            tab--;
            wrl("}");

          }
        }
        tab--;
        wrl("#endregion");
        tab--;
        wrl("}");
        wrl("#pragma warning restore CS8618");
        wrl("#pragma warning restore CS8981");
        tab--;
        wrl("}");
        return sb.ToString();
      }

      internal void WriteRepos(string ns, string nsModels, string ContextName, string folder, IEnumerable<TableMeta> tables)
      {
        if (!Directory.Exists(folder))
          throw new Exception("WriteModel: Folder does note exist ");

        foreach (var tm in tables)
        {

          string code = WriteRepoClass(ns, nsModels, ContextName, tm);
          string fn = Path.Join(folder, tm.name + ".cs");
          File.WriteAllText(fn, code);
        }
      }

      private string WriteRepoClass(string ns, string nsmodel, string ContextName, TableMeta tm)
      {
        int tab = 0;

        StringBuilder sb = new StringBuilder();
        var types = this.GetTableInfo(tm.name);
        if (types == null) return "";
        bool hasPK = types.Any(o => o.pk);
        void wrl(string txt)
        {
          sb.AppendLine($"{new string('\t', tab)}{txt}");
        }
        string namespaces =
@"using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.IO;";
        wrl(namespaces);
        wrl("#pragma warning disable CS8618");
        wrl("#pragma warning disable CS8981");
        wrl($"namespace {ns} {{");
        tab++;
        wrl($"public class Repo_{tm.name} : IDisposable {{");
        tab++;

        if (types == null || types.Any(o => o.type == ""))
        {

          return ("//unsupported datatype found");
          //wrl("}}");
         // return sb.ToString();
        }

        //context var
        wrl($"public {ContextName} c {{get;set;}}");
        wrl($"public Repo_{tm.name}({ContextName} x) ");
        wrl("{");
        tab++;
        wrl($"this.c = x;");
        tab--;
        wrl("}");


        //Get All Query
        {
          wrl($"public IEnumerable<{nsmodel}.{tm.name}> {tm.name}_GetAll()");
          wrl("{");
          tab++;
          wrl($"var r =  c.conn.Query<{nsmodel}.{tm.name}>(\"SELECT * from {tm.tbl_name};\");");
          wrl("foreach (var x in r){x.changedProperties.Clear();}");
          wrl("return r;");
          tab--;
          wrl("}");

        }
        if (hasPK)
        {
          table_info pkF = types.First(o => o.pk);
          var csType = PlexStructureGen.SQLCodeGen.typeLookup[pkF.type];

          //Get By ID
          {

            wrl($"public {nsmodel}.{tm.name}? {tm.name}_GetBy{pkF.name} ({csType} {pkF.name} )");
            wrl("{");
            tab++;
            wrl($"var r =  c.conn.Query<{nsmodel}.{tm.name}>($\"SELECT * FROM {tm.name} WHERE {pkF.name} = {{{pkF.name}}}\").FirstOrDefault();");
            wrl("r.changedProperties.Clear();");
            wrl("return r;");

            tab--;
            wrl("}");
          }
          //Update By ID
          { 
            wrl($"public void {tm.name}_Update ({nsmodel}.{tm.name} _{tm.name} )");
            wrl("{");
            tab++;
            wrl($"if (_{tm.name}.changedProperties.Count == 0) return;");
            wrl($"string sql = @\"UPDATE {tm.tbl_name}\";");
            wrl($"sql += \"\\r\\nSET\";");
            wrl($"foreach (var p in _{tm.name}.changedProperties)");
            wrl("{");
            tab++;
            wrl($"string cma = (p == _{tm.name}.changedProperties.Last()) ? \"\" : \",\";");
            wrl($"sql += $\"\\r\\n{{p}} = @{{p}}{{cma}}\";");
            tab--;
            wrl("}");
            wrl($"sql += $\"\\r\\nWHERE {pkF.name} = @{pkF.name};\";");
            wrl($"c.conn.Execute(sql,_{tm.name});");


            tab--;
            wrl("}");

          }

        }

        wrl("public void Dispose()");
        wrl("{");
        tab++;
        wrl("this.c.Dispose();");
        tab--;
        wrl("}");
        tab--;
        wrl("}");
        tab--;
        wrl("}");


        return sb.ToString();
      }
    }
    public class Context : IDisposable
    {

      public System.Data.SQLite.SQLiteConnection con;
      public List<string> err = new List<string>();
      public Repository repo;
      public Context(string dbPath)
      {
        con = new SQLiteConnection(dbPath);
        try
        {
          con.Open();
          repo = new Repository(this);
        }
        catch (Exception x)
        {
          err.Add(x.Message);
        }
      }
      public Context() : this(@"Data Source=H:\PLEX\Plex Media Server\Plug-in Support\Databases\com.plexapp.plugins.library.db")
      {

      }

      public void Dispose()
      {
        try
        {

          con.Close();
        }
        catch (Exception x)
        {
          err.Add(x.Message);

        }
        con.Dispose();
      }
    }


  }

}