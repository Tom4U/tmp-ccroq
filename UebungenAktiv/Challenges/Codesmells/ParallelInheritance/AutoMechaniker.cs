namespace Challenges.Codesmells.ParallelInheritance;

public class AutoMechaniker : Mechaniker
{
    public override string Taetigkeit() => new AutoMechanikerTaetigkeit().Get();
}
