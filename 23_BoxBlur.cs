int[][] solution(int[][] image)
{

    int height = image.Length;
    int width = image[0].Length;
    int[][] blurredImage = new int[height - 2][];

    for (int i = 0; i < height - 2; i++)
    {

        blurredImage[i] = new int[width - 2];

        for (int j = 0; j < width - 2; j++)
        {
            int sum = 0;

            // Sum the values in the 3x3 box
            for (int k = i; k < i + 3; k++)
            {
                for (int l = j; l < j + 3; l++)
                {
                    sum += image[k][l];
                }
            }
            blurredImage[i][j] = sum / 9;
        }
    }

    return blurredImage;

}