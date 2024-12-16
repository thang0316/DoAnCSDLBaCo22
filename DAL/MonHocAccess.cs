using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Driver;
using static DAL.DatabaseAccess;

namespace DAL
{
    public class MonHocAccess
    {
        private IMongoCollection<MonHoc> _monhocCollection;
        public MonHocAccess()
        {
            var database = MongoDbConnection.Connect();
            _hocphanCollection = database.GetCollection<HocPhan>("HocPhan");
        }
    }
}
