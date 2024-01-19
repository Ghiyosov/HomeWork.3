int sum(int i) 
{
   
    if (i==1)
        return 1;

    else return i+sum(i-1);
}

Console.WriteLine(sum(10));