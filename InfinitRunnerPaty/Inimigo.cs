namespace InfinitRunnerPaty;

public class Inimigo
{
    Image ImageView;
    public Inimigo (Image a)
    {
        ImageView = a;
    }
    public void MoveX (double s)
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