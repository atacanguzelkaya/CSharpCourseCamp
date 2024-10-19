using System;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Void Metotlar
			//Geriye Değer Döndürmeyen Metotlar
			// Customer --> Listele, Ekle, Sil, Güncelle

			//void CustomerList()
			//{

			//	Console.WriteLine("Atacan Güzelkaya");
			//	Console.WriteLine("Ata Güzel");
			//	Console.WriteLine("Can Kaya");
			//	Console.WriteLine("Ata Kaya");
			//}
			//CustomerList();
			//CustomerList();

			//void Sum()
			//{
			//	int x = 1; 
			//	int y = 2;
			//	int z = x + y;
			//	Console.WriteLine(z);
			//}
			//Sum();

			#endregion

			#region Geriye Değer Döndürmeyen String Parametreli Metotlar

			//void WriteMethod(string customerName)
			//{
			//	Console.WriteLine(customerName);
			//}
			//WriteMethod("Atacan Güzelkaya");

			//void CustomerCard(string name, string surName)
			//{
			//	Console.WriteLine("Customer: " + name + " " + surName);
			//}
			//CustomerCard("Atacan","Güzelkaya");

			#endregion

			#region Geriye Değer Döndürmeyen Int Parametreli Metotlar

			//void Sum(int number1, int number2, int number3 )
			//{
			//	int result = number1 + number2 + number3;
			//	Console.WriteLine(result);
			//}
			//Sum(4,5,6);

			#endregion

			#region Geriye Değer Döndüren Metotlar

			//string CustomerName()
			//{
			//	return "Atacan Güzelkaya";
			//}
			//CustomerName();

			//string StudentCard()
			//{
			//	string name = "Ata";
			//	string surname = "Kaya";
			//	return name + " " + surname;
			//}
			//Console.WriteLine(StudentCard());

			#endregion

			#region Geriye Değer Döndüren String Parametreli Metotlar

			//string CountryCard(string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = "Ülke: "+ countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
			//	return cardInfo;
			//}
			//string x, y, z;
			//Console.WriteLine("Ülke adı giriniz: ");
			//x = Console.ReadLine();

			//Console.WriteLine("Başkent giriniz: ");
			//y = Console.ReadLine();

			//Console.WriteLine("Bayrak Rengi giriniz: ");
			//z = Console.ReadLine();

			//Console.WriteLine(CountryCard(x,y,z));
			//Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

			#endregion

			#region Geriye Değer Döndüren Int Parametreli Metotlar

			//int Sum(int number1, int number2)
			//{
			//	int result = number1 + number2;
			//	return result;
			//}
			//Console.WriteLine(Sum(45,98));
			//Console.WriteLine(Sum(36,25));
			//Console.WriteLine(Sum(44,36));

			#endregion

			#region Örnek Uygulama

			string ExamResult(string student, int exam1, int exam2, int exam3)
			{
				int result = (exam1 + exam2 + exam3) / 3;
				if (result >= 50)
				{
					return student + " adlı öğrenci Sınavı geçti. " + "Ortalama: " + result;
				}
				else
				{
					return student + " adlı öğrenci başarısız oldu. " + "Ortalama: " + result;
				}
			}
			Console.WriteLine(ExamResult("Ali", 25, 41, 55));
			Console.WriteLine(ExamResult("Ayşe", 33, 36, 88));

			#endregion

			Console.Read();
		}
	}
}