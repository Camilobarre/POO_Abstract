using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models;
public abstract class Forma
{
    //Este es el método que se usará en la clase hija
    public abstract double CalcularArea();

    //Este método solo me muestra en consola
    public void MostrarArea(){
        Console.WriteLine($"El área es:"+ CalcularArea());
    }
}