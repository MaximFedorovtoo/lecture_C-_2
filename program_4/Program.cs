Console.Clear();
void RandomNumber(int[] rand)
{

    int count = 0;
    while(count < rand.Length)
    {
        rand[count] = new Random().Next(1,10);
        count++;
        
    }
};
void IndexNumber(int[] index, int var)
{
    int count = 0;
    Console.Write($"Число {var} находится под индексом: ");
    while (count<index.Length)
    {
        if(var == index[count]) {Console.Write($"{count}, ");}
        count++;
    }
}
void PrintArray(int[] arr)
{
    int count = 0;
    while(count< arr.Length)
    {
        Console.Write($"{arr[count]}, ");
        count++;
    }
    Console.WriteLine();
}
int[] array = new int [10];
int find = new Random().Next(1,10); 
RandomNumber(array);
PrintArray(array);
IndexNumber(array,find);
