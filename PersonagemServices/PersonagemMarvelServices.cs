using Newtonsoft.Json;
using PersonagensMarvel;
using System.Text;

namespace PersonagemServices;

public class PersonagemMarvelServices
{
    public static List<PersonagemMarvel> LerArquivoPersonagem(string path)
    {
        List<PersonagemMarvel> list = new List<PersonagemMarvel> ();

        using( var fs = new FileStream(path, FileMode.Open) )
            using (var reader = new StreamReader(fs, Encoding.UTF8))
        {
            while (!reader.EndOfStream)
            {
                var linha = reader.ReadLine()!;
                string[] coluna = linha.Split('\t'); //verificar no arquivo como está a separação

                if (coluna.Length < 4) continue;

                PersonagemMarvel pm = new PersonagemMarvel();
                pm.Id = int.Parse(coluna[0]);
                pm.Nome = (coluna[1]);
                pm.AlterEgo = (coluna[2]);
                pm.Time = (coluna[3]);

                list.Add(pm);
                Console.WriteLine(pm.ToString());
            }
        }
      return list;
    }

    public static void EscreverArquivoPersonagem(string path, List<PersonagemMarvel> list)
    {
        using(var fs = new FileStream(path,FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(fs, Encoding.UTF8))
        {
            foreach(var personagem in list)
            {
                writer.WriteLine(personagem.ToString());
            }
            Console.WriteLine($"\n\nArquivo salvo em {path}\n");
        }
    }

    public static void EscreverArquivoJsonPersonagem(string path, List<PersonagemMarvel> list)
    {
        //Necessário -> using Newtonsoft.Json
        string json = JsonConvert.SerializeObject(list, Formatting.Indented);

        File.WriteAllText(path, json, Encoding.UTF8);

        Console.WriteLine($"Arquivo JSON salvo em: {path}");
    }

}