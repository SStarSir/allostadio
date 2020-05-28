using System;
using System.Globalization;

namespace Game
{
    static class AlloStadio
    {
        //declare variables
        static string[] Squadre = new string[] { "creature", "luminous" };
        static string[] Prompts = new string[] { " squadra di casa", " squadra in trasferta", "adjective", "adjective", "occupation", "occupation", "occupation", "adjective", "noun", "noun" };
        static string Story;
        static string GameTitle;



        


        public static void Run()
        {




            Header();
            AskQuestions();
            ReadStory();
            End();
        }

        static void Header()
        {

            //write header and instructions

            Console.Title = "ASCII Art";
            string title = @"

                    
          _      _      ____     _____ _______       _____ _____ ____  
    /\   | |    | |    / __ \   / ____|__   __|/\   |  __ \_   _/ __ \ 
   /  \  | |    | |   | |  | | | (___    | |  /  \  | |  | || || |  | |
  / /\ \ | |    | |   | |  | |  \___ \   | | / /\ \ | |  | || || |  | |
 / ____ \| |____| |___| |__| |  ____) |  | |/ ____ \| |__| || || |__| |
/_/    \_\______|______\____/  |_____/   |_/_/    \_\_____/_____\____/ 
                                                                       



              ";

            Console.WriteLine(title);

            Console.WriteLine("-------");
            Console.WriteLine("Un programma di Roy & Spuk!");
            Console.WriteLine("Presented by IFCATS");
            Console.WriteLine("-------");



        }

        static void AskQuestions()

        {

            //ask player to enter words

            //ask player to enter words
            for (int i = 0; i < Squadre.Length; i++)
            {
                Console.Write("Inserisci la" + Prompts[i] + ": ");
                Squadre[i] = Console.ReadLine();
            }

            //clear the console window
            Console.Clear();


        }


        static void ReadStory()

        {
            //write out story


            //Concatenate strings to make a title
            GameTitle = "La partita di oggi: " + Squadre[0] + " contro " + Squadre[1];

            //So we can capitalize the words in our title
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            //Write the title to the console window
            Console.WriteLine(GameTitle);
            Console.WriteLine(" ");

            //change the title of the application window
            Console.Title = GameTitle;

            Story = "Buonasera da Fabio Caressa e Beppe Bergomi. Tutto é pronto per il calcio di inizio. \nOggi si affronteranno {0} e {1}. \nPartiti! {0} batte il calcio di inizio.";
            Console.WriteLine(Story, Squadre[0], Squadre[1]);


            int homescore = 0;
            int awayscore = 0;
            
            for (int clock = 1; clock < 46; clock++)

            {

                
                System.Threading.Thread.Sleep(1000);

                Random r = new Random();
                int rInt = r.Next(0, 100); //for ints

                if (rInt < 5)
                {
                    Console.WriteLine("GOAL! Ha segnato " + Squadre[0] + " al minuto " + clock );
                    homescore = homescore + 1;
                }

                else if (rInt > 95)

                {
                    Console.WriteLine("GOAL! Ha segnato " + Squadre[1] + " al minuto " + clock);
                    awayscore = awayscore + 1;
                }

                else

                {
                    Console.WriteLine("Non succede un cazzo al minuto " + clock);
                }
            }


            Console.WriteLine("Termina qui il primo tempo. L'arbitro manda tutti a prendere un té caldo.");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Tutto é pronto per il secondo tempo. " + Squadre[1] + " sul pallone pronto a battere. Partiti!");

            

            for (int clock = 46; clock < 91; clock++)

            {


                System.Threading.Thread.Sleep(1000);

                Random r = new Random();
                int rInt = r.Next(0, 100); //for ints

                if (rInt < 5)
                {
                    Console.WriteLine("GOAL! Ha segnato " + Squadre[0] + " al minuto " + clock);
                    homescore = homescore + 1;
                }

                else if (rInt > 95)

                {
                    Console.WriteLine("GOAL! Ha segnato " + Squadre[1] + " al minuto " + clock);
                    awayscore = awayscore + 1;
                }

                else

                {
                    Console.WriteLine("Non succede un cazzo al minuto " + clock);
                }
            }



            Console.WriteLine("Triplice fischio. Finisce " + homescore + " a " + awayscore + ", una partita ricca di emozioni");

        }

        static void End()
        {
            //keep window open and prompt for exit
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }


    }
    class Program
    {
        static void Main()
        {
            AlloStadio.Run();

        }
    }
}
