namespace Loesungen.Adapter.Moveable;

internal class MovableKmphAdapter : IMovable
{
    private IMovable car;

    public MovableKmphAdapter(IMovable car) => this.car = car;

    public double GetSpeed() => ConvertMphToKmph(car.GetSpeed());

    private double ConvertMphToKmph(double mph) => mph * 1.60934;
}
