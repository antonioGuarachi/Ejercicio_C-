/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 10/6/2024
 * Hora: 17:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace InstitutoProy
{
	/// <summary>
	/// Description of Estudiante.
	/// </summary>
	public class Estudiante:Persona
	{
		private string Matricula;
		protected int Cant_materia;
		private Materia [] MA ;
		public Estudiante():base()
		{
			Matricula="12367abc";
			Cant_materia = 2;
			MA=new Materia[Cant_materia];
			for(int i=0;i<MA.Length;i++)
				MA[i]=new Materia();
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Estudiante--");
			Console.Write("\t Ingrese matricula : ");
			Matricula=Console.ReadLine();
			for(int i=0;i<MA.Length;i++)
				MA[i].leer();
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrando Datos de Estudiante--");
			Console.WriteLine("\n matricula = "+Matricula);
			for(int i=0;i<MA.Length;i++)
				MA[i].mostrar();
		}
		public string Matric{
			get{return Matricula;}
			set{Matricula = value;}
		}
		public Materia[]Mate{
			get{return MA;}
			set{MA=value;}
		}
		public void matriculaES(){
			Console.WriteLine("\n matricula = "+Matricula);
		}
		
	}
}
