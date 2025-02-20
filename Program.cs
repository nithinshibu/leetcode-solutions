int[] nums = { 0, 1, 0, 3, 12 };
MoveZeroes(nums);
Console.WriteLine(string.Join(", ", nums));

static void MoveZeroes(int[] nums)
{
    int index = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[index++] = nums[i];
        }
    }

    for (int i = index; i < nums.Length; i++)
    {
        nums[i] = 0;
    }
}