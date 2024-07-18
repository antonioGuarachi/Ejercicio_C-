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
	/// Description of Catedratico.
	/// </summary>
	public class Catedratico:Persona
	{
		private string Cod_cate;
		private int item;
		private double sueldo;
		public Catedratico():base()
		{
			Cod_cate="123cat";
			item=224466;
			sueldo=7000;
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Catedratico--");
			Console.Write("\t Ingrese Codigo catedratico :");
			Cod_cate=Console.ReadLine();
			Console.Write("\t Ingrese item :");
			item=int.Parse(Console.ReadLine());
			Console.Write("\t Ingrese sueldo :");
			sueldo=double.Parse(Console.ReadLine());
			base.leer();
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrando Datos de Catedratico--");
			Console.WriteLine("\n Codigo catedratico = "+Cod_cate);
			Console.WriteLine("\n  item = "+item );
			Console.WriteLine("\n  sueldo = "+sueldo);
			base.mostrar();
		}
		public string CodCate{
			get{return Cod_cate;}
			set{Cod_cate = value;}
		}
		public int Item{
			get{return item;}
			set{item = value;}
		}
		public double Sueldo{
			get{return sueldo;}
			set{sueldo = value;}
		}
		public bool aumentarsueldo1(int x){
			if(item==x)
				return true;
			else 
				return false;
		}
	}
}
