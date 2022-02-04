using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {

            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("345.765.876.-90");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("543.876.345-23");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            sistemaInterno.Logar(camila, "abc");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "1234";

            sistemaInterno.Logar(parceiro, "1234");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("342.435.346-87");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("345.765.876.-90");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("321.543.654-45");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("543.876.345-23");
            camila.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciador.GetTotalBonificacao());
        }

    }
}
