using DesafioTecnicoIBID;

bool entradaValida = false;
bool controle = true;
List<Item> listaItens = new List<Item>();

while (!entradaValida)
{

    try
    {
    
        Metodos.Menu(controle, listaItens);
        entradaValida = true;
    }

    catch (FormatException)
    {

        Console.WriteLine($"\nFormato digitado errado. Deve-se digitar somente número!");
    
    }

    finally
    {
    
            Console.WriteLine("\nObrigado por utlizar o sistema!");
            Console.WriteLine("\nFim da Execução...\n\n");
    }

}


