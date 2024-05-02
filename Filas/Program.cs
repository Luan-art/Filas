using Filas;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Bem vindo a fila!");

        FilaPessoa filaPessoas = new ();

        filaPessoas.Push(new("Cleber"));
        filaPessoas.Push(new("Clebinho"));
        filaPessoas.Push(new("Clebão"));

        filaPessoas.RunOver();

        filaPessoas.Pop();
        filaPessoas.Pop();

        filaPessoas.RunOver();

        filaPessoas.Pop();

        filaPessoas.RunOver();


    }
}