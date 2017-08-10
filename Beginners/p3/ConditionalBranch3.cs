/*
 * goto文について
*/
using System;

namespace conditionalBranch3{
	class Program{
		public static void Main(String[] args){
			int x = 1;
			int y = 4;
			// 指定したラベルへジャンプする(多用しない)
			while(x > 0){
				while(y > x){
					Console.WriteLine("({0}, {1})", x++, y++);
					if(y >= 10){
						goto LOOPEND;
					}
				}
			}
			LOOPEND:
			;
		}
	}
}
