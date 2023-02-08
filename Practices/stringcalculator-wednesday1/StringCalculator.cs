
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }

        string[] nums = numbers.Split(',', '\n');
        if (nums.Length == 1)
        {
            return int.Parse(nums[0]);
        }
        else
        {
            int sum = 0;
            int numberAsInt = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                numberAsInt= int.Parse(nums[i]);
                sum += numberAsInt;
            }
            return sum;
        }
    }
}
