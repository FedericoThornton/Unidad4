﻿using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //  Hacer un programa para ingresar 4 números.
            // Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
             


            int a, b, c, d;

            Console.WriteLine ("Ingrese un numero: ");
            a = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese otro numero: ");
            b = int.Parse (Console.ReadLine());
            Console.WriteLine ("Ingrese otro numero: ");
            c = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Ingrese un nro mas" );
            d = int.Parse (Console.ReadLine());

           if ((a > b) && (b > c) && (c > d))
           {
             Console.WriteLine ("ordenados en forma decreciente");
           }
                else
                {
                    Console.WriteLine ("no estan ordenados");
                }
            
           
                
            
            
                
            

        }




        
            
               
                
               
            


        
        
        
    }
}
