namespace Lab4
{
    internal class Wheel
    {
        internal enum WheelType
        {
            Winter,
            Summer,
            AllSeason
        }
        internal enum WheelPosition
        {
            FrontLeft,
            FrontRight,
            RearLeft,
            RearRight
        }
        internal WheelType Type { get; set; }
        internal WheelPosition Position { get; set; }

        internal Wheel(WheelPosition Position, WheelType Type)
        {
            this.Position = Position;
            this.Type = Type;
            Console.WriteLine($"Wheel {Position} {Type} created.");
        }
    }
}
