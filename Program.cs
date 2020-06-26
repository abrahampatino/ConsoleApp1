/*
 * Practica 8
 * Autor: Abraham Patino
 * ESCOM - Analisis De Algoritmos
 */

using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccion de Ruta");
            StreamReader reader = new StreamReader("../../../caminos.txt");
            reader.ReadLine().Split(",");
            String [] ini_fin = reader.ReadLine().Split(",");
            String[] tra = reader.ReadToEnd().Replace('\r', ' ').Split('\n');
            Viaje travel = new Viaje(ini_fin, tra);
        }
    }
}
