using System.Diagnostics.Contracts;

namespace GestionCarrera;
public class Carrera{

    protected int Codigo { get; set; }
    protected string Nombre { get; set; }
    protected string Descripcion { get; set; }
    protected int Duracion { get; set; }
    protected List<Semestre> Semestres { get; set; }
    protected Director Director { get; set; }

    public Carrera(int Cod, string Nom, string Desc, int Duracion, Director Dir)
    {
        this.Codigo = Cod;
        this.Nombre = Nom;
        this.Descripcion = Desc;
        this.Duracion = Duracion;
        this.Semestres = new List<Semestre>();
        this.Director = Dir;
    }

    public override string ToString()
    {
        return $"Carrera {this.Nombre}, descripción: {this.Descripcion}, con duración de: {this.Duracion} semestres y Director: {this.Director}";
    }

    //Metodos de Acceso
    public string GetNombre(){
        return this.Nombre;
    }

    public void SetNombre(string nNombre){
        if (nNombre.Length <= 5)
            Console.WriteLine("No se puede poner el Nombre de la carrera vacio o menor a 5 letras");
        else
            this.Nombre = nNombre;
    }

    public string GetDescripcion(){
        return this.Descripcion;
    }

    public void SetDescripcion(string nDesc){
        if (nDesc.Length <= 5)
            Console.WriteLine("No se puede poner la Descripcion de la carrera vacio o menor a 5 letras");
        else
            this.Descripcion = nDesc;
    }

    public int GetDuracion(){
        return this.Duracion;
    }

    public void SetDuracion(int Dur){
        if (Dur < 1 || Dur > 10)
            Console.WriteLine("No se puede poner una duracion de carrera menor a 1 0 mayor a 11 semestres");
        else
            this.Duracion = Dur;
    }

    public List<Semestre> GetSemestres(){
        return this.Semestres;
    }


    public void GetInfoSemestres(){
        string Resultado = "No hay semestres en la carrera";
        
        if (this.Semestres == null)
            Console.WriteLine(Resultado);
        else
        {
            Console.WriteLine($"La carrera: {GetNombre()}, tiene los siguientes semestres:");
            this.Semestres.ForEach(Semestre => {Console.WriteLine($"\nSemestre {Semestre.GetNumero()}");
            });
        }
    }

    public void AgregarSemestres(){
        for (int i = 1; i < this.Duracion + 1; i++)
        {
            Semestre semestre = new Semestre(i);
            this.Semestres.Add(semestre);
        }
    }

    public Director GetDirector(){
        return this.Director;
    }

    public void SetDirector(Director director){
        this.Director = director;
    }

    public Profesor GetProfesores(int cod){
        Profesor p = null;

        foreach (Semestre semestre in this.Semestres)
        {
            p = semestre.BusquedaProfesor(cod);

            if (p != null)
            {
                if (p.GetCodigo().Equals(cod))
                {
                    return p;
                }
            }
        }
        return p;
    }

    
}