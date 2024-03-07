// Write a function that reverses characters in (possibly nested) parentheses in the input string.
// Input strings will always be well-formed with matching ()s.
string solution(string inputString)
{
    int start, end;
    while (true)
    {
        // find the first closing bracket
        end = inputString.IndexOf(')');
        if (end == -1)
        {
            break; // no more closing brackets, we're done
        }

        // find the corresponding opening bracket
        start = inputString.LastIndexOf('(', end);

        // reverse the substring between the opening and closing brackets
        inputString = ReverseSubstring(inputString, start + 1, end - 1);

        // remove the opening and closing brackets
        inputString = inputString.Substring(0, start) + inputString.Substring(start + 1, end - start - 1) + inputString.Substring(end + 1);
    }
    return inputString;

}
static string ReverseSubstring(string str, int start, int end)
{
    char[] chars = str.ToCharArray();
    while (start < end)
    {
        char temp = chars[start];
        chars[start] = chars[end];
        chars[end] = temp;
        start++;
        end--;
    }
    return new string(chars);
}
