// Some people are standing in a row in a park. 
// There are trees between them which cannot be moved. 
// Your task is to rearrange the people by their heights in a non-descending order without moving the trees. 
// People can be very tall!
int[] solution(int[] a)
{

    List<int> heights = a.Where(x => x != -1).ToList();
    heights.Sort();
    int heightIndex = 0;
    for (int i = 0; i < a.Length; i++)
    {

        if (a[i] != -1)
        {
            a[i] = heights[heightIndex];
            heightIndex++;
        }

    }
    return a;
}
