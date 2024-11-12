namespace CorridaInfinita;

public partial class MainPage : ContentPage
{
	int count = 0;
	bool estaMorto=false;
	bool estaPulando=false;
	const int tempoEntreFrame=25;
	int velocidade1=0;
	int velocidade2=0;
	int velocidade3=0;
	int velocidade=0;
	int larguraJanela=0;
	int AlturaJanela=0;
	public MainPage()
	{
		InitializeComponent();
	}
	void GerenciaCenarios()
	{
		MoveCenario();
		GerenciaCenario(hslayer1);
		GerenciaCenario(hslayer2);
		GerenciaCenario(hslayer3);
		GerenciaCenario(hslayerChao);
	}
	void MoveCenario()
	{
		hslayer1.TranslationX-=velocidade1;
		hslayer2.TranslationX-=velocidade2;
		hslayer3.TranslationX-=velocidade3;
		hslayerChao.TranslationX-=velocidade;
	}
	void GerenciaCenario(HorizontalStackLayout hsl)
	{
		var view=(hsl.Children.First() as Image);
		if (view.WidthRequest+hsl.TranslationX<0)
		{
			hsl.Children.Remove(view);
			hsl.Children.Add(view);
			hsl.TranslationX= view.TranslationX;
		}
	}

	protected override void OnSizeAllocated(double w, double h)
	{
		base.OnSizeAllocated(w, h);
		CorrigeTamanhoCenario(w, h);
		CalculaVelocidade(w);
	}
	void CalculaVelocidade(double w)
	{
		velocidade1=(int)(w*0.001);
		velocidade2=(int)(w*0.004);
		velocidade3=(int)(w*0.008);
		velocidade=(int)(w*0.01);
	}
	void CorrigeTamanhoCenario(double w, double h)
	{
		foreach (var a in hslayer1.Children)
		(a as Image).WidthRequest=w;
		foreach (var a in hslayer2.Children)
		(a as Image).WidthRequest=w;
		foreach (var a in hslayer3.Children)
		(a as Image).WidthRequest=w;
		foreach (var a in hslayerChao.Children)
		(a as Image).WidthRequest=w;

		hslayer1.WidthRequest=w*1.5;
		hslayer2.WidthRequest=w*1.5;
		hslayer3.WidthRequest=w*1.5;
		hslayerChao.WidthRequest=w*1.5;
	}
	
}

