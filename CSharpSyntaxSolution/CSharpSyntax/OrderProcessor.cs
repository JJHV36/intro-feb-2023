namespace CSharpSyntax;

public class OrderProcessor
{
    public void AddItem(Item itemToAdd)
    {

    }
}

public interface IHandleTheDatabase
{
    void AddShoppingItem(Item itemToAdd);
}

public record Item
{
    public string Name { get; init; } = string.Empty;
    public int Qty { get; init; }
    public decimal Price { get; init; }
}