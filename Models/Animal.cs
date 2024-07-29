using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models;
public class Animal
{
    public int Id {get; set; }
    public string Nombre {get; set; }
    public string Especie {get; set; }
    private string specie2;
    public Animal(int id, string nombre, string especie)
    {
        Id=id;
        Nombre=nombre;
        Especie=especie;
    }    
}