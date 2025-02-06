using PersonagemServices;
using PersonagensMarvel;

string path = "C:/Users/dyego.lima/source/repos/IO_Read_Write_Json/IO_Read_Write_Json/bin/Debug/net8.0";

string doc1 = "/personagens_marvel.txt";
string pathDoc1 = $"{path}{doc1}";
List<PersonagemMarvel> lista = PersonagemMarvelServices.LerArquivoPersonagem(pathDoc1);

string doc2 = "/personagens_marvel.csv";
string pathDoc2 = $"{path}{doc2}";
PersonagemMarvelServices.EscreverArquivoPersonagem(pathDoc2, lista);

string doc3 = "/personagens_marvel.json";
string pathDoc3 = $"{path}{doc3}";
PersonagemMarvelServices.EscreverArquivoJsonPersonagem(pathDoc3,lista);