using DesafioPOO.Models;

bool executarPrograma =  true;
bool telefoneLigado = false;

Nokia nokia = new Nokia();
Iphone iphone = new Iphone();

Console.WriteLine("Informe o modelo do Telefone:");
Console.WriteLine("1 - Nokia");
Console.WriteLine("2 - Iphone");

int modeloTelefone = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o Número do telefone:");
string numero = Console.ReadLine();

Console.WriteLine("Informe o Modelo do telefone:");
string modelo = Console.ReadLine();

Console.WriteLine("Informe o IMEI do telefone:");
string imei = Console.ReadLine();

Console.WriteLine("Informe o Memória do telefone:");
int memoria = int.Parse(Console.ReadLine());

if (modeloTelefone == 1)
{
    nokia.Modelo = modelo;
    nokia.Numero = numero;
    nokia.IMEI = imei;
    nokia.Memoria = memoria;
}
else if(modeloTelefone == 2)
{
    iphone.Modelo = modelo;
    iphone.Numero = numero;
    iphone.IMEI = imei;
    iphone.Memoria = memoria;
}
else
{
    Console.WriteLine("Opção Inválida");
    executarPrograma = false;

}



while (executarPrograma)
{
    Console.WriteLine("Escolha uma Opção:");
    Console.WriteLine("1 - Ligar Telefone. ");
    Console.WriteLine("2 - Receber Ligação.");
    Console.WriteLine("3 - Instalar Aplicativo.");
    Console.WriteLine("0 - Sair.");

    int opcaoEscolhida = int.Parse(Console.ReadLine());

    switch (opcaoEscolhida)
    {
        case 1:
            if (!telefoneLigado)
            {

                if(modeloTelefone == 1)
                {
                    nokia.Ligar();
                }
                else
                {
                    iphone.Ligar();
                }
                
                telefoneLigado = true;
               
            }
            else
            {
                Console.WriteLine("Telefone já se encontra ligado. Desligando o telefone.");
                telefoneLigado = false;
            }
            break;
        case 2:
            if(modeloTelefone == 1)
            {
                nokia.ReceberLigacao();
            }
            else
            {
                iphone.ReceberLigacao();
            }
            break;
        case 3:
            Console.WriteLine("Informe o nome do APP a ser instalado");
            var nomeApp = Console.ReadLine();
            if (modeloTelefone == 1)
            {
                nokia.InstalarAplicativo(nomeApp);
            }
            else
            {
                iphone.InstalarAplicativo(nomeApp);
            }
            break;
        case 0:
            Console.WriteLine("Obrigado por Utilizar nosso Sistema. Volte Sempre!!");
            executarPrograma = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}