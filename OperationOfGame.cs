


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

        static private void SetOperationOfGame(char _operation)
        {

            GameOption._operation = _operation;

        }

        static private void PerfromOption()
        {

            switch (chooise)
            {

                case 1:
                    SetOperationOfGame('+');
                    break;

                case 2:
                    SetOperationOfGame('-');
                    break;

                case 3:
                    SetOperationOfGame('*');
                    break;

                case 4:
                    SetOperationOfGame('/');
                    break;

                case 5:
                    SetOperationOfGame('H');
                    break;

            }

        }


        static public void OperationMenuScreen()
        {

            Console.Clear();

            HeaderSreen();
            MenuScreen();
            PerfromOption();

        }

    }
}
