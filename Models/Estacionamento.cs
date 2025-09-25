namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        List<string> NomeDoModelo = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"

            Console.Write("Digite a placa do veículo para estacionar: ");
            string puxaPlaca = Console.ReadLine();
            veiculos.Add(puxaPlaca.ToUpper());
            Console.Write("Modelo do veículo: ");
            NomeDoModelo.Add(Console.ReadLine());

            Console.WriteLine("Veículo está no sistema");
            

        }
        
        public void RemoverVeiculo()
        {
            for (int i = 0; i < veiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {NomeDoModelo[i]} => Placa {veiculos[i].ToUpper()}");
            }

            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            int indice = veiculos.FindIndex(v => v.Equals(placa, StringComparison.OrdinalIgnoreCase));

            if (indice >= 0)
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int qtHorasEstacio = Convert.ToInt32(Console.ReadLine());
                decimal ValorPg = ((qtHorasEstacio * precoPorHora) + precoInicial);

                // Remove das duas listas pelo mesmo índice
                veiculos.RemoveAt(indice);
                NomeDoModelo.RemoveAt(indice);

                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido");
                Console.WriteLine($"e o preço total foi de: R$ {ValorPg} ");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }


        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("=== Veículos estacionados: ===");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"{i+1} - {NomeDoModelo[i]} => Placa  {veiculos[i].ToUpper()} ");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
