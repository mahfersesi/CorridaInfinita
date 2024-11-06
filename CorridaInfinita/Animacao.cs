public class Animacao
{
    protected List<String> Animacao1 = new List<String>();
    protected List<String> Animacao2 = new List<String>();
    protected List<String> Animacao3 = new List<String>();
    protected bool Loop=true;
    protected int animacaoAtiva=1;
    bool parado=true;
    protected Image compImagem;
    public Animacao(Image a)
    {
        compImagem=a;
    }
    public void Stop()
    {
        parado=true;
    }
    public void Play()
    {
        parado=false;
    }
    public void SetAnimacaoAtiva(int a)
    {
        animacaoAtiva=a;
    }
    public void Desenhar()
    {
        if(parado)
           return;
        String nomeArquivo;
        int tamanhoAnimacao;
        if(animacaoAtiva==1)
        {
            nomeArquivo=Animacao1[frameAtual];
            tamanhoAnimacao=Animacao1.Count;
        }
        else if (animacaoAtiva==2)
        {
            nomeArquivo=Animacao2[frameAtual];
            tamanhoAnimacao=Animacao2.Count;
        }
        else if (animacaoAtiva==3)
        {
            nomeArquivo=Animacao3[frameAtual];
            tamanhoAnimacao=Animacao3.Count;
        }
        compImagem.Source=ImageSource.FromFile(nomeArquivo);
        frameAtual++;
        if(frameAtual >=tamanhoAnimacao)
        {
            if (loop)
              frameAtual=0;
            else 
            {
                parado=true;
                QuandoParar();
            }
        }
    }
    public virtual void QuandoParar()
    {
        
    }
}