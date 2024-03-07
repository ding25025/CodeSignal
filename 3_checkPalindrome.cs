// Given the string, check if it is a palindrome.

bool solution(string inputString)
{
    int i = 0, j = inputString.Length - 1;

    while (i < j)
        if (inputString[i] == inputString[j])
        {
            i += 1;
            j -= 1;
            continue;
        }
        else
        {
            return false;
        }
    return true;

}
