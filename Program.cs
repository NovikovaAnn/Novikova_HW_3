// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Cubes(int N){
    int num = 1;
    if(N >= 1){
        for(int i = 1; i <= N; i++){
            num = i * i * i;
            Console.WriteLine(num);
        }
        return num;

    }
    else return 0;
}
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());

Cubes(A);



//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome()
{
    Console.WriteLine("Enter five - digit number");
    int number = Convert.ToInt32(Console.ReadLine());
    int n = number;
    int reverse = 0;
    if (number <= 99999 & number >= 10000)
    {
        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        };
        if (n == reverse)
        {
            Console.WriteLine(n + " is a palindrome");
        }
        else
            Console.WriteLine(n + " is not a palindrome");
    }
    else
        Console.WriteLine("You entered not a five - digit number");
}

Palindrome();


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


void Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine("Distance between the dots is " + dist);
}

Console.WriteLine("Input coordinates of first dot");
int Xa = Convert.ToInt32(Console.ReadLine());
int Ya = Convert.ToInt32(Console.ReadLine());
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinates of the second dot");
int Xb = Convert.ToInt32(Console.ReadLine());
int Yb = Convert.ToInt32(Console.ReadLine());
int Zb = Convert.ToInt32(Console.ReadLine());
Dist(Xa, Ya, Xb, Yb, Za, Zb);

