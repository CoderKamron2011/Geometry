﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

bool isCantinue = true;

    do
    {
        Console.Clear();
        Console.WriteLine("Welcome to my project");
        Console.WriteLine("1.Calculation");
        Console.WriteLine("2.Draw");
        Console.WriteLine("Enter your command:(i: 1,2): ");
        string commandFirst = Console.ReadLine();

        if (commandFirst == "1")
        {
            Console.Clear();
            Console.WriteLine("===Calculation===");
            Console.WriteLine("1.kub is volume");
            Console.WriteLine("2.circle face");
            Console.WriteLine("3.circle length");
            Console.WriteLine("Enter your command for calculation:(i: 1,2,3): ");
            string commandSecond = Console.ReadLine();

            if (commandSecond == "1")
            {   
                Console.Clear();
                Console.WriteLine("Kub tomonini kiriting: ");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("Berilgan kubning hajmi = "+side*side*side );
            }
            else if (commandSecond == "2")
            {
                Console.Clear();
                Console.WriteLine("Aylana radiusini kiriting: ");
                int radius_1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Berilgan doira yuzi = "+radius_1 *radius_1 * 3,14);
                
            }
            else if (commandSecond == "3")
            {   
                Console.Clear();
                Console.WriteLine("Aylana radiusini kiriting: ");
                int radius_2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Berilgan aylana uzunligi = "+radius_2 * 2 * 3,14);

            }
            
        }
        if (commandFirst == "2")
        {
            Console.Clear();
            Console.WriteLine("===Draw===");
            Console.WriteLine("1.Rectangle");
            Console.WriteLine("2.Round");
            Console.WriteLine("3.Circle");
            Console.WriteLine("Qaysi birini chizmoqchisiz(i:1,2,3)");
            string sideOfDraw = Console.ReadLine();

            if (sideOfDraw == "1")
            {   
                Console.Clear();
                Console.WriteLine("rectangle : _____________________ "); 
                Console.WriteLine("            |                   | ");
                Console.WriteLine("            |                   | ");
                Console.WriteLine("            |___________________| ");
            }
            else if (sideOfDraw == "2")
            {
                Console.Clear();
                Console.WriteLine("Round:  |-----|   ");
                Console.WriteLine("        |     |   ");
                Console.WriteLine("        |-----|   ");
                    
            }
            else if (sideOfDraw == "3")
            {   
                Console.Clear();
                Console.WriteLine("Circle:  *****         ");
                Console.WriteLine("        *     *        ");
                Console.WriteLine("        *     *        ");
                Console.WriteLine("         *****         ");

            }
        }
        Console.WriteLine("Is cantinue: ");
        string commandCantinue = Console.ReadLine();

        if (commandCantinue.ToLower().Contains("no") is true)
        {
            isCantinue = false;
        }
    }while (isCantinue is true);

