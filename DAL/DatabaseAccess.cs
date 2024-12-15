using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Configuration;

namespace DAL
{
    public class DatabaseAccess
    {
        public class MongoDbConnection
        {
            private static IMongoDatabase _database;

            // Phương thức kết nối đến MongoDB
            public static IMongoDatabase Connect()
            {
                // Lấy chuỗi kết nối từ app.config
                string connectionString = ConfigurationManager.ConnectionStrings["MongoDBConnection"].ConnectionString;

                // Tạo đối tượng MongoClient
                var client = new MongoClient(connectionString);

                // Kết nối đến cơ sở dữ liệu "NHOM7"
                _database = client.GetDatabase("NHOM7");

                // Trả về đối tượng cơ sở dữ liệu đã kết nối
                return _database;
            } 
        }
    }
}
