namespace InfinitRunnerPaty;

public partial class MainPage : ContentPage
{
	Player player;
	bool estaMorto = false;
	bool estaPulando = false;
	const int tempoEntreFrames = 25;
	int velocidade1 = 0;
	int velocidade2 = 0;
	int velocidade3 = 0;
	int velocidade = 0;
	int larguraJanela = 0;
	int alturaJanela = 0;
	

	public MainPage()
	{
		InitializeComponent();
		player=new Player (imgPlayer);
		player.Run();
	}


	protected override void OnSizeAllocated(double w, double h)
	{
		base.OnSizeAllocated(w, h);
		CorrigeTamanhoCenario(w, h);
		CalculaVelocidade(w);
	}
	void CalculaVelocidade(double w)
	{
		velocidade1 = (int)(w * 0.001);
		velocidade2 = (int)(w * 0.004);
		velocidade3 = (int)(w * 0.008);
		velocidade = (int)(w * 0.001);

	}
	void CorrigeTamanhoCenario(double w, double h)
	{
		foreach (var a in HSLayer1.Children)
			(a as Image).WidthRequest = w;
		foreach (var a in HSLayer2.Children)
			(a as Image).WidthRequest = w;
		foreach (var a in HSLayer3.Children)
			(a as Image).WidthRequest = w;
		foreach (var a in HSLayerChao.Children)
			(a as Image).WidthRequest = w;

		HSLayer1.WidthRequest = w;
		HSLayer2.WidthRequest = w;
		HSLayer3.WidthRequest = w;
		HSLayerChao.WidthRequest = w;
	}
	void GerenciaCenarios()
	{
		MoveCenario();
		GerenciaCenarios(HSLayer1);
		GerenciaCenarios(HSLayer2);
		GerenciaCenarios(HSLayer3);
		GerenciaCenarios(HSLayerChao);
	}

	void MoveCenario()
	{
		HSLayer1.TranslationX -= velocidade1;
		HSLayer2.TranslationX -= velocidade2;
		HSLayer3.TranslationX -= velocidade3;
		HSLayerChao.TranslationX -= velocidade;
	}

	void GerenciaCenarios(HorizontalStackLayout HSL)
	{
		var view = (HSL.Children.First() as Image);
		if (view.WidthRequest + HSL.TranslationX < 0)
		{
			HSL.Children.Remove(view);
			HSL.Children.Add(view);
			HSL.TranslationX = view.TranslationX;
		}
	}
	async Task Desenha()
	{
		while (!estaMorto)
		{
			GerenciaCenarios();
			await Task.Delay(tempoEntreFrames);
			player.Desenha();
		}
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		Desenha();
	}

}
