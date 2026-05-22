using CadastroClientes.Models;

namespace CadastroCliente.Models.Repository
{
    public class ClientesRepository
    {
        public List<Clientes> Listar()
        {
            List<Clientes> clientesLista = new List<Clientes>();
            Clientes cliente = new Clientes ();
            //instanciando cliente luis 
            cliente.UF = "SP";
            cliente.Fax = "111111111";
            cliente.Telefone = "123456789";
            cliente.Documento = "111222333444";
            cliente.Email = "luis@gmail.com";
            cliente.Nome = "Luis Duarte";
            cliente.Sexo = "Masculino";
            cliente.IdClientes = 10;
                //add luis na lista de clientes
            clientesLista.Add(cliente);
                //estanciando o cliente felipe
            cliente.UF = "rs";
            cliente.Fax = "122222221";
            cliente.Telefone = "1232139";
            cliente.Documento = "112134";
            cliente.Email = "felipe@gmail.com";
            cliente.Nome = "Felipe Duarte";
            cliente.Sexo = "Masculino";
            cliente.IdClientes = 12;
            //add felipe na lista de clientes
            clientesLista.Add(cliente);
            //estanciando a cliente aurora
            cliente.UF = "rj";
            cliente.Fax = "123213234221";
            cliente.Telefone = "12324141139";
            cliente.Documento = "112134324324";
            cliente.Email = "aurora@gmail.com";
            cliente.Nome = "aurora Duarte";
            cliente.Sexo = "Feminino";
            cliente.IdClientes = 17;
            //add aurora na lista de clientes
            clientesLista.Add(cliente);













            return clientesLista;
        }
    }
}
