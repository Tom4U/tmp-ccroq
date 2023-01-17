namespace Loesungen.Codesmells.ParallelInheritance;

public class AutoMechaniker : Mechaniker, Taetigkeit
{
    public string? Name { get; set; }

    public string Taetigkeit(Mechaniker mechaniker) => "Repariert Autos";
}
