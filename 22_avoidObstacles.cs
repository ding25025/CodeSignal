// You are given an array of integers representing coordinates of obstacles situated on a straight line.
// For inputArray = [5, 3, 6, 7, 9], the output should be solution(inputArray) = 4.
int solution(int[] inputArray)
{
    int maxNum = inputArray.Max();

    for (int jump = 2; ; jump++)
    {
        bool canJump = true;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] % jump == 0)
            {
                canJump = false;
                break;
            }
        }
        if (canJump)
        {
            return jump;
        }
        if (jump > maxNum)
        {
            break;
        }
    }
    return -1;

}


