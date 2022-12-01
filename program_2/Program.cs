Console.Clear();
int Max(int ver1, int ver2, int ver3)
{
    int result = ver1;
    if(result < ver2) { result = ver2; }
    if(result < ver3) { result = ver3; }
    return result;
}
int [] array = {1,3,4,5,6,7,8,9,2};
int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4],array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);