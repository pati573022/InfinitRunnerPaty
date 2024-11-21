namespace InfinitRunnerPaty;

{
    List <Inimigo> inimigos= new List <Inimigo> ();
    Inimigo atual = null;
    double minX=0;
    public Inimigos (double a)
    {
        minX = a;
    }
    public void Add (Inimigo a)
    {
        Inimigos.Add (a);
        if (atual==null)
        atual= a;
        Iniciar();
    }
    public void Iniciar ();
    {
        foreach(var e in inimigos)
        e.Reset();
    }
  
}
