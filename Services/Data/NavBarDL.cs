using Dapper;
using CoreMvcFront.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CoreMvcFront.Services{
    public class NavBarDL:BaseData{
        public List<NavBarItem> GetAllItems(string Conn){
            using(MySql.Data.MySqlClient.MySqlConnection sConn=new MySql.Data.MySqlClient.MySqlConnection(Conn)){
                SQLs.Clear();
                SQLs.AppendLine("SELECT * ");
                SQLs.AppendLine("FROM CoreMVCBackend.NavBarItems "); 
                SQLs.AppendLine("WHERE ItemStatus!=3 ");

                List<NavBarItem> items=sConn.Query<NavBarItem>(SQLs.ToString()).AsList();

                return items;
            }
        }
    }
}