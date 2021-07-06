using System;

namespace Demo_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int myNum=5;
            myNum+=2;
            myNum-=1;
            long myNum2=5000000000000;
            double myDouble=5.8D;
            char myLetter='H';
            string myText="Hello World!";
            int[] numList = {10,20,30};
            Console.WriteLine(myText);
            Console.WriteLine(myNum+myText);
            Console.WriteLine(numList[0]);
            numList[0]+=10;
            Console.WriteLine(numList[0]);

            //if/else
            int numberOne=5;
            int numberTwo=10;
            if (numberOne==numberTwo){
                Console.WriteLine("The numbers are equal");
            }
            else if (numberOne>numberTwo){
                Console.WriteLine("#1 is greater than #2");
            }
            else {
                Console.WriteLine("#1 is less than #2");
            }

            //loop
            //while (true){
            int i=0;
            while (i<5){
                Console.WriteLine(i);
                i++;
            }

            for (int k=0;k<5;k++){
                Console.WriteLine(k);
            }
            //Console.WriteLine(k);


            //functions
            int sum = AddNumbers(9,10);
            Console.WriteLine(sum);
            //Console.WriteLine(num1);

            //Text adventure
            Console.WriteLine("You are at a fork in the road.");
            switch (AskQuestion("Go LEFT or RIGHT?", new string[] {"LEFT","RIGHT"})){
                case 0:
                    Console.WriteLine("You go left.");
                    break;
                case 1:
                    Console.WriteLine("You go right.");
                    break;
                default: break;
            }
            Console.WriteLine("The End");
        }

        static int AddNumbers(int num1, int num2){
            return num1+num2;
        }

        static int AskQuestion(string question, string[] choices){
            Console.WriteLine(question);
            while (true){
                string answer=Console.ReadLine().ToUpper();
                Console.WriteLine("AFASDFASDF");
                for (int i=0;i<choices.Length;i++){
                    if (choices[i]==answer) return i;
                }
            }
        }
    }
}
