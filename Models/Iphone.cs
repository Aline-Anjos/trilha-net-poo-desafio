
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero,string modelo,string imei,int memoria) : base(numero,modelo,imei,memoria){
            
            Console.WriteLine($"Numero:{numero}, Modelo:{modelo},Imei:{imei},Memoria:{memoria}");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp}");
            
        }
    }
}