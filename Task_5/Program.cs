    int b = 0;


int sum(int i)
{
    b++;

    if (i <= 10)
        return b;

    else return sum(i/10);
}
Console.WriteLin