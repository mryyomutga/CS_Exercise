/**
 * 列挙型の操作
 */
using System;

namespace enamulationType{
	// 列挙型 : 特定の値しかとらないものを表現する
	enum Month{
		January, February, March,
		April, May, June,
		July, August, September,
		October, November, December
	}
	// int型で定義する場合
	// enum Month : int{
	// 	January = 0, February, March,
	// 	April, May, June,
	// 	July, August, September,
	// 	October, November, December
	// }

	// フラグ : Flags属性を付ける
	// 例 : ビット演算処理
	[Flags]
	enum Bin{
		x = 1,
		y = 2,
		z = 4
	}
	public class Program{
		public static void Main(string[] args){
			// 列挙型名.メンバーで、指定した値を取り出す
			Month[] month = {Month.January, Month.February, Month.March,
							 Month.April, Month.May, Month.June,
							 Month.July, Month.August, Month.September,
							 Month.October, Month.November, Month.December};
			// i番目のメンバーを出力する
			for(int i = 0; i < month.Length + 1; i++){
				Console.WriteLine((Month)i);
			}
			Console.WriteLine();
			// OR演算処理とコンソール出力
			// x, y, zで表示できる
			Bin xy = Bin.x | Bin.y;
			Bin yz = Bin.y | Bin.z;
			Bin zx = Bin.z | Bin.x;
			Bin xyz = Bin.x | Bin.y | Bin.z;
			Console.WriteLine(xy);
			Console.WriteLine(yz);
			Console.WriteLine(zx);
			Console.WriteLine(xyz);
		}
	}
}
