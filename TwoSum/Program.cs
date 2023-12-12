// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

int[] numbers = [1, 4, 18, 9, 2, 7, 3];
int targetValue = 6;

int[] TwoSum(int[] nums, int target)
{
    int[] output = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                output[0] = i;
                output[1] = j;
                break;
            }
        }
    }
    return output;
}

int[] result = TwoSum(numbers, targetValue);
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);