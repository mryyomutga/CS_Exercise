/*
 * 複数の戻り値(タプル)について
*/
using System;

namespace method3{
	// C# 6以前
	struct SumCount{
		public int sum;
		public int count;
	}
	class Programe{
		// 複合型で複数の値を返す
		static SumCount calc(int[] items){
			var sum = 0;
			var count = 0;
			foreach(var x in items){
				sum += x;
				count++;
			}
			return new SumCount{sum = sum, count = count};
		}
		/*
		 C# 7以降で実装された機能
		static (int sum, int count) calc(int[] items){
			var sum = 0;
			var count = 0;
			foreach(var x in items){
				sum += x;
				count++;
			}
			return (sum, count);
		}
		*/
		public static void Main(string[] args){
			int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			// 構造体SumCountをscと定義
			SumCount sc = new SumCount{sum=0, count=0};
			// scに値を格納
			sc = calc(array);
			/*
			C# 7以降で実装
			var sc;
			sc = calc(array);
			*/
			Console.WriteLine("SumCount.sum = {0}", sc.sum);
			Console.WriteLine("SumCount.count = {0}", sc.count);
		}
	}
}
