/*
 * 型推論と構造体を使った変数
*/
using System;

namespace typeInference{
	// プロパティ
	struct pt{
		public int X {set; get;}
		public int Y {set; get;}
		public int Z {set; get;}
	}
	class Program{
		public static void Main(string[] args){
			// 型推論
			var n = 1;
			var x = 1.0;
			var s = "test";
			Console.WriteLine("TypeInference");
			Console.WriteLine("n : {0}", n.GetType());
			Console.WriteLine("x : {0}", x.GetType());
			Console.WriteLine("s : {0}", s.GetType());
			// 匿名型
			var f = new {FamilyName = "FamilyName", FirstName = "FirstName"};
			Console.WriteLine("Anonymous Type");
			Console.WriteLine("{0} {1}", f.FamilyName, f.FirstName);
			// プロパティ
			Console.WriteLine("Property");
			pt g = new pt{X = 0, Y = 1, Z = 2};
			var h = new {g.X, g.Y, g.Z};
			Console.WriteLine("g.X = {0}", g.X);
			Console.WriteLine("g.Y = {0}", g.Y);
			Console.WriteLine("g.Z = {0}", g.Z);
			Console.WriteLine("h.X = {0}", h.X);
			Console.WriteLine("h.Y = {0}", h.Y);
			Console.WriteLine("h.Z = {0}", h.Z);
		}
	}
}
