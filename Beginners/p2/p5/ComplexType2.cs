/*
 * 名前のない複合型について
 */
// C#には匿名型(anonymous type)とタプル(tuple)の2種類ある
using System;

namespace complexType2{
	// C#5のため、構造体で代用
	public struct Answer{
		public double min;
		public double max;
		public double ave;
	}
	class Calculater{
		public Answer Measure(params double[] items){
			var count = 0;
			var sum = 0.0;
			// あらかじめ極端な値をセット
			var min = double.MaxValue;
			var max = double.MinValue;
			foreach(var x in items){
				sum += x;
				count++;
				min = Math.Min(x, min);
				max = Math.Max(x, max);
			}
			return new Answer{min = min, max = max, ave = sum/count};
		}
		/* タプルでのMeasure関数実装
		static (double min, double max, double ave) Measure(params double[] items){
			var count = 0;
			var sum = 0.0;
			// あらかじめ極端な値をセット
			var min = double.MaxValue;
			var max = double.MinValue;
			foreach(var x in items){
				sum += x;
				count++;
				min = Math.Min(x, min);
				max = Math.Max(x, max);
			}
			return (min, max, sum/ave);
		}
		*/
	}

	class Program{
		public static void Main(string[] args){
			Calculater calc = new Calculater();
			Answer ans = new Answer{};
			double a = 12.23, b = 23.7, c = 892.3, d = 71.5, e = 9.6;
			ans = calc.Measure(a,b,c,d,e);
			ShowAll(ans);
		}
		public static void ShowAll(Answer ans){
			Console.WriteLine("min : " + ans.min);
			Console.WriteLine("max : " + ans.max);
			Console.WriteLine("ave : " + ans.ave);
		}
	}
}
