namespace InfinitRunnerPaty;

public partial class MainPage : ContentPage
{
bool estaMorto=false;
bool estaPulando=false;
const int tempoEntreFrames=25;

int velocidade1= 0;
int velocidade2 = 0;
int velocidade3 = 0;
int velocidade=0;
int larguraJanela=0;
int alturaJanela=0;
protected override void OnSizeAllocated(double w, double h)
{
	base.OnSizeAllocated(w, h);
	CorrigeTamanhoCenario(w, h);
	CalculaVelocidade(w);
}
void CalculaVelocidade CalculaVelocidade(double w)
{
	velocidade1 = (int)(w* 0.001);
	velocidade2 = (int)(w* 0.004);
	velocidade3 = (int)(w* 0.008);
	velocidade=   (int)(w*0.001);

}
void CorrigeTamanhoCenario (double w, double h)
{
	foreach (var a in HSLayer1.Children)
	(a as Image).WidthRequest = w;
	foreach (var a in HSLayer2.Children)
	(a as Image).WidthRequest = w;
	foreach (var a in HSLayer3.Children)
	(a as Image).WidthRequest = w;
	foreach(var a in HSLayerChao.Children)
	(a as Image.).WidthRequest = w;

	HSLayer1.WidthRequest = w
	HSLayer2.WidthRequest = w*
	HSLayer3.WidthRequest = w*
	HSLayerChao.WidthRequest =w*
}


}

