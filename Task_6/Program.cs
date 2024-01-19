void juft(int i, int b )
{
    if ( i%2 == 0) Console.Write(i + " ");


    if (i == b)
        return;
    i++;

    juft(i, b);
}

void toq(int i, int b)
{
    if (i % 2 != 0) Console.Write(i + " ");


    if (i == b)
        return;
    i++;

    toq(i, b);
}
int i=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

Console.Write($"All even numbers from {i} to {b} are :");
juft(i,b);
Console.WriteLine();
Console.Write($"All odd numbers from {i} to {b} are:");
toq(i,b);