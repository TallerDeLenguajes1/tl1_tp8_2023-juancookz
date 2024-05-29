using System.Collections.Generic;
using System.ComponentModel.Design;
List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();
Random rnd = new Random();
for (int i = 1; i < 11; i++)
{
    Tarea tarea = new Tarea(i, "Esta es la descripcion de la tarea " + i, rnd.Next(10, 100));
    TareasPendientes.Add(tarea);
}
int menu = 0;
while (menu != 3)
{
    Console.Clear();
    System.Console.WriteLine("Menu Tareas");
    System.Console.WriteLine("[1] Mover las tareas pendientes a realizadas");
    System.Console.WriteLine("[2] Buscar tareas pendientes por descripción");
    System.Console.WriteLine("[3] SALIR");
    int.TryParse(Console.ReadLine(), out menu);
    switch (menu)
    {
        case 1:
            break;
        case 2:
            System.Console.WriteLine(BuscarTarea(TareasPendientes, Console.ReadLine()).Id);
            break;
        case 3:
            break;
        default:
            System.Console.WriteLine("Opcion invalida.");
            break;
    }
}
Tarea BuscarTarea(List<Tarea> tareas, string descripcion)
{
    foreach (var tarea in tareas)
    {
        if (tarea.Descripcion.Contains(descripcion))
        {
            return tarea;
        }
    }
    return null;
}