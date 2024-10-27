using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
			Console.WriteLine();
			Console.WriteLine("--------------------");
			SqlConnection connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Initial Catalog=EgitimKampiDb; Integrated Security=true; TrustServerCertificate=True");

			#region Kategori Ekleme İşlemi

			//Console.WriteLine("Eklemek istediğiniz Kategori Adı: ");
			//string categoryName = Console.ReadLine();
			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
			//command.Parameters.AddWithValue("@p1", categoryName);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Kategori başarıyla eklendi.");

			#endregion

			#region Ürün Ekleme İşlemi

			//string productName;
			//decimal productPrice;
			//bool productStatus;

			//Console.WriteLine("Ürünün Adı: ");
			//productName = Console.ReadLine();
			//Console.WriteLine("Ürünün Fiyatı: ");
			//productPrice = decimal.Parse(Console.ReadLine());

			//connection.Open();
			//SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.Parameters.AddWithValue("@productStatus", true);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Ürün başarıyla eklendi.");

			#endregion

			#region Ürün Listeleme İşlemi

			//connection.Open();
			//SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
			//SqlDataAdapter adapter = new SqlDataAdapter(command);
			//DataTable dataTable = new DataTable();
			//adapter.Fill(dataTable);

			//foreach (DataRow row in dataTable.Rows)
			//{
			//	foreach (var item in row.ItemArray)
			//	{
			//		Console.Write(item.ToString()+ " ");
			//	}
			//	Console.WriteLine();
			//}
			//connection.Close();

			#endregion

			#region Ürün Silme İşlemi

			//Console.WriteLine("Silinecek Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());

			//connection.Open();
			//SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Ürün başarıyla silindi.");

			#endregion

			#region Ürün Günecelleme İşlemi

			//Console.WriteLine("Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());
			//Console.WriteLine("Ürün Adı: ");
			//string productName = Console.ReadLine();
			//Console.WriteLine("Ürün Fiyatı: ");
			//decimal productPrice = decimal.Parse(Console.ReadLine());

			//connection.Open();
			//SqlCommand command = new SqlCommand("update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
			//command.Parameters.AddWithValue("@productId", productId);
			//command.Parameters.AddWithValue("@productName", productName);
			//command.Parameters.AddWithValue("@productPrice", productPrice);
			//command.ExecuteNonQuery();
			//connection.Close();
			//Console.WriteLine("Ürün başarıyla güncellendi.");

			#endregion


			Console.Read();
		}
	}
}