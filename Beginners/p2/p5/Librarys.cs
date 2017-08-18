/*
 * 標準ライブラリについて
 */
// C#で標準ライブラリを利用するときは、コンパイル時に/rオプションを付ける
using System;

public class Program{
	public static void Main(string[] args){
		for(double i = 0; i < 1; i += 0.1){
			// usingディレクティブを使用しない場合のクラスの利用は、以下のように完全修飾名で書く
			// usingディレクティブを記述してあってもエラーではない
			System.Console.WriteLine("nn sin{0} = {1}", i, System.Math.Sin(i));
			// usingディレクティブを使用する場合、「System.」を省略できる
			Console.WriteLine("sin{0} = {1}", i, Math.Sin(i));
		}
	}
}
