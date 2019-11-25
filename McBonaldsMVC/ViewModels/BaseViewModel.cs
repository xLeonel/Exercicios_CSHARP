namespace McBonaldsMVC.ViewModels
{
    public class BaseViewModel
    {
        public string NomeView {get;set;}
        public string UsuarioNome {get;set;}
        public string UsuarioEmail {get;set;}
        
        public BaseViewModel ()
        {
            this.NomeView = NomeView;
            this.UsuarioNome = UsuarioNome;
            this.UsuarioEmail = UsuarioEmail;
        }
    }
}