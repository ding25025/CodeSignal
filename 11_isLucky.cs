// Ticket numbers usually consist of an even number of digits. 
// A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.
// For n = 1230, the output should be solution(n) = true;
// For n = 239017, the output should be solution(n) = false.
bool solution(int n)
{

    int leftSum = 0;
    int rightSum = 0;
    string nStr = n.ToString();

    for (int i = 0; i < nStr.Length / 2; i++)
    {
        leftSum += int.Parse(nStr[i].ToString());
        rightSum += int.Parse(nStr[nStr.Length - 1 - i].ToString());
    }

    return leftSum == rightSum;
}
