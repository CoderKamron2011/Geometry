# Geometry

Hammaga salom bu mening yangi **proyektim**. Mening yangi proyektimning nomi **"Geometry"** bo'lib u **geometriya**ga bog'liq.

## Codes:

``` csharp
// ---------------------------------------------------------------
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


```

To'g'ri ancha katta lekin shuncha kodga arziydi.

# Natijalar 

![Home page](/gif/image%20gif.gif)
Agarda siz ushbu kodni run  qilsangiz birinchi bo'lib shu **runcode**ni ko'rasiz. Bu yerda 2 xil tommi ko'rishingiz mumkin.

* Calculation(Hisoblash)
* Draw(Chizish)

# 1.Calculation

Agarda siz 1ni kiritsangiz siz 3 ta turni ko'rasiz.

![Home page](/gif/imega.gif)                         

* kub is volume(kub yuzi)
* circle face(doira yuzi)
* circle length(aylana uzunligi)

Hammasini birdaniga ko'rsataman.

# 1.1 | 1.2 | 1.3 runcodelar

![](/gif/gemotry.gif)

Bu yerda siz 1 yoki 2 yoki 3 ni tanlaysiz.

## 1.1
kub tomonini kiriting va u o'zi hajmini topib beradi.

## 1.2
doira radiusini kiriting va u o'zi yuzini topadi.

## 1.3
aylana radiusini kiriting va u o'zi uzunligini topadi.

# 2.Draw

![](/gif/gemotry.gif)

Draw da siz 3 xil shaklni chizishingiz mumkin.

* Rectangle(to'g'ri to'rtburchak)
* Round(kvadrat)
* circle(aylana)

# 2.1 | 2.2 | 2.3 runcodelar

![](/gif/tugadi.gif)

Bu yerda siz faqat tanlaysiz u ase generatsiya qiladi...