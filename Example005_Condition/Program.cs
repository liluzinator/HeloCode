Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "mikkel")
{
    Console.WriteLine("Привет мой пупсик:*");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}