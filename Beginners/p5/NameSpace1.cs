/*
 * 名前空間について
 */
using System;

// mylibという名前空間を定義
namespace myLib{
	// 標準入出力に関するクラス
	class ConsoleIO{
		public void Echo(){
			Console.Write("called myLib.ConsoleIO.Echo()\n");
		}
		public void Echo(string str){
			Console.Write("called myLib.ConsoleIO.Echo(string:{0})\n", str);
		}
		public void Echo(int num){
			Console.Write("called myLib.ConsoleIO.Echo(int:{0})\n",num);
		}
		public void Echo(double x){
			Console.Write("called myLib.ConsoleIO.Echo(double:{0})\n", x);
		}
		public string ReadStr(){
			Console.Write("Read string : ");
			return Console.ReadLine();
		}
		public int ReadInt(){
			Console.Write("Read integer : ");
			return int.Parse(Console.ReadLine());
		}
		public double ReadDouble(){
			Console.Write("Read double : ");
			return double.Parse(Console.ReadLine());
		}
	}
	// 計算に関するクラス
	class Calculater{
		public int Sum(params int[] num){
			int sum = 0;
			foreach(var x in num){
				sum += x;
			}
			return sum;
		}
		public double Sum(params double[] num){
			double sum = 0;
			foreach(var x in num){
				sum += x;
			}
			return sum;
		}
		public double Average(int sum, int num){
			return (sum / num);
		}
		public double Average(double sum, int num){
			return (sum / num);
		}
		public double Average(params int[] num){
			double sum = 0;
			int count = 0;
			foreach(var x in num){
				sum += x;
				count++;
			}
			return (sum / count);
		}
		public double Average(params double[] num){
			double sum = 0;
			int count = 0;
			foreach(var x in num){
				sum += x;
				count++;
			}
			return (sum / count);
		}
	}
}
namespace nameSpace1{
	// 完全修飾名を省略する場合
	using myLib;

	class Program{
		// IOに関する処理
		static void Routine1(){
			// 名前空間.クラスで使用する
			myLib.ConsoleIO io1 = new myLib.ConsoleIO();
			Console.WriteLine("io1 : " + io1);
			string str1 = io1.ReadStr();
			int num1 = io1.ReadInt();
			double x1 = io1.ReadDouble();
			io1.Echo();
			io1.Echo(str1);
			io1.Echo(num1);
			io1.Echo(x1);
			Console.WriteLine();
			// usingで指定することで省略可
			ConsoleIO io2 = new ConsoleIO();
			Console.WriteLine("io2 : " + io2);
			string str2 = io2.ReadStr();
			int num2 = io2.ReadInt();
			double x2 = io2.ReadDouble();
			io2.Echo();
			io2.Echo(str2);
			io2.Echo(num2);
			io2.Echo(x2);
			Console.WriteLine();
		}
		// myLibを使った計算の処理
		static void Routine2(){
			int[] box1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			double[] box2 = {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.0};
			int n1 = 1, n2 = 2, n3 = 3, n4 = 4, n5 = 5;
			double d1 = 1.1, d2 = 2.2, d3 = 3.3, d4 = 4.4, d5 = 5.5;
			Calculater calc = new Calculater();

			var sumn = calc.Sum(n1, n2, n3, n4, n5);
			var sumd = calc.Sum(d1, d2, d3, d4, d5);

			var ave1 = calc.Average(sumn, 5);
			var ave2 = calc.Average(sumd, 5);
			var ave3 = calc.Average(box1);
			var ave4 = calc.Average(box2);
			Console.WriteLine("sum(box1) : {0}", calc.Sum(box1));
			Console.WriteLine("sum(n) : {0}", sumn);
			Console.WriteLine("sum(d) : {0}", sumd);
			Console.WriteLine("average(sumn) : {0}", ave1);
			Console.WriteLine("average(sumd) : {0}", ave2);
			Console.WriteLine("average(box1) : {0}", ave3);
			Console.WriteLine("average(box2) : {0}", ave4);
			Console.WriteLine("average(inputs) : {0}", calc.Average(d1,d2,d3,d4,d5));

		}
		public static void Main(string[] args){
			Routine1();
			Routine2();
		}
	}
}
