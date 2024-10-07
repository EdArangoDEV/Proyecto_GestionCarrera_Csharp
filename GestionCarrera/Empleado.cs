namespace GestionCarrera;

public class Empleado{

    protected int Codigo { get; set; }   
    protected string Nombre  { get; set; }
    protected string Especialidad { get; set; }


    public Empleado(int cod, string nom, string esp)
    {
        this.Codigo = cod;
        SetNombre(nom);
        SetEspecialidad(esp);
    }

    public override string ToString(){
        return this.Nombre;
        // return "Empleado " + this.Nombre + " con especialidad " + this.Especialidad;
    }

    // Metodos de Acceso
    public int GetCodigo(){
        return this.Codigo;
    }

    public void SetCodigo(int cod){
        this.Codigo = cod;
    }

    public string GetNombre(){
        return this.Nombre;
    }

    public void SetNombre(string nNombre){
        if (nNombre.Length <= 2)
        {
            Console.WriteLine("No se puede poner el Nombre vacio o menor a 2 letras\n");
        } else
        {
            this.Nombre = nNombre;
        }
    }

    public string GetEspecialidad(){
        return this.Especialidad;
    }

    public void SetEspecialidad(string especialidad){
        if (especialidad.Length <= 2)
        {
            Console.WriteLine("No se puede poner especialidad vacio o menor a 2 letras\n");
        } else
        {
            this.Especialidad = especialidad;
        }
    }

}