using System;

namespace byteBank.Models
{
    public class Cliente
    {
        public string Cpf { get; set;} 
        public string Nome { get; set;} 
        public string Email { get; set;} 
        public string Senha { get; set;} 


        //* */ CONSTRUTOR
        public Cliente(string Nome, string Cpf, string Email)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
        }

        //* */ Metodo
        public bool TrocarSenha(string senhaUsuario)
        {
            if ((senhaUsuario.Length >= 6) && (senhaUsuario.Length <= 16))
            {
                this.Senha = senhaUsuario;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static implicit operator Cliente(string v)
        {
            throw new NotImplementedException();
        }
    }
}