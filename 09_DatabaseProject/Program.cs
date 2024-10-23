using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
            string tableNumber;
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
			tableNumber = Console.ReadLine();
			Console.WriteLine("--------------------");

			SqlConnection sqlConnection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=EgitimKampiDb; Integrated Security=true; TrustServerCertificate=True");
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("Select * From TblCategory", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			sqlConnection.Close();

			foreach (DataRow row in dataTable.Rows) 
			{
				foreach (var item in row.ItemArray) 
				{
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

			Console.Read();
		}
	}
}
