/*
 * オプション・名前付き引数
*/
using System;

namespace method4{
	class Programe{
		// 引数を初期化しておく
		static int Sum(int x = 0, int y = 0, int z = 0){
			Console.WriteLine("({0}, {1}, {2})", x, y, z);
			return x + y + z;
		}
		static void Task1(){
			// optional parameter
			var task1 = Sum();		// -> Sum(0, 0, 0);
			Console.WriteLine("task1 : {0}", task1);
			Console.WriteLine("================");

			var task2 = Sum(1);		// -> Sum(1, 0, 0);
			Console.WriteLine("task2 : {0}", task2);
			Console.WriteLine("================");

			var task3 = Sum(1, 2);	// -> Sum(1, 2, 0);
			Console.WriteLine("task3 : {0}", task3);
			Console.WriteLine("================");

			// named parameter
			var task4 = Sum(x:1, y:2, z:3);
			Console.WriteLine("task4 : {0}", task4);
			Console.WriteLine("================");

			var task5 = Sum(z:3);
			Console.WriteLine("task5 : {0}", task5);
			Console.WriteLine("================");
		}
		public static void Main(string[] args){
			Task1();
		}
	}
}
