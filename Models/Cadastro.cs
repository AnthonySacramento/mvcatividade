public class Cadastro
{
    public int Registro { get; set; }
    public string Data { get; set; }

    public string Volume { get; set; }
    public double Valor { get; set; }

    public Cadastro(int registro, string data,string volume,double valor)
    {
        Registro = registro;
        Data = data;
        Volume = volume;
        Valor = valor;
    }
}