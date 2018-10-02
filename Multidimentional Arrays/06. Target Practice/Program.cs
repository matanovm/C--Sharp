﻿using System;


namespace _06._Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            char[] snake = Console.ReadLine().ToCharArray();
            string[] shot = Console.ReadLine().Split();
            int shotRow = int.Parse(shot[0]);
            int shotColumn = int.Parse(shot[1]);
            int radius = int.Parse(shot[2]);

            char[,] matrix = new char[rows, cols];
            
            int index = 0;
            bool rightToLeft = true;
            for (int r = rows - 1; r >= 0; r--)
            {
                if (rightToLeft)
                {
                    for (int c = cols - 1; c >= 0; c--)
                    {
                        if (index == snake.Length)
                        {
                            index = 0;
                        }
                        matrix[r, c] = snake[index];
                        index++;
                    }
                }
                else
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (index == snake.Length)
                        {
                            index = 0;
                        }
                        matrix[r, c] = snake[index];
                        index++;
                    }
                }
                rightToLeft = !rightToLeft;
            }

            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - shotRow, 2) + Math.Pow(col - shotColumn, 2));
                    if (distance <= radius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }

            //check for whitespaces
            for (int c = 0; c < cols; c++)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int r = rows - 1; r > 0; r--)
                    {
                        if (matrix[r, c] == ' ')
                        {
                            matrix[r, c] = matrix[r - 1, c];
                            matrix[r - 1, c] = ' ';
                        }
                    }
                }
            }
           
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
