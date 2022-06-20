using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesaDia20
{
    public class ToDo
    {
        public static List<string> listaDeTarefas = new List<string>();

        public static void AdicionarTarefa()
        {
            Console.WriteLine("Qual tarefa deseja adicionar?");
            listaDeTarefas.Add(Console.ReadLine());
        }

        public static void RemoverTarefa()
        {
            Console.WriteLine("Qual tarefa deseja remover?");
            listaDeTarefas.Remove(Console.ReadLine());
        }

        public static void AtualizarTarefa()
        {
            Console.WriteLine("Qual tarefa deseja atualizar?");
            string tarefa = Console.ReadLine();

            if (listaDeTarefas.Contains(tarefa))
            {
                int index = listaDeTarefas.IndexOf(tarefa);
                listaDeTarefas.Remove(tarefa);
                Console.WriteLine("Qual tarefa deseja acrescentar?");
                string novaTarefa = Console.ReadLine();
                listaDeTarefas.Insert(index, novaTarefa);
            }
            else
            {
                Console.WriteLine("Tarefa Inexistente.");
            }

        }

        public static void ListarTodasAsTarefas()
        {
            foreach (string tarefa in listaDeTarefas)
            {
                Console.WriteLine(tarefa);
            }
        }

        public static void ApresentarUmaTarefaAPartirDoIndice()
        {
            Console.WriteLine("Qual o índice da tarefa que deseja consultar?");
            int index = int.Parse(Console.ReadLine());
            string[] listaInArray = listaDeTarefas.ToArray();
            Console.WriteLine(listaInArray[index]);
        }

    }

    //Adicionar tarefa ok.
    //Remover tarefa ok.
    //Atualizar tarefa.
    //Listar todas as tarefas ok.
    //Apresentar uma tarefa a partir do índice.
}

