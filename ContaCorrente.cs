using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjContaBancaria
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal Saldo{
            get{ return this.saldo;}
        }

        public ContaCorrente(int numeroConta, decimal saldo, Cliente cliente){
            this.numeroConta = numeroConta;
            this.saldo = saldo;
            this.cliente = cliente;
        }

        public void Depositar(decimal deposito){
            this.saldo += deposito;
            Console.WriteLine($"Você depositou R${deposito}");
        }

        public void Sacar(decimal saque){
            if(this.saldo - saque < 0){
                Console.WriteLine($"Valor de saque superior ao saldo, seu saldo é R${this.saldo}");
            }else{
                this.saldo -= saque;

                Console.WriteLine($"Você sacou R${saque}");
            }
        }

        public void MeuSaldo(){
            Console.WriteLine($"Saldo da conta corrente R${this.saldo}");
        }
    }
}