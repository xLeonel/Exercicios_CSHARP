namespace Ex29
{
    public class AgendaTelefonica
    {
        private string _Nome;
        private string _Telefone;
        private string _Aniversario;

        public string Nome
        {
            get { return _Nome; }
            set { this._Nome = value;}

        }
        public string Telefone
        {
            get { return _Telefone; }  
            set { this._Telefone = value;}
        }
        public string Aniversario
        {
            get { return _Aniversario; } 
            set { this._Aniversario = value;}     
        }

        public AgendaTelefonica(string Nome, string Telefone,string Aniversario)
        {
            this._Nome = Nome;
            this._Telefone = Telefone;
            this._Aniversario = Aniversario;
        }
    }
}