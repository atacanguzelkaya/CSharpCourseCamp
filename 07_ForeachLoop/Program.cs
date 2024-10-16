using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region Foreach Döngüsü

			//string[] cities = { "Milano", "Roma", "Ankara", "İstanbul", "Paris" };

			//foreach (var city in cities)
			//{
			//    Console.WriteLine(city);
			//}

			//int[] numbers = { 45,78,985,635,74,11,22,33,41,205,6578,10394 };
			//foreach (int number in numbers)
			//{
			//    Console.WriteLine(number);
			//}

			//---Dizideki Çift Sayılar ---
			//int[] numbers = { 45,78,985,635,74,11,22,33,41,205,6578,10394 };
			//foreach (var item in numbers)
			//{
			//    if (item %2 == 0)
			//    {
			//        Console.WriteLine(item);
			//    }
			//}

			//---- Dizideki Elemanların Toplamı ---
			//int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
			//int sum = 0;
			//foreach (int i in numbers)
			//{
			//	sum += i;
			//}
			//Console.WriteLine(sum); // --> 120


			//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 8 };
			//foreach (int number in numbers)
			//{
			//	Console.WriteLine(number);
			//}

			//string word = "Hello";

			//foreach (char c in word)
			//{
			//    Console.WriteLine(c);
			//}

			#endregion

			#region Örnek Sınav Sistemi Uygulaması

			Console.WriteLine("********** C# Eğitim Kampı Sistem Uygulaması ***********");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("Sınıfınızda kaç öğrenci var: ");
			int studentCount = int.Parse(Console.ReadLine());
			Console.WriteLine("-----------------------------------");

			string[] studentNames = new string[studentCount];
			double[] studentExamAverage = new double[studentCount];

			for (int i = 0; i < studentCount; i++)
			{
				Console.WriteLine($"{i + 1}. öğrencinin adını giriniz: ");
				studentNames[i] = Console.ReadLine();

				double totalExamResult = 0;

				// Her öğrenci için 3 sınav notu
				for (int j = 0; j < 3; j++)
				{
					Console.WriteLine($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
					double value = double.Parse(Console.ReadLine());
					totalExamResult += value; //notları topluyoruz
				}
				Console.WriteLine();
				studentExamAverage[i] = totalExamResult / 3;
			}

			// Öğrencilerin Sınav Ortalamaları
			Console.WriteLine("Sonuçlar:");
			for (int i = 0; i < studentCount; i++)
			{
				Console.WriteLine($"{studentNames[i]} - Ortalama: {studentExamAverage[i]:F2}");

				if (studentExamAverage[i] >= 50)
				{
					Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
				}
				else
				{
					Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
				}
				Console.WriteLine("--------------------------------");
			}

			#endregion

			Console.Read();
		}
	}
}