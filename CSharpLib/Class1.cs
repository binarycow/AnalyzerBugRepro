
using FSharpLib;

namespace CSharpLib;

public interface ICSharpInterface
{
    public int GetStringLength(string str);
}

public class TestCSharp : ICSharpInterface
{
    public int GetStringLength(string str) => str.Length;
}

public class TestFSharp : IFSharpInterface
{
    public int GetStringLength(string str) => str.Length;
}