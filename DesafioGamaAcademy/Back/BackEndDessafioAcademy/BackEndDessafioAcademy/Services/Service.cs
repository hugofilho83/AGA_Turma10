using BackEndDessafioAcademy.Models;
using BackEndDessafioAcademy.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDessafioAcademy.Services
{
    public class Service
    {
        public bool ValidaEndereco(Endereco endereco)
        {
            if (endereco.Pais == null || endereco.Estado == null || endereco.Cidade == null || endereco.Cep == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool ValidaCliente(Cliente cliente)
        {
            if (ValidaEndereco(cliente.Endereco))
            {
                if (cliente.Nome == null || cliente.Cpf == null || cliente.Email == null || cliente.Senha == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }

        public void CadastrarCliente(Cliente cliente)
        {
            if (ValidaCliente(cliente))
            {
                var dataBasePadrao =  new DataBasePadrao();
                dataBasePadrao.Clientes.Add(cliente);
                dataBasePadrao.SaveChanges();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
