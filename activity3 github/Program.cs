
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
                  singer();
                    break;
                case ConsoleKey.D4:
                    Football();
                    break;
                case ConsoleKey.D5:
                    NBA();
                    break;
                case ConsoleKey.D6:
                    F1();
                    break;
                default:
                    MsgNextScreen("ERROR, Prem una tecla per tornar al menu..");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void ShowOptions()
    {
        Console.WriteLine("CHOOSE A TOPIC");
        Console.WriteLine("1- CAPITALS");
        Console.WriteLine("2- BIGGEST COUNTRY");
        Console.WriteLine("3- SINGER");
        Console.WriteLine("4- FOOTBALL");
        Console.WriteLine("5- NBA");
        Console.WriteLine("6- F1");
        Console.WriteLine("0- EXIT");
    }
    //nayara
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
        Console.WriteLine("CHOOSE A QUESTION PLEASE");
        Console.WriteLine("1-WHAT'S THE CAPITAL OF THE UK?");
        Console.WriteLine("2-WHAT'S THE CAPITAL OF SPAIN?");
        Console.WriteLine("3-WHAT'S THE CAPITAL OF ANDORRA?");
        Console.WriteLine("4-WHAT'S THE CAPITAL OF FRANCE?");
        Console.WriteLine("5-WHAT'S THE CAPITAL OF GERMANY?");
        Console.WriteLine("0-EXIT?");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- LONDON");
        Console.WriteLine("2- BERLIN");
        Console.WriteLine("3- MADRID");
        Console.WriteLine("4- PARIS");
        Console.WriteLine("0- EXIT");
    }

    public static void lon1()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", lon());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

    }

    public static string lon()
    {
       return " LONDON ";
    }
    public static void ber1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON !", berlin());
      
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    
}
    public static string berlin()
    {
        return " BERLIN ";
    }
    public static void mad1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON !", madrid());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");

    }
    public static string madrid()
    {
        return " MADRID ";
    }

    public static void par1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON !", paris());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");

    }
    public static string paris()
    {
        return " PARIS ";
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- SORIA");
        Console.WriteLine("2- GUADALAJARA");
        Console.WriteLine("3- MADRID");
        Console.WriteLine("4- BARCELONA");
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

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string guadalajara()
    {
        return " GUADALAJARA ";
    }

    public static void madr1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", madrid1());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string madrid1()
    {
        return " MADRID ";
    }

    public static void bar1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS MADRID!", barcelona());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- PRAGA");
        Console.WriteLine("2- BRUSSELS");
        Console.WriteLine("3- ATHENS");
        Console.WriteLine("4- ANDORRA LA VELLA");
        Console.WriteLine("0- EXIT");
    }

    public static void pra1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ANDORRA LA VELLA!", praga());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
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

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string atenes()
    {
        return " ATHENS ";
    }

    public static void and1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", andorra());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- ROMA");
        Console.WriteLine("2- PARIS");
        Console.WriteLine("3- VIENNA");
        Console.WriteLine("4- LISBON");
        Console.WriteLine("0- EXIT");
    }
    public static void pari1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", paris());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static void rom1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS PARIS!", roma());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string roma()
    {
        return " ROMA ";
    }

    public static void vi1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS PARIS!", viena());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string viena()
    {
        return " VIENNA ";
    }

    public static void lis1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS PARIS!", lisboa());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- AMSTERDAM");
        Console.WriteLine("2- MINSK");
        Console.WriteLine("3- BERLIN");
        Console.WriteLine("4- BERN");
        Console.WriteLine("0- EXIT");
    }

    public static void ams1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BERLIN!", amsterdam());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string amsterdam()
    {
        return " AMSTERDAM ";
    }

    public static void min1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BERLIN!", minsk());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string minsk()
    {
        return " MINISK ";
    }

    public static void berl1()
    {
        Console.WriteLine("{0}IS THE CORRECT ANSWER!", berlin());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }


    public static void bern1()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BERLIN!", bern());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
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
        Console.WriteLine("CHOOSE A QUESTION PLEASE");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1-DUBLIN");
        Console.WriteLine("2-LONDON");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void dub2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON!", dublin());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string dublin()
    {
        return " DUBLIN ";
    }

    public static void lond2()
    {
        Console.WriteLine("{0}IS CORRECT!", london());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string london()
    {
        return " LONDON ";
    }

    public static void idk2()
    {
        Console.WriteLine("DON'T WORRY DARLING! TRY IT AGAIN!");

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static void both2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LONDON!", both());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1-ANKARA");
        Console.WriteLine("2-BUDAPEST");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void ank2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ANKARA!",budapest());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string budapest()
    {
        return " BUDAPEST ";
    }

    public static void bud2()
    {
        Console.WriteLine("{0}IS CORRECT!", ankara());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- OSLO ");
        Console.WriteLine("2-SOFIA");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void osl2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS SOFIA!", oslo());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string oslo()
    {
        return " OSLO ";
    }

    public static void sof2()
    {
        Console.WriteLine("{0}IS CORRECT!", sofia());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1-STOCKHOLM");
        Console.WriteLine("2-COPENHAGEN ");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void cop2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS SOFIA!", copenhagen());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string copenhagen()
    {
        return " COPENHAGEN ";
    }

    public static void stoc2()
    {
        Console.WriteLine("{0}IS CORRECT!", estocolmo());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string estocolmo()
    {
        return " STOCKHOLM";
    }

  
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
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1-WARSAW");
        Console.WriteLine("2-GIRONA ");
        Console.WriteLine("3-IDK DARLING!");
        Console.WriteLine("4-BOTH SIMILAR ");
        Console.WriteLine("0-EXIT");
    }

    public static void gir2()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS WARSAW!", girona());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string girona()
    {
        return " GIRONA ";
    }

    public static void war2()
    {
        Console.WriteLine("{0}IS CORRECT!", varsovia());

        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string varsovia()
    {
        return " WARSAW";
    }

    

    public static void singer()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            preguntesultimes1();
            tecla = Console.ReadKey();
            Console.Clear();

            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    marineroLuces();
                    break;
                case ConsoleKey.D2:
                    enmisalsa();
                    break;
                case ConsoleKey.D3:
                    elSenyor();
                    break;

                case ConsoleKey.D4:
                   xina();
                    break;
                case ConsoleKey.D5:
                 purpurina();
                    break;


            }
        } while (tecla.Key != ConsoleKey.D0);


    }

    public static void preguntesultimes1()
    {
        Console.WriteLine("CHOOSE A QUESTION PLEASE");
        Console.WriteLine("1-WHO'S THE SINGER OF MARINERO DE LUCES SONG?");
        Console.WriteLine("2-WHO'S THE SINGER OF EN MI SALSA'S SONG?");
        Console.WriteLine("3-WHO'S THE SINGER OF EL SENYOR DE LA NOCHE'S SONG?");
        Console.WriteLine("4-WHO'S THE SINGER OF CHINA'S SONG?");
        Console.WriteLine("5-WHAT'S THE CAPITAL OF GERMANY?");
    }

    public static void marineroLuces()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestasultima1();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    isabelP();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    manoloE();
                    break;
                case ConsoleKey.D3:
                    rocioJ();
                    break;
                case ConsoleKey.D4:
                    patxotM();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestasultima1()
    {
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- ISABEL PANTOJA");
        Console.WriteLine("2- MANOLO ESCOBAR");
        Console.WriteLine("3- ROCIO JURADO");
        Console.WriteLine("4- PATXOT");
        Console.WriteLine("0- EXIT");
    }

    public static void isabelP()
    { 
            Console.WriteLine("{0} IS THE CORRECT ANSWER!", isabel());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string isabel()
    {
        return " ISABEL PANTOJA ";
    }

    public static void manoloE()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", manolo());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string manolo()
    {
        return " MANOLO ESCOBAR ";
    }

    public static void rocioJ()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", rocio());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string rocio()
    {
        return " ROCIO JURADO ";
    }
    public static void patxotM()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", patxot());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string patxot()
    {
        return " PATXOT ";
    }
    public static void enmisalsa()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestasultima2();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                   letiS();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    mariaP();
                    break;
                case ConsoleKey.D3:
                  patxotM2();
                    break;
                case ConsoleKey.D4:
                  mileyC();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestasultima2()
    {
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- LETICIA SABATER");
        Console.WriteLine("2- MARIA PATIÑO");
        Console.WriteLine("3- PATXOT");
        Console.WriteLine("4- MILEY CYRUS");
        Console.WriteLine("0- EXIT");
    }

    public static void letiS()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", leti());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string leti()
    {
        return " LETICIA SABATER ";
    }

    public static void mariaP()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", maria());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string maria()
    {
        return " MARIA PATIÑO ";
    }

    public static void patxotM2()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", patxot());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static void mileyC()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", miley());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string miley()
    {
        return " MILEY CYRUS ";
    }

    public static void elSenyor()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestasultima3();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    letiS();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    omarM();
                    break;
                case ConsoleKey.D3:
                    mCaballer();
                    break;
                case ConsoleKey.D4:
                    dOmar();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestasultima3()
    {
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- LETICIA SABATER");
        Console.WriteLine("2- OMAR MONTES");
        Console.WriteLine("3- MONTSERRAT CABALLER");
        Console.WriteLine("4- DON OMAR");
        Console.WriteLine("0- EXIT");
    }

    public static void omarM()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", omar());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string omar()
    {
        return " OMAR MONTES ";
    }

    public static void mCaballer()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", caballer());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string caballer()
    {
        return " MONTSERRAT CABALLER ";
    }

    public static void dOmar()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", donO());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string donO()
    {
        return " DON OMAR ";
    }

    public static void xina()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestasultima4();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                   omarM();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                  patxotM();
                    break;
                case ConsoleKey.D3:
                  anuelX2A();
                    break;
                case ConsoleKey.D4:
                    d0mar2();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestasultima4()
    {
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- OMAR MONTES");
        Console.WriteLine("2- PATXOT");
        Console.WriteLine("3- ANUEL AA");
        Console.WriteLine("4- DON OMAR");
        Console.WriteLine("0- EXIT");
    }

    public static void anuelX2A()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", anuel());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string anuel()
    {
        return " ANUEL AA ";
    }

    public static void dOmar2()
    {
        Console.WriteLine("{0} ISN'T THE CORRECT ANSWER SORRY TRY AGAIN!", d0mar2());
        MsgNextScreen("PRESS A KEY TO TRY AGAIN");
    }

    public static string d0mar2()
    {
        return " DON OMAR ";
    }

    public static void purpurina()
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            respuestasultima5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    albertoG();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                   patxotM();
                    break;
                case ConsoleKey.D3:
                   letiS();
                    break;
                case ConsoleKey.D4:
                   mileyC();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void respuestasultima5()
    {
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- ALBERTO GAMBINO");
        Console.WriteLine("2- PATXOT");
        Console.WriteLine("3- LETICIA SABATER");
        Console.WriteLine("4- MILEY CYRUS");
        Console.WriteLine("0- EXIT");
    }
    public static void albertoG()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", alberto());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
    }

    public static string alberto()
    {
        return " ALBERTO GAMBINO ";
    }
}

//Mamadou
public static void Football()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        preguntesFootball();
        tecla = Console.ReadKey();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                respostamoreworld();
                break;
            case ConsoleKey.D2:
                respostamorechampionsleague();
                break;
            case ConsoleKey.D3:
                respostatopscorer();
                break;
            case ConsoleKey.D4:
                respostaLastworldcupwinner();
                break;
            case ConsoleKey.D5:
                respostaLastwinneroftheFinalissima();
                break;
        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void preguntesFootball()
{
    Console.WriteLine("1-Which national team has more world cups?");
    Console.WriteLine("2-Which team has more champions league?");
    Console.WriteLine("3-Soccer top scorer of all time?");
    Console.WriteLine("4-Last world cup winner?");
    Console.WriteLine("5-Last winner of the Finalissima?");
}
public static void MsgNextScreen(string msg)
{
    Console.WriteLine(msg);
    Console.ReadKey();

}
public static void respostamoreworld()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare1();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Aleman1();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Esapan1();
                break;
            case ConsoleKey.D3:
                Argentin1();
                break;
            case ConsoleKey.D4:
                Brazil1();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare1()
{
    Console.WriteLine("1- Alemania");
    Console.WriteLine("2- Esapaña");
    Console.WriteLine("3- Argentina");
    Console.WriteLine("4- Brazil");
    Console.WriteLine("0- EXIT");
}
public static void Brazil1()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Brazil());
    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}

public static string Brazil()
{
    return "BRAZIL";
}
public static void Aleman1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BRAZIL !", Alemania());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Alemania()
{
    return "ALEMANIA";
}
public static void Esapan1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BRAZIL !", España());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string España()
{
    return "ESAPAÑA";
}
public static void Argentin1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BRAZIL !", Argentina());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Argentina()
{
    return "ALEMANIA";
}
public static void preguntesFootball()
public static void respostamorechampionsleague()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare2();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Mad2();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Bar2();
                break;
            case ConsoleKey.D3:
                Liv2();
                break;
            case ConsoleKey.D4:
                Man2();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare2()
{
    Console.WriteLine("1- Real Madrid");
    Console.WriteLine("2- Barcelona");
    Console.WriteLine("3- Liverpool");
    Console.WriteLine("4- Man United");
    Console.WriteLine("0- EXIT");
}
public static void Mad2()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Madrid());
    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}

public static string Madrid()
{
    return "REAL MADRID";
}
public static void Bar2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS REAL MADRID !", Barcelona());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Barcelona()
{
    return "BARCELONA";
}
public static void Liv2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS REAL MADRID !", Liverpool());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Liverpool()
{
    return "LIVERPOOL";
}
public static void Man2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS REAL MADRID !", ManUnited());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string ManUnited()
{
    return "MAN UNITED";
}
public static void preguntesFootball()
public static void respostatopscorer()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare3();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Ronal3();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Josef3();
                break;
            case ConsoleKey.D3:
                Mes3();
                break;
            case ConsoleKey.D4:
                Pel3();
                break;
        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare3()
{
    Console.WriteLine("1- Cristiano Ronaldo");
    Console.WriteLine("2- Josef Bican");
    Console.WriteLine("3- Lionel Messi");
    Console.WriteLine("4- Pelé");
    Console.WriteLine("0- EXIT");
}
public static void Ronal3()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Ronaldo());
    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
}
public static string Ronaldo()
{
    return "RONALDO;"
}
public static void Josef3()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS RONALDO !", Josef());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Josef()
{
    return "JOSEF BICAN";
}
public static void Mes3()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS RONALDO !", Messi());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Messi()
{
    return "LIONEL MESSI";
}
public static void Pel3()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS RONALDO !", Pele());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Pele()
{
    return "PELÉ";
}
public static void respostaLastworldcupwinner()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare4();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Argen4();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Brazil4();
                break;
            case ConsoleKey.D3:
                Fran4();
                break;
            case ConsoleKey.D4:
                Espan4();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare4()
{
    Console.WriteLine("1- Argentina");
    Console.WriteLine("2- Brazil");
    Console.WriteLine("3- Francia");
    Console.WriteLine("4- España");
    Console.WriteLine("0- EXIT");
}
public static void Argen4()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Argentina2());
    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}

public static string Argentina2()
{
    return "ARGENTINA";
}
public static void Brazil4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ARGENTINA!", Brazil2());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Brazil2()
{
    return "BRAZIL";
}
public static void Fran4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ARGENTINA !", Francia());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Francia()
{
    return "ESAPAÑA";
}
public static void Espan4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ARGENTINA !", Esapan2());



    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");

}
public static string Esapan2()
{
    return "ESPAÑA";
}

public static void respostaLastwinneroftheFinalissima()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare5();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Espan5();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Ital5();
                break;
            case ConsoleKey.D3:
                Argen5();
                break;
            case ConsoleKey.D4:
                Fran5();
                break;
        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare5()
{
    Console.WriteLine("1- España");
    Console.WriteLine("2- Italia");
    Console.WriteLine("3- Argetina");
    Console.WriteLine("4- Francia");
    Console.WriteLine("0- EXIT");
}
public static void Espan5()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ARGENTINA!", Espan3());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");
}
public static string Espan3()
{
    return "ESAPAÑA";
}
public static void Ital5()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ARGETINA!", Italia());

    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
}

public static string Italia()
{
    return "ITALIA";
}
public static void Argen5()
{
    Console.WriteLine("{0}IS THE CORRECT ANSWER!", Argentina3());

    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");
}

public static string Argentina3()
{
    return "ARGENTINA";
}
public static void Fran5()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS ARGETINA!", Francia2());

    MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
}

public static string Francia2()
{
    return "FRANCIA";
}
public static void NBA()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        preguntesNba();
        tecla = Console.ReadKey();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                respostamostchampionships();
                break;
            case ConsoleKey.D2:
                respostaleadingscorer();
                break;
            case ConsoleKey.D3:
                respostamostNBAchampionships();
                break;
            case ConsoleKey.D4:
                respostamosttriples();
                break;
            case ConsoleKey.D5:
                respostamosttripledoubles();
                break;
        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void preguntesNba()
{
    Console.WriteLine("1-Franchise with the most championships?");
    Console.WriteLine("2-All-time leading scorer in the NBA?");
    Console.WriteLine("3-Player with the most NBA championships won?");
    Console.WriteLine("4-Player with the most triples in the NBA?");
    Console.WriteLine("5-Player with the most triple-doubles in the NBA?");
}
public static void MsgNextScreen(string msg)
{
    Console.WriteLine(msg);
    Console.ReadKey();

}
public static void respostamostchampionships()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare1();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Lakers1();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Boston1();
                break;
            case ConsoleKey.D3:
                Bulls1();
                break;
            case ConsoleKey.D4:
                Warriors1();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare1()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Los Angeles Lakers");
    Console.WriteLine("2- Boston Celtics");
    Console.WriteLine("3- Chicago Bulls");
    Console.WriteLine("4- Golden State Warriors");
    Console.WriteLine("0- EXIT");
}
public static void Lakers1()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Lakers());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Lakers()
{
    return "LAKERS";
}
public static void Boston1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LAKERS !", Boston());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Boston()
{
    return " BOSTON ";
}
public static void Bulls1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LAKERS !", Bulls());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Bulls()
{
    return "BULLS";
}
public static void Warriors1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LAKERS !", Warriors());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Warriors()
{
    return "WARRIORS";
}
public static void respostaleadingscorer()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare2();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Kareem2();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                LeBron2();
                break;
            case ConsoleKey.D3:
                Kobe2();
                break;
            case ConsoleKey.D4:
                Jordan2();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare2()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Kareem Abdul-Jabbar");
    Console.WriteLine("2- LeBron James");
    Console.WriteLine("3- Kobe Bryant");
    Console.WriteLine("4- Michael Jordan");
    Console.WriteLine("0- EXIT");
}
public static void Kareem2()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Kareem());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Kareem()
{
    return "KAREEM";
}
public static void LeBron2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS KAREEM !", LeBron());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string LeBron()
{
    return "LEBRON";
}
public static void Kobe2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS KAREEM !", Kobe());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Kobe()
{
    return "KOBE";
}
public static void Jordan2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS KAREEM !", Jordan());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Jordan()
{
    return "JORDAN";
}
public static void respostamostNBAchampionships()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare3();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Russell3();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Jones3();
                break;
            case ConsoleKey.D3:
                Jordan3();
                break;
            case ConsoleKey.D4:
                Kobe3();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare3()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Bill Russell");
    Console.WriteLine("2- Sam Jones");
    Console.WriteLine("3- Michael Jordan");
    Console.WriteLine("4- Kobe Bryant");
    Console.WriteLine("0- EXIT");
}
public static void Russell3()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Russell());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Russell()
{
    return "RUSSELL";
}
public static void Jones3()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BILL RUSSELL !", Jones());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Jones()
{
    return "JONES";
}
public static void Jordan3()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BILL RUSSELL !", Joran());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Joran()
{
    return "JORDAN";
}
public static void Kobe3()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS BILL RUSSELL!", Kob());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Kob()
{
    return "KOBE";
}
public static void respostamosttriples()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare4();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Curry4();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Ray4();
                break;
            case ConsoleKey.D3:
                James4();
                break;
            case ConsoleKey.D4:
                Harden4();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare4()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Stephen Curry");
    Console.WriteLine("2- Ray Allen");
    Console.WriteLine("3- LeBron James");
    Console.WriteLine("4- James Harden");
    Console.WriteLine("0- EXIT");
}
public static void Curry4()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Curry());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Curry()
{
    return "CURRY";
}
public static void Ray4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS STEPHEN CURRY !", Allen());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Allen()
{
    return "ALLEN";
}
public static void James4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS STEPHEN CURRY!", jmes());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string jmes()
{
    return "LEBRON";
}
public static void Harden4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS STEPHEN CURRY!", Harden());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Harden()
{
    return "HARDEN";
}
public static void respostamosttripledoubles()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare5();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                West5();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Oscar5();
                break;
            case ConsoleKey.D3:
                Magic5();
                break;
            case ConsoleKey.D4:
                James5();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare5()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Russell Westbrook");
    Console.WriteLine("2- Oscar Robertson");
    Console.WriteLine("3- Magic Johnson");
    Console.WriteLine("4- LeBron James");
    Console.WriteLine("0- EXIT");
}
public static void West5()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Westbrook());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Westbrook()
{
    return "WESTBROOK";
}
public static void Oscar5()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS WESTBROOK !", Oscar());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Oscar()
{
    return "OSCAR";
}
public static void Magic5()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS WESTBROOK !", Magic());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Magic()
{
    return "MAGIC";
}
public static void James5()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS WESTBROOK !", Bron());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Bron()
{
    return "LEBRON";
}
public static void F1()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        preguntesF1();
        tecla = Console.ReadKey();
        Console.Clear();

        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                respostaWorldChampionship();
                break;
            case ConsoleKey.D2:
                respostaMostConstructors();
                break;
            case ConsoleKey.D3:
                respostaMostGrandPrixVictories();
                break;
            case ConsoleKey.D4:
                respostaMostpolepositions();
                break;
            case ConsoleKey.D5:
                respostaYoungestdrivertowin();
                break;
        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void preguntesF1()
{
    Console.WriteLine("1- Most Drivers’ World Championships?");
    Console.WriteLine("2- Most Constructors’ World Championships?");
    Console.WriteLine("3- Most Grand Prix Victories?");
    Console.WriteLine("4- Most pole positions?");
    Console.WriteLine("5- Youngest driver to win an f1 world championship?");
}
public static void MsgNextScreen(string msg)
{
    Console.WriteLine(msg);
    Console.ReadKey();

}
public static void respostaWorldChampionship()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare1();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Alo1();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Ham1();
                break;
            case ConsoleKey.D3:
                Fan1();
                break;
            case ConsoleKey.D4:
                Vett1();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare1()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Fernando Alonso");
    Console.WriteLine("2- Lewis Hamilton");
    Console.WriteLine("3- Juan Manuel Fangio");
    Console.WriteLine("4- Sebastian Vettel");
    Console.WriteLine("0- EXIT");
}
public static void Alo1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS HAMILTON !", Alonso());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Alonso()
{
    return " ALOSNO ";
}
public static void Ham1()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Hamilton());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Hamilton()
{
    return "HAMILTON";
}
public static void Fan1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS HAMILTON!", Fangio());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Fangio()
{
    return "FANGIO";
}
public static void Vett1()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS HAMILTON!", Vettel());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Vettel()
{
    return "VETTEL";
}
public static void respostaMostConstructors()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare2();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Fer2();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Will2();
                break;
            case ConsoleKey.D3:
                Merc2();
                break;
            case ConsoleKey.D4:
                Lot2();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare2()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Ferrari");
    Console.WriteLine("2- Williams");
    Console.WriteLine("3- Mercedes");
    Console.WriteLine("4- Lotus");
    Console.WriteLine("0- EXIT");
}
public static void Fer2()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Ferra());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Ferra()
{
    return "FERRARI";
}
public static void Will2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS FERRARI !", Williams());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Williams()
{
    return "WILLIAMS";
}
public static void Merc2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS FERRARI !", Mercedes());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Mercedes()
{
    return "MERCEDES";
}
public static void Lot2()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS FERRARI !", Lotus());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Lotus()
{
    return "LOTUS";
}
public static void respostaMostpolepositions()
{
    ConsoleKeyInfo tecla;
    do
    {
        Console.Clear();
        answare4();
        tecla = Console.ReadKey();
        Console.Clear();
        switch (tecla.Key)
        {
            case ConsoleKey.D1:
                Pro4();
                Console.ReadLine();
                break;
            case ConsoleKey.D2:
                Mich4();
                break;
            case ConsoleKey.D3:
                Vet4();
                break;
            case ConsoleKey.D4:
                Lwi4();
                break;

        }
    } while (tecla.Key != ConsoleKey.D0);
}
public static void answare4()
{
    Console.WriteLine("CHOOSE AN ANSWER PLEASE");
    Console.WriteLine("1- Alain Prost");
    Console.WriteLine("2- Michael Schumacher");
    Console.WriteLine("3- Sebastian Vettel");
    Console.WriteLine("4- Lewis Hamilton");
    Console.WriteLine("0- EXIT");
}
public static void Pro4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LEWIS HAMILTON !", prost());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string prost()
{
    return "PROST";
}
public static void Mich4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LEWIS HAMILTON !", Mich());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string Mich()
{
    return "SCHUMACHER";
}
public static void Vet4()
{
    Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS LEWIS HAMILTON !", vet());

    MsgNextScreen("PRESS A KEY TO TRY AGAIN");

}
public static string vet()
{
    return "VETTEL";
}
public static void Lwi4()
{
    Console.WriteLine("{0} IS THE CORRECT ANSWER!", Llhm());
    MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

}

public static string Llhm()
{
    return "HAMILTON";
}

public static void respostaYoungestdrivertowin()
{
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            answare5();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Max5();
                    Console.ReadLine();
                    break;
                case ConsoleKey.D2:
                    Fer5();
                    break;
                case ConsoleKey.D3:
                    Ha5();
                    break;
                case ConsoleKey.D4:
                    Bas5();
                    break;

            }
        } while (tecla.Key != ConsoleKey.D0);
    }
    public static void answare5()
    {
        Console.WriteLine("CHOOSE AN ANSWER PLEASE");
        Console.WriteLine("1- Max Verstappen");
        Console.WriteLine("2- Fernando Alonso");
        Console.WriteLine("3- Lewis Hamilton");
        Console.WriteLine("4- Sebastian Vettel");
        Console.WriteLine("0- EXIT");
    }
    public static void Max5()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS VETTEL !", max());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");

    }
    public static string max()
    {
        return "MAX";
    }
    public static void Fer5()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS VETTEL !", fer());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");

    }
    public static string fer()
    {
        return "ALONSO";
    }
    public static void Ha5()
    {
        Console.WriteLine("{0}IS NOT CORRECT, SORRY THE CORRECT ANSWER IS VETTEL!", hasm());

        MsgNextScreen("PRESS A KEY TO TRY AGAIN");

    }
    public static string hasm()
    {
        return "HAMILTON";
    }
    public static void Bas5()
    {
        Console.WriteLine("{0} IS THE CORRECT ANSWER!", bastian());
        MsgNextScreen("PRESS A KEY AND THEN 0 TO CHOOSE ANOTHER QUESTION");

    }

    public static string bastian()
    {
        return "VETTEL";
    }
}