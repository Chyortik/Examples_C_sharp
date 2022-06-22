Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "dimon")
{
    Console.WriteLine("Салют, браток!!!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}