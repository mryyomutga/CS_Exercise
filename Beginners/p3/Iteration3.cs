using System;

namespace iteration2{
	class Programe{
		public static void Main(string[] args){
			// for: 条件判定がfalseになるまで繰り返す
			for(int x = 1; x < 10; x++){
				for(int y = 1; y < 10; y++){
					Console.Write("{0} ", (x*y));
				}
				Console.WriteLine();
			}
		}
	}
}
