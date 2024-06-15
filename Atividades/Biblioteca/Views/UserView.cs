using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
namespace Biblioteca.Views
{
    public class UserView
    {
        public UserView() {
            this.Init();
        }
        public void Init() {
            Console.WriteLine("MENU Cliente");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir ");
                Console.WriteLine("2 - Deletar ");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Pesquisar");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu) {
                        case 0: // caso a pessoa escolha a opção 0
                            aux = false;
                        break;
                        case 1:
                          InsertUser();

                            
                        break;
                        case 2:
                            
                        break;
                        case 3:
                            
                        break;
                        case 4:
                           
                        break;
                        case 5:
                        
                        break;
                        default:
                            Console.WriteLine("Opção Inválida.");
                            aux = true;
                        break;
                    }
                }
                
                catch {
                    Console.WriteLine("Opção Inválida.");
                    menu = -1; // caso a pessoa digite algo inválido
                }
            }

            while(aux);
        }

        private void InsertUser() {
            Console.WriteLine("***********************");
            Console.WriteLine("INSERIR NOVO CLIENTE");
            Console.WriteLine("***********************");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("cpf: ");
                int cpf = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                User user = new User(nome,cpf);
               
        }
        private void SearchUser() {
            Console.WriteLine("***********************");
            Console.WriteLine("PESQUISAR CLIENTE");
            Console.WriteLine("***********************");

            Console.Write("cpf ");
            Console.Write(user);
    }
}
}
