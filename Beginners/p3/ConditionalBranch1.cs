using System;

namespace conditionalBranch1{
	class Programe{
		public static void Main(String[] args){
			int x = 0;
			Console.WriteLine("逆数を求めます");
			Console.Write("整数を入力してください : ");
			// 型.Parseで文字列を指定した型に変換
			x = int.Parse(Console.ReadLine());
			if(x != 0){
				double inv = 1.0 / x;
				Console.WriteLine("1/{0} = {1}", x, inv);
			}
			else{
				Console.WriteLine("0が入力されました");
			}
		}
	}
}
