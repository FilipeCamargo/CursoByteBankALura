using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : funcionarioAutenticavel
    {

        public Diretor(string cpf) : base(5000,cpf)      // construtor herdando cpf de funcionario, jah que eh a primeira classe acionada
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()      //sobrescreve o metodo na classe Funcionário
        {

            return Salario * 0.5;
        }

    }
}
