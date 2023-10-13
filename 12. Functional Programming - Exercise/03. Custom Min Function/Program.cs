int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

Func<int[], int> minNum = (nums) =>
{
    int minnum = nums.Min();
    return minnum;
};

Console.WriteLine(minNum(nums));