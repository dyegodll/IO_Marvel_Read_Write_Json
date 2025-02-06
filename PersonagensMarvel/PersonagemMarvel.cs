namespace PersonagensMarvel;

public class PersonagemMarvel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string AlterEgo { get; set; }
    public string Time { get; set; }

    public override string? ToString()
    {
        return $"Personagem {Id} [ {Nome} - {AlterEgo} - {Time} ]";
    }
}
