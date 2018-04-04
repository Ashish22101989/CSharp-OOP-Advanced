
public class CustomTuple<T, U>
{
    public CustomTuple(T itemOne, U itemTwo)
    {
        this.ItemOne = itemOne;
        this.ItemTwo = itemTwo;
    }

    public T ItemOne { get; private set; }

    public U ItemTwo { get; private set; }

    public override string ToString()
    {
        return $"{this.ItemOne} -> {this.ItemTwo}";
    }
}
