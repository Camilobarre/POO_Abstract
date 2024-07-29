using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models;
public class Circulo : Forma
{
    public double Radio { get; set; }

    //Se crea un constructor
    public Circulo(double radio)
    {
        Radio = radio;
    }
    //El método heredado de Forma se implementa aquí
    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
}