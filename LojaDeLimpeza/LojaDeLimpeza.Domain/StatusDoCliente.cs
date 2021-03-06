﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class StatusDoCliente
    {
        public int IdStatus { get; set; }
        public IList<Cliente> ListaDeCliente = new List<Cliente>();
        public string NomeStatus { get; set; }
        
        public void VerificarStatusCliente(Cliente cliente)
        {
            foreach(var listaDeCliente in ListaDeCliente)
            {
                if(cliente.LimiteDeCredito < 1000)
                {
                    this.IdStatus = 1;
                }
                else if(cliente.LimiteDeCredito <= 3000)
                {
                    this.IdStatus = 2;
                }
                else if(cliente.LimiteDeCredito > 3000)
                {
                    this.IdStatus = 3;
                }
                else
                {
                    throw new Exception("Status do cliente inváido");
                }
            }
        }
    }
}
