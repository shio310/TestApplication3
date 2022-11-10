/// <summary>
/// サンプルクラスライブラリ
/// </summary>
namespace ClassLibrary
{
    /// <summary>
    /// サンプルクラス
    /// </summary>
    public class Class1
    {

        /// <summary>
        /// サンプルプロパティ
        /// </summary>
        public int someNumber = 1;

        /// <summary>
        /// サンプルメソッド
        /// </summary>
        /// <param name="text">サンプル引数</param>
        public void DoSomething(string text)
        {
            System.Diagnostics.Debug.WriteLine(text);
        }

    }
}