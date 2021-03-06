﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHShortStory
{
    internal class View

    {
        public string Name { get; set; }
 public int count = 0;

        private bool keepRunningTimer = true;

        public void askUserName()
        {
            Console.WriteLine("Please Enter your name");
             Name= Console.ReadLine();

            Console.WriteLine(
                "The year is 1969 and you have just moved to a house in Baltimore, America.\nYou have heard stories of how this is apparently the\nhaunted capital of America " +
                "but nothing could have prepared you for what was\nabout to happen. " +
                "This is the story of your first night in the house....\n");

            

            //Console.ReadLine();

        }


        public string DisplayQuestion(int questionNum)
        {


            if (questionNum == 1)
            {

                string qstn="As you settled down in bed, a loud thump from the kitchen is heard. " +
                                  "Knowing the stories of the town you are living in, instant fear spreads to your mind." +
                                  " Do you:" +
                                  "\nA)Ignore the noise and try to sleep\nB)Decide that it's worth investigating.";
                Console.WriteLine(qstn);
                keepRunningTimer = true;

                Task task = new Task(()=> Timer(15));
               // task.Start();
                string userInput = Console.ReadLine();

                keepRunningTimer = false;

                return userInput;

            }

            else if (questionNum == 2)
            {
                 string qstn="As you enter the kitchen, you see the toaster floating in front of you. Do you:" +
                                  " \nA)Decide it doesn't matter, and try to make yourself some toast \nB)Scream and run away!!";
                Console.WriteLine(qstn);
                string userInput = Console.ReadLine();
                return userInput;

            }
            else if (questionNum == 3)
            {
                string qstn = "You sprint as fast as you can, but you trip over and knock your self out." +
                                  " As you regain consciousness, you doubt yourself as to what really happened before." +
                                  " You decide to enter the kitchen again and find everything normal. " +
                                  "You decide that before must have been a crazy dream, as you had been very stressed lately BUT then out of nowhere, a wild Charmander appears. Do you...\n A) Try and battle the pokemon with a water bottle next to you\nB) Stay calm and try to find out why it's in your house";
                Console.WriteLine(qstn);
                string userInput = Console.ReadLine();
                return userInput;
            }
            else if (questionNum == 4)
            {
                Console.WriteLine(
                    "As you talk to the Charmander, you find out that there is a rogue Gengar in your house, and he has been terrorizing your local town. Apparently Charmander has been chasing him for weeks and then finally tracked him down to your house." +
                    " He asks for you help in catching Gengar, do you: \n A) Pour some water on Charmander and then kick him out of your house \n B) Join forces with this Charmander, and take on the evil Gengar");
                string userInput = Console.ReadLine();
                return userInput;
            }
            else if (questionNum == 5)
            {
                Console.WriteLine(
                    "You trust your better judgement, and decide to help the Charmander to get the Gengar out of your house. He asks if you have any Pokemon of your own, you tell him that you own a:\nA) Geodude\nB) Abra");
                string userInput = Console.ReadLine();
                return userInput;
            }
            else if (questionNum == 6)
            {
                Console.WriteLine(
                    "He glee's in excitement, as any sane person will know that a psychic Pokemon is super effective against ghost type. You and Charmander then come up with a plan to lure the Gengar into a trap. You decide to bait him by putting something he loves in the middle of the lounge:\nA) Pokesnack\nB) Cow");
                string userInput = Console.ReadLine();
                return userInput;
            }

            else if(questionNum==7)
            {
                Console.WriteLine(
                    "Gengar takes the bait and appears in the lounge. You and Charmander are hiding behind the couch watching Gengar approach the Cow. Just as he is about to attack the cow you throw out your abra!! Abra attack that Gengar you scream!! Gengar tries to attack your abra but is beaten by the awesome might of abra's psychic abilities. Gengar screams, and leaves the house you decide to:\nA) Chase the Gengar to get rid of him forever\nB) Decide to go back to bed after a crazy night");
                string userInput = Console.ReadLine();
                return userInput;
            }
            else
            {
                 Console.WriteLine("Well done Pokemone Master {0}, your night in the terrible haunted house is over",Name);
            }
            return null;

        }

        public void asciiTitle()
        {
            List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("title for project.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line); // Add to list.
                    Console.WriteLine(line); // Write to console.
                }
            }

          
           
        }

        public int Dead(int number)
        {
            
            count++;
            if (count > 1)
            {
                Console.WriteLine(" A truck falls from the sky and lands on you....you are dead, the game is over\n");
            }
            else
            {
                Console.WriteLine("You are dead!!!!! But wow, a magical genie suddenly appears and grants you another life, use it more wisely this time!!\n");
                
                return number;
            }
            return 0;


        }

        public int Timer(int time)
        {
            //create int set at 30s
            Console.Write("Decide in the next:{0}    seconds, or die!!!!", time);
            for (int a = time; a >= 0; a--)
            {
                if (!keepRunningTimer)
                {
                    break;
                }

                //Console.CursorLeft = 22;
                for (int j = 0;  j < (a/10 +1) ; j++)
                {
                    
                Console.Write("\b");
                }
                Console.Write(a.ToString());
                System.Threading.Thread.Sleep(1000);
                time--;
            }
            return time;
        }
      

        }
    }

