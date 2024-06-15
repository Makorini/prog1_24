using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class User
    {
        // Construtor da classe User
    public User(string nome, int cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
    }
        public string nome { get; set; }
        public int cpf { get; set; }
        
        // Outros atributos específicos do usuário, se necessário

    }
}