Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());
int x1 = n / 10000;
int x2 = n / 1000 % 10;
int y1 = n % 10;
int y2 = n / 10 % 10;
if (x1 == y1 && x2 == y2)
    Console.WriteLine ("Число палиндром");
else
    Console.WriteLine("Число не палиндром");