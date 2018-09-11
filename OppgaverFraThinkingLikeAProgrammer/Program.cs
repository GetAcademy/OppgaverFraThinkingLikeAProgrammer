﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppgaverFraThinkingLikeAProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise2_9();
        }

        private static void Exercise2_9()
        {
            Console.Write("Skriv inn tekst: ");
            var line = Console.ReadLine() + " ";
            var wordCount = 0;
            var charsInCurrentWord = 0;
            for (var i = 0; i < line.Length; i++)
            {
                var isSpace = line[i] == ' ';
                if (charsInCurrentWord == 0 && !isSpace) wordCount++;
                if (isSpace)
                {
                    Console.WriteLine("ordlengde = " + charsInCurrentWord);
                    charsInCurrentWord = 0;
                }
                else charsInCurrentWord++;
            }
        }

        // Kun telle ord
        //private static void Exercise2_9()
        //{
        //    Console.Write("Skriv inn tekst: ");
        //    var line = Console.ReadLine();
        //    var wordCount = 0;
        //    var isInsideWord = false;
        //    for (var i = 0; i < line.Length; i++)
        //    {
        //        var isSpace = line[i] == ' ';
        //        if (!isInsideWord && !isSpace) wordCount++;
        //        isInsideWord = !isSpace;
        //    }

        //    Console.WriteLine(wordCount + " ord");
        //}

        private static void Exercise2_3()
        {
            for (int row = 1; row <= 4; row++) ShowStarRow(row);
            for (int row = 4; row >= 1; row--) ShowStarRow(row);
        }

        private static void ShowStarRow(int row)
        {
            ShowCountOfCharacter(row - 1, " ");
            ShowCountOfCharacter(row, "#");
            ShowCountOfCharacter(16 - row * 4, " ");
            ShowCountOfCharacter(row, "#");
            Console.Write("\n");
        }

        private static void ShowCountOfCharacter(int count, string character)
        {
            for (int i = 1; i <= count; i++) Console.Write(character);
        }

        private static void Exercise2_1()
        {
            for (int row = 1; row <= 4; row++)
            {
                for (int hashNum = 1; hashNum <= row - 1; hashNum++)
                {
                    Console.Write(" ");
                }
                var n = 2 * (5 - row);
                for (int hashNum = 1; hashNum <= n; hashNum++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");
                //Console.WriteLine();
            }
        }

        private static void Exercise2_2x()
        {
            for (int row = 1; row <= 8; row++)
                ShowRow(row < 5 ? 5 - row : row - 4);
        }

        private static void Exercise2_2()
        {
            for (int row = 4; row >= 1; row--) ShowRow(row);
            for (int row = 1; row <= 4; row++) ShowRow(row);
        }

        private static void ShowRow(int row)
        {
            for (int hashNum = 1; hashNum <= row - 1; hashNum++)
            {
                Console.Write(" ");
            }

            var n = 2 * (5 - row);
            for (int hashNum = 1; hashNum <= n; hashNum++)
            {
                Console.Write("#");
            }

            Console.Write("\n");
        }
    }
}
