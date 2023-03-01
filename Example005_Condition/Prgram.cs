Conole.Write("Введите имя пользователя:");
string username = Console.Readline();

if(username == "МАША")
{
    Console.Writeline("Ура, это же МАША");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}