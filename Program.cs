Console.Clear();
Console.WriteLine(" Ввежите пятизначное число ->");
string x = Console.ReadLine();
if (x[0] == x[4] && x[1] == x[3])
{
    Console.WriteLine($"{x} -> Да");
}
else
Console.WriteLine($"{x}-> Нет");