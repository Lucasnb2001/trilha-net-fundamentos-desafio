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
            // Pede ao usuário uma placa (ReadLine) e adiciona na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            this.veiculos.Add(Convert.ToString(Console.ReadLine()));
            //Console.WriteLine(this.veiculos[0]);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pede para o usuário digitar a placa e armazenar na variável placa
            string placa = "";
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            placa = Convert.ToString(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt16(Console.ReadLine());
               
                
                decimal valorTotal = this.precoInicial + this.precoPorHora * horas; 

                // Remove a placa digitada da lista de veículos
                this.veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            int cont = 1;
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach(string veiculo in veiculos){
                    Console.WriteLine("Veículo Nº " + cont + ": " + veiculo);
                    cont++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
