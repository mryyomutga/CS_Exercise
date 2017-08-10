/*
 * 関数の戻り値について
*/
using System;

namespace method2{
	// 肩を1つ作成
	struct Unit{}

	class Program{
		// 戻り値ありで統一する
		// voidの代わりにUnitを使う
		// 不格好になるためあまり使用しない方がよい
		static Unit func1(){
			Console.WriteLine("call func1");
			return default(Unit);
		}
		static Unit func2(int x){
			Console.WriteLine("call func2  x={0}", x);
			return default(Unit);
		}
		static int func3(){
			Console.WriteLine("call func3");
			return 1;
		}
		static int func4(int x){
			Console.WriteLine("call func4  x={0}", x);
			return x+1;
		}
		public static void Main(string[] args){
			func1();
			Console.WriteLine("====================");
			func2(1);
			Console.WriteLine("====================");
			Console.WriteLine("{0} call back from func3", func3());
			Console.WriteLine("====================");
			Console.WriteLine("{0} call back from func4", func4(2));
			Console.WriteLine("====================");
		}
	}
}
