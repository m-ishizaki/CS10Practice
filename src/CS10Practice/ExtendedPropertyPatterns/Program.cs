SampleA a = new();

// プロパティの中のプロパティをシンプルに書ける
if (a is SampleA { PropertyA.PropertyB: 1 })
{
}

// 構造体定義
struct SampleA
{
    public SampleB PropertyA { get; set; }
}

struct SampleB
{
    public int PropertyB { get; set; }

}
