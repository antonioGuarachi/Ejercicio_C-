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
	/// Description of Carrera.
	/// </summary>
	public class Carrera
	{
		private string nombre;
		protected int Cant_sem;
		private Semestre[]SE;
		
		public Carrera(Semestre se)
		{
			nombre="Gastronomia";
			Cant_sem=1;
			SE=new Semestre[Cant_sem];
			for(int i=0;i<SE.Length;i++){
				SE[i]=se;
			}
		}
		public void leer(){
			Console.WriteLine("\n--Datos de Carrera--");
			Console.Write("\t Ingrese nombre de carrera : ");
			nombre=Console.ReadLine();
			for(int i=0;i<SE.Length;i++){
				SE[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("\n--Mostrando Datos de Carrera--");
			Console.Write("\t nombre de carrera : "+nombre );
			for(int i=0;i<SE.Length;i++){
				SE[i].mostrar();
			}
		}
		public void setNombreCarrera(string nombre){
			this.nombre=nombre;
		}
		public Semestre[] getSEMESTRE(){
			return SE;
		}
		//B) Cuantas personas son de nacionalidad x mostrar su nombre y telefono
		//1ra. Forma
		public void ContarNacionalidad(){
			Console.Write("\n Intro nacionalidad :");
			string x = Console.ReadLine().ToLower();
			int contador=0;
			for(int i=0;i<Cant_sem;i++){
				for(int j=0;j<SE[i].CAT.Length;j++)
					if(SE[i].CAT[j].Nacionalidad.ToLower().Equals(x)){
					SE[i].CAT[j].mostrandodato();
					contador++;
				}
			}				
			for(int i=0;i<Cant_sem;i++)
				for(int j=0;j<SE[i].EST.Length;j++)
					if(SE[i].EST[j].Nacionalidad.ToLower().Equals(x)){
					SE[i].EST[j].mostrandodato();
					contador++;
			}
					
				Console.WriteLine("\nCantidad de nacionalida " +x+ "   ES : "+contador);
				
		}
		
		//C) Buscar al estdiante con ci "x" y mostrar la nota final de la materia "Y"
			//1ra. Forma 
		public void buscarEstudiante(){
			Console.Write("\n Intro ci de estudiante :");
			int x =int.Parse(Console.ReadLine());
			Console.Write("\n Intro materia a buscar :");
			string y = Console.ReadLine();
			for(int i=0;i<SE.Length;i++)
				for(int j=0;j<SE[i].EST.Length;j++)
					for(int k=0;k<SE[i].EST[j].Mate.Length;k++)
					if(SE[i].EST[j].CI.Equals(x)&&SE[i].EST[j].Mate[k].NombreMat.ToLower().Equals(y.ToLower()))
							SE[i].EST[j].Mate[k].NOT.mostrandoNotafinal();
		}
		//D) Existe un error en la segunda nota  del estudiante  con ci "x" corregir ese erroe por "y" luego mostrar datos actualizados
		//1ra. Forma 
		public void cambiarNota(){
			Console.Write("\n Intro ci de estudiante :");
			int x =int.Parse(Console.ReadLine());
			
			for(int i=0;i<SE.Length;i++)
				for(int j=0;j<SE[i].EST.Length;j++)
					for(int k=0;k<SE[i].EST[j].Mate.Length;k++)
					if(SE[i].EST[j].CI.Equals(x)){
				Console.Write("\n Intro nueva nota 2 :");
				SE[i].EST[j].Mate[k].NOT.Nota2=short.Parse(Console.ReadLine());
					SE[i].EST[j].Mate[k].mostrar();
			}
			
		}
		//E)Si el catedratico con item "x" es de nacionalidad "y" adicionar el 20% mas al sueldo, mostrar datos actualizados
		//1ra. Forma
		public void Aumentosueldo(){
			Console.Write("\n Intro item de catedratico :");
			int x =int.Parse(Console.ReadLine());
			Console.Write("\n Intro nacionalidad  :");
			string y = Console.ReadLine().ToLower();
			for(int i=0;i<SE.Length;i++)
				for(int j=0;j<SE[i].CAT.Length;j++)
					if(SE[i].CAT[j].Item.Equals(x)&SE[i].CAT[j].Nacionalidad.ToLower().Equals(y)){
				SE[i].CAT[j].Sueldo=SE[i].CAT[j].Sueldo*0.2;
				SE[i].CAT[j].mostrar();
			}			
		}
		//F)Buscar a los estudiantes del periodo semestral "x" y que pertenezca a la materia "y" mostrar su nombre matricula y observacion de la nota
		//1ra. Forma 
		public void EstuSemestrales(){
			Console.Write("\n Intro periodo semestral :");
			string x = Console.ReadLine();
			Console.Write("\n Intro materia a buscar :");
			string y = Console.ReadLine();
			for(int i=0;i<SE.Length;i++)
				for(int j=0;j<SE[i].EST.Length;j++)
						for(int l=0;l<SE[i].EST[j].Mate.Length;l++)
							if(SE[i].Periodo.ToLower().Equals(x.ToLower())&
							   SE[i].EST[j].Mate[i].NombreMat.ToLower().Equals(y.ToLower())){
								SE[i].EST[j].nombreEs();
								SE[i].EST[j].matriculaES();
								SE[i].EST[j].Mate[l].NOT.estobs();
			}
		}
	}
}
