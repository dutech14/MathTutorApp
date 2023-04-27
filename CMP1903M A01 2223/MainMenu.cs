﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class MainMenu
    {


        public void menu()
        {
            
            Messages messages = new Messages();
            Console.WriteLine(messages.welcomemessage()); 
            bool valid = false;
            int user_input = 0;
            while (!valid)
            {

                Console.WriteLine("Enter :");
                Console.WriteLine("(1) For easy level");
                Console.WriteLine("(2) For Hard level");
                Console.WriteLine("(3) For Help");
                Console.WriteLine("(4) To quit");

                if (int.TryParse(Console.ReadLine(), out user_input))
                {
                    if (user_input == 1)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        /*dynamic threelevel= new threeCardslevel();
                        threelevel.Equation();
                        threelevel.userInput();*/
                        threeCardslevel level = new threeCardslevel();
                        level.userInput(level.evaluate());
                        dynamic playerchoice = new Questions();

                        playerchoice.playAgain();

                    }
                    else if (user_input == 2)
                    {
                        valid = true;
                        Questions.shufflegameMethod();
                        dynamic hard_level= new fivelevels();
                        //hard_level.evaluate();
                        hard_level.userInput(hard_level.evaluate());
                        dynamic playerchoice = new Questions();

                        playerchoice.playAgain();
                    }
                    else if (user_input == 3)
                    {
                        valid = true;
                        Console.WriteLine(Help.firstmessage());
                        Help.operators();
                        Help.sample1();
                        Help.sample2();
                        Help.back();
                    }
                    else if (user_input == 4)
                    {
                        valid = true;
                        Console.WriteLine(messages.goodByeMessage()); 
                    }
                }
                else
                {
                    Console.WriteLine("input an integer please!!");
                }

            }

        }
        

      
    }
}
