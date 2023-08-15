namespace CursedCode;

public interface IInterface<T>
    where T : IInterface<T>
{
    static virtual implicit operator MyStruct(in T value) => default;
}
