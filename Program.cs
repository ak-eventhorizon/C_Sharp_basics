﻿using System;
using System.Collections.Generic;

// пространство имен - по имени проекта
namespace C_Sharp_Basics {

    // класс - по имени файла
    class Program {

        // метод Main() - единственный на проект, точка входа в исполнение программы
        static void Main(string[] args) {
            Print();
            Print("Hello everybody!");
            Print(Summ(12.5, 0.76).ToString());
        }

        // public - метод доступен по всему проекту
        // static - не требуется создавать экземпляр класса для вызова метода, метод принадлежит самому классу
        // void - возвращаемое значение отсутствует
        public static void Print(string msg = "") {
            System.Console.WriteLine(msg);
        }

        public static double Summ(double a, double b) {
            double result = a + b;
            return result;
        }
    }    
} 