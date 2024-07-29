using POO_Abstract.Models;

//Usamos la clase padre
// var objetoPadre = new Animal(1, "dogpool", "canina");

//Usamos la clase hija
var objetoHijo = new Perro(2, "taitus", "canino", false);

//Caso de uso en Static
string ejemplo = "hola";
string textoEnMayusculas = Constantes.Mayuscula(ejemplo);
Console.WriteLine(textoEnMayusculas);

//Caso de uso Abstract
var figura1 = new Circulo(5);
figura1.MostrarArea();