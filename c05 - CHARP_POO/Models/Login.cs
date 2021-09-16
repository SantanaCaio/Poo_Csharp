namespace c05___CHARP_POO.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public Login(string email, string senha)
        {
            Email = email;
            Senha = Senha;
        }
    }
}