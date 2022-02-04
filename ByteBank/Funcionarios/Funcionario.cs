using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }        //membro estatico da classe que nao pode ser alterado de fora dela
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;          // Propriedade CPF recebe valor passado por argumento
            Salario = salario;

            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();      // Cria um metodo a ser sobrescrito obrigatoriamente

    }
}
