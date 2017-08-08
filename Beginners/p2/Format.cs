using System;

namespace format{
	class Programe{
		public static void Main(string[] args){
			double x = 1.0, y = 2.0;
			// Formatメソッドを用いた文字列挿入
			Console.WriteLine("string.Format");
			Console.WriteLine(string.Format("({0}, {1})", x, y));
			// $""での文字列挿入
			/* Console.WriteLine("$\"\"");
			var form = $"({x}, {y})";
			Console.WriteLine(form);
			*/
			int i = 0;
			Console.WriteLine(string.Format("{0,4:d}", i));
		}
	}
}
