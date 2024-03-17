// here the idea is at every time the player innit the game change he scripture

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();

        _scriptures.Add(new Scripture(new Reference("Juan", 3, 16), "Porque de tal manera amó Dios al mundo, que ha dado a su Hijo unigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna."));
        _scriptures.Add(new Scripture(new Reference("1 Juan", 5, 7), " Porque tres son los que dan testimonio en el cielo: el Padre, el Verbo y el Espíritu Santo; y estos tres son uno."));
        _scriptures.Add(new Scripture(new Reference("DC", 8, 2), "Sí, he aquí, hablaré a tu mente y a tu corazón por medio del Espíritu Santo que vendrá sobre ti y morará en tu corazón."));
        _scriptures.Add(new Scripture(new Reference("Eter", 4, 9), "Y por mi mandato se abre la tierra y los cielos y por mi palabra temblara la tierra y por mi mandato sus habitantes pasaran coomo si fuera por fuego."));

    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
