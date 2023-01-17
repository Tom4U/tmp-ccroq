namespace Challenges.Codesmells.ParallelInheritance;

public class FeinMechaniker : Mechaniker
{
    public override string Taetigkeit() => new FeinMechanikerTaetigkeit().Get();
}
