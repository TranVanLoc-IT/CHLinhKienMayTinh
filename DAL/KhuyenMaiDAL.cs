using DAL.LKMTTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.LKMT;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        private KHUYENMAITableAdapter _km;
        public KhuyenMaiDAL()
        {
            _km = new KHUYENMAITableAdapter();
        }
        // Phương thức trả về KHUYENMAIDataTable hiện tại
        public List<ResponseDTO.KhuyenMai> GetData()
        {
            return _km.GetData().Select(row => new ResponseDTO.KhuyenMai
            {
                MaCT = row.MaCT,
                MaHD = row.IsMaDHNull() ? "" : row.MaDH, // Kiểm tra giá trị NULL trước khi gán
                MaKhuyenMai = row.MaKhuyenMai,
                DaDung = row.DaDung
            }).ToList();

        }

        public void Update(KHUYENMAIDataTable km)
        {
            _km.Update(km);  // Cập nhật DataTable vào cơ sở dữ liệu
        }

        public void Create(EditDTO.KhuyenMai km)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=MSI;Initial Catalog=LKMT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Câu lệnh SQL
            string sql = @"
                INSERT INTO KhuyenMai (MaKhuyenMai, MaDH, MaCT, DaDung)
                VALUES (@MaKhuyenMai, @MaHD, @MaCT, @DaDung)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Thêm tham số và kiểm tra giá trị NULL
                        command.Parameters.AddWithValue("@MaKhuyenMai", km.MaKhuyenMai ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MaHD", km.MaHD ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@MaCT", km.MaCT ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@DaDung", km.DaDung);

                        // Thực thi lệnh SQL
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý ngoại lệ SQL
                Console.WriteLine("Lỗi SQL: " + ex.Message);
                throw;
            }
        }

            public void Delete(string id)
        {
            QueriesTableAdapter query = new QueriesTableAdapter();
            query.XoaKhuyenMai(id);
        }
        public IEnumerable<ResponseDTO.KhuyenMai> GetKhuyenMaisByDaDung(string maCT, bool daDung)
        {
            return _km.GetData().Where(row => row.MaCT == maCT && row.DaDung == daDung).Select(row => new ResponseDTO.KhuyenMai
            {
                MaCT = row.MaCT,
                MaHD = row.IsMaDHNull() ? "" : row.MaDH,
                MaKhuyenMai = row.MaKhuyenMai,
                DaDung = row.DaDung
            }).ToList();
        }
        public int GetQuantityByProgramId(string maCT)
        {
            return _km.GetData().Where(row => row.MaCT == maCT).Count();
        }
    }
}
