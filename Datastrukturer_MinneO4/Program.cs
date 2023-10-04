using System.Xml.Linq;
using System;

namespace Datastrukturer_MinneO4
{
    internal class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 
        /// F1: Stacken är som böcker som blir staplade på varandra. För att komma åt en måste man ta bort de som är 
        ///     ovanför först i ordning. fungerar som Last in first Out LIFO. 
        ///     Hypen är däremot mer oordnad och man kan komma åt data mycket snabbare.
        ///    
        /// F2: 
        /// F3: I första metoden är x och y valueType x=3 och sedan sätts y till x vilket ger värdet 3 men när värdet
        ///     på y ändras till 4 behåller x sitt värde eftersom var och en av valuetype variablerna behåller sina värdena.
        ///     medans i den andra är de x och y av referenstype som pekar på utrymmet där värdet lagras. om man ändrar 
        ///     värdet för den ena så ändras för alla andra som pekar samma minnes utrymme.
        static void Main(string[] args)
        {
            while (true)
            {
                

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        //ReverseText();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */

                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            Console.WriteLine(" ------Examine List------");
            List<string> theList = new List<string>();
           
            while (true)
            {
                Console.WriteLine("enter + and item like +item to add to the list");
                Console.WriteLine("Enter - and item like -item to remomve from the list");

                String input = Console.ReadLine();
                char nav = input[0];
                String value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        if (!theList.Contains(value))
                        {
                            theList.Add(value);
                            Console.WriteLine($"'{value}' is added  to the list.");
                        }
                        else
                        {
                            Console.WriteLine($"'{value}' is already in the list.");
                        }
                        break;

                    case '-':
                        if (theList.Contains(value))
                        {
                            theList.Remove(value);
                            Console.WriteLine($"'{value}' is removed from the list.");
                        }
                        else
                        {
                            Console.WriteLine($"'{value}' is not in the list.");
                        }
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Please use + or - followed by item to put in the list or remove.");
                        break;
                }

                foreach (var item in theList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"The capasity of the list is {theList.Capacity}");
            }
            
        }

        /// F2: Efter att man har 4 Kommer den utökas när den femte kommer in
        /// F3: Då fördubblas den till 8 och sedan 16 efter åttonde elementet, osv.
        /// F4: När kapaciteten är nåd kommer en ny minnesutrymme allokeras av den dubbla. Kanske är det mer effektivt så. 
        ///     Det är inte samma sak som Count som bara visar antal element i listan. 
        /// F5: Nej. Den behåller senaste kapaciteten.
        /// F6: Om man vet den storlek man jobbar med kan det vara fördelaktigt.

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// 



        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */


            Console.WriteLine(" ------Examine the Queue------");
            Queue<string> theQueue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("enter + and item like +item to add to the Queue");
                Console.WriteLine("Enter - and item like -item to remomve from the Queue");

                String input = Console.ReadLine();
                char nav = input[0];
                String value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        if (!theQueue.Contains(value))
                        {
                            theQueue.Enqueue(value);
                            Console.WriteLine($"'{value}' is added  to the Queue.");
                        }
                        else
                        {
                            Console.WriteLine($"'{value}' is already in the Queue.");
                        }
                        break;

                    case '-':
                        if (theQueue.Contains(value))
                        {
                            var first = theQueue.Dequeue();
                            Console.WriteLine($"'{value}' is removed from the Queue.");
                        }

                        else
                        {
                            Console.WriteLine($"'{value}' is not in the Queue.");
                        }
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Please use + or - followed by item to put in the list or remove.");
                        break;
                }
                //theQueue.Enqueue("Kalle");
                //theQueue.Enqueue("Greta");
                //theQueue.Dequeue();
                //theQueue.Enqueue("Stina");
                //theQueue.Dequeue();
                //theQueue.Enqueue("Olle");

                foreach (var item in theQueue)
                {
                    Console.WriteLine(item);
                }

            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */


            Console.WriteLine(" ------Examine the Stack------");
            Stack<string> theStack = new Stack<string>();

            while (true)
            {
                Console.WriteLine("enter + and item like +item to add to the Queue");
                Console.WriteLine("Enter - and item like -item to remomve from the Queue");

                String input = Console.ReadLine();
                char nav = input[0];
                String value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        if (!theStack.Contains(value))
                        {
                            theStack.Push(value);
                            Console.WriteLine($"'{value}' is pushed  to the stack.");
                        }
                        else
                        {
                            Console.WriteLine($"'{value}' is already in the stack.");
                        }
                        break;
                    case '-':
                        string str;
                        if (theStack.Count != 0)
                        {
                            str = theStack.Pop();
                            Console.WriteLine($"Popped {str}");
                        }
                        else
                        {
                            Console.WriteLine($"'{value}' is not in the stack.");
                        }
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Please use + or - followed by item to put in the list or remove.");
                        break;
                }
       
                foreach (var item in theStack)
                {
                    Console.WriteLine(item);
                }

            }
        }  
         // F1:  Stack använder sig av LIFO, last in first out. så den kund som kommer sist in i kön 
         //      blir servad vilket inte kommer funka i det här fallet.

    static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.WriteLine(" ------Examine the Parentheses------");
        
            while (true) {

                  Console.WriteLine("Enter a string and paranthesis: ");
                
                  String input = Console.ReadLine();
                  if (IsCorrectForm(input) == true)
                  {
                   Console.WriteLine("Right input!");
                  }
                  else
                  {
                   Console.WriteLine("Wrong input!");
                  }  
            } 
        }
        static bool IsCorrectForm(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 ||
                        (c == ')' && stack.Peek() != '(') ||
                        (c == '}' && stack.Peek() != '{') ||
                        (c == ']' && stack.Peek() != '['))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }

        /* static void ReverseText()
        {
            Console.WriteLine("Skriv in en text: ");

            var input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            foreach (var c in input)
            {
                stack.Push(c);
            }



            Console.WriteLine(input);

        }*/
    }
}