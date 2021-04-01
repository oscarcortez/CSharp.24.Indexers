using Models;
using System;

namespace ConsoleApp4Indexers
{
    class Program
    {
        /// <summary>
        /// Indexer nos permite trabajar con un objeto como si fuera un array
        /// dentro de la clase debe tener un array y un indice
        /// la manera de acceder desde el objeto es nombreObjeto[/brackets/indice];
        /// 
        /// nice to have: indices no enteros
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollectionInt<string>();
            stringCollection.Add("Hello, World");
            System.Console.WriteLine(stringCollection[0]);
        }
    }
}
