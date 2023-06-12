using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06___atividade_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variáveis

                string usuario_cadastrado = "João"; string senha_cadastrada = "j1o2a3o4";

                int opcoes;
            
            //Inicio
            
                Console.WriteLine( " -- Bem-vindo ao Internet bank --" );

                Console.Write( "\n" );

                Console.WriteLine (" 1 - Cadastrar " );

                Console.WriteLine( " 2 - Acessar" );

                Console.Write ( "\n" );
            
                Console.Write( " Por favor digite uma das opções: " );
                opcoes = int.Parse( Console.ReadLine() );

                Console.Clear();

            //Login

                if (opcoes == 2)
                {
                    string usuario2; string senha2;
    
                    Console.Write(" Digite seu usuário: ");
                    usuario2 = Console.ReadLine();

                    Console.Write("\n");


                    if (usuario2 != usuario_cadastrado)
                    {

                        Console.WriteLine(" -- Usuário inválido, inicie o processo novamente --");

                        Console.Write("\n");

                        Main(null);

                    }

                    Console.Write(" Digite sua senha: ");
                    senha2 = Console.ReadLine();

                    Console.Write("\n");

                    if (senha2 != senha_cadastrada)
                    {

                        Console.WriteLine(" -- Senha inválida, inicie o processo novamente --");

                        Console.Write("\n");

                        Main(null);

                    }

                    Console.WriteLine(" -- Login efetuado com sucesso -- ");

                    Console.ReadKey();

                }

            //Cadastrar

                //Variáveis

                    string usuario; string senha;
                    string novo_usuario; string nova_senha;
                
                Console.WriteLine( " -- Cadastrar --" ) ;

                Console.Write( "\n" );

                Console.Write( " Digite o nome do novo usuário: " );
                novo_usuario = Console.ReadLine();

                Console.Write ( "\n" );

                Console.Write( " Digite a senha do novo usuário: " );
                nova_senha = Console.ReadLine();

                Console.Write ( "\n" );

                Console.WriteLine( " -- Usuário cadastrado com sucesso, aperte qualquer tecla para continuar --" );

                Console.ReadKey();

                Console.Clear();

            //Login\Cadastrar
            
                Console.WriteLine( " -- Login --" );

                Console.Write( "\n" );

                Console.Write( " Digite seu nome de usuário: " );
                usuario = Console.ReadLine();

                Console.Write( "\n" );
            
                if ( usuario != novo_usuario )
                {

                    Console.WriteLine( " -- Usuário inválido, inicie o processo novamente --" );

                    Console.Write("\n");

                    Main( null );

                }

                Console.Write( " Digite sua senha: " );
                senha = Console.ReadLine();

                Console.Write("\n");

                if( senha != nova_senha )
                {

                    Console.WriteLine(" -- Senha inválida, inicie o processo novamente --");

                    Console.Write("\n");

                    Main( null );

                }

                Console.WriteLine( " -- Login efetuado com sucesso -- " );

                Console.ReadKey();

            //Login

                if (opcoes == 2)
                {
                    string usuario2; string senha2;

                    Console.Write(" Digite seu usuário: ");
                    usuario2 = Console.ReadLine();

                    Console.Write("\n");


                    if (usuario2 != usuario_cadastrado)
                    {

                        Console.WriteLine(" -- Usuário inválido, inicie o processo novamente --");

                        Console.Write("\n");
                    
                        Main(null);

                    }

                    Console.Write(" Digite sua senha: ");
                    senha2 = Console.ReadLine();

                    Console.Write("\n");

                    if (senha2 != senha_cadastrada)
                    {

                        Console.WriteLine(" -- Senha inválida, inicie o processo novamente --");

                        Console.Write("\n");

                        Main(null);

                    }

                    Console.WriteLine(" -- Login efetuado com sucesso -- ");

                    Console.ReadKey();

                }

        }
    }
}
