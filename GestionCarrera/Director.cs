namespace GestionCarrera;
public class Director : Profesor
{
    public Director(int cod, string nom, string esp) : base(cod, nom, esp)
    {
    }

    public override string ToString()
    {
        return "Director " + base.ToString();
    }
}