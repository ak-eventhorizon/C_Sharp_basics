﻿using System;
using System.Collections.Generic;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {


        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {

            
            // Test code samples here: =============================================================>

            Example.Print("Hello!!!");
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();

            Example.GetMinMaxFromRandomArray();
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();

            DateTime start1 = new DateTime(2022,12,28,9,30,0); // 28.12.2022 9:30
            DateTime end1 = new DateTime(2022,12,28,13,30,0); // 28.12.2022 13:30
            DateTime start2 = new DateTime(2022,12,28,13,0,0); // 28.12.2022 13:00
            DateTime end2 = new DateTime(2022,12,28,15,0,0); // 28.12.2022 15:00
            Example.GetTimeIntersection(start1, end1, start2, end2);
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();

            // End of code sample <=============================================================


            // использование конструктора с параметрами для создания объектов
            Bot bot1 = new Bot("Siri", 450, new int[] {1, 7, 4});
            bot1.StatusReport();

            // использование конструктора без параметров, с последующей установкой свойств объекта
            Bot bot2 = new Bot();
            bot2.Name = "Manya";
            bot2.Weight = 550;
            bot2.Coords = new int[] {1, 2, 3};
            bot2.StatusReport();

            // создание списка объектов
            List<Bot> robots = new List<Bot>();
            robots.Add(new Bot("2B", 75, new int[] {10, 5, 3}));
            robots.Add(new Bot("R2D2", 77, new int[] {11, 11, 5}));
            robots.Add(new Bot("C3PO", 129, new int[] {10, 10, 6}));
            robots.Add(new Bot("T-1000", 400, new int[] {7, 15, 0}));

            foreach (Bot item in robots)
            {
                item.StatusReport();
            }

            // вывод статического свойства самого класса Robot
            System.Console.WriteLine($"Was created {Robot.Counter} units");


            // создание экземпляра класса Killer (наследника от родительского класса Robot)
            Killer demon = new Killer("DEMON", 45, new int[] {133, 45, 67}, 1000, LaserColor.Red);
            demon.LaserFire();  // переопределенный виртуальный метод из класса Killer
            bot1.LaserFire();  // исходный метод класса Robot

            System.Console.WriteLine($"Was created {Robot.Counter} units"); // создание класса-наследника так-же увеличивает counter родительского класса Robot
        }
    }
}