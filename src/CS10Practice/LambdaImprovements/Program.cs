MapAction([HttpPost("/")] ([FromBody] string todo) => todo);    // ラムダで属性が使える
MapAction(string (todo) => todo);   // 直接書くラムダで return の型ががける

//MapAction([HttpPost("/")] todo => todo);    // これはエラー。ラムダに属性をつける場合、引数リストは ( ) が必要
MapAction([HttpPost("/")] (todo) => todo);  // これは ( ) があるので OK

// 関数やクラスの定義

// Function
void MapAction(Func<string, string> action) {; }

// 属性
class HttpPostAttribute : Attribute { public HttpPostAttribute(string root) {; } }
class FromBodyAttribute : Attribute { public FromBodyAttribute() {; } }
