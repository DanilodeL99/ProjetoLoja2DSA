using MySql.Data.MySqlClient;
using ProjetoLoja2dsA.Models;
namespace ProjetoLoja2dsA.Repositorio

{
    public class UsuarioRepositorio(IConfiguration configuration)
    {
        // Declara um campo privado somente leitura para armazenar a string de conexão com o MySQL.
        private readonly string _conexaoMySQL = configuration.GetConnectionString("ConexaoMySQL");


        public Usuario ObterUsuario(string email)
        {


        }
    }
}
