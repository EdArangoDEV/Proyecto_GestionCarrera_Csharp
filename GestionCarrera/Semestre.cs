namespace GestionCarrera;

public class Semestre{

    protected int Codigo { get; set; }
    protected int Numero { get; set; }
    protected List<Curso> Cursos { get; set; }


    public override string ToString()
    {
        return "El semestre nuero: " + this.Numero;
    }


    // Metodos de acceso
    public int GetNumero(){
        return this.Numero;
    }

    public void SetNumero(int nNumero){
        if (nNumero <= 0)
            Console.WriteLine("No se puede poner un numero de semestre menor a 1 o mayor a la duracion de la carrera.");
        else
        {
            this.Numero = nNumero;
            SetCodigo(nNumero);
        }      
    }

    protected void SetCodigo(int numero){
        string cod = "";
        string n = numero.ToString();
        cod = "10" + n;

        this.Codigo = int.Parse(cod);
    }


    
}