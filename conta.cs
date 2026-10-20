using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ContaBancaria
{
    public class conta
    {
        public int numConta;            
        protected string tipo;
        private string dono;
        private double saldo;        
        private Boolean status;


        public void abrirConta(string t)
        {
            setTipo(t);
            setStatus (true);
            if (t == "CC")
            {
                saldo = 50;
                Console.WriteLine("abriste uma conta tipo cc com 50$ de saldo");
            }
            else if(t == "CP")
            {
                saldo = 150;
                Console.WriteLine("abriste uma conta tipo CP com 150$ de saldo");
            }
        }
        public void fecharConta()
        {
            if (saldo > 0)
            {
                Console.WriteLine("Não consegues fechar a conta porque tem dinheiro ");
            }
            else if (saldo < 0)
            {
                Console.WriteLine("Conta em Débito");
            }
            else 
                setStatus(false);
        }
        public void depositar(double v)
        {
            if (status == true)
            {
                setSaldo(getSaldo() + v);
                Console.WriteLine("foi depositado "+v+"$");
            }
            else
            {
                Console.WriteLine("Impossivel Depositar");
            }
        }
        public void levantar(double v)
        {
            if (status == true)
            {
                if (saldo >= v)
                {
                    saldo = saldo - v;
                    Console.WriteLine("Levantaste " + v + "$");
                }
                else
                {
                    Console.WriteLine("salod Insuficiente");
                }
            }
            else {
                Console.WriteLine("Impossivel Levantar");
            }
            
        }
        public void mensalidade()
        {
            double v = 0;
            if (tipo == "CC")
            {
                v = 12;
            }
            else if (tipo == "CP")
            {
                v = 20;
            }
            if (status == true)
            {
                if(saldo >= v)
                {
                    saldo= saldo - v;
                }
                else
                {
                    Console.WriteLine("saldo insuficiente");
                }

            }
            else
            {
                Console.WriteLine("impossivel pagar");
            }
        }
        public conta()
        {
            saldo = 0;
            status = false;  

        }
        public void setNumConta(int n)
        {
            numConta = n;
        }
        public int getNumConta()
        {
            return numConta;
        }
        public void setTipo(string t)
        {
            tipo=t;
        }
        public string getTipo()
        {
            return tipo;
        }
        public void setDono(string d)
        {
            dono = d;
        }
        public string getDono()
        {
            return dono;
        }
        public void setSaldo(double s)
        {
            saldo = s;
        }
        public double getSaldo()
        {
            Console.WriteLine("o teu saldo atual é " + saldo);
            return saldo;
             
        }
        public void setStatus(Boolean s)
        {
            status = s;
        }
        public Boolean getStatus()
        {
            return status;
        }
        public void mostrarInformacao()
        {
            Console.WriteLine("O dono da conta é " + dono + ".");
            Console.WriteLine("o numero da conta é " + numConta);
           

        }
    }

}                                                                                                                                                                              