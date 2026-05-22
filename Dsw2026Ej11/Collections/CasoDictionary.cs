using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _diccionarioAlumnos = new Dictionary<int, Alumno>();

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        _diccionarioAlumnos.Add(legajo, alumno);
    }

    public Alumno BuscarAlumnoPorClave(int legajo)
    {
        if (_diccionarioAlumnos.ContainsKey(legajo))
        {
            return _diccionarioAlumnos[legajo];
        }

        return null;
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return _diccionarioAlumnos;
    }

    public void EliminarPorClave(int legajo)
    {
        _diccionarioAlumnos.Remove(legajo);
    }
}
