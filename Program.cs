using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "1111-1111", modelo: "Modelo 1", imei: "000000000", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("Facebook");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "22222-2222", modelo: "Modelo 2", imei: "11111111", memoria: 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.ReadLine();
    }
}
