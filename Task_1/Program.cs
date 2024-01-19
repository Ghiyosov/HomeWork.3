
int b = 1;

void sum(int i)
{
    Console.WriteLine(b);

    if (b == i)
        return;
    b++;

    sum(i);
}

sum(10);