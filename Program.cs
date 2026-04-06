using System;
using System.Collections.Generic;
using System.Linq;
using ejercicios;



var videojuegos = new List<Videojuego>
{
    new Videojuego { Nombre = "Minecraft", Genero = "Sandbox", Puntos = 95, EsMultijugador = true },
    new Videojuego { Nombre = "FIFA", Genero = "Deportes", Puntos = 88, EsMultijugador = true },
    new Videojuego { Nombre = "Celeste", Genero = "Plataformas", Puntos = 92, EsMultijugador = false },
    new Videojuego { Nombre = "Mario Kart", Genero = "Carreras", Puntos = 90, EsMultijugador = true },
    new Videojuego { Nombre = "Hollow Knight", Genero = "Aventura", Puntos = 94, EsMultijugador = false }
};

var estudiantes = new List<Estudiante>
{
    new Estudiante { Nombre = "Ana", Edad = 12, Nota = 4.8, Curso = "6A" },
    new Estudiante { Nombre = "Luis", Edad = 13, Nota = 3.2, Curso = "6A" },
    new Estudiante { Nombre = "Marta", Edad = 12, Nota = 4.5, Curso = "6B" },
    new Estudiante { Nombre = "Carlos", Edad = 14, Nota = 2.9, Curso = "6B" },
    new Estudiante { Nombre = "Sofía", Edad = 13, Nota = 5.0, Curso = "6A" }
};

var equipos = new List<Equipo>
{
    new Equipo { Nombre = "Tigres FC", Puntos = 15, GolesFavor = 12, GolesContra = 6 },
    new Equipo { Nombre = "Leones FC", Puntos = 22, GolesFavor = 18, GolesContra = 10 },
    new Equipo { Nombre = "Águilas FC", Puntos = 19, GolesFavor = 10, GolesContra = 5 },
    new Equipo { Nombre = "Toros FC", Puntos = 8, GolesFavor = 6, GolesContra = 14 }
};


// Mostrar videojuegos multijugador
Console.WriteLine("=== VIDEOJUEGOS MULTIJUGADOR ===");
var resultado1 = new Resultado();
resultado1.MostrarMultijugadores(videojuegos);


// Mostrar estudiantes aprobados
Console.WriteLine("\n=== ESTUDIANTES APROBADOS ===");
var resultado2 = new ejercicio2();
resultado2.MostrarEstudiantesAprobados(estudiantes);

//Obtener solo los nombres de los videojuegos
Console.WriteLine("\n === NOMBRES DE VIDEOJUEGOS ===");
var resultado3 = new ejercicio3();
resultado3.MostrarNombresVideojuegos(videojuegos);

//Mostrar nombre y curso de cada estudiante
Console.WriteLine("\n=== NOMBRE Y CURSO DE CADA ESTUDIANTE ===");
var resultado4 = new ejercicio4();
resultado4.MostrarNombresCurso(estudiantes);

//Ordenar equipos por puntos
Console.WriteLine("\n=== EQUIPOS ORDENADOS POR PUNTOS ===");
var resultado5 = new ejercicio5();
resultado5.MostrarEquiposOrdenados(equipos);

//Ordenar estudiantes por nota y luego por nombre
Console.WriteLine("\n=== ESTUDIANTES ORDENADOS POR NOTA Y NOMBRE ===");
var resultado6 = new ejercicio6();
resultado6.MostrarEstudiantesOrdenados(estudiantes);

//Contar cuántos videojuegos tienen más de 90 puntos
Console.WriteLine("\n=== VIDEOJUEGOS CON MÁS DE 90 PUNTOS ===");
var resultado7 = new ejercicio7();
resultado7.ContarVideojuegosPorPuntos(videojuegos);

// Revisar si existe algún equipo con menos de 10 puntos

Console.WriteLine("\n=== EQUIPOS CON MENOS DE 10 PUNTOS ===");
var resultado8 = new ejercicio8();
resultado8.EquiposConMenosPuntos(equipos);

//Buscar el mejor estudiante
Console.WriteLine("\n=== MEJOR ESTUDIANTE ===");
var resultado9 = new ejercicio9();
resultado9.MejorEstudiante(estudiantes);

//Agrupar estudiantes por curso
Console.WriteLine("\n=== ESTUDIANTES AGRUPADOS POR CURSO ===");
var resultado10 = new ejercicio10();
resultado10.EstudiantePorCurso(estudiantes);