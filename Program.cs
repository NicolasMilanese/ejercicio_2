using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;

            string alumnos;
            int publico,privado,alumno,porcentaje1,porcentaje2;

            alumnos="publico";
            alumnos="privado";
            alumnos="salir";
            publico=0;
            privado=0;
            alumno=0;
            porcentaje1=0;
            porcentaje2=0;

Console.WriteLine("ingrese publico o privado si es que va a algun colegio de estos");
 Console.WriteLine("Si desea salir ingrese salir");  
        
 while (alumnos=="publico"||alumnos=="privado"||alumnos=="salir")
{
        
alumnos=Console.ReadLine();
 if (alumnos=="publico")
{
alumno=alumno+1;
publico=publico+1;
                    
}
if (alumnos=="privado")
{
alumno=alumno+1;
privado=privado+1;
}

if (alumnos=="salir")
{
Console.WriteLine("saliendo del sistema");
Console.ReadKey();
}
 
}
             
porcentaje1=(publico*100)/alumno;
porcentaje2=(privado*100)/alumno;
          
Console.WriteLine("el total de alumnos son " + alumno);
Console.WriteLine("el total de colegios publicos son " + publico);
Console.WriteLine("el total de colegios privados son " + privado);
Console.WriteLine("el porcentaje de alumnos en el colegio publico es de " + porcentaje1);
Console.WriteLine("el porcentaje de alumnos en el colegio privado es de " + porcentaje2);
          
        }
    }
}
