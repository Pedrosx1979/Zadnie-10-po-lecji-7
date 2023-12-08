// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Podaj długość pierwszego boku"); 
int a = Int32. Parse(Console.ReadLine());
Console.WriteLine("Podaj długość drugiego boku");
int b = Int32. Parse(Console.ReadLine());
Console.WriteLine("Podaj długość trzeciego boku");
int c = Int32.Parse(Console.ReadLine());*/
int a = 40;
int b = 55;
int c = 65;


int longest = Math.Max(a, Math.Max(b, c));

if (a > 0 || b > 0 || c > 0 && a + b > c || c + b > a || a + c > b)
{
    Console.WriteLine(" Z podanych boków można utworzyć trójkąt ");
}
else 
{
    Console.WriteLine(" Z podanych boków nie można utworzyć trójkąta ");
}