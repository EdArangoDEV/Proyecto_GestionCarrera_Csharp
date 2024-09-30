namespace GestionCarrera;
public class Profesor : Empleado{

    public Profesor(int cod, string nom, string esp) : base(cod, nom, esp)
    {
    }

    public override string ToString()
    {
        return "Profesor " + base.ToString();
    }


}