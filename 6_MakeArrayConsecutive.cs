// Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, 
// each statue having an non-negative integer size. 
// Since he likes to make things perfect, 
// he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1.
// He may need some additional statues to be able to accomplish that. 
// Help him figure out the minimum number of additional statues needed.

int solution(int[] statues)
{
    Array.Sort(statues);
    int diff = 0;
    int total = 0;
    for (int i = 0; i < statues.Length - 1; i++)
    {
        diff = statues[i + 1] - statues[i];
        if (diff == 1)
            continue;
        else
            total += diff - 1;
    }
    return total;
}
