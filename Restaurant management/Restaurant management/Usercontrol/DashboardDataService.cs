
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace Restaurant_management.User_control
{
    public class DailyRevenue
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    public class BestSellingDish
    {
        public string Name { get; set; } = "";
        public int Quantity { get; set; }
    }

    public class DashboardData
    {
        public decimal TodayRevenue { get; set; }
        public decimal MonthRevenue { get; set; }
        public int TodayItemsSold { get; set; }
        public int OccupiedTables { get; set; }
        public int TotalTables { get; set; }
        public int TotalDishes { get; set; }

        public List<DailyRevenue> WeeklyRevenue { get; set; }
            = new List<DailyRevenue>();

        public List<BestSellingDish> BestSellingDishes { get; set; }
            = new List<BestSellingDish>();
    }

    public class DashboardDataService
    {
        // Cùng máy chủ/database đang dùng trong UC_Revenue.
        // Sau này có thể chuyển về cấu hình chung.
        private readonly string connectionString =
            @"Data Source=LAPTOP-MK554FA4;" +
            "Initial Catalog=QuanLyNhaHang;" +
            "Integrated Security=True;" +
            "Trust Server Certificate=True";

        public DashboardData GetDashboardData()
        {
            DashboardData result = new DashboardData();
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            DateTime monthStart =
                new DateTime(today.Year, today.Month, 1);

            DateTime weekStart = today.AddDays(-6);

            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. Doanh thu hôm nay
                result.TodayRevenue = GetDecimal(
                    conn,
                    @"SELECT COALESCE(SUM(ThanhTien), 0)
                      FROM dbo.DoanhThu
                      WHERE NgayTao >= @start
                        AND NgayTao < @end",
                    today, tomorrow);

                // 2. Doanh thu tháng hiện tại
                result.MonthRevenue = GetDecimal(
                    conn,
                    @"SELECT COALESCE(SUM(ThanhTien), 0)
                      FROM dbo.DoanhThu
                      WHERE NgayTao >= @start
                        AND NgayTao < @end",
                    monthStart, tomorrow);

                // 3. Số lượng món đã bán hôm nay
                result.TodayItemsSold = GetInt(
                    conn,
                    @"SELECT COALESCE(SUM(SoLuong), 0)
                      FROM dbo.DoanhThu
                      WHERE NgayTao >= @start
                        AND NgayTao < @end",
                    today, tomorrow);

                // 4. Bàn đang phục vụ
                result.OccupiedTables = GetInt(
                    conn,
                    @"SELECT COUNT(*)
                      FROM dbo.Ban
                      WHERE TrangThai = 1");

                result.TotalTables = GetInt(
                    conn,
                    "SELECT COUNT(*) FROM dbo.Ban");

                // 5. Tổng món trong thực đơn
                result.TotalDishes = GetInt(
                    conn,
                    "SELECT COUNT(*) FROM dbo.ThucDon");

                // 6. Doanh thu của 7 ngày gần nhất
                Dictionary<DateTime, decimal> revenueByDate =
                    new Dictionary<DateTime, decimal>();

                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT NgayTao,
                             SUM(COALESCE(ThanhTien, 0))
                      FROM dbo.DoanhThu
                      WHERE NgayTao >= @start
                        AND NgayTao < @end
                      GROUP BY NgayTao
                      ORDER BY NgayTao", conn))
                {
                    cmd.Parameters.AddWithValue("@start", weekStart);
                    cmd.Parameters.AddWithValue("@end", tomorrow);

                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                revenueByDate[
                                    reader.GetDateTime(0).Date
                                ] = reader.IsDBNull(1)
                                    ? 0m
                                    : Convert.ToDecimal(
                                        reader.GetValue(1));
                            }
                        }
                    }
                }

                // Bổ sung những ngày không có giao dịch
                for (int i = 0; i < 7; i++)
                {
                    DateTime day = weekStart.AddDays(i);

                    result.WeeklyRevenue.Add(new DailyRevenue
                    {
                        Date = day,
                        Amount = revenueByDate.TryGetValue(
                            day, out decimal value) ? value : 0m
                    });
                }

                // 7. Top 5 món bán chạy từ doanh thu
                using (SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP (5)
                             TenMon,
                             SUM(COALESCE(SoLuong, 0))
                      FROM dbo.DoanhThu
                      WHERE TenMon IS NOT NULL
                      GROUP BY TenMon
                      ORDER BY
                          SUM(COALESCE(SoLuong, 0)) DESC,
                          TenMon", conn))
                {
                    using (SqlDataReader reader =
                        cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.BestSellingDishes.Add(
                                new BestSellingDish
                                {
                                    Name = reader.GetString(0),
                                    Quantity = Convert.ToInt32(
                                        reader.GetValue(1))
                                });
                        }
                    }
                }
            }

            return result;
        }

        private decimal GetDecimal(
            SqlConnection conn, string query,
            DateTime start, DateTime end)
        {
            using (SqlCommand cmd =
                new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        private int GetInt(SqlConnection conn, string query)
        {
            using (SqlCommand cmd =
                new SqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private int GetInt(
            SqlConnection conn, string query,
            DateTime start, DateTime end)
        {
            using (SqlCommand cmd =
                new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}
