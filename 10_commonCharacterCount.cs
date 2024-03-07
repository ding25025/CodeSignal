// Given two strings, find the number of common characters between them.
// For s1 = "aabcc" and s2 = "adcaa", the output should be solution(s1, s2) = 3.
int solution(string s1, string s2)
{

    int count = 0;
    for (int i = 0; i < s1.Length; i++)
    {
        int index = s2.IndexOf(s1[i]);
        if (index != -1)
        {
            s2 = s2.Remove(index, 1);
            count++;
        }
    }
    return count;
}
