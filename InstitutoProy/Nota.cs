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
	/// Description of Nota.
	/// </summary>
	public class Nota
	{
		private short nota1;
		private short nota2;
		private short nota3;
		private short nota_Ayudantia;
		private short notafinal;
		private string observacion;
		public Nota()
		{
			nota1=100;
			nota2=61;
			nota3=80;
			nota_Ayudantia=70;
			notafinal=50;
			observacion="ninguna";
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Notas--");
			Console.Write("\t Ingrese nota 1 : ");
			nota1=short.Parse(Console.ReadLine());
			Console.Write("\t Ingrese nota 2 : ");
			nota2=short.Parse(Console.ReadLine());
			Console.Write("\t Ingrese nota 3 : ");
			nota3=short.Parse(Console.ReadLine());
			Console.Write("\t Ingrese nota ayudantia :");
			nota_Ayudantia=short.Parse(Console.ReadLine());
			Console.Write("\t Ingrese nota final : ");
			notafinal=short.Parse(Console.ReadLine());
			Console.Write("\t Ingrese observacion : ");
			observacion=Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrando Datos de Notas--");
			Console.WriteLine("\n  nota 1 = "+nota1);
			Console.WriteLine("\n  nota 2 = "+nota2);
			Console.WriteLine("\n  nota 3 = "+nota3);
			Console.WriteLine("\n  nota ayudantia = "+nota_Ayudantia);
			Console.WriteLine("\n  nota final = "+notafinal);
			Console.WriteLine("\n  observacion  ="+observacion);	
		}
		public short Nota1{
			get{return nota1;}
			set{nota1 = value;}
		}
		public short Nota2{
			get{return nota2;}
			set{nota2 = value;}
		}
		public short Nota3{
			get{return nota3;}
			set{nota3 = value;}
		}
		public short NotaAyu{
			get{return nota_Ayudantia;}
			set{nota_Ayudantia = value;}
		}
		public short NotaFin{
			get{return notafinal;}
			set{notafinal = value;}
		}
		public string Obs{
			get{return observacion;}
			set{observacion = value;}
		}
		public void mostrandoNotafinal(){
			Console.WriteLine("\n  nota final = "+notafinal);
		}
		public void estobs(){
			Console.WriteLine("\n  observacion  ="+observacion);
		}
	}
}
