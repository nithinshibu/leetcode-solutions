string input = "nithin";
int length = LengthOfLongestSubstring(input);
string s = LongestNonRepeatedSubString(input);
Console.WriteLine($"Length: {length}");
Console.WriteLine($"String: {s}");

static int LengthOfLongestSubstring(string s)
{
    int n = s.Length;
    int left = 0, maxLen = 0;
    var seen = new HashSet<char>();

    for (int right = 0; right < n; right++)
    {
        while (seen.Contains(s[right]))
        {
            seen.Remove(s[left]);
            left++;
        }
        seen.Add(s[right]);
        maxLen = Math.Max(maxLen, right - left + 1);
    }

    return maxLen;
}

static string LongestNonRepeatedSubString(string s)
{
    int left = 0, maxLen = 0;
    int bestLeft = 0; //track the starting position of the best substring
    var seen = new HashSet<char>();


    for (int right = 0; right < s.Length; right++)
    {
        while (seen.Contains(s[right]))
        {
            seen.Remove(s[left]);
            left++;
        }
        seen.Add(s[right]);


        //if we found a larger substring , update both length and starting position 

        if (right - left + 1 > maxLen)
        {
            maxLen = right - left + 1;
            bestLeft = left;
        }
    }
    // Return the substring using the stored position and length
    return s.Substring(bestLeft, maxLen);

}