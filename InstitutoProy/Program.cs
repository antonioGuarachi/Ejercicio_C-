/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 10/6/2024
 * Hora: 17:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace InstitutoProy
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Catedratico CA = new Catedratico();
			Estudiante E = new Estudiante();
			Semestre S = new Semestre(CA,E);
			Carrera C=new Carrera(S);
			//C.leer();
			//C.mostrar();
			//B) Cuantas personas son de nacionalidad x mostrar su nombre y telefono
			//1ra. Forma
			//C.ContarNacionalidad();
			//C) Buscar al estdiante con ci "x" y mostrar la nota final de la materia "Y"
			//1ra. Forma 
			//C.buscarEstudiante();
			//D) Existe un error en la segunda nota  del estudiante  con ci "x" corregir ese erroe
			//por "y" luego mostrar datos actualizados
			//1ra. Forma 
			//C.cambiarNota();
			//E) Si el catedratico con item "x" es de nacionalidad "y" adicionar
			//el 20% mas al sueldo, mostrar datos actualizados
			//1ra. Forma 
			//C.Aumentosueldo();
			//F)Buscar a los estudiantes del periodo semestral "x" y que pertenezca a la materia "y" 
			//mostrar su nombre matricula y observacion de la nota
			//1ra. Forma 
			C.EstuSemestrales();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}