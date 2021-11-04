#nullable enable

C c = new C();
if (c?.M(out object obj3) == true)
{
    obj3.ToString(); // undesired error
}

if (c?.M(out object obj4) ?? false)
{
    obj4.ToString(); // undesired error
}
if (c != null ? c.M(out object obj) : false)
{
    obj.ToString(); // undesired error
}

public class C
{
    public bool M(out object obj)
    {
        obj = new object();
        return true;
    }
}