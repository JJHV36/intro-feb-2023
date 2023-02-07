namespace CSharpSyntax;
public class CreatingAndInitializingTypes
{

    [Fact]
    public void UsingLiteralsToCreateInstancesOfTypes()
    {
        // local variables -- variables that are declared inside a method, or property
        string myName = "Jeffrey"; // Initializing
        char mi = 'J';

        bool isVendor = true;

        int myAge = 23;
        bool isLegalAgeToDrink = myAge >= 21;

        Taco food = new Taco();

        Assert.Equal("Jeffrey", myName);
        Assert.Equal(23, myAge);
    }
}

public class Taco { }
