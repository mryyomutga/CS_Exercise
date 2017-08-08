using System;

namespace iteration2{
	class Programe{
		public static void Main(string[] args){
			int a;

			// do-while : doの中を実行してから判定し、繰り返す
			do{
				Console.Write("1~100の整数を入力してください : ");
				a = int.Parse(Console.ReadLine());
			}
			while(a < 1 || a > 100);
			Console.WriteLine("入力値は{0}", a);
		}
	}
}
