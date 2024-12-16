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
    public class SinhVienAccess : DatabaseAccess
    {
        private IMongoCollection<BsonDocument> _sinhvienCollection;
        public SinhVienAccess() {
            var database = MongoDbConnection.Connect();
            _sinhvienCollection = database.GetCollection<BsonDocument>("SinhVien");
        }

        private SinhVien ConvertToSinhVien(BsonDocument doc)
        {
            return new SinhVien
            (
                doc["MaTaiKhoan"].AsString,
                doc["HoTen"].AsString,
                doc["NgaySinh"].ToUniversalTime(),
                doc["GioiTinh"].AsString,
                doc["DiaChi"].AsString,
                doc["Email"].AsString,
                doc["Khoa"].AsString,
                doc["Nganh"].AsString,
                doc["SoDienThoai"].AsString
            );
        }

        public SinhVien GetSinhVienByMaTaiKhoan(string maTaiKhoan)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaTaiKhoan", maTaiKhoan);
            var sinhvien = _sinhvienCollection.Find(filter).FirstOrDefault();
            if (sinhvien != null)
            {
                return ConvertToSinhVien(sinhvien);
            }
            else
            {
                return null;
            }
        }
    }
}
