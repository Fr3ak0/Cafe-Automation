using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public class DailySalesCalculator
    {
        cGeneral gnl = new cGeneral();

        public decimal GetTotalPaymentsForToday()
        {
            decimal totalPayments = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(gnl.conString))
                {
                    connection.Open();   
                    DateTime today = DateTime.Today;
                    string query = "SELECT SUM(TOTAL) FROM Payments WHERE CONVERT(DATE, DATE) = @Date";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ayarla
                        command.Parameters.AddWithValue("@Date", today);

                        // Toplam ödemeyi al
                        object result = command.ExecuteScalar();

                        // Eğer sonuç null değilse, decimal'e dönüştür
                        if (result != null && result != DBNull.Value)
                        {
                            totalPayments = Convert.ToDecimal(result);
                        }
                        else
                        {
                            Console.WriteLine("SQL sorgusu null değer döndü.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            return totalPayments;
        }
        public decimal GetTotalPaymentsForMonth()
        {
            decimal totalPayments = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(gnl.conString))
                {
                    connection.Open();
                    DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                    string query = "SELECT SUM(TOTAL) FROM Payments WHERE CONVERT(DATE, DATE) BETWEEN @StartDate AND @EndDate";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ayarla
                        command.Parameters.AddWithValue("@StartDate", firstDayOfMonth);
                        command.Parameters.AddWithValue("@EndDate", lastDayOfMonth);

                        // Toplam ödemeyi al
                        object result = command.ExecuteScalar();

                        // Eğer sonuç null değilse, decimal'e dönüştür
                        if (result != null && result != DBNull.Value)
                        {
                            totalPayments = Convert.ToDecimal(result);
                        }
                        else
                        {
                            Console.WriteLine("SQL sorgusu null değer döndü.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }

            return totalPayments;
        }

    }
}
