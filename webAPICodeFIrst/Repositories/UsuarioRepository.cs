using webAPICodeFIrst.Contexts;
using webAPICodeFIrst.Domains;
using webAPICodeFIrst.Interfaces;
using webAPICodeFIrst.Utéis;

namespace webAPICodeFIrst.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        private readonly InlockContext ctx;
        public UsuarioRepository() 
        {
        
           ctx = new InlockContext();
        
        }  
        public void Cadastrar(Usuario novoUsuario)
        {

            try
            {
                novoUsuario.Senha = Criptografia.GerarHash(novoUsuario.Senha!);

                ctx.Usuario.Add(novoUsuario);

                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Usuario BuscarUsuario(string email, string senha)
        {
            throw new NotImplementedException();
        }

    }
}
