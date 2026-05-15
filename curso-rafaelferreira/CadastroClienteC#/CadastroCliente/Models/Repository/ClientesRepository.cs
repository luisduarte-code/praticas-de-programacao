using CadastroClientes.Models;

namespace CadastroCliente.Models.Repository
{
    public class ClientesRepository
    {
        public List<Clientes> Listar()
        {
            List<Clientes> clientesLista = new List<Clientes>();
            Clientes cliente = new Clientes ();
            cliente.UF = "SP";
            cliente.Fax = "111111111";
            cliente.Telefone = "123456789";
            cliente.Documento = "111222333444";
            cliente.Email = "luis@gmail.com";
            cliente.Nome="Luis Duartewd"
            return null;
        }
    }
}
