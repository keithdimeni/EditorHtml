using System.Text;

namespace EditorHtml;
public static class Editor
{
    // Modo Edicao
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("-------------------");
        Start();

    }

    public static void Start()
    {
        StringBuilder? file = new StringBuilder();

        do
        {
            file.AppendLine(Console.ReadLine());
            file.AppendLine(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("-------------------");
        Console.WriteLine("Deseja salvar o arquivo([s]-Sim | [n]-Não)?");
       
        string isSave = Console.ReadLine();
        if (isSave.ToLower() == "s")
        {
            save(file.ToString());
            Console.WriteLine("Arquivo salvo com sucesso!");
            Console.ReadKey();
        }
        Exibicao.Show(file.ToString());
        //Show();
    }

    public static void save(string text)
    {
        Console.WriteLine("Qual o caminho para salvar o arquivo?");
        string? path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
    }

}
