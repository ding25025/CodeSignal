// Given an array of integers, 
// find the pair of adjacent elements that has the largest product and return that product.

int solution(int[] inputArray)
{

    int maxNum = -int.MaxValue;

    for (int i = 0; i < inputArray.Length - 1; i++)
    {
        if ((inputArray[i] * inputArray[i + 1]) > maxNum)
        {
            maxNum = (inputArray[i] * inputArray[i + 1]);
        }
    }
    return maxNum;
}
