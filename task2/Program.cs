void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i*i}\t");
        i = i + 1;
    }
}
PrintSquares(5);
PrintSquares(10);
PrintSquares(15);
