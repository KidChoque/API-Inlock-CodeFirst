using webAPICodeFIrst.Domains;

namespace webAPICodeFIrst.Interfaces
{
    public interface IUsuario
    {
        void Cadastrar(Usuario novoUsuario);

        public Usuario BuscarUsuario(string email, string senha);
    }
}
