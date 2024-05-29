public class Tarea
{
    private int id;
    private string descripcion;
    private int duracion;

    public Tarea(int id, string descripcion, int duracion)
    {
        this.Id = id;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
    }

    public int Id { get => id; set => id = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    public void Mostrar()
    {
        System.Console.WriteLine("Tarea " + Id);
        System.Console.WriteLine("Descripcion: " + Descripcion);
        System.Console.WriteLine("Duracion: " + Duracion + " minutos");
        System.Console.WriteLine();
    }
}