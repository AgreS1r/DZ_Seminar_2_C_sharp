Console.WriteLine("Enter number (100-999) ");
int num = int.Parse(Console.ReadLine());

int numA = num / 10;
int result = numA % 10;
Console.WriteLine(result);