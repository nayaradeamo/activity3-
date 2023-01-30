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
                     bigC();
                    break;
                case ConsoleKey.D3:
                  //  DoTry2ReadValidTimeStamp();
                    break;

                default:
                    MsgNextScreen("ERROR, Prem una tecla per tornar al menu..");
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void ShowOptions()
    {
        Console.WriteLine("1- CAPITALS");
        Console.WriteLine("2- BIGGEST COUNTRY");
        Console.WriteLine("3- ");
    }

    public static void capitals()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            preguntesTotes();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    respostaUk();
                    break;
                case ConsoleKey.D2:
                 respostaSpain();
                    break;
                case ConsoleKey.D3:
                  respostaAndorra();
                    break;

                case ConsoleKey.D4:
                  respostafransa();
                    break;
                case ConsoleKey.D5:
                  respostaalemanya();
                    break;


            }
        } while (tecla.Key != ConsoleKey.D0);


    }

    public static void preguntesTotes()
    {
        Console.WriteLine("1-WHAT'S THE CAPITAL OF THE UK?");
        Console.WriteLine("2-WHAT'S THE CAPITAL OF SPAIN?");
        Console.WriteLine("3-WHAT'S THE CAPITAL OF ANDORRA?");
        Console.WriteLine("4-WHAT'S THE CAPITAL OF FRANCE?");
        Console.WriteLine("5-WHAT'S THE CAPITAL OF GERMANY?");
    }

    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();

    }


    public static void respostaUk()
    {
       

        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestas1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    lon1();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    ber1();
                    break;
                case ConsoleKey.D3:
                    mad1();
                    break;
                case ConsoleKey.D4:
                    par1();
                    break;
          
            }
        } while (tecla.Key != ConsoleKey.D0);


    }

    public static void respuestas1()
    {
       
        Console.WriteLine("1- london");
        Console.WriteLine("2- berlin");
        Console.WriteLine("3- madrid");
        Console.WriteLine("4- paris");
        Console.WriteLine("0- EXIT");
    }

    public static void lon1()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", lon());
        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

    }

    public static string lon()
    {
       return"LONDON";
    }
    public static void ber1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON !", berlin());
        
      

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    
}
    public static string berlin()
    {
        return "BERLIN";
    }
    public static void mad1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON !", madrid());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

    }
    public static string madrid()
    {
        return "MADRID";
    }

    public static void par1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON !", paris());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

    }
    public static string paris()
    {
        return "PARIS";
    }

    public static void respostaSpain()
    {


        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestas2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    sor1();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                     gua1();
                    break;
                case ConsoleKey.D3:
                    madr1();
                    break;
                case ConsoleKey.D4:
                    bar1();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);


    }

    public static void respuestas2()
    {

        Console.WriteLine("1- soria");
        Console.WriteLine("2- guadalajara");
        Console.WriteLine("3- madrid");
        Console.WriteLine("4- barcelona");
        Console.WriteLine("0- EXIT");

    }

    public static void sor1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS MADRID!", soria());

        MsgNextScreen("PRESS TWICE A KEY TO GO TO THE MAIN MENU");
    }

    public static string soria()
    {
        return " SORIA ";
    }

    public static void gua1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS MADRID!", guadalajara());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string guadalajara()
    {
        return " GUADALAJARA ";
    }

    public static void madr1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", madrid1());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string madrid1()
    {
        return " MADRID ";
    }

    public static void bar1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS MADRID!", barcelona());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string barcelona()
    {
        return " BARCELONA ";
    }

    public static void respostaAndorra()
    {
          ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestas3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    pra1();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                     bru1();
                    break;
                case ConsoleKey.D3:
                    ate1();
                    break;
                case ConsoleKey.D4:
                    and1();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestas3()
    {

        Console.WriteLine("1- PRAGA");
        Console.WriteLine("2- BRUSSELS");
        Console.WriteLine("3- ATHENS");
        Console.WriteLine("4- ANDORRA LA VELLA");
        Console.WriteLine("0- EXIT");
    }

    public static void pra1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ANDORRA LA VELLA!", praga());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string praga()
    {
        return " PRAGA ";
    }
    public static void bru1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ANDORRA LA VELLA!", bruselas());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string bruselas()
    {
        return " BRUSSELS ";
    }

    public static void ate1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ANDORRA LA VELLA!", atenes());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string atenes()
    {
        return " ATHENS ";
    }

    public static void and1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", andorra());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string andorra()
    {
        return " ANDORRA LA VELLA ";
    }

    public static void respostafransa()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestas4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    rom1();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    pari1();
                    break;
                case ConsoleKey.D3:
                    vi1();
                    break;
                case ConsoleKey.D4:
                    and1();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void respuestas4()
    {

        Console.WriteLine("1- ROMA");
        Console.WriteLine("2- PARIS");
        Console.WriteLine("3- VIENNA");
        Console.WriteLine("4- LISBON");
        Console.WriteLine("0- EXIT");
    }
    public static void pari1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", paris());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static void rom1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS PARIS!", roma());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string roma()
    {
        return " ROMA ";
    }

    public static void vi1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS PARIS!", viena());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string viena()
    {
        return " VIENNA ";
    }

    public static void lis1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS PARIS!", lisboa());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string lisboa()
    {
        return " LISBOA ";
    }

    public static void respostaalemanya()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestas5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    ams1();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    min1();
                    break;
                case ConsoleKey.D3:
                    berl1();
                    break;
                case ConsoleKey.D4:
                    bern1();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestas5()
    {

        Console.WriteLine("1- AMSTERDAM");
        Console.WriteLine("2- MINSK");
        Console.WriteLine("3- BERLIN");
        Console.WriteLine("4- BERN");
        Console.WriteLine("0- EXIT");
    }

    public static void ams1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BERLIN!", amsterdam());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string amsterdam()
    {
        return " AMSTERDAM ";
    }

    public static void min1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BERLIN!", minsk());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string minsk()
    {
        return " MINISK ";
    }

    public static void berl1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", berlin());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }


    public static void bern1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BERLIN!", bern());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string bern()
    {
        return " BERN ";
    }

    public static void bigC()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            preguntesTotes2();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    respostaLondDub();
                    break;
                case ConsoleKey.D2:
                  respostaAnkBud();
                    break;
                case ConsoleKey.D3:
                 respostaSofOls();
                    break;

                case ConsoleKey.D4:
                respostaCopSto();
                    break;
                case ConsoleKey.D5:
                 respostaGirWar();
                    break;


            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void preguntesTotes2()
    {
        Console.WriteLine("1-WHAT'S THE BIGGEST CITY, LONDON OR DUBLIN?"); 
        Console.WriteLine("2-WHAT'S THE BIGGEST CITY, ANKARA OR BUDAPEST?");
        Console.WriteLine("3-WHAT'S THE BIGGEST CITY, SOFIA OR OSLO?");
        Console.WriteLine("4-WHAT'S THE BIGGEST CITY, COPENHAGEN OR STOCKHOLM?");
        Console.WriteLine("5-WHAT'S THE BIGGEST CITY, GIRONA OR WARSAW?");
        Console.WriteLine("0-EXIT");
    }

    public static void respostaLondDub()
    {


        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respostes11();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    dub2();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    lond2();
                    break;
                case ConsoleKey.D3:
                    idk2();
                    break;
                case ConsoleKey.D4:
                    both2();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);

      
    }

    public static void respostes11()
    {
        Console.WriteLine("1-DUBLIN");
        Console.WriteLine("2-LONDON");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void dub2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON!", dublin());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string dublin()
    {
        return " DUBLIN ";
    }

    public static void lond2()
    {
        Console.WriteLine("{0}IS CORRECT!", london());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string london()
    {
        return " LONDON ";
    }

    public static void idk2()
    {
        Console.WriteLine("DON'T WORRY DARLING! TRY IT LATER!");

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static void both2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON!", both());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string both()
    {
        return " BOTH ";
    }

    public static void respostaAnkBud()
    {


        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respostes11();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    ank2();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    bud2();
                    break;
                case ConsoleKey.D3:
                    idk2();
                    break;
                case ConsoleKey.D4:
                    both2();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);


    }

    public static void respostes22()
    {
        Console.WriteLine("1-ANKARA");
        Console.WriteLine("2-BUDAPEST");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void ank2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ANKARA!",budapest());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string budapest()
    {
        return " BUDAPEST ";
    }

    public static void bud2()
    {
        Console.WriteLine("{0}IS CORRECT!", ankara());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string ankara()
    {
        return " ANKARA ";
    }

    public static void respostaSofOls()
    {
        

        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respostes23();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    sof2();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    osl2();
                    break;
                case ConsoleKey.D3:
                    idk2();
                    break;
                case ConsoleKey.D4:
                    both2();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);


    }
    public static void respostes23()
    {
        Console.WriteLine("1- OSLO ");
        Console.WriteLine("2-SOFIA");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void osl2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS SOFIA!", oslo());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string oslo()
    {
        return " OSLO ";
    }

    public static void sof2()
    {
        Console.WriteLine("{0}IS CORRECT!", sofia());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string sofia()
    {
        return " SOFIA ";
    }


   

    public static void respostaCopSto()
    {


        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respostes24();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    stoc2();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    cop2();
                    break;
                case ConsoleKey.D3:
                    idk2();
                    break;
                case ConsoleKey.D4:
                    both2();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);


    }
    public static void respostes24()
    {
        Console.WriteLine("1-STOCKHOLM");
        Console.WriteLine("2-COPENHAGEN ");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void cop2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS SOFIA!", copenhagen());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string copenhagen()
    {
        return " COPENHAGEN ";
    }

    public static void stoc2()
    {
        Console.WriteLine("{0}IS CORRECT!", estocolmo());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string estocolmo()
    {
        return " STOCKHOLM";
    }

    // aqui

    //WARSAW
    public static void respostaGirWar()
    {


        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respostes25();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    war2();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    gir2();
                    break;
                case ConsoleKey.D3:
                    idk2();
                    break;
                case ConsoleKey.D4:
                    both2();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);


    }

    public static void respostes25()
    {
        Console.WriteLine("1-WARSAW");
        Console.WriteLine("2-GIRONA ");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void gir2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS WARSAW!", girona());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string girona()
    {
        return " GIRONA ";
    }

    public static void war2()
    {
        Console.WriteLine("{0}IS CORRECT!", varsovia());

        MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
    }

    public static string varsovia()
    {
        return " WARSAW";
    }


}
