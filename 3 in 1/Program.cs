// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;


void main()
{
    int input;
    input = 1;
    do
    {
        
        try
        {

            Console.WriteLine("Choise a program\n");
            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("Today's menu: \n");
            Console.WriteLine("1. Game \"Guess the number\" ");
            Console.WriteLine("2. Multiplication table:");
            Console.WriteLine("3. Output of divisors of a number");
            Console.WriteLine("0. if you want to leave... Traitor");


            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Random rand = new Random();
                    int randomNum = rand.Next(101);
                    int count = 1;
                    Console.WriteLine("A number from 0 to 100 is guessed. Try to guess it in 15 attempts.");
                    Console.WriteLine("Enter the first number:");

                    while (count <= 15)
                    {
                        int msg = Convert.ToInt32(Console.ReadLine());
                        if (count == 15)
                        {
                            Console.WriteLine("Alas, you did not get the number you had guessed. It was a number " + randomNum + "!");
                            break;
                        }

                        if (msg > 100)
                        {
                            count++;
                            Console.WriteLine("Conceived  in the range from 0 to 100! But you can continue))");
                            continue;
                        }

                        if (msg < 0)
                        {
                            count++;
                            Console.WriteLine("Conceived  in the range from 0 to 100! But you can continue))");
                            continue;
                        }

                        if (randomNum == msg)
                        {
                            Console.WriteLine("Yes! Computer conceived a number " + msg + "!");
                            break;
                        }

                        if (Math.Abs(randomNum - msg) < 10)
                        {
                            count++;
                            Console.WriteLine("Почти угодал, горячевое");
                            Console.WriteLine("Try № " + count + ":");
                            continue;
                        }
                        if (Math.Abs(randomNum - msg) < 20)
                        {
                            count++;
                            Console.WriteLine("Рядышком, тёпленьбкое");
                            Console.WriteLine("Try № " + count + ":");
                            continue;
                        }
                        if (Math.Abs(randomNum - msg) > 20)
                        {
                            count++;
                            Console.WriteLine("Не угодал, холодненьбкое");
                            Console.WriteLine("Try № " + count);
                            continue;
                        }

                        else
                        {
                            count++;
                            Console.WriteLine("Играй по правилам)");
                            Console.WriteLine("Try № " + count);

                        }
                    }
                    break;

                case 2:
                    {/* Мне больше нравиться такой вариант, ибо я нахожу его более лакончиным конкретно для этой задачи. 
             * Но как говориться спешел фо ю, сделаю и вариант с отработкой обработки двумерных массивов
             */
                        //    Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
                        //    Console.Write("--------------------------------------------------------------------------");
                        //    Console.WriteLine();
                        //    for (int ix = 1; ix < 10; ix++)
                        //    {
                        //        Console.Write(ix + "   |  ");
                        //        for (int j = 1; j < 10; j++)
                        //        {
                        //            Console.Write("\t" + ix * j);
                        //        }
                        //        Console.WriteLine("");
                        //        Console.WriteLine("");
                        //    }
                        //    Console.WriteLine("Tap any button to continue");
                        //    Console.ReadLine();
                        //    break;
                        //}


                        int[,] myArray = new int[9, 9];
                        {
                            //foreach (int i in myArray.GetLength(0)) ;
                        }


                        int height = myArray.GetLength(0);
                        int width = myArray.GetLength(1);

                        for (int y = 0; y < height; y++)
                        {
                            for (int x = 0; x < width; x++)
                            {
                                Console.Write(myArray[y, x] + "\t");
                            }
                            Console.WriteLine();    
                        }
                        break;
                    }
                            
                 


                case 3:
                    {
                        Console.WriteLine("Enter a number");
                        int userInput = Convert.ToInt32(Console.ReadLine()); 
                        List <int> resultArray = new List<int> {}; string result;
                        
                        while(userInput != 0)
                        {
                            for (int divider = 1; divider <= userInput; divider++)
                            {
                                if (userInput % divider == 0)
                                {
                                    resultArray.Add(divider);
                                    result = string.Join(" ", resultArray);

                                }
                            
                                Console.WriteLine(result);


                            Console.WriteLine("\nIf you wont enter a new number press any button other then 0");
                            userInput = Convert.ToInt32(Console.ReadLine());


                            } ; 
                        }
                        
                        break;

                    }
                case 0:
                    Console.WriteLine("\nk -. -");
                    break;
                default:
                    Console.WriteLine("HAVE MERCY ON ME, DON'T BREAK CODE, JUST COISE NUM OF RANGE 0 TO 3");
                    break;
            
            };
            input = 1;
        }
        catch
        {
            Console.WriteLine("Not today :) Play by the rules next time");

        }
    } while (input != 0);
}
main();

