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
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string nombreP;
		protected string apellidoP;
		protected int ci;
		protected string direccion;
		protected int  telefono;
		protected string nacionalidad;
		protected string fecha_nac;
		public Persona()
		{
			nombreP="Rosmery";
			apellidoP="Michel";
			ci=123456;
			direccion="Av. Alamos";
			telefono=1234567;
			nacionalidad="Chilena";
			fecha_nac="09-09-1987";
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Persona--");
			Console.Write("\t Ingrese Nombre :");
			nombreP=Console.ReadLine();
			Console.Write("\t Ingrese Apellido :");
			apellidoP=Console.ReadLine();
			Console.Write("\t Ingrese Ci :");
			ci=int.Parse(Console.ReadLine());
			Console.Write("\t Ingrese Direccion :");
			direccion=Console.ReadLine();
			Console.Write("\t Ingrese Telefono :");
			telefono=int.Parse(Console.ReadLine());
			Console.Write("\t Ingrese nacionalidad :");
			nacionalidad=Console.ReadLine();
			Console.Write("\t Ingrese Fecha de nacimiento :");
			fecha_nac=Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrando Datos de Persona--");
			Console.WriteLine("\t Nombre = "+nombreP);
			Console.WriteLine("\t  Apellido = "+apellidoP);
			Console.WriteLine("\t  Ci = "+ci);
			Console.WriteLine("\t  Direccion = "+direccion);
			Console.WriteLine("\t  Telefono = "+telefono);
			Console.WriteLine("\t nacionalidad = "+nacionalidad);
			Console.WriteLine("\t Fecha de nacimiento = "+fecha_nac);	
		}
		public string NombreP{
			get{return nombreP;}
			set{nombreP = value;}
		}
		public string ApellidoP{
			get{return apellidoP;}
			set{apellidoP = value;}
		}
		public int CI{
			get{return ci;}
			set{ci = value;}
		}
		public string Direccion{
			get{return direccion;}
			set{direccion = value;}
		}
		public int Telf{
			get{return telefono;}
			set{telefono = value;}
		}
		public string Nacionalidad{
			get{return nacionalidad;}
			set{nacionalidad = value;}
		}
		public string FechaNac{
			get{return fecha_nac;}
			set{fecha_nac = value;}
		}
		
		public void nombreEs(){
			Console.WriteLine("\n Nombre = "+nombreP);
			
		}
		public void mostrandodato(){
			Console.WriteLine("\n Nombre = "+nombreP);
			Console.WriteLine("\n  Telefono = "+telefono);
		}
	}
}
