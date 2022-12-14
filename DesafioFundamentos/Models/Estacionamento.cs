namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            //Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placasAdd = Console.ReadLine();
            veiculos.Add(placasAdd);
        }

        public void RemoverVeiculo()
        {
             // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string valorQuantiaHoras = Console.ReadLine();
                
                int horas = Convert.ToInt32(valorQuantiaHoras);
                decimal valorTotal = 0; 

                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                valorTotal = precoInicial + (precoPorHora * horas);
               

                // Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                //Realizar um laço de repetição, exibindo os veículos estacionados
                int contador = 0;
                foreach(string carros in veiculos)
                {
                    Console.WriteLine($"{veiculos[contador]}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
