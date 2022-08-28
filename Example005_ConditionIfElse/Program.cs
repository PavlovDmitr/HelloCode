// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введитие имя пользователя");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine("Ура это же Маша!!!");
}
else
{
    Console.WriteLine($"Привет, {userName}!");
}