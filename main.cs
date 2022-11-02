// Created by: liya getachew
// Created on: Oct 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radius;

        Console.WriteLine("This program calculates the volume of a sphere (cm³).");

        Console.WriteLine("Enter dimensions of sphere here: ");
        Console.WriteLine("");

        Console.Write("radius of sphere (cm): ");
        radius = Convert.ToDouble(Console.ReadLine());

        double volume = (4.0/3.0) * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine("");
        Console.WriteLine("Volume = " + volume.ToString("0.00") + " cm³.");

        Console.WriteLine("\nDone.");
    }
}