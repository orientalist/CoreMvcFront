using CoreMvcFront.Model;
using Microsoft.Extensions.Options;
using MySql.Data;

namespace CoreMvcFront.Utility{
    public class ConfigHelper{
        private readonly IOptions<MySqlConnection> _MySqlConnection;

        public ConfigHelper(IOptions<MySqlConnection> Connection){
            _MySqlConnection=Connection;
        }

        public string ConnectionString{
            get{
                string str=string.Format("server={0};user={1};database={2};port={3};password={4};",
                _MySqlConnection.Value.RDS_Hostname,
                _MySqlConnection.Value.RDS_User,
                _MySqlConnection.Value.RDS_DBName,
                "3306",
                _MySqlConnection.Value.RDS_Password);

                return str;
            }
        }
    }
}