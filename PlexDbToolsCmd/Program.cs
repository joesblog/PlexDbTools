using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SQLite;
using Dapper;
using System.Data;
using System.Configuration;

namespace PlexDbToolsCmd
{
  internal partial class Program
  {
    static void Main(string[] args)
    {



      using (PlexDBLib.Repositories.Repo_devices r = new PlexDBLib.Repositories.Repo_devices(new PlexDBLib.Context($@"{ConfigurationManager.AppSettings["PATH_DBConnectionString"]}")))
      {
        var x = r.devices_GetAll();
        DateTime st = new DateTime(1970, 1, 1);
        foreach (var i in x)
        {

          Console.Write($@"
------------------
ID:       {i.id}
Name:     {i.name}
Updated:  {i.dte_created_at}
------------------");
        }
      }

    }




  }

   
}