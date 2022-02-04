using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class funcionarioAutenticavel:Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public funcionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
