Console.Clear();
int Max(int ver1, int ver2, int ver3)
{
    int result = ver1;
    if(result < ver2) { result = ver2; }
    if(result < ver3) { result = ver3; }
    return result;
}

int a1 = 12;
int a2 = 45;
int a3 = 50;
int b1 = 40;
int b2 = 23;
int b3 = 454;
int c1 = 32;
int c2 = 4;
int c3 = 67;

int max = Max(Max(a1, a2, a3), Max(b1, b2,b3), Max(c1, c2, c3));
Console.WriteLine(max);