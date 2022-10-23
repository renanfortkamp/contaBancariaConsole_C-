using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjContaBancaria
{
    public class Cliente
    {
        public string Name{get;private set;}
        public string Cpf{get;private set;}
        public string Rg{get;private set;}

        public Cliente(string name, string cpf, string rg){
            this.Name = name;
            this.Cpf = cpf;
            this.Rg = rg;
        }
    }
}