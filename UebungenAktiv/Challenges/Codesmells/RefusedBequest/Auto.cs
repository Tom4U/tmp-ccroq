namespace Challenges.Codesmells.RefusedBequest;

public class Auto
{
    private double tankstand = 50.0;
    private int geschwindigkeit;

    public virtual void Fahren()
    {
        if (tankstand.Equals(0.00))
            Tanken();

        SetzeGeschwindigkeit(30);
    }

    protected void SetzeGeschwindigkeit(int geschwindigkeit) => this.geschwindigkeit = geschwindigkeit;

    protected void Tanken() => tankstand = 50.0;
}
