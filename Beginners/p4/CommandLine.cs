/*
 * コマンドライン引数について
*/
using System;

namespace commandLine{
	public class Program{
		public static void Main(string[] args){
			// コマンドライン引数 : コマンドラインから引数を与えるとargs[0]に格納される
			for(int i = 0; i < args.Length; i++){
				Console.WriteLine("{0}番目の引数は{1}です", i, args[i]);
			}
		}
	}
}
