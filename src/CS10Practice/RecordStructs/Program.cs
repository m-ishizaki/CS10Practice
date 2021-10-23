{ // レコード構造体
    SampleRecordStruct sampleRecordStruct = new(1);
    sampleRecordStruct.Value1 = 2;
}

{ // レコードクラス (以前からの機能)
    SampleClass sampleClass = new(1);
    // sampleClass.Value1 = 2; これはエラー。レコードクラスは不変
}

{ // 不変のレコード構造体
    SampleReadolyStruct sampleReadonlyStruct = new(1);
    // sampleReadonlyStruct.Value1 = 2; これはエラー
}

{ // レコード構造体
    SampleRecordStruct sampleRecordStruct = new(1);
    sampleRecordStruct.Value1 = 2;

    var struct4 = sampleRecordStruct with { Value1 = 2 };

    // ToString の結果は「SampleRecordStruct { Value1 = 2 }」フィールドの値も表示するいい感じの実装
    Console.WriteLine(sampleRecordStruct);
    // == で比較ができる。フィールドの値が同じなら True になる
    Console.WriteLine(sampleRecordStruct == struct4); // True
    // != もできる
    Console.WriteLine(sampleRecordStruct != struct4); // False
}

{ // 構造体
    // 位置指定レコードは通常の構造体では使えない
    SampleStruct sampleStruct = new (){ Value1 = 2 };
    sampleStruct.Value1 = 2;

    // with 式は通常の構造体でも使える
    var struct3 = sampleStruct with { Value1 = 3 };
    var struct4 = sampleStruct with { Value1 = 2 };

    // ToString の結果は「SampleStruct」構造体の名前だけの実装
    Console.WriteLine(sampleStruct);
    // == はできない文法エラー
    // Console.WriteLine(sampleStruct == struct4);
}



// レコード構造体
record struct SampleRecordStruct(int Value1);
// レコードクラス (以前からの機能)
record class SampleClass(int Value1);
// 不変のレコード構造体
readonly record struct SampleReadolyStruct(int Value1);
// 構造体
struct SampleStruct { public int Value1; };
