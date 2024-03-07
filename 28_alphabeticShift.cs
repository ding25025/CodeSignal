// Given a string, your task is to replace each of its characters by the next one in the English alphabet; 
// i.e. replace a with b, replace b with c, etc (z would be replaced by a).
// For inputString = "crazy", the output should be solution(inputString) = "dsbaz".
string solution(string inputString)
{
    string characters = "abcdefghijklmnopqrstuvwxyz";
    string result = "";
    for (int i = 0; i < inputString.Length; i++)
    {
        int index = characters.IndexOf(inputString[i]);
        if (index == 25)
        {
            result += characters[0];
        }
        else
        {
            result += characters[index + 1];
        }
    }
    return result;

}
