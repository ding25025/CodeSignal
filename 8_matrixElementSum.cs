// After becoming famous, the CodeBots decided to move into a new building together.
// Each of the rooms has a different cost,
// and some of them are free, but there's a rumour that all the free rooms are haunted! 
// Since the CodeBots are quite superstitious, they refuse to stay in any of the free rooms, 
// or any of the rooms below any of the free rooms.
int solution(int[][] matrix)
{
    int total = 0;
    List<int> ghost = new List<int>();

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (!ghost.Contains(j))
                if (matrix[i][j] == 0)
                {
                    ghost.Add(j);
                }
                else
                {
                    total += matrix[i][j];
                }

        }
    }
    return total;

}
