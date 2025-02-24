AreAnagrams("listen","silent");

static bool AreAnagrams(string str1, string str2)
{
    if (str1.Length != str2.Length) return false;

    string sortedStr1 = new string(str1.ToLower().OrderBy(c => c).ToArray());
    string sortedStr2 = new string(str2.ToLower().OrderBy(c => c).ToArray());

    // Print the sorted strings for debugging (optional):
    Console.WriteLine(sortedStr1);
    Console.WriteLine(sortedStr2);

    // Compare the sorted strings:
    Console.WriteLine(sortedStr1 == sortedStr2);

    return sortedStr1 == sortedStr2;
}

