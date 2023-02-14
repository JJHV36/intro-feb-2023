namespace CSharpSyntax;

public class ClassesAndRecords
{
    [Fact]
    public void MutatingStuffIsBadSometimes()
    {
        // fake code getting from a database
        var me = GetCustomer();
        
        Assert.Equal("Jeff", me.Name);

        //me.AvailableCredit = 10000;

        var other = new Customer
        {
            Name = "Jeff",
            AvailableCredit = 3000
        };

        Assert.Equal(me, other);
        //Assert.Equal(other.Name, me.Name);
        //Assert.Equal(other.AvailableCredit, me.AvailableCredit);

        var message = "Hello, World";

        var message2 = message.ToUpper();    // immutable operation

        Assert.Equal("Hello, World!", message);
        Assert.Equal("HELLO, WORLD!", message2);

        var updatedMe = me with { AvailableCredit = 30000 };
        Assert.Equal(3000, me.AvailableCredit);
        Assert.Equal(30000, updatedMe.AvailableCredit);
        Assert.Equal("Jeff", updatedMe.Name);
    }

    [Fact]
    public void ConstructorRecord()
    {
        var product = new Product("1919", "Eggs", 6, 1.99M);

        Assert.Equal("1919", product.Sku);
        Assert.Equal("eggs", product.Description);

        //Assert.Equal(11.19M);
    }

    private Customer GetCustomer()
    {
        return new Customer
        {
            Name = "Jeff",
            AvailableCredit = 3000
        };
    }
}


public record Customer
{
    public string Name { get; set; } = "";

    public decimal AvailableCredit { get; set; } = 3000;
}

public record Product(string Sku, string Description, int Qty, decimal Price)
{
    // public decimal
}