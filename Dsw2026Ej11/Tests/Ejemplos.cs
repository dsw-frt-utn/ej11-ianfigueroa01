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
        Console.WriteLine("=== EJEMPLO DICTIONARY ===");
        CasoDictionary casoDict = new CasoDictionary();

        Alumno a1 = new Alumno(101, "Lautaro Martinez", 7.8);
        Alumno a2 = new Alumno(102, "Exequiel Palacios", 8.4);
        Alumno a3 = new Alumno(103, "Ian Figueroa", 9.5);

        casoDict.AgregarAlumno(a1.Id, a1);
        casoDict.AgregarAlumno(a2.Id, a2);
        casoDict.AgregarAlumno(a3.Id, a3);

        Console.WriteLine("\n--- LISTAR ALUMNOS EN DICCIONARIO ---");
        foreach (Alumno a in casoDict.RetornarDiccionario().Values)
        {
            Console.WriteLine($"Legajo: {a.Id} -> Alumno: {a.Nombre} - Promedio: {a.Promedio}");
        }

        Console.WriteLine("\n--- BUSCAR CLAVE EXISTENTE [102] ---");
        Alumno alumnoClaveOk = casoDict.BuscarAlumnoPorClave(102);
        Console.WriteLine(alumnoClaveOk != null ? $"Legajo: {alumnoClaveOk.Id} -> Alumno: {alumnoClaveOk.Nombre} - Promedio: {alumnoClaveOk.Promedio}" : "Alumno buscado no existe");

        Console.WriteLine("\n--- BUSCAR CLAVE INEXISTENTE [999] ---");
        Alumno alumnoClaveFalsa = casoDict.BuscarAlumnoPorClave(999);
        Console.WriteLine(alumnoClaveFalsa != null ? $"Legajo: {alumnoClaveFalsa.Id} -> Alumno: {alumnoClaveFalsa.Nombre} - Promedio: {alumnoClaveFalsa.Promedio}" : "Alumno buscado no existe");

        Console.WriteLine("\n--- ELIMINAR ALUMNO CON CLAVE [101] Y LISTAR ---");
        casoDict.EliminarPorClave(101);
        foreach (Alumno a in casoDict.RetornarDiccionario().Values)
        {
            Console.WriteLine($"Legajo: {a.Id} -> Alumno: {a.Nombre}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        List<Libro> listaDeLibros = Libro.CrearLista();
        CasoLinq casoLinq = new CasoLinq(listaDeLibros);

        Console.WriteLine($"PRIMER LIBRO: {casoLinq.GetPrimero()?.Titulo} - ID: {casoLinq.GetPrimero()?.Id}\n");

        Console.WriteLine($"ULTIMO LIBRO: {casoLinq.GetUltimo()?.Titulo} - ID: {casoLinq.GetUltimo()?.Id}\n");

        Console.WriteLine($"TOTAL DE PRECIOS: {casoLinq.GetTotalPrecios():C}\n");

        Console.WriteLine($"PROMEDIO PRECIOS: {casoLinq.GetPromedioPrecios():C}\n");

        Console.WriteLine("LIBROS CON ID MAYOR A 15:");
        IEnumerable<Libro> librosMayores15 = casoLinq.GetListById();
        foreach (Libro l in librosMayores15)
        {
            Console.WriteLine($"   - ID: {l.Id} | Título: {l.Titulo}");
        }

        Console.WriteLine("\nLIBROS CON FORMATO: ");
        IEnumerable<string> librosFormato = casoLinq.GetLibros();
        foreach (string l in librosFormato)
        {
            Console.WriteLine(l);
        }

        Libro masCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"\nLIBRO MÁS CARO: {masCaro?.Titulo} ({masCaro?.Precio:C}) - ID: {masCaro.Id}\n");

        Libro masBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"LIBRO MÁS BARATO: {masBarato?.Titulo} ({masBarato?.Precio:C}) - ID: {masBarato.Id}\n");

        Console.WriteLine("LIBROS CON PRECIO MAYOR AL PROMEDIO:");
        IEnumerable<Libro> sobrePromedio = casoLinq.GetMayorPromedio();

        foreach (Libro l in sobrePromedio)
        {
            Console.WriteLine($"   - {l.Titulo} ({l.Precio:C})");
        }

        Console.WriteLine("\nLIBROS ORDENADOS DE FORMA DESCENDENTE:");
        IEnumerable<Libro> ordenadosDesc = casoLinq.GetLibrosOrdenadosDesc();
        foreach (Libro l in ordenadosDesc)
        {
            Console.WriteLine($"   - {l.Titulo}");
        }
    }
}
