namespace Loesungen.Codesmells.RefusedBequest;

public class Auto : Fahrzeug
{
    private double tankstand = 50.0;
    private int geschwindigkeit;

    public override void Fahren()
    {
        if (tankstand.Equals(0.00))
            Tanken();

        SetzeGeschwindigkeit(30);
    }

    protected void Tanken() => tankstand = 50.0;
}
