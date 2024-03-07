// Given a string, find out if its characters can be rearranged to form a palindrome.
// For inputString = "aabb", the output should be solution(inputString) = true.
bool solution(string inputString)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach (char c in inputString)
    {
        if (charCount.ContainsKey(c))
        {
            charCount[c] += 1;
        }
        else
        {
            charCount[c] = 1;
        }
    }
    int oddCount = 0;

    foreach (int num in charCount.Values)
    {
        if (num % 2 != 0)
        {
            oddCount++;
        }
    }
    return oddCount <= 1;
}
