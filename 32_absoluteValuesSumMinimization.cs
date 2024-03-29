// Given a sorted array of integers a, 
// your task is to determine which element of a is closest to all other values of a. In other words, 
// find the element x in a, which minimizes the following sum:
int solution(int[] a)
{

    int n = a.Length;
    if (n <= 1)
    {
        return (n == 1) ? a[0] : -1; // -1 indicates no valid result for an empty array
    }
    int medianIndex = n / 2;

    // If there's a tie, return the smaller element
    if (n % 2 == 0)
    {
        // For an even-sized array, return the smaller of the two middle elements
        return Math.Min(a[medianIndex - 1], a[medianIndex]);
    }
    else
    {
        // For an odd-sized array, return the middle element
        return a[medianIndex];
    }

}
