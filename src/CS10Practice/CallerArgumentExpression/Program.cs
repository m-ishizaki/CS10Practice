var array = new[] { 1 };

Debug.Assert(array != null);        // 「array != null」と出力される
Debug.Assert(array.Length == 1);    // 「array.Length == 1」と出力される

public static class Debug
{
    public static void Assert(bool condition, [System.Runtime.CompilerServices.CallerArgumentExpression("condition")] string message = null)
    {
        // message に式の叔父列が入ってくる
        System.Console.WriteLine(message);
    }
}
