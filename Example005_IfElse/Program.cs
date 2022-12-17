Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "я")
{
   Console.WriteLine("Самая топовая девушка прибыла!) Приветики)");
}
else
{
    Console.Write ("Добро пожаловать, ");
    Console.Write (username);
}
