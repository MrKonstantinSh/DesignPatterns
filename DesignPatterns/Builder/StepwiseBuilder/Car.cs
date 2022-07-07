namespace Builder.StepwiseBuilder
{
    public class Car
    {
        public CarType Type { get; set; }
        public int WheelSize { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}, Wheel size: {WheelSize}";
        }
    }
}
