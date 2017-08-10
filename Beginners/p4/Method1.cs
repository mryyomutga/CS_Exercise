/*
 * 関数(メソッド)の基本
*/
using System;

namespace method1{
	class Program{
		// 関数(メソッド) : 戻り値の型 関数名(引数)
		// 文字列を標準出力する関数(改行有)
		static void Echo(string echo){
			Console.WriteLine(echo);
		}
		static double Sum(double[] num){
			double ans = 0;
			for(int i = 0; i < num.Length; i++){
				ans += num[i];
			}
			// returnで値を返す
			return ans;
		}
		// C# 6以降で実装
		// 1つの式だけからなる場合に限る
		/*
 		  戻り値の型 関数名(引数) => 関数本体の式
		  static void Add(int x, int y) => x + y;
		 */
		public static void Main(string[] args){
			// staticであれば関数名(引数)で呼び出し可
			// 戻り値なし
			Echo("Hello");
			// 戻り値あり
			double[] cnt = {1, 1.5, 2, 2.5, 3, 3.5};
			// Sum()でreturnされた値がanswerに格納される
			double answer = Sum(cnt);
			Echo(answer.ToString());
		}
	}
}
