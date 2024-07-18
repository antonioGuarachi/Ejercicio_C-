/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 10/6/2024
 * Hora: 17:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace InstitutoProy
{
	/// <summary>
	/// Description of Semestre.
	/// </summary>
	public class Semestre
	{
		private string periodo;
		protected int cant_catedratico;
		protected int cant_estudiantes;
		private Catedratico[]CA;
		private Estudiante[]ES;
		public Semestre(Catedratico ca, Estudiante es)
		{
			periodo="Segundo";
			cant_catedratico=2;
			CA=new Catedratico[cant_catedratico];
			for(int i=0;i<CA.Length;i++){
				CA[i]=ca;
			}
			cant_estudiantes=3;
			ES=new Estudiante[cant_estudiantes];
			for(int i=0;i<ES.Length;i++){
				ES[i]=es;
			}
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Semestre--");
			Console.Write("\t Ingrese periodo : ");
			periodo=Console.ReadLine();
			for(int i=0;i<CA.Length;i++){
				CA[i].leer();
			}
			for(int i=0;i<ES.Length;i++){
				ES[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrar Datos de Semestre--");
			Console.Write("\n periodo = "+periodo);
			for(int i=0;i<CA.Length;i++){
				CA[i].mostrar();
			}
			for(int i=0;i<ES.Length;i++){
				ES[i].mostrar();
			}
		}
		public string Periodo{
			get{return periodo;}
			set{periodo = value;}
		}
		public Catedratico[]CAT{
			get{return CA;}
			set{CA=value;}
		}
		public Estudiante[]EST{
			get{return ES;}
			set{ES=value;}
		}
	}
}
