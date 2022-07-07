namespace Builder.StepwiseBuilder.Interfaces
{
    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType carType);
    }
}
