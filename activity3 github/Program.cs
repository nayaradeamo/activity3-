internal class Program
{
    public static void Main(string[] args)
    {

        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    capitals();
                    break;
                case ConsoleKey.D2:
                    OddOrEven();
                    break;
                case ConsoleKey.D3:
                    DoTry2ReadValidTimeStamp();
                    break;
                

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void ShowOptions()
    {
        Console.WriteLine("1- Capitals");
        Console.WriteLine("2- ");
        Console.WriteLine("3- ");
    }
}
