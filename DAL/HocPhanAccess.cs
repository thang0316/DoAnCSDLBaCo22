using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class HocPhanAccess : DatabaseAccess
    {
        private IMongoCollection<HocPhan> _hocphanCollection;
        public HocPhanAccess()
        {
            var database = MongoDbConnection.Connect();
            _hocphanCollection = database.GetCollection<HocPhan>("HocPhan");
        }

        public List<HocPhan> GetHocPhan()
        {
            return _hocphanCollection.Find(h => true).ToList();
        }

    }
}
