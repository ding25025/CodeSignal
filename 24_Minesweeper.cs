// matrix = [[true, false, false],
//           [false, true, false],
//           [false, false, false]]
// solution(matrix) = [[1, 2, 1],
//                     [2, 1, 1],
//                     [1, 1, 1]]

int[][] solution(bool[][] matrix)
{

    int height = matrix.Length;
    int width = matrix[0].Length;

    int[][] resultBoard = new int[height][];
    for (int i = 0; i < height; i++)
    {
        resultBoard[i] = new int[width];
        for (int j = 0; j < width; j++)
        {
            resultBoard[i][j] = CountNeighboringMines(matrix, i, j);

        }
    }
    return resultBoard;
}

static int CountNeighboringMines(bool[][] matrix, int row, int col)
{
    int Count = 0;
    int height = matrix.Length;
    int width = matrix[0].Length;
    int[] dr = { -1, -1, -1, 0, 0, 1, 1, 1 };
    int[] dc = { -1, 0, 1, -1, 1, -1, 0, 1 };
    for (int i = 0; i < 8; i++)
    {
        int newRow = row + dr[i];
        int newCol = col + dc[i];

        if (newRow >= 0 && newRow < height && newCol >= 0 && newCol < width)
        {
            if (matrix[newRow][newCol])
            {
                Count++;
            }

        }

    }
    return Count;

}