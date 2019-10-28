namespace Ex28
{
    public class AgendaTelefonica
    {
        private string _Nome;
        private string _Telefone;
        private string _Aniversario;

        public string Nome
        {
            get { return _Nome; }

        }
        public string Telefone
        {
            get { return _Telefone; }  
        }
        public string Aniversario
        {
            get { return _Aniversario; }      
        }

        public AgendaTelefonica(string Nome, string Telefone,string Aniversario)
        {
            this._Nome = Nome;
            this._Telefone = Telefone;
            this._Aniversario = Aniversario;
        }

    }
}