// Given two cells on the standard chess board, determine whether they have the same color or not.
// For cell1 = "A1" and cell2 = "C3", the output should be solution(cell1, cell2) = true.
bool solution(string cell1, string cell2)
{
    string letters = "ABCDEFGH";
    int[] one = { letters.IndexOf(cell1[0]) + 1, cell1[1] };
    int[] two = { letters.IndexOf(cell2[0]) + 1, cell2[1] };

    if ((one[0] + one[1]) % 2 == (two[0] + two[1]) % 2)
    {
        return true;
    }
    return false;

}
