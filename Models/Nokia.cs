namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" ok
    public class Nokia:Smartphone
    {
        public Nokia(string numero,string modelo,string imei,int memoria) : base(numero,modelo,imei,memoria){
            Console.WriteLine($"Numero:{numero}, Modelo:{modelo},Imei:{imei},Memoria:{memoria}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}");
        }
    }
}