using System;

namespace operation{
	class Programe{
		public static void Main(String[] args){
			int x = 100;
			int y = 20;
			// 算術演算
			Console.WriteLine("Arithmetic Operation");
			Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
			Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
			Console.WriteLine("{0} * {1} = {2}", x, y, x*y);
			Console.WriteLine("{0} / {1} = {2}", x, y, x/y);
			Console.WriteLine("{0} % {1} = {2}", x, y, x%y);
			Console.WriteLine("x = {0}", -x);
			// インクリメントとデクリメント
			Console.WriteLine("Increment, Decrement");
			Console.WriteLine("x = {0}", x);
			Console.WriteLine("x++ = {0}, x = {1}", x++, x);
			x = 100;
			Console.WriteLine("++x = {0}, x = {1}", ++x, x);
			x = 100;
			Console.WriteLine("x-- = {0}, x = {1}", x--, x);
			x = 100;
			Console.WriteLine("--x = {0}, x = {1}", --x, x);
			x = 100;
			// シフト演算
			Console.WriteLine("Shift");
			Console.WriteLine("{0} << 1 = {1}", x, x<<1);
			x = 100;
			Console.WriteLine("{0} >> 1 = {1}", x, x>>1);
			x = 100;
			// 文字列連結
			Console.WriteLine("abc + def = {0}", "abc"+"def");
			// 論理演算
			Console.WriteLine("Logical Operation");
			Console.WriteLine("2 & 3 = {0}", 2&3);
			Console.WriteLine("2 | 3 = {0}", 2|3);
			Console.WriteLine("2 ^ 3 = {0}", 2^3);
			Console.WriteLine("!True = {0}", !true);
			Console.WriteLine("~5 = {0}", ~5);
			// 関係演算
			Console.WriteLine("Relational Operation");
			Console.WriteLine("x = {0}, y = {1}", x, y);
			Console.WriteLine("x == x -> {0}", x==x);
			Console.WriteLine("x == y -> {0}", x==y);
			Console.WriteLine("x != x -> {0}", x!=x);
			Console.WriteLine("x != y -> {0}", x!=y);
			Console.WriteLine("x > x -> {0}", x>x);
			Console.WriteLine("x > y -> {0}", x>y);
			Console.WriteLine("x < x -> {0}", x<x);
			Console.WriteLine("x < y -> {0}", x<y);
			Console.WriteLine("x >= x -> {0}", x>=x);
			Console.WriteLine("x >= y -> {0}", x>=y);
			Console.WriteLine("x <= x -> {0}", x<=x);
			Console.WriteLine("x <= y -> {0}", x<=y);
			// 三項演算
			Console.WriteLine("Ternary Operation");
			Console.WriteLine("x = {0}, y = {1}", x, y);
			Console.WriteLine("x > y ? 10 : 0 -> {0}", x>y?10:0);
			Console.WriteLine("x < y ? 10 : 0 -> {0}", x<y?10:0);
		}
	}
}
