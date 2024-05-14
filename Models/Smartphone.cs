namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama OK
        protected int Memoria { get; set; }
         protected string Modelo { get; set; }
         protected string IMEI { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Memoria= memoria;
            Modelo = modelo;
            IMEI= imei;
            // TODO: Passar os parâmetros do construtor para as propriedades -- OK
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}