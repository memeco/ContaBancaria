namespace SistemaContaBancaria
{
    public class ContaBancaria
    {
        // Variáveis privadas
        private readonly int _numeroConta;
        public string NomeTitular; // Nome do titular agora é público
        public double Saldo; // Saldo agora é público sem _

        // Construtor para conta com depósito inicial
        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial)
        {
            _numeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = depositoInicial;
        }

        // Construtor para conta sem depósito inicial
        public ContaBancaria(int numeroConta, string nomeTitular) : this(numeroConta, nomeTitular, 0)
        {
        }

        // Propriedades públicas
        public int NumeroConta => _numeroConta;

        // Métodos públicos
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (Saldo - valor - 5.00 >= 0)
            {
                Saldo -= valor + 5.00;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Número da Conta: {_numeroConta}\n" +
                $"Nome do Titular: {NomeTitular}\n" +
                $"Saldo: R${Saldo:F2}";
        }
    }
}
