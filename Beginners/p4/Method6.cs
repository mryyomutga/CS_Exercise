/*
 * ローカル関数と匿名関数
*/
using System;
using System.Linq;

namespace method6{
	class Programe{
		public static void Main(string[] args){
			var input = new[]{1, 2, 3, 4, 5};
			// 匿名関数 : outputにWhereの条件からSelectの内容を格納
			// Whereをコメントアウトすればoutputにinputの2乗を格納
			// SelectをコメントアウトすればWhereの条件を満たすものをoutputに格納			var output = input
				.Where(n => n > 3)
				.Select(n => n*n);
			foreach(var x in output){
				Console.WriteLine(x);
			}
			// C# 7以降で実装 ローカル関数
			// 関数内に関数を定義
			/*
			n!を計算
			int f(int n) => n >= 1 ? n * f(n - 1) : 1;
			Console.WriteLine(f(10));
			*/
		}
	}
}
