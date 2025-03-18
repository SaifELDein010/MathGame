

using Generic_Libraries;

namespace MathGame
{
    class LevelOfGame
    {


        static private int chooise = 0;

        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\t    M a t h  -  game  -  m e n u\n\n");

        }

        static private void MenuScreen()
        {

            Console.WriteLine("\t\t\t\t\t      _-_-_-_-_-_-_-_-_-_-_-_\n");

            Console.WriteLine("\t\t\t\t\t      [1] Easy");
            Console.WriteLine("\t\t\t\t\t      [2] Mid");
            Console.WriteLine("\t\t\t\t\t      [3] Hard");
            Console.WriteLine("\t\t\t\t\t      [4] Hybird");

            Console.WriteLine("\n\t\t\t\t\t      -_-_-_-_-_-_-_-_-_-_-_-");

            chooise = Read_Int_Input.ReadNumberBetweenRange(1, 4, "\n\t\t\t\t\t       Chooise Level [1:4]: ",
                "\n\t\t\t\t       Out of range, Enter a vaild number [1:4]: ");

        }




        static public void LevelMenuScreen()
        {

            Console.Clear();

            HeaderSreen();
            MenuScreen();

        }


    }


}
