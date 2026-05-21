using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Console.WriteLine("=== EJEMPLO LIST ===");
        CasoList casoList = new CasoList();

        Alumno a1 = new Alumno(1, "Ian Figueroa", 8);
        Alumno a2 = new Alumno(2, "Enzo Perez", 6);
        Alumno a3 = new Alumno(3, "Julian Alvarez", 10);

        casoList.AgregarAlumno(a1);
        casoList.AgregarAlumno(a2);
        casoList.AgregarAlumno(a3);

        Console.WriteLine("\n--- LISTAR ALUMNOS ---");

        foreach(Alumno a in casoList.RetornarAlumno())
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\n--- BUSCANDO ALUMNO Ian Figueroa ---");

        Alumno alumnoExistente = casoList.BuscarAlumno("Ian Figueroa");
        Console.WriteLine(alumnoExistente != null ? alumnoExistente.ToString() : "Alumno buscado no existe");

        Console.WriteLine("\n--- BUSCANDO ALUMNO Lionel Messi ---");

        Alumno alumnoInexistente = casoList.BuscarAlumno("Lionel Messi");
        Console.WriteLine(alumnoInexistente != null ? alumnoInexistente.ToString() : "Alumno buscado no existe");

        Console.WriteLine("\n--- ELIMINAR ALUMNO Enzo Perez Y LISTAR ---");
        casoList.EliminarAlumno(a2);
        foreach (Alumno a in casoList.RetornarAlumno())
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("\n--- ELIMINAR ALUMNO EN PRIMER POSICIÓN Y LISTAR ---");
        casoList.EliminarAlumno(0);
        foreach (Alumno a in casoList.RetornarAlumno())
        {
            Console.WriteLine(a);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
