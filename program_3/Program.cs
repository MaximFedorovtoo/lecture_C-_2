int [] array = {1,2,3,4,5,6,99,8,9};
int n = array.Length;
int find = 99;
int index =0;
while(index <= n)
{
    if( array[index] == find ){ Console.WriteLine(index); }
    index++;
}