/*
 * 配列の基本的な操作
 */
using System;

namespace arrays1{
	class Programe{
		public static void Main(string[] args){
			// 配列 : 型名[] 変数名;
			// 変数 = new 型名[配列の長さ];
			int[] array = new int[5];

			// 配列の変数.Lengthでサイズを取得
			for(int i = 0; i < array.Length; i++){
				array[i] = i;
				Console.Write("{0}", array[i]);
				if(i != array.Length - 1){
					Console.Write(", ");
				}
			}
			Console.WriteLine();

			double average = 0.0;
			// foreach文で配列の要素を取り出す
			foreach(int i in array){
				average += i;
			}
			average /= array.Length;
			Console.WriteLine("arrayの平均は{0}", average);
			// 宣言時に初期化する場合に限り有効
			int[] a = {1, 3, 5, 7, 9};
			foreach(int i in a){
				Console.Write("{0} ", i);
			}
			// C# 3.0 以降の機能
			// 配列の宣言を型推論で
			var b = new[]{1, 2, 3, 4, 5};
			// {}の中で配列の型を推論
			Console.WriteLine("\nType:{0}", b.GetType());
			for(int i = 0; i < b.Length; i++){
				Console.Write("{0} ", b[i]);
			}
		}
	}
}
