using CarGalery.Business.Abstract;
using CarGalery.Business.CrossCuttingConcern.DependencyResolves.Ninject;
using System;

namespace CarGalery.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carService = InstanceFactory.Get<ICarService>();
            var list = carService.GetAll();
            foreach (var c in list)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
