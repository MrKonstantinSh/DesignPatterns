using Builder.StepwiseBuilder.Interfaces;

namespace Builder.StepwiseBuilder
{
    public class CarBuilder
    {
        private class CarBuilderImplementation : ISpecifyCarType, ISpecifyWheelSize, ICarBuilder
        {
            private readonly Car _car = new();

            public ISpecifyWheelSize OfType(CarType carType)
            {
                _car.Type = carType;

                return this;
            }

            public ICarBuilder WithWheelSize(int wheelSize)
            {
                _car.WheelSize = wheelSize;

                return this;
            }

            public Car Build()
            {
                return _car;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new CarBuilderImplementation();
        }
    }
}
