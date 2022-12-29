using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploCalc{
    public class calculadora{
        public void somar(int x, int y){
           Console.WriteLine($"{x} + {y} = { x+y }");             
        }
        public void subtrair(int x, int y){
           Console.WriteLine($"{x} - {y} = { x-y }");             
        }
        public void multi(int x, int y){
           Console.WriteLine($"{x} x {y} = { x*y }") ;            
        }
        public void dividir(int x, int y){
           Console.WriteLine($"{x} / {y} = { x/y }") ;            
        }
        public void pot(int x, int y){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = { pot }") ;            
        }
        public void seno (double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo} é {Math.Round (seno,4)} ");
        }
        public void coseno (double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo} é {Math.Round (coseno,4)} ");
        }
        public void tangente (double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O tangente de {angulo} é {Math.Round (tangente,4)} ");
        }
        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é igual a {raiz} ") ;            
        }
    }



}
