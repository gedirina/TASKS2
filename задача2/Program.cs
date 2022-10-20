int n = int.Parse(Console.ReadLine());
if (n<100)  
{ 
    Console.WriteLine("Число двузначное");
    }
else 
{
    int coef=10;
        while (true)
{
    int sep=n/coef;
    if (sep>10 && sep<100)
    {
    break;}
else
{
            coef *=10;
}
}
Console.WriteLine($"Второе число - {(n/coef) %10}");
}

