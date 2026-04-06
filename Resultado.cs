using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ejercicios;

namespace ejercicios
{
    public class Resultado
    {
      public void MostrarMultijugadores(List<Videojuego> videojuegos)
        {
            var multijugador = videojuegos.Where(v => v.EsMultijugador);
            foreach (var juego in multijugador)
            {
                Console.WriteLine(juego.Nombre);
            }
        }
    }
}
public class ejercicio2
{
    public void MostrarEstudiantesAprobados(List<Estudiante> estudiantess)
{
   var aprobados = estudiantess.Where(e => e.Nota >= 3.0);

foreach (var estudiante in aprobados)
{
    Console.WriteLine($"{estudiante.Nombre} - {estudiante.Nota}");
}
}
}


public class ejercicio3
{
    public void MostrarNombresVideojuegos(List<Videojuego> videojuegos)
    {
        var nombres = videojuegos.Select(v => v.Nombre);
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}

public class ejercicio4
{
    public void MostrarNombresCurso(List<Estudiante> estudiantes)
    {
        var nombresCurso = estudiantes.Select(e => $"{e.Nombre} - {e.Curso}");
        foreach (var item in nombresCurso)
        {
            Console.WriteLine(item);
        }
    }
}

public class ejercicio5
{
    public void MostrarEquiposOrdenados(List<Equipo> equipos)
    {
        var equiposOrdenados = equipos.OrderBy(e => e.Puntos);
        foreach (var equipo in equiposOrdenados)
        {
            Console.WriteLine($"{equipo.Nombre} - {equipo.Puntos} puntos");
        }
    }
}


public class ejercicio6
{
    public void MostrarEstudiantesOrdenados(List<Estudiante> estudiantes)
    {
        var estudiantesOrdenados = estudiantes.OrderBy(e => e.Nota).ThenBy(e => e.Nombre);
        foreach (var estudiante in estudiantesOrdenados)
        {
            Console.WriteLine($"{estudiante.Nombre} - {estudiante.Nota}");
        }
    }
}

public class ejercicio7
{
    public void ContarVideojuegosPorPuntos(List<Videojuego> videojuegos)
    {
        int cantidad = videojuegos.Count(v => v.Puntos > 90);
        Console.WriteLine(cantidad);
    }
}

public class ejercicio8
{
    public void EquiposConMenosPuntos(List<Equipo> equipos)
    {
        bool existe = equipos.Any(e => e.Puntos < 10);
        Console.WriteLine(existe);
    }
} 

public class ejercicio9
{
    public void MejorEstudiante(List<Estudiante> estudiantes)
    {
        var mejor = estudiantes
    .OrderByDescending(e => e.Nota)
    .FirstOrDefault();

Console.WriteLine($"{mejor.Nombre} - {mejor.Nota}");
    }
}

public class ejercicio10
{
    public void EstudiantePorCurso(List<Estudiante> estudiantes)
    {
        var grupos = estudiantes.GroupBy(e => e.Curso);

        foreach (var grupo in grupos){
        Console.WriteLine($"Curso: {grupo.Key}");

        foreach (var estudiante in grupo){
        Console.WriteLine($" - {estudiante.Nombre}");
        }
        
        }
    }
}

public class Todo
{
    public void TodoJunto (List<Videojuego> videojuegos, List<Estudiante> estudiantes, List<Equipo> equipos)
    {
        var resultado = equipos
    .Where(e => e.GolesFavor > e.GolesContra)
    .OrderByDescending(e => e.Puntos)
    .Select(e => new
    {
        e.Nombre,
        DiferenciaGol = e.GolesFavor - e.GolesContra
    });

foreach (var item in resultado)
{
    Console.WriteLine($"{item.Nombre} - DG: {item.DiferenciaGol}");
}
    }
}