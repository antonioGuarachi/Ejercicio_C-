/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 10/6/2024
 * Hora: 17:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace InstitutoProy
{
	/// <summary>
	/// Description of Materia.
	/// </summary>
	public class Materia
	{
		private string nombreM;
		private string sigla;
		Nota NO =new Nota();
		public Materia()
		{
			nombreM="Quimica";
			sigla="Est-009";
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Materia--");
			Console.Write("\t Ingrese Nombre de materia : ");
			nombreM=Console.ReadLine();
			Console.Write("\t Ingrese sigla : ");
			sigla=Console.ReadLine();
			NO.leer();
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrando Datos de Materia--");
			Console.WriteLine("\n  materia = "+nombreM);
			Console.WriteLine("\n  sigla = "+sigla);
			NO.mostrar();
		}
		public string NombreMat{
			get{return nombreM;}
			set{nombreM = value;}
		}
		public string Sigla{
			get{return sigla;}
			set{sigla = value;}
		}
		public Nota NOT{
			get{return NO;}
			set{NO=value;}
		}	
	}
}
