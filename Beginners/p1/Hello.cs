// ReadLine, WriteLine(standard IO) and Format
using System;

namespace hello{
	class Programe{
		public static void Main(string[] args)
		{
			// Writeは改行なし
			Console.Write("Please input your name : ");
			// ReadLine()で標準入力から文字列を読み込む
			var name = Console.ReadLine();
			// WriteLineは改行あり
			Console.WriteLine("{0} ,Hello World", name);
		}
	}
}
