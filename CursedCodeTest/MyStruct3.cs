using CursedCode;

namespace CursedCodeTest;

public struct MyStruct3 : IInterface<MyStruct3>
{
    public static implicit operator MyStruct(in MyStruct3 s) => default;
}
