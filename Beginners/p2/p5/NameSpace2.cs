/*
 * エイリアスについて
 */
using System;

namespace myLibs{
	class Output{
		public static void put(){
			Console.WriteLine("myLibs.Output");
		}
	}
}

namespace nameSpace2{
	// 名前空間やクラスのエイリアス
	// using libs = myLibs.Output;
	// libsクラスを追加した場合
	using libs = myLibs;
	class program{
		public static void Main(string[] args){
			//libs.put();
			libs::Output.put();
			// globalを付けることで最上位から名前をたどることができる
			global::X.func();
		}
	}
	class libs{}
}
// 名前空間外にクラスがある場合
class X{
	public static void func(){
		Console.WriteLine("X.func()");
	}
}
