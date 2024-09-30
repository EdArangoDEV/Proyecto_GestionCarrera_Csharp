
namespace GestionCarrera;

public class Curso
{

    protected int Codigo { get; set; }
    protected string Nombre { get; set; }
    protected int Creditos { get; set; }
    protected Horario Horario { get; set; }
    protected Profesor Prof_asignado { get; set; }
    protected int NextId { get; set; }

    public Curso(string nom, int cred, Horario horario, Profesor prof)
    {
        this.Codigo = NextId++;
        SetNombre(nom);
        SetCreditos(cred);
        this.Horario = horario;
        this.Prof_asignado = prof;
    }



    public override string ToString()
    {
        return this.Nombre;

    }

    // Metodos de acceso
    public string GetNombre()
    {
        return this.Nombre;
    }

    public void SetNombre(string nNombre)
    {
        if (nNombre.Length <= 4)
            Console.WriteLine("No se puede poner el Nombre del curso vacio o menor a 4 letras");
        else
            this.Nombre = nNombre;

    }

    public int GetCreditos()
    {
        return this.Creditos;
    }

    public void SetCreditos(int nCred)
    {
        if (nCred < 0)
            Console.WriteLine("se debe poner un valor a los creditos.");
        else
            this.Creditos = nCred;
    }

    public Horario GetHorario()
    {
        return this.Horario;
    }

    public string GetHora()
    {
        return "De " + this.Horario.GetHoraInicio() + " a " + this.Horario.GetHoraFin();
    }

    public void SetHorario(Horario horario)
    {
        int HoraI = horario.GetHoraInicio();
        int HoraF = horario.GetHoraFin();

        if (HoraI <= 0 && HoraF <= 0)
            Console.WriteLine("Se debe poner un valor a los horarios.");
        else
        {
            this.Horario.SetHoraInicio(HoraI);
            this.Horario.SetHoraFin(HoraF);
        }
    }


    public Profesor GetProfesor()
    {
        return this.Prof_asignado;
    }

}