using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using DTO;

namespace DAL
{
    public class TaiKhoanAccess : DatabaseAccess
    {
        private IMongoCollection<BsonDocument> _taiKhoanCollection;

        public TaiKhoanAccess()
        {
            // Kết nối đến MongoDB và chọn collection "TaiKhoan"
            var database = MongoDbConnection.Connect();
            _taiKhoanCollection = database.GetCollection<BsonDocument>("TaiKhoan");
            
        }

        // Phương thức kiểm tra đăng nhập
        public TaiKhoan ConvertToTaiKhoan(BsonDocument doc)
        {
            string maTaiKhoan = doc["MaTaiKhoan"].AsString; 
            string matKhau = doc["MatKhau"].AsString;
            int phanQuyen = doc["PhanQuyen"].AsInt32;

            return new TaiKhoan(maTaiKhoan, matKhau, phanQuyen);
        }

        // Kiểm tra đăng nhập
        public TaiKhoan AuthenticateUser(string username, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaTaiKhoan", username) &
                         Builders<BsonDocument>.Filter.Eq("MatKhau", password);
            var taiKhoanDoc = _taiKhoanCollection.Find(filter).FirstOrDefault();

            if (taiKhoanDoc != null)
            {
                return ConvertToTaiKhoan(taiKhoanDoc); // Trả về đối tượng TaiKhoan nếu tìm thấy
            }
            else
            {
                return null; // Không tìm thấy tài khoản
            }
        }


        // Phương thức lấy tất cả tài khoản
        public List<BsonDocument> GetAllTaiKhoan()
        {
            try
            {
                // Truy vấn tất cả tài khoản
                var taiKhoanList = _taiKhoanCollection.Find(new BsonDocument()).ToList();
                return taiKhoanList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi truy vấn MongoDB: " + ex.Message);
                return new List<BsonDocument>();
            }
        }

        // Phương thức thêm tài khoản mới
        public void AddTaiKhoan(string username, string password)
        {
            try
            {
                // Tạo tài khoản mới dưới dạng BsonDocument
                var newTaiKhoan = new BsonDocument
                {
                    { "username", username },
                    { "password", password }
                };

                // Thêm tài khoản vào collection
                _taiKhoanCollection.InsertOne(newTaiKhoan);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm tài khoản vào MongoDB: " + ex.Message);
            }
        }

        // Phương thức cập nhật mật khẩu cho tài khoản
        public void UpdatePassword(string username, string newPassword)
        {
            try
            {
                // Tạo bộ lọc tìm tài khoản theo username
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);

                // Tạo cập nhật mới cho password
                var update = Builders<BsonDocument>.Update.Set("password", newPassword);

                // Thực hiện cập nhật
                _taiKhoanCollection.UpdateOne(filter, update);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật mật khẩu: " + ex.Message);
            }
        }

        // Phương thức xóa tài khoản
        public void DeleteTaiKhoan(string username)
        {
            try
            {
                // Tạo bộ lọc tìm tài khoản theo username
                var filter = Builders<BsonDocument>.Filter.Eq("username", username);

                // Thực hiện xóa tài khoản
                _taiKhoanCollection.DeleteOne(filter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa tài khoản: " + ex.Message);
            }
        }

        public int KiemTraPhanQuyen(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("MaTaiKhoan", username);
            var taiKhoanDoc = _taiKhoanCollection.Find(filter).FirstOrDefault();
            
            return taiKhoanDoc["PhanQuyen"].AsInt32; // Trả về phân quyền
        }

    }
}
