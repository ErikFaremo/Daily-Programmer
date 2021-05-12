using System;

namespace _389__The_Monty_Hall_Problem
{
    class MontyHall
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Monty Hall Problem");
            Console.WriteLine("1. There are three closed doors, labeled #1, #2, and #3. Monty Hall randomly selects one of the three doors and puts a prize behind it. The other two doors hide nothing.");
            Console.WriteLine("2. A contestant, who does not know where the prize is, selects one of the three doors. This door is not opened yet.");
            Console.WriteLine("3. Monty chooses one of the three doors and opens it. The door that Monty opens (a) does not hide the prize, and (b) is not the door that the contestant selected. There may be one or two such doors. If there are two, Monty randomly selects one or the other.");
            Console.WriteLine("4. There are now two closed doors, the one the contestant selected in step 2, and one they didn't select. The contestant decides whether to keep their original choice, or to switch to the other closed door.");
            Console.WriteLine("5. The contestant wins if the door they selected in step 4 is the same as the one Monty put a prize behind in step 1.");
            Console.WriteLine("");
            Console.WriteLine("-= CHALLENGE =-");
            Console.WriteLine("Alice chooses door #1 in step 2, and always sticks with door #1 in step 4.");
            Console.WriteLine("Bob chooses door #1 in step 2, and always switches to the other closed door in step 4.");
            Console.WriteLine("");
            //Strategy
            //0 = Never switch
            //1 = Always switch
            //Alice
            Console.WriteLine("Alice => " + Monty(0));
            //Bob
            Console.WriteLine("Bob => " + Monty(1));
        }

        private static string Monty(int strategy)
        {
            int selectedDoor = 0;
            int success = 0;
            if (strategy == 0 || strategy == 1)
            {
                selectedDoor = 1;
            }
            for (int i = 0; i < 1000; i++)
            {
                int prizeDoor = RandomizeDoor();

                if(strategy == 1)
                {
                    if(prizeDoor == 1)
                    {
                        Random rand = new();
                        //Generate a number between 2 and 3
                        int openDoor = rand.Next(2, 4);
                        if(openDoor == 2)
                        {
                            selectedDoor = 3;
                        } else
                        {
                            selectedDoor = 2;
                        }
                    }
                    else if(prizeDoor == 2)
                    {
                        selectedDoor = 2;
                    } else
                    {
                        selectedDoor = 3;
                    }
                }

                if(selectedDoor == prizeDoor)
                {
                    success++;
                }
            }
            float percent = (success / 1000.0f) * 100.0f;
            return (success + " of 1000 tries. " + percent.ToString() + "% chance of success.");
        }

        private static int RandomizeDoor()
        {
            Random rand = new();
            //Generate a number between 1 and 3
            return rand.Next(1, 4);
        }
    }
}
