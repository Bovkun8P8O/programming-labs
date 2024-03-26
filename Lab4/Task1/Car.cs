namespace Lab4
{
    internal class Car
    {
        private string carBrand;
        private Engine engine;
        private Wheel[] wheels;
        private const int wheelsAmount = 4;

        public Car(string carBrand, string engineModel, Wheel.WheelType Type)
        {
            this.carBrand = carBrand;
            engine = new Engine(engineModel);
            wheels = new Wheel[wheelsAmount];
            for (int i = 0; i < wheelsAmount; i++)
            {
                wheels[i] = new Wheel((Wheel.WheelPosition)i, Type);
            }
            Console.WriteLine($"Car created ({carBrand}, {engineModel}, {Type}).");
        }

        public void Drive()
        {
            if (engine.IsEngineWorking == true)
            {
                engine.IsEngineStarted = true;
                Console.WriteLine($"The car is driving.");
            }
            else
            {
                Console.WriteLine("The engine is broken.");
            }
        }

        public void Refuel()
        {
            Console.WriteLine("The car is refueling.");
        }

        public void ReplaceWheel(int index, Wheel.WheelType Type)
        {
            wheels[index] = new Wheel((Wheel.WheelPosition)index, Type);
            Console.WriteLine($"The wheel {wheels[index].Position} is replaced. Type: {Type}.");
        }

        public void ReplaceWheel(Wheel.WheelPosition Position, Wheel.WheelType Type)
        {
            wheels[(int)Position] = new Wheel(Position, Type);
            Console.WriteLine($"The wheel {wheels[(int)Position].Position} is replaced. Type: {Type}.");
            return;
        }

        public void PrintCarBrand()
        {
            Console.WriteLine($"The car brand is {carBrand}.");
        }

        public override bool Equals(object obj)
        {
            if (obj is Car car)
            {
                bool areTypesEqual = true;
                for (int i = 0; i < wheelsAmount; i++)
                {
                    if (wheels[i].Type != car.wheels[i].Type)
                    {
                        areTypesEqual = false;
                        break;
                    }
                }
                return carBrand == car.carBrand && engine.EngineModel == car.engine.EngineModel && areTypesEqual;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(carBrand, engine, wheels);
        }

        public override string ToString()
        {
            string wheels = "";
            foreach (Wheel wheel in this.wheels)
            {
                wheels += wheel.Position + ", " + wheel.Type + ";\t";
            }
            return $"Car brand: {carBrand}, Engine: {engine.EngineModel}, Wheels: {wheels}";
        }
    }
}
