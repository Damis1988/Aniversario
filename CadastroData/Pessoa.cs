﻿using System;

namespace CadastroData
{
    class Pessoa
    {
        private DateTime dataEntrada;
        private string nome, sobrenome;

        public Pessoa()
        {
        }

        public Pessoa(string nome, string sobrenome, DateTime dataEntrada)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.dataEntrada = dataEntrada;
        }

        public DateTime DataEntrada{get;set;}
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public Double diferencaData ()
        {
            DateTime data = DateTime.Now;
            double aniversario = (data.Day - dataEntrada.Day) * 12 + data.Month - dataEntrada.Month;
            //DateTime aniversario = new DateTime(DateTime.Now.Year, dataEntrada.Month, dataEntrada.Day);
           
            if (aniversario == 0) {

                Console.WriteLine($"Feliz aniversario !!! ");
                Console.ReadLine();
            }

            return aniversario; 
        }

        public override string ToString()
        {
            String data = String.Format("{0:MM/dd/yyyy}", dataEntrada);
            return "Cadastro : " + Nome + " " + Sobrenome + " Data de Nascimento " + data;
        }
    }
}
