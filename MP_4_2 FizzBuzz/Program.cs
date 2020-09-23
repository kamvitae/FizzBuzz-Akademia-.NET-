using System;


namespace MP_4_2_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            do
            {
                fizzBuzz.GetNewNumber();
                fizzBuzz.RunAlgorithm(fizzBuzz.number);

                Console.WriteLine("Wciśnij dowolny klawisz by grać, 'Esc' by wyjść");
            } 
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        class FizzBuzz
        {
            string userInput;
            bool isValid;
            public int number;
            public FizzBuzz()
            {
                //GetNumber(); <---początkowo większość kodu zawarłem w konstruktorze
            }
            public void GetNewNumber()
            {
                SetNumber();
            }
            private void SetNumber()
            {
                do
                {
                    Request();
                    userInput = Console.ReadLine();
                    isValid = int.TryParse(userInput, out int result);

                    if (isValid)
                        number = int.Parse(userInput);
                }
                while (!isValid);
            }

            public void RunAlgorithm(int input)
            {
                if (input % 3 == 0 && input % 5 == 0)
                    Console.WriteLine("FizzBuzz\n");
                else if (input % 3 == 0)
                    Console.WriteLine("Fizz\n");
                else if (input % 5 == 0)
                    Console.WriteLine("Buzz\n");
                else
                    Console.WriteLine($"{input}\n");

            }
            void Request() 
            {
                Console.WriteLine($"\nProszę wprowadzić liczbę całkowitą w przedziale {Int32.MinValue} a {Int32.MaxValue}"); 
            }  
        } 

    }

}
