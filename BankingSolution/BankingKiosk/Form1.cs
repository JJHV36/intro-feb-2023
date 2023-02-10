using Banking.Domain;
namespace BankingKiosk;

public partial class Form1 : Form
{
    BankAccount _account;
    public Form1()
    {
        InitializeComponent();
        _account = new BankAccount(new StandardBonusCalculator(new StandardBusinessClock(new SystemTime())));
        UpdateBalanceDisplay();
    }

    private void UpdateBalanceDisplay()
    {
        this.Text = $"You have a balance of {_account.GetBalance():c} Currently";
    }

    private void depositButton_Click(object sender, EventArgs e)
    {
        DoTransaction(_account.Deposit);
    }

    private void withdrawButton_Click(object sender, EventArgs e)
    {
        DoTransaction(_account.Withdraw);
    }

    private void DoTransaction(Action<decimal> op) // if you call me you have to give me a method that returns void
        // and takes a decimal argument
    {
        try
        {
            var amount = decimal.Parse(amountInput.Text);
            op(amount);// this "op" refers to a method that takes a decimal.
            UpdateBalanceDisplay();
        } catch(FormatException)
        {
            DisplayTransactionError("Enter a number, dummy.");
        }
        catch (AccountOverdraftException) 
        {
            DisplayTransactionError("Insufficient funds!");
        } catch (NoNegativeNumbersException)
        {
            DisplayTransactionError("No negative numbers allowed!");
        }
        finally
        {
            // run this if there is an error, of if there isn't an error. ALWAYS
            amountInput.SelectAll(); // select all the text in the input
            amountInput.Focus(); // Put the cursor there.
        }
    }

    private static void DisplayTransactionError(string error)
    {
        MessageBox.Show(error, "Error on Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Anonymous Function (a method with no name) we call these "lambdas" in C#, Arrow FUnction in JavaScript, etc.
        DoTransaction((amount) => MessageBox.Show("You clicked a button, blah" + amount.ToString()));

        // "Anonymous Delegate" - how we did this up until 2008+
        //DoTransaction(delegate (decimal amount)
        //{
        //    MessageBox.Show("You clicked a button, blah" + amount.ToString());
        // HomoIconicity = code and data structures are represented the same way
        //});
    }
}