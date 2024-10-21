public class NodoLista
{
    
    public int DNI { get; set; }
    public bool Cliente { get; set; }
    public string Nombre { get; set; }
    public NodoLista Siguiente { get; set; }

    
    public NodoLista(int dni, string nombre)
    {
        DNI = dni;
        Nombre = nombre; 
        Cliente = false; 
        Siguiente = null; 
    }
}