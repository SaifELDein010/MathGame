﻿
using System;

namespace MathGame
{
    class GameMenuDesign
    {

        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\t    M a t h  -  game  -  m e n u\n\n");

        }

        static private void MenuScreen() 
        {

            Console.WriteLine("\t\t\t\t\t      _-_-_-_-_-_-_-_-_-_-_-_\n");

            Console.WriteLine("\t\t\t\t\t      [1] Start");    
            Console.WriteLine("\t\t\t\t\t      [2] Show previous result");
            Console.WriteLine("\t\t\t\t\t      [3] End");
                                                
            Console.WriteLine("\n\t\t\t\t\t      -_-_-_-_-_-_-_-_-_-_-_-");

            Console.Write("\n\t\t\t\t\t          Chooise [1:3]: ");

        }


        static private void PerfromOption()
        {



        }

        static public void MainMenuScreen()
        {

            HeaderSreen();
            MenuScreen();

        }

    }

}
