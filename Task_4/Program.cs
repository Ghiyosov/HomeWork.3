
    int b = 0;

int  nab(int a ) 
{
    b = b * 10 + a % 10;
    if (a <=10)
        return b;

    else 
    {
     

        return nab(a / 10);   
    } 
}
void nab1(int a)
{
    if (a <= 0) return;

    else
    {
        Console.Write((a % 10) + " ");
        nab1(a / 10);
    }
}

nab1(nab(1234));