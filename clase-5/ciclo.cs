//see http://aka.ms/new-console-template for more info.
Console.WriteLine("Cuantas vueltas quiere dar?");

var respuesta = "S";
var contador = 0;

while (respuesta.ToUpper()!="N")
{
    contador++; //contador + 1;
    Console.WriteLine("Seguime dando vueltas, vuelta número: " + contador);
}
