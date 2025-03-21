﻿
using Generic_Libraries;
using System;

namespace MathGame
{
    class GameMenuDesign
    {

        static private int chooise = 0;
        static public bool continueTheGame = true;


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

            chooise = Read_Int_Input.ReadNumberBetweenRange(1, 3, "\n\t\t\t\t\t          Chooise [1:3]: ",
                "\n\t\t\t\t       Out of range, Enter a vaild number [1:3]: ");

        }


        static private void Start()
        {

            Console.Clear();
            LevelOfGame.LevelMenuScreen();
            //Console.Write("Come soon, Enter any key to go back...");
            //Console.ReadKey();

        }

        static private void ShowPreviousResultScreen()
        {

            Console.Clear();
            Console.Write("Come soon, Enter any key to go back...");
            Console.ReadKey();

        }

        static private void PerfromOption()
        {

            switch(chooise)
            {

                case 1:
                    Start();
                    break;

                case 2:
                    ShowPreviousResultScreen();
                    break;

                case 3:
                    continueTheGame = false;
                break;

            }

        }


        static public void MainMenuScreen()
        {

            Console.Clear();

            HeaderSreen();
            MenuScreen();
            PerfromOption();

        }

    }

}
