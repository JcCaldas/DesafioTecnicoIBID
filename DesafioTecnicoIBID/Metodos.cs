namespace DesafioTecnicoIBID;

internal class Metodos
{
    //MENU
    public static void Menu(bool controle, List<Item> listaItens)
    {
        bool entradaValida = false;
        while (!entradaValida)
        {
            try
            {

                while (controle)
                {

                    Console.WriteLine("\n###\tMENU\t###\n" +
                        "1 - Adicionar item\n" +
                        "2 - Remover item pelo ID\n" +
                        "3 - Editar nome do item\n" +
                        "4 - Visualizar lista de itens\n" +
                        "5 - Limpar tela\n" +
                        "6 - Finalizar Programa\n");

                    Console.Write("Escolha: ");
                    int escolha = Convert.ToInt32(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            entradaValida = true;
                            Metodos.AddItem(listaItens);
                            break;

                        case 2:
                            entradaValida = true;
                            Metodos.RemoveItens(listaItens);
                            break;

                        case 3:
                            entradaValida = true;
                            Metodos.EditItem(listaItens);
                            break;

                        case 4:
                            entradaValida = true;
                            Metodos.GetItens(listaItens);
                            break;

                        case 5:
                            entradaValida = true;
                            Console.Clear();
                            break;

                        case 6:
                            entradaValida = true;
                            controle = false;
                            break;

                        default:
                            entradaValida = true;
                            Console.WriteLine("Opção inválida");
                            continue;
                    }


                }

            }
            catch (FormatException)
            {

                Console.WriteLine($"\nFormato digitado errado. Deve-se digitar um números!");

            }

        }
    }

    //Adicionar Itens
    public static List<Item> AddItem(List<Item> listaItens)
    {
        bool entradaValida = false;
        while (!entradaValida)
        {


            try
            {

                Console.Write("\nDigite o ID do item: ");
                int id = Convert.ToInt32(Console.ReadLine());
                entradaValida = true;

                foreach (var itemID in listaItens)
                {
                    while (id == itemID.ID)
                    {
                        Console.Write($"\nO ID {id} já existe.\n" +
                            $"Digite um novo ID para o item: ");
                        id = Convert.ToInt32(Console.ReadLine());

                    }
                }


                Console.Write("Digite o nome do item: ");
                string? nome = Console.ReadLine();

                Item item = new Item() { ID = id, Nome = nome };

                listaItens.Add(item);
                listaItens = listaItens.OrderBy(x => x.ID).ToList();

                Console.WriteLine("\nItem adicionado com sucesso!");


            }

            catch (FormatException)
            {

                Console.WriteLine($"\nFormato digitado errado. Deve-se digitar somente número!");

            }
        }
        return listaItens;

    }

    //Exibir Lista de Itens
    public static void GetItens(List<Item> listaItens)
    {
        Console.WriteLine("\n-----------------------------------------------------\n");
        if (listaItens.Count == 0)
        {
            Console.WriteLine("\tLista vazia!");
        }

        else
        {
            Console.WriteLine("Lista de itens:\n");
            listaItens.ForEach(item => Console.WriteLine($"ID: {item.ID}\tNome: {item.Nome}"));
        }
        Console.WriteLine("\n-----------------------------------------------------\n");
    }

    //Remover Itens
    public static List<Item> RemoveItens(List<Item> listaItens)
    {
        bool entradaValida = false;
        while (!entradaValida)
        {
            try
            {

                Console.Write("\nDigite o ID do item que deseja remover: ");
                int id = Convert.ToInt32(Console.ReadLine());
                entradaValida = true;


                foreach (Item item in listaItens)
                {

                    if (id == item.ID)
                    {
                        listaItens.Remove(item);
                        Console.WriteLine($"\nID {id} removido com sucesso!");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"\nO ID {id} não foi encontrado!");
                    }

                }

            }
            catch (FormatException)
            {

                Console.WriteLine($"\nFormato digitado errado. Deve-se digitar somente número!");

            }

        }
        return listaItens;
    }

    //Editar Itens
    public static List<Item> EditItem(List<Item> listaItens)
    {
        Console.Write("\nDigite o ID do item que deseja editar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        foreach (Item item in listaItens)
        {
            if (id == item.ID)
            {
                Console.Write("\nDigite o novo nome do produto: ");
                item.Nome = Console.ReadLine();
                Console.WriteLine("\nNome alterado com sucesso!");
                break;
            }
            else
            {
                Console.WriteLine($"\nItem não encontrado!");
            }
        }
        return listaItens;
    }
}
