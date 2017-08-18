# C# Exercise
## 目的
- C#の勉強を始めたので、勉強中に作成したソースの管理
- Windows上で動作するデスクトップアプリケーションの開発が最終目標
  * デスクトップアプリケーション作り始めたら別のリポジトリを作成する
- GitHub上にアップロードし、C#の勉強を始める人のための手助け（になるかはわからない）

## 開発環境
Atomエディタとコマンドプロンプトによる開発  
Visual Studio等の統合開発環境(IDE)は使用していない
- Windows10 Pro x64
- Microsoft (R) Visual C# Compiler version 4.7.2053.0 for C# 5
- Visual Studio Code (Markdown編集用)

## 利用する上での注意事項
- 問題が生じた場合、一切の責任を取りませんので自己責任でお願いします
- 勉強を始めたばかりでC# についてよくわかっていないため、詳しいことは[teratail](https://teratail.com/)などを活用してください
- ソースコードに無駄、意味が異なる記述が紛れ込んでいる可能性があります
- コンパイラが C# 5のため、C# 6以降に実装された機能は、記述するようにしているが動作確認はしていません

## ソースコードの目次
以下のページを参照  

[ソースのリスト](https://github.com/mryyomutga/CS_Exercise/blob/master/SourceList.md)

## その他
### ソースコード
- コードは自由に改変可
- ご指摘があれば報告お願いします  
    * なにかあれば書き込んでいってください

### ライセンス
詳細は [LICENSE](https://github.com/mryyomutga/CS_Exercise/blob/master/LICENSE) を参照

### コメント
- Visual Studio 2017 Enterpriseをインストールしているけど、C# 7のコンパイラはどこ？
- Visual StudioでC# のコンソールアプリケーションの開発の仕方が分からない

## 参考・引用
- [C#によるプログラミング入門|++C++;//未確認飛行 C](http://ufcpp.net/study/csharp/)

# Note
- 文字列を他の型に変換する操作がJavaと違って`int.Parse()`といったような操作をするだけでよい  
    - Javaだと`Integer.parseInt()`などで型変換
- 関数の引数などに`params`を付けるだけで可変長にできる  
- Cより構造体が使いやすい（気がする）
- `var`で型推論できる  
---
- JavaやC言語に比べて書きにくい（フォーマット、変数の扱い）
- 多次元配列のサイズ取得が面倒  
  `可変長配列か多次元配列かで.Lengthか.GetLength()メソッドを使い分ける必要がある`  
- 省略しすぎて使いにくい  
  `匿名関数、内部関数、特にまだ勉強してないラムダ式`  
- usingディレクティブや名前空間がよくわからない。 Javaでの `import`と `package` ?  
