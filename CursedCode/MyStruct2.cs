using CursedCode;

namespace CursedCode;

public struct MyStruct2 : IInterface<MyStruct2>
{
    public static implicit operator MyStruct(in MyStruct2 s) => default;
}