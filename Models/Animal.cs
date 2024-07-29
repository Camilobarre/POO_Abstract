using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Abstract.Models;
public abstract class Animal
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Especie { get; set; }
    public Animal(int id, string nombre, string especie)
    {
        Id = id;
        Nombre = nombre;
        Especie = especie;
    }
    //Cuando se usa la palabra reservada Abstract, se obliga a usar el método en la clase hijo
    public abstract void Saludar();
}