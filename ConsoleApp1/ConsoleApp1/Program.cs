Console.WriteLine("Enter the value of x:");
int x = Convert.ToInt32(Console.ReadLine());

int y = ((x << 5) - x) - ((x << 4) + (x << 0)) + 5;

Console.WriteLine($"Result: y = {y}");

