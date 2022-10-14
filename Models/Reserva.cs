namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool validacao = hospedes.Count<= Suite.Capacidade;
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (validacao)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("O número de hóspedes recebido é maior que a capacidade da suíte");
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes = Hospedes.Count;
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo do valor da diária
            decimal valorTotalDiaria = Suite.ValorDiaria * DiasReservados;
            double valor = Convert.ToDouble(valorTotalDiaria);

            bool desconto = DiasReservados >= 10;
            // Caso os dias reservados forem maior ou igual a 10, ganha-se um desconto de 10%
            if (desconto)
            {
                valor = valor*0.9;
            }

            return Convert.ToDecimal(valor);
        }
    }
}