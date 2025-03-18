


using Generic_Libraries;

namespace MathGame
{
    class OperationOfGame
    {

        static private int chooise = 0;

        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\t    M a t h  -  game  -  m e n u\n\n");

        }

        static private void MenuScreen()
        {

            Console.WriteLine("\t\t\t\t\t    _-_-_-_-_-_-_-_-_-_-_-_-_-_\n");

            Console.WriteLine("\t\t\t\t\t      [1] Addition       (+)");
            Console.WriteLine("\t\t\t\t\t      [2] Subtraction    (-)");
            Console.WriteLine("\t\t\t\t\t      [3] Multiplication (*)");
            Console.WriteLine("\t\t\t\t\t      [4] Division       (/)");
            Console.WriteLine("\t\t\t\t\t      [5] Hybird");

            Console.WriteLine("\n\t\t\t\t\t    -_-_-_-_-_-_-_-_-_-_-_-_-_-");

            chooise = Read_Int_Input.ReadNumberBetweenRange(1, 5, "\n\t\t\t\t\t       Chooise Level [1:5]: ",
                "\n\t\t\t\t       Out of range, Enter a vaild number [1:5]: ");

        }


        static public void OperationMenuScreen()
        {

            Console.Clear();

            HeaderSreen();
            MenuScreen();
            

        }

    }
}
