using System.Text.RegularExpressions;

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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
           string placa;
            do {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                placa = Console.ReadLine();
            } while (!ValidarPlaca(placa));
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            string placa;
            do
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                placa = Console.ReadLine();
            } while (!ValidarPlaca(placa));

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                string horasInput;
                do
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    horasInput = Console.ReadLine();
                } while (!ValidarHoras(horasInput));
                int horas = int.Parse(horasInput);
                decimal valorTotal = precoInicial + precoPorHora * horas;
                
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
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
               foreach (string veiculo in veiculos)
               {
                    Console.WriteLine(veiculo);
               }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public bool ValidarPlaca(string placa)
        {
           if (Regex.IsMatch(placa, "^[A-Z]{3}-[0-9]{4}$"))
           {
                Console.WriteLine("Placa válida.");
                return true;
           }
           else
           {
                Console.WriteLine("Placa inválida. O formato correto é AAA-0000.");
                return false;
           }
        }

     public bool ValidarHoras(string horasInput)
        {
            if (int.TryParse(horasInput, out int horas) && horas >= 0)
            {
                Console.WriteLine("Quantidade de horas válida.");
                return true;
            }
            else
            {
                Console.WriteLine("Quantidade de horas inválida. Por favor, insira um número inteiro não negativo.");
                return false;
            }
        }

    }
}
