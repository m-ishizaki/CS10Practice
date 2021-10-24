struct Sample
{
    public int Value1 = default;  // フィールドを初期化しているのがポイント

    // C# 10.0 未満ではエラー 「CS8773  Feature 'parameterless struct constructors' is not available in C# 9.0. Please use language version 10.0 or greater.」
    public Sample() { }

    // パラメータのあるコンストラクタは以前から OK
    public Sample(int value1) { Value1 = value1; }
}

// これはエラー。フィールドは初期化される必要がある
struct Sample2
{
    public int Value1;  // フィールドを初期化していないのがポイント

    // エラー 「CS0171  Field 'Sample2.Value1' must be fully assigned before control is returned to the caller」
    // public Sample2() { }
}

// これは OK。
struct Sample3
{
    public int Value1;

    // フィールドを初期化しているので OK
    public Sample3() { Value1 = default; }
}
