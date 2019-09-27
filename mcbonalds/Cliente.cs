using System;

namespace mcbonalds
{
    public class Cliente
    {
        // Atributos
        public string Nome;  // Nome do Cliente
        public string Endereço; // Endereço do Cliente
        public string Telefone; // Telefone do Cliente 
        public string Senha; // Senha de acesso do cliente ao sistema 
        public string Email; // Email do cliente e nome de user do sistema
        public DateTime DataNascimento; //  data de nascimento do cliente

        // Construtores

        public Cliente(string Nome, string Telefone, string Email) {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
        }

    }
}