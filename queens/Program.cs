using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Queens
{
    static class Program
    {
        static void Main()
        {
            string message;
            List<string> lines = new();
            List<int[]> queens = new();

            string input;

            while ((input = Console.ReadLine()) != null)
            {
                lines.Add(input);
            }

            for (int i = 0; i < lines.Count; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                string[] coords = lines[i].Split(" ");
                int[] qCoords = new int[2];
                qCoords[0] = int.Parse(coords[0]);
                qCoords[1] = int.Parse(coords[1]);
                queens.Add(qCoords);
            }

            message = ValidateCoords(queens) ? "CORRECT" : "INCORRECT";
            Console.WriteLine(message);
        }
        static bool ValidateCoords(List<int[]> queens)
        {
            int[] colCount = new int[queens.Count];
            int[] rowCount = new int[queens.Count];
            int[] diagCount = new int[(2 * queens.Count) - 1];
            int[] antiDiagCount = new int[(2 * queens.Count) - 1];
            foreach (int[] queen in queens)
            {
                colCount[queen[0]]++;
                rowCount[queen[1]]++;
                diagCount[queen[0] + queen[1]]++;
                antiDiagCount[queen[0] - queen[1] + queens.Count - 1]++;

                if (colCount[queen[0]] > 1 ||
                    rowCount[queen[1]] > 1 ||
                    diagCount[queen[0] + queen[1]] > 1 ||
                    antiDiagCount[queen[0] - queen[1] + queens.Count - 1] > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}