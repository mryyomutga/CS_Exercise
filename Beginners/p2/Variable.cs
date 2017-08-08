// variable and statement
using System;

namespace variable{
	class Programe{
		public static void Main(String[] args){
			// 変数とリテラル
			int n = 3;
			double x = 1.5;
			char c = 'c';
			string s = "String";
			bool b = true;
			Console.WriteLine("変数・リテラル(variable and literal)");
			Console.WriteLine("n:{0}  type:{1}", n, n.GetType());
			Console.WriteLine("x:{0}  type:{1}", x, x.GetType());
			Console.WriteLine("c:{0}  type:{1}", c, c.GetType());
			Console.WriteLine("s:{0}  type:{1}", s, s.GetType());
			Console.WriteLine("b:{0}  type:{1}", b, b.GetType());
			Console.WriteLine("--------------------------------");
			// 型推論(宣言時に代入する)
			var vn = 3;
			var vx = 1.5;
			var vc = 'c';
			var vs = "strings";
			var vb = true;
			Console.WriteLine("型推論");
			Console.WriteLine("n:{0}  type:{1}", vn, vn.GetType());
			Console.WriteLine("n:{0}  type:{1}", vx, vx.GetType());
			Console.WriteLine("n:{0}  type:{1}", vc, vc.GetType());
			Console.WriteLine("n:{0}  type:{1}", vs, vs.GetType());
			Console.WriteLine("n:{0}  type:{1}", vb, vb.GetType());
			Console.WriteLine("--------------------------------");
			// 逐語的識別子(variable identifier)
			// @を先頭に付けることで識別子を変数の名前にすることができる
			int @this = 10;
			string @for = "for";
			Console.WriteLine("逐語的識別子 variable identifier");
			Console.WriteLine("@this:{0}  type:{1}", @this, @this.GetType());
			Console.WriteLine("@for:{0}  type:{1}", @for, @for.GetType());
			Console.WriteLine("--------------------------------");
			// 演算
			Console.WriteLine("演算");
			int num1, num2;
			string str;

			// 標準入力で受け取った文字列を数値に変換
			Console.Write("num1=");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("num2=");
			num2 = int.Parse(Console.ReadLine());

			Console.Write("str=");
			str = Console.ReadLine();

			Console.WriteLine("num1 + num2 = {0}", num1+num2);
			Console.WriteLine("num1 - num2 = {0}", num1-num2);
			Console.WriteLine("num1 * num2 = {0}", num1*num2);
			Console.WriteLine("num1 / num2 = {0}", num1/num2);
			// 数値を文字として認識する
			Console.WriteLine("str + num2 = {0}", str+num2);

			// グループ化も可能
			int area, w = 10, l = 20;
			{
				area = w * l / 2;
			}
			Console.WriteLine("area = {0}", area);
		}
	}
}
