// Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.
// For a = [1, 2, 3] and b = [1, 2, 3], the output should be solution(a, b) = true.
// For a = [1, 2, 3] and b = [2, 1, 3], the output should be solution(a, b) = true.
bool solution(int[] a, int[] b)
{

    if (a.Length != b.Length)
    {
        return false;
    }
    int diffCount = 0;
    int[] diffIndices = new int[2];
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
        {
            diffCount++;
            if (diffCount > 2)
            {
                return false;
            }
            diffIndices[diffCount - 1] = i;
        }
    }
    if (diffCount == 0)
        return true;
    else if (diffCount == 2)
    {
        return (a[diffIndices[0]] == b[diffIndices[1]] && a[diffIndices[1]] == b[diffIndices[0]]);
    }
    return false;
}
