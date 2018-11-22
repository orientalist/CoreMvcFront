using Dapper;
using CoreMvcFront.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CoreMvcFront.Services{
    public class DailyNewsData:BaseData{
        public List<DailyNews> GetDailyNews(string Conn){
            using(MySql.Data.MySqlClient.MySqlConnection sqlConnection=new MySql.Data.MySqlClient.MySqlConnection(Conn)){
                SQLs.AppendLine("SELECT * ");
                SQLs.AppendLine("FROM CoreMVCBackend.DailyNews "); 
                SQLs.AppendLine("WHERE ItemStatus!=3 ");
                SQLs.AppendLine("ORDER BY NewsDate DESC");

                List<DailyNews> news=sqlConnection.Query<DailyNews>(SQLs.ToString()).AsList();

                return news;
            }
        }
    }
}