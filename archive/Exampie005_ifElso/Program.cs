Console.Write("Введите своё имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "кот")
{
    Console.WriteLine("Ура, это же Котик");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}