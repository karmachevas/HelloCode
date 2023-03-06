Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "admin") 
{
    Console.Write("Привет администратор");
}
else
{
    Console.Write("Привет, пользователь ");
    Console.WriteLine(username);
}