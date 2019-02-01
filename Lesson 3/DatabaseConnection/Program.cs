using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WideWorldImporters.Sales;

namespace DatabaseConnection
{
    class Program
    {
        static readonly string connectionString = "Server=localhost;Database=WideWorldImporters;Trusted_Connection=True";
        static readonly string sql = "SELECT OrderLineId, StockItemId, Description, Quantity, UnitPrice, TaxRate FROM WideWorldImporters.Sales.OrderLines where OrderId = 26866";
        static void Main(string[] args)
        {
            QueryWithDataReader();
            QueryWithDataAdapter();
        }

        static void QueryWithDataReader() {
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try {
                    conn.Open();
                } catch (Exception ex) {
                    Console.WriteLine($"Unable to connect to database: {ex.Message}");
                    return;
                } 
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<OrderLines> lines = new List<OrderLines>();
                if (reader.HasRows) {
                    while(reader.Read()){
                        OrderLines line = new OrderLines();
                        line.OrderLineID = reader.GetInt32(0);
                        line.StockItemID = reader.GetInt32(1);
                        line.Description = reader.GetString(2);
                        line.Quantity = reader.GetInt32(3);
                        line.UnitPrice = reader.GetDecimal(4);
                        line.TaxRate = reader.GetDecimal(5);
                        lines.Add(line);
                    }
                }
                Console.WriteLine($"Count: {lines.Count}");
                lines.ForEach(l => { 
                    Console.WriteLine($"{l.OrderLineID}: Item {l.StockItemID} ({l.Description, -50}) - {l.Quantity, 3} @ ${l.UnitPrice, -8}(+{l.TaxRate:F0}% Tax)");
                });
            }
        }

        static void QueryWithDataAdapter()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.TableMappings.Add("Table", "OrderLines");
                adapter.Fill(ds);
                Console.WriteLine($"Count: {ds.Tables["OrderLines"].Rows.Count}");
                foreach (DataRow line in ds.Tables["OrderLines"].Rows)
                {
                    Console.WriteLine($"{line[0]}: Item {line[1]} ({line[2], -50}) - {line[3], 3} @ ${line[4], -8}(+{line[5]:F0}% Tax)");
                } 
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
