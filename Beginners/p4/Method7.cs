/*
 * 可変長引数について(paramsキーワード)
*/
using System;

namespace method7{
	struct Elements{
		public int max;
		public int min;
	}
	class Program{
		// paramsキーワードで引数を可変長にできる
		// 引数なしでも関数を呼び出せる
		/// <summary>
		///   最大値と最小値を返す
		/// </summary>
		static Elements Search(params int[] num){
			int max = num[0];
			int min = num[0];
			for(int i = 1; i < num.Length; i++){
				if(max < num[i]){
					max = num[i];
				}
				if(min > num[i]){
					min = num[i];
				}
			}
			return new Elements{max = max, min = min};
		}
		public static void Main(string[] args){
			int a = 124, b = 92, c = 537, d = 78, e = 32;

			// max, minを初期化
			Elements ans = new Elements{max = 0, min = 0};
			// 初期化せずにElements ans;だけだとここでエラー
			// Console.WriteLine("max = {0}\nmin = {1}", ans.max, ans.min);
			/*
			可変長引数でない場合、配列に値を格納する必要がある
			int[] tmp = {a, b, c, d, e};
			*/
			ans = Search(a, b, c, d, e);
			Console.WriteLine("max = {0}\nmin = {1}", ans.max, ans.min);
		}
	}
}
