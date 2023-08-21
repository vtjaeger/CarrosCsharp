using Carros.Funcoes;

class Program
{
    static void Main(string[] args)
    {   
        FuncaoCarro carroPrograma = new FuncaoCarro();

        Dictionary<string, double> listaCarros = new Dictionary<string, double>();
        listaCarros.Add("a", 20);
        FuncaoCarro.MostraTexto(listaCarros);
    }
}
