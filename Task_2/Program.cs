void sum(int i) 
{
    int b = 0;
    Console.WriteLine(i);

    if (i==1)
        return;
    i--;

    sum(i);
}

sum(10);