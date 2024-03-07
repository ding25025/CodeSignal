// You are given an array of integers. 
// On each move you are allowed to increase exactly one of its element by one. 
// Find the minimal number of moves required to obtain a strictly increasing sequence from the input.
// For inputArray = [1, 1, 1], the output should be solution(inputArray) = 3.
int solution(int[] inputArray)
{
    int move = 0;
    int temp = inputArray[0];
    for (int i = 1; i < inputArray.Length; i++)
    {

        if (inputArray[i] <= temp)
        {
            move += temp - inputArray[i] + 1;
            inputArray[i] = temp + 1;
        }
        temp = inputArray[i];
    }
    return move;
}
