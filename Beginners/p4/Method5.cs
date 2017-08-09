/*
 * メソッドのオーバーロード
*/
using System;

namespace method5{
	class Programe{
		// オーバーロード : 関数名が同じで引数の型、個数が異なる
		static void EchoValue(string s){
			Console.WriteLine("string : {0}", s);
		}
		static void EchoValue(int n){
			Console.WriteLine("int : {0}", n);
		}
		static void EchoValue(double x){
			Console.WriteLine("double : {0}", x);
		}
		public static void Main(string[] args){
			EchoValue("Hello");
			EchoValue(20);
			EchoValue(3.141592);
		}
	}
}
