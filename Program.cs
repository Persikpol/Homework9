// Task 64

void Zadacha64()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    Recursion64(M, N);
}

void Recursion64(int M, int N)
{
    if (M > N) return;
    if (M%3 == 0) Console.Write(M + " ");
    M++;
    Recursion64(M, N);
}
Zadacha64();

// Task 66

void Zadacha66()
{
    Console.WriteLine("Введите число M");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    Recursion66(M, N, sum);
    
}

void Recursion66(int M, int N, int sum)
{
    
    if (M > N) 
    {
        Console.WriteLine("Сумма всех элементов между M и N = " + sum);
        return;
    }
    sum = sum + M;
    M++;
    Recursion66(M, N, sum);
}
Zadacha66();

