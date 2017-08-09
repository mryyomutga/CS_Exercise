/*
 * 多次元配列と配列の配列
*/
using System;

namespace arrays2{
	class Programe{
		public static void Main(string[] args){
			// 多次元配列(2次元) : 型名[,] 変数名;
			// 変数名 = new 型名[サイズ1,サイズ2];
			// 初期化 : 型名[,] = new 型名[,]{{a1,b1,c1,...}, {a2,b2,c2,...}};
			Console.WriteLine("Rectangular Array");
			int[,] rect = {{1, 2, 3},
						   {2, 3, 4},
				   		   {3, 4, 5}};
		   	// 配列全体のサイズを取得するには .Length
		    Console.WriteLine("rect.Length = {0}", rect.Length);
			// 各行のサイズを取得するには .GetLength(i)
			Console.WriteLine("rect.GetLength(0) = {0}", rect.GetLength(0));
			Console.WriteLine("rect.GetLength(1) = {0}", rect.GetLength(1));
			for(int i = 0; i < rect.GetLength(0); i++){
				for(int j = 0; j < rect.GetLength(1); j++){
					// rect[i,j]でその場所に格納された値を参照
					// ※rect[i][j]ではコンパイルエラー
					Console.Write("{0} ", rect[i,j]);
				}
				Console.WriteLine();
			}
			// 配列の配列 : 可変長の配列を作ることができる
			Console.WriteLine("Jagged Array");
			int[][] jag = new int[][]{new int[]{1},
									  new int[]{1, 2},
									  new int[]{1, 2, 3}};
			// .Lengthで行数を取得
			Console.WriteLine("jag.Length = {0}", jag.Length);
			// [i].Lengthでi行目のサイズを取得
  			Console.WriteLine("jag[0].Length = {0}", jag[0].Length);
			Console.WriteLine("jag[1].Length = {0}", jag[1].Length);
			Console.WriteLine("jag[2].Length = {0}", jag[2].Length);
			for(int i = 0; i < jag.Length; i++){
				for(int j = 0; j < jag[i].Length; j++){
					// 多次元配列と違い[i][j]でその場所に格納されている値を参照
					// ※[i,j]ではコンパイルエラー
					Console.Write("{0} ", jag[i][j]);
				}
				Console.WriteLine();
			}
		}
	}
}
