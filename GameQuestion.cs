



using System.Reflection.Metadata.Ecma335;

namespace MathGame
{
    class GameQuestion
    {

        static private int from = 0;
        static private int to = 0;

        static private char _Operation = '\0';
        static private char op ='\0';

        static private int numberOfCorrectAnswer = 0;
        static private int numberOfWrongeAnswer = 0;
        static public int correctAnswer = 0;


        static public void SetRangeOfNumber(int _from, int _to)
        {

            from = _from;
            to = _to;

        }

        static public void SetOperationOfGame(char operation)
        {

            _Operation = operation;

        }

        static private int GenerateRandomIntNumber(int _from, int _to)
        {

            Random rnd = new Random();
            return rnd.Next(_from, (_to+1));

        }

        static public int GenerateRandomIntNumber()
        {

            Random rnd = new Random();
            return rnd.Next(from, (to+1));

        }


        static public char GetOperation()
        {

            op = _Operation;

            if (_Operation == 'H')
            {
                op = GetRandomOperation();
            }
                
            return op;
        }

        static public string GetLevel()
        {

            if(from == 0 && to == 100)
            {
                return "Easy";
            }
            else if(from == 100)
            {
                return "Mid";
            } 
            else if(from == 150)
            {
                return "Hard";
            }
            else
            {
                return "Hybird";
            }

        }


        static private char GetRandomOperation()
        {

            int number = GenerateRandomIntNumber(1,4);

            switch(number)
            {

                case 1:
                    return '+';

                case 2:
                    return '-';

                case 3:
                    return '*';

                case 4:
                    return '/';

            }

            return '+';

        }


        static private int GetAnswer(int number1, int number2)
        {

            switch(op)
            {

                case '+':
                    return number1 + number2;

                case '-':
                    return number1 - number2;

                case '*':
                    return number1 * number2;

                case '/':
                    return number1 * number2;


            }

            return 0;

        }


        static public bool IsrigthAnswer(int userAnswer, int number1, int number2)
        {

            correctAnswer = GetAnswer(number1, number2);

            if (correctAnswer == userAnswer)
            { 
                numberOfCorrectAnswer++;
                return true;
            }
            else
            {
                numberOfWrongeAnswer++;
                return false;
            }


        }

    }

}
