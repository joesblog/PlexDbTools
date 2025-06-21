using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexDBLib
{
  public partial  class Context : IDisposable
  {
    public System.Data.SQLite.SQLiteConnection conn;
    public List<string> err = new List<string>();

    public Context(string dbPath)
    {
      conn = new SQLiteConnection(dbPath);
      try
      {
        conn.Open();
         
      }
      catch (Exception x)
      {
        err.Add(x.Message);
      }
    }
 

    public void Dispose()
    {
      try
      {

        conn.Close();
      }
      catch (Exception x)
      {
        err.Add(x.Message);

      }
      conn.Dispose();
    }
  }
}
