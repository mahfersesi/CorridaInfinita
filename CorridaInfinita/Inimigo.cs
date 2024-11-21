using FFImageLoading.Maui;
using Microsoft.Maui.Platform;
namespace CorridaInfinita;

public class inimigo 
{
    Image ImageView;
    public inimigo(Image a)
    {
        ImageView=a;
    }
    public void MoveX(double s)
    {
        ImageView.TranslationX -=s;
    }
    public double GetX()
    {
        return ImageView.TranslationX;
    }
    public void Reset()
    {
        ImageView.TranslationX=500;
    }
}