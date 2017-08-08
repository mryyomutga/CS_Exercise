using System;

namespace iteration2{
	class Programe{
		public static void Main(string[] args){
			// for: 条件判定がfalseになるまで繰り返す
			int[] num = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			double y = 0;
			// foreach : 配列やコレクションの要素を取り出す
			foreach(int x in num){
				y += x;
				Console.Write("{0}", x);
				if(x != 10){
					Console.Write(", ");
				}
			}
			Console.WriteLine();
			y /= num.Length;
			Console.WriteLine(y);
		}
	}
}
