using Controllers;

Console.WriteLine("Inicio...");

if (new PersistController().Inserir())
{
    Console.WriteLine("Inseriu tudo!!!!");
}
else
{
    Console.WriteLine("ERRO");
}