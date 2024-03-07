
// Given an array of strings, 
// return another array containing all of its longest strings.
// For inputArray = ["aba", "aa", "ad", "vcd", "aba"],
// the output should be solution(inputArray) = ["aba", "vcd", "aba"].

string[] solution(string[] inputArray)
{
    List<string> result = new List<string>();
    int maxLength = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        int currentLength = inputArray[i].Length;
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            result.Clear();
            result.Add(inputArray[i]);
        }
        else if (currentLength == maxLength)
        {
            result.Add(inputArray[i]);
        }
    }
    return result.ToArray();

}
