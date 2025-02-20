int[] arr = { 1, 2, 3, 4, 6 };
int target = 6;
var result = FindPairWithSum(arr, target);
if (result != null)
    Console.WriteLine($"Pair: {result[0]}, {result[1]}");
else
    Console.WriteLine("No pair found.");

static int[] FindPairWithSum(int[] arr, int target)
{
    int left = 0, right = arr.Length - 1;
    while (left < right)
    {
        int sum = arr[left] + arr[right];
        if (sum == target) return new int[] { arr[left], arr[right] };
        else if (sum < target) left++;
        else right--;
    }
    return null; // No pair found
}