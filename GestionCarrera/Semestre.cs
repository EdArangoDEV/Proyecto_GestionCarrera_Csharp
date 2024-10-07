using System.Reflection.Metadata;

namespace GestionCarrera;

public class Semestre
{

    protected int Codigo { get; set; }
    protected int Numero { get; set; }
    protected List<Curso> Cursos { get; set; }

    public Semestre(int Num)
    {
        SetNumero(Num);
        this.Cursos = new List<Curso>();
    }


    public override string ToString()
    {
        return "El semestre nuero: " + this.Numero;
    }


    // Metodos de acceso
    public int GetNumero()
    {
        return this.Numero;
    }

    public void SetNumero(int nNumero)
    {
        if (nNumero <= 0)
            Console.WriteLine("No se puede poner un numero de semestre menor a 1 o mayor a la duracion de la carrera.");
        else
        {
            this.Numero = nNumero;
            SetCodigo(nNumero);
        }
    }

    private void SetCodigo(int numero)
    {
        string cod = "";
        string n = numero.ToString();
        cod = "10" + n;

        this.Codigo = int.Parse(cod);
    }
    
    public List<Curso> GetListCursos(){
        return this.Cursos;
    }

    public bool GetCursos()
    {
        string resultado = "\tNo tiene cursos.";
        bool b = false;

        if (this.Cursos.Count == 0)
        {
            Console.WriteLine(resultado);
            return b;
        }
        else
        {
            int[] i = [1];
            this.Cursos.ForEach(curso =>
            {
                Console.WriteLine($"\t {i[0]}. curso: {curso.GetNombre()} con {curso.GetHorario()} y Profesor: {curso.GetProfesor()}.");
                i[0]++;
            });
            b = true;
            return b;
        }
    }


    public void AgregarCurso(Curso c)
    {
        this.Cursos.Add(c);
        Console.WriteLine("Se agrego el curso: " + c.GetNombre() + " al semestre numero " + this.GetNumero() + "\n");
    }

    public void EliminarCurso(Curso c)
    {
        this.Cursos.Remove(c);
        Console.WriteLine("Se elimino el curso: " + c.GetNombre() + " con " + c.GetHorario() + "\n");
    }


    public Profesor BusquedaProfesor(int cod)
    {
        Profesor p = null;

        if (this.Cursos.Count != 0)
        {
            foreach (Curso curso in this.Cursos)
            {
                if (curso.GetProfesor().GetCodigo().Equals(cod))
                {
                    p = curso.GetProfesor();
                    return p;
                }
            }
        }
        return p;
    }



}