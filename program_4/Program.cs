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
    int notMutch = 0;
    Console.Write($"Число {var} находится под индексом: ");
    while (count<index.Length)
    {
        if(var == index[count]) {Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{count}, ");}
        else {notMutch++;}
        count++;
    }
    if (notMutch == index.Length){Console.ForegroundColor = ConsoleColor.Red; Console.Write("Нет такого числа!!!");}
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
int FindNumber(int numb)
{
    Console.Write("Введите число для поиска ");
    numb = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return numb;
    
}
int[] array = new int [10];
int find = 0;
RandomNumber(array);
PrintArray(array);
IndexNumber(array,FindNumber(find));
