using Microsoft.VisualBasic;
using System.Text;

namespace CSharpSyntax;
public class CreatingAndInitializingTypes
{
    string thingy = "Birdy";

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

    [Fact]
    public void ImplicitlyTypedLocalVariables() 
    { 
        // Var can be used for local variables, and you must initialize the variable.
        var myAge = 18;

        var r = new TransitoryPolicyCommuterRecord();
        var myName = "Jeffrey";

        var favoriteFood = new Taco();

        decimal myPay = 25.23M;

        // option in c# 6, we don't use this much except in special circumstances Jeff will show later

        Taco lunch = new();
        Assert.IsType<Taco>(lunch);
    }

    [Fact]
    public void CurlyBracesCreatScopes()
    {
        Assert.Equal("Birds", thingy);
        var message = "";
        var myAge = 23;
        if (myAge >= 21)
        {
            message = "Old Enough!";
        }
    }
    
    [Fact]
    public void MutableStringsWithStringBuilders()
    {
        var message = new StringBuilder();

        foreach(var num in Enumerable.Range(1, 10000))
        {
            message.Append(num.ToString() + ", ");
        }
        Assert.True(message.ToString().StartsWith("1, 2, 3, 4"));

        var myName = "Joe";
    }

    [Fact]
    public void MoreAboutStrings()
    {
        var name = "Bob"; var age = 33; var message = "The name is " + name + " and the age is " + age + ".";
        var message2 = string.Format("The name is {0} and the age is {1} (again, name: {0})", name, age);
        var pay = 120_000.00M;
        var m3 = $"{name} makes {pay:c} a year";
    }

    public void DoingConversionOnTypes()
    {

        string myPay = "10000.83Tacos";

        if(decimal.TryParse(myPay, out decimal payAsNumber))
        {
            Assert.Equal(10_0000.83M, payAsNumber);
        } else
        {
            Assert.True(false); // it should blow up here
        }

        var birthdate = DateTime.Parse("04/20/1969");
        Assert.Equal(4, birthdate.Month);
        Assert.Equal(20, birthdate.Day);
        Assert.Equal(1969, birthdate.Year);
    }
}

public class Taco { }

public class TransitoryPolicyCommuterRecord { }
