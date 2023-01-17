namespace Loesungen.Codesmells.RefusedBequest;

public abstract class Fahrzeug
{
    private int geschwindigkeit = 0;

    public abstract void Fahren();

    protected void SetzeGeschwindigkeit(int geschwindigkeit) => this.geschwindigkeit = geschwindigkeit;
}
