using System;

namespace conditionalBranch2{
	class Programe{
		public static void Main(String[] args){
			double x = 0.0, y = 0.0;
			char opr;

			Console.WriteLine("2項演算を行います");
			Console.Write("左辺の値を入力してください : ");
			x = double.Parse(Console.ReadLine());
			Console.Write("右辺の値を入力してください : ");
			y = double.Parse(Console.ReadLine());

			Console.Write("演算子を入力してください(+ - * / %) : ");
			opr = Console.ReadLine()[0];

			// 各ケースごとにbreakをする必要がある
			// 変数は整数型か文字列型のみ
			// breakを挿入しない場合、フォールスルーが発生(C#では禁止)
			switch(opr){
				case '+':
					Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
					break;
				case '-':
					Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
					break;
				case '*':
					Console.WriteLine("{0} × {1} = {2}", x, y, x*y);
					break;
				case '/':
					Console.WriteLine("{0} ÷ {1} = {2}", x, y, x/y);
					break;
				case '%':
					Console.WriteLine("{0} % {1} = {2}", x, y, x%y);
					break;
				default:
					Console.WriteLine("不正な操作です");
					break;
			}
		}
		/* C# 7からの機能
		   変数の型で分岐が可能
		static void TypeSwitch(object obj){
			switch(obj){
				case int n:
					Console.WriteLine("整数:" + n);
					break;
				case string s:
					Console.WriteLine("文字列:" + s);
					break;
				default:
					Console.WriteLine("その他");
			}
		}*/
	}
}
