using cl3;
using cl31;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr14
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//			Завдання 2:
			//Для двох масивів цілих реалізуйте такі запити:
			//+ Отримати різницю двох масивів(елементи першого масиву,яких немає у другому). 
			//+ Отримати перетин масивів(спільні елементи для обох масивів).
			//+ Отримати об'єднання масивів (елементи обох масивів без дублікатів).
			// Отримати вміст першого масиву без повторень.

			//int[] arr1 = { 1, 2, 3, 55, 22, 55, 88, 2, 11 };
			//int[] arr2 = { 1, 3, 33, 55, 12, 88, 11 };

			//int[] arrExept = arr1.Except(arr2).ToArray();
			//PrintList(arrExept.ToList());

			//int[] arrIntersect = arr1.Intersect(arr2).ToArray();
			//PrintList(arrIntersect.ToList());

			//int[] arrUnion = arr1.Union(arr2).ToArray();
			//PrintList(arrUnion.ToList());

			//int[] arrDistinct = arr1.Distinct().ToArray();
			//PrintList(arrDistinct.ToList());


			//			Завдання 1:
			//Для масиву рядків реалізуйте користувальницьке сортування. 
			//Сортування має працювати за кількістю символів(за зростанням та спаданням).
			//Наприклад, якщо сортування проводиться за спаданням, потрібно повернути рядки з максимальною
			//довжиною в порядку зменшення довжини.

			//string[] arrString = { "For", "an", "array", "of", "strings", "implement", "custom", "sorting" };
			//Console.WriteLine("Strinf before sort:\n");
			//PrintList(arrString.ToList());

			//Console.WriteLine("\nEnter sorting string: 1 - ascending, 2 - descending\n");
			//int choiceUser = int.Parse(Console.ReadLine());

			//if (choiceUser == 1)
			//{
			//	var arrNewAsc = arrString.OrderBy(a => a.Length).ToList();
			//	PrintList(arrNewAsc.ToList());
			//}
			//else if (choiceUser == 2)
			//{
			//	var arrNewDesc = arrString.OrderByDescending(a => a.Length).ToList();
			//	PrintList(arrNewDesc.ToList());
			//}


			//			Завдання 3:
			//Створіть користувацький тип «Автомобіль», який зберігатиме
			//таку інформацію:
			//+ назва;
			//+ виробник; 
			//+ рік випуску.
			//Для двох масивів автомобілів реалізуйте операції:
			//+ різниця масивів;
			//+ перетин масивів;
			//+ об'єднання масивів.
			//Критерій для виконання операцій – виробник

			Car car1 = new Car("Civic", "Honda", new DateTime(2022, 5, 10));
			Car car2 = new Car("Camry", "Toyota", new DateTime(2021, 12, 15));
			Car[] carsArray1 = new Car[] { car1, car2 };
			PrintList(carsArray1.ToList());

			Car car3 = new Car("Mustang", "Ford", new DateTime(2023, 8, 20));
			Car car4 = new Car("Accord", "Honda", new DateTime(2020, 6, 25));
			Car[] carsArray2 = new Car[] { car3, car4 };
			PrintList(carsArray2.ToList());

			Console.WriteLine("\nExcept arrays car: ");
			Car[] carsExp = carsArray1.Except(carsArray2, new CarManufacturerComparer()).ToArray();
			PrintList(carsExp.ToList());

			Console.WriteLine("\nIntersect arrays car: ");
			Car[] carsInters = carsArray1.Intersect(carsArray2, new CarManufacturerComparer()).ToArray();
			PrintList(carsInters.ToList());

			Console.WriteLine("\nUnion arrays car: ");
			Car[] carsUnion = carsArray1.Union(carsArray2, new CarManufacturerComparer()).ToArray();
			PrintList(carsUnion.ToList());

		}

		private static void PrintList<T>(List<T> list, string separator = " ")
		{
			foreach (T item in list)
			{
				Console.Write(item + separator);
			}
			Console.WriteLine();
		}
	}
}
