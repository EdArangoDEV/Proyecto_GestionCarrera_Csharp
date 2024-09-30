namespace GestionCarrera;
public class Horario
{
    protected int Codigo { get; set; }
    protected string Dia { get; set; }
    protected int HoraInicio { get; set; }
    protected int HoraFin { get; set; }
    static int NextId = 101;

    public Horario(string dia, int horaI, int horaF)
    {
        this.Codigo = NextId++;
        SetDia(dia);
        this.HoraInicio = horaI;
        this.HoraFin = horaF;

    }

    public class DiaSemana
    {
        static string[] Dias = {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"
        };

        public static string[] GetDias()
        {
            return Dias;
        }
    }

    public override string ToString()
    {
        return "Horario: " + this.Dia + " de " + this.HoraInicio + " a " + this.HoraFin;
    }

    // Metodos de acceso
    public string GetDia()
    {
        return this.Dia;
    }

    public void SetDia(string nDia)
    {
        if (nDia.Length <= 0)
            Console.WriteLine("No se poner un dia vacio o nulo");
        else
        {
            Boolean Encontrado = false;
            string d = "";

            foreach (string dia in DiaSemana.GetDias())
            {
                if (dia.ToUpper().Equals(nDia.ToUpper()))
                {
                    Encontrado = true;
                    d = dia;
                    break;
                }
            }

            if (!Encontrado)
                Console.WriteLine("No se puede poner un dia incorrecto: " + nDia);
            else
                this.Dia = d;
        }
    }

}