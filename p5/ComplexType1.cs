/*
 * 複合型について
 */
// C#の複合型にはクラス(class)と構造体(struct)がある
using System;

namespace complexType1{
	// 構造体のメンバー
	public struct Point{
		public double x;
		public double y;
		// コンストラクタの呼び出しによる初期化
		public Point(double px, double py){
			x = px;
			y = py;
		}
	}
	// Personクラス(このような宣言が普通)
	class Person{
		// Personクラスのメンバー変数(フィールド)
		public string name;		// 名前
		public uint   age;		// 年齢
		public string address;	// 住所
		// 情報をコンソール出力する関数
		public void EchoInfo(){
			// 設定した情報を変数にセット
			string name = this.name;
			uint age = this.age;
			string address = this.address;
			Console.WriteLine("name    : " + name);
			Console.WriteLine("age     : " + age);
			Console.WriteLine("address : " + address);
		}
	}
	public class Program{
		// Programクラスのメンバー
		static string greet = "hello";

		public static void Main(string[] args){
			Point p1 = new Point();
			p1.x = 1;
			p1.y = 3;
			// Programクラスのstaticなメンバーにアクセスする場合
			Console.WriteLine(greet);
			// 構造体そのものを表示すると名前空間.構造体名が表示される
			Console.WriteLine("{0}\n({1}, {2})", p1, p1.x, p1.y);
			// コンストラクタを使用する
			Point p2 = new Point(2, 5);
			Console.WriteLine("{0}\n({1}, {2})", p2, p2.x, p2.y);

			// Personクラスのメンバーにアクセスする場合
			Person ps1 = new Person();	// インスタンスの生成
			// ps1のメンバーの初期化
			ps1.name = "Miyamoto";
			ps1.age = 90;
			ps1.address = "https://github.com/mryyomutga";
			// クラスの関数を使用する場合
			ps1.EchoInfo();
		}
	}
}
