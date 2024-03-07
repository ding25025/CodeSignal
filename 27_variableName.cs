// Correct variable names consist only of English letters, 
// digits and underscores and they can't start with a digit.
// For name = "var_1__Int", the output should be solution(name) = true;
// For name = "qq-q", the output should be solution(name) = false;
// For name = "2w2", the output should be solution(name) = false.

bool solution(string name)
{

    if (char.IsDigit(name[0]))
    {
        return false;
    }
    for (int i = 0; i < name.Length; i++)
    {
        if (char.IsLetterOrDigit(name[i]) || name[i].Equals('_'))
        {
            continue;
        }
        else
        {
            return false;
        }
    }
    return true;
}
