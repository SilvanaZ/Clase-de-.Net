Console.WriteLine("Ingrese las notas de cada alumno");

//tipo[] nombre = new tipo[tamanio]
int[] notas = new int[5];

//Recorremos el vector para cargar
for (int posicion = 0; posicion < 5; posicion++)
{
    Console.WriteLine($"Nota del alumno N° {posicion + 1}");
notas[posicion] = int.Parse(Console.Readline());
}

//