/* var opcionElegida;
while (opcionElegida.toUpper() == "s")
{
    //borro la pantalla 
    console.clear();

    //pido el nombre de la persona 
    console.Writeline("!buenas¡ Ingrese su nombre :");
    var nombrePersona = console.Readline();
    //muestro el saludo
    //console.Writeline("¡hola! "  +  nombrePersona + "!") ;
    console.Writeline($"¡hola{nombrePersona}!");

    console.Writeline("¿Desea continuar? S para si, N para no.") ;
    opcionElegida =console.Readline();

}
//Alternativa con do-while(hacer mientras) */
var opcionElegida;
 do
 {
      //borro la pantalla 
    console.clear();

    //pido el nombre de la persona 
    console.Writeline("!buenas¡ Ingrese su nombre :");
    var nombrePersona = console.Readline();
    //muestro el saludo
    //console.Writeline("¡hola! "  +  nombrePersona + "!") ;
    console.Writeline($"¡hola{nombrePersona}!");
 } while (opcionElegida.toUpper() == "s");
{
    //borro la pantalla 
    console.clear();

    //pido el nombre de la persona 
    console.Writeline("!buenas¡ Ingrese su nombre :");
    var nombrePersona = console.Readline();
    //muestro el saludo
    //console.Writeline("¡hola! "  +  nombrePersona + "!") ;
    console.Writeline($"¡hola{nombrePersona}!");

    console.Writeline("¿Desea continuar? S para si, N para no.") ;
    opcionElegida =console.Readline();

}
if (opcionElegida.toUpper()=="N")
{
    console.Writeline("Programa finalizado correctamente");
}
else
{
    console.Writeline("Opcion no válida");
}
while (opcionElegida.toUpper() == "S");
{
    
}