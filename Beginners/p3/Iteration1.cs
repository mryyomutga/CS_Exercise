using System;

namespace iteration1{
	class Programe{
		public static void Main(string[] args){
			int a, b;
			Console.WriteLine("ユークリッドの互除法を用いて最大公約数を求めます");
			Console.Write("1つめの整数を入力してください : ");
			a = int.Parse(Console.ReadLine());
			Console.Write("2つめの整数を入力してください : ");
			b = int.Parse(Console.ReadLine());

			Console.Write("{0}と{1}の最大公約数は", a, b);
			// while : 条件がtrueになるまで繰り返す
			while(b != 0){
				int r = a % b;
				a = b;
				b = r;
			}
			Console.Write("{0}", a);
		}
	}
}
