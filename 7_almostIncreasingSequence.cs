// Given a sequence of integers as an array, 
// determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.
// For sequence = [1, 3, 2, 1], the output should be solution(sequence) = false.
// For sequence = [1, 3, 2], the output should be solution(sequence) = true.
bool solution(int[] sequence)
{
    int remove = 1;

    for (int i = 0; i < sequence.Length - 1; i++)
    {
        if (sequence[i] < sequence[i + 1])
        {
            continue;
        }
        else
        {
            remove -= 1;

        }
        if (remove < 0) return false;

        if (i > 0 && sequence[i - 1] >= sequence[i + 1])
        {
            sequence[i + 1] = sequence[i] + 1;
        }

    }

    return true;

}
