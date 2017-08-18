/**
 * 例外処理
 */
using System;

namespace exceptionHandling{
	class program{
		public static void Main(string[] args){
			int i = 0;
			while(true){
				i++;
				try{
					Console.Write("no{0} ", i);
					Console.WriteLine("{0}", getNum());
				}
				// FormatExceptionのキャッチ
				catch(FormatException e){
					Console.WriteLine(e);
					break;
				}
			}
		}
		static int ctoi(char c){
			// throw new 例外クラスのインスタンスで例外を投げる
			if(c < '0' || '9' < c)
				throw new FormatException();
			return c - '0';
		}
		static int stoi(string s){
			int val = 0;
			foreach(char c in s){
				int num = ctoi(c);
				val = val * 10 + num;
			}
			return val;
		}
		static int getNum(){
			Console.Write("整数を入力して下さい:");
			return stoi(Console.ReadLine());
		}
	}
}
