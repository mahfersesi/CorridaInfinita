using FFImageLoading.Maui;
using Microsoft.Maui.Platform;
namespace CorridaInfinita;

    public class Inimigos
{
    List<Inimigo> inimigos=new List<inimigo>();
    inimigo atual=null;
    double minX=0;
    public Inimigos (double a)
    {
        minX=a;
    }
    public void Add(inimigo a)
    {
        inimigos.Add(a);
        if (atual==null)
            atual=a;
            Iniciar();
    }
    public void Iniciar()
    {
        foreach(var e in inimigos)
                e.Reset();
    }
}