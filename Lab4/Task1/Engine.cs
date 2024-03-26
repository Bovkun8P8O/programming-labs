namespace Lab4
{
    internal class Engine
    {
        private string engineModel;
        private bool isEngineWorking = true;
        private bool isEngineStarted = false;

        internal Engine(string engineModel = "null")
        {
            this.engineModel = engineModel;
            Console.WriteLine($"Engine {this.engineModel} created.");
        }

        internal string EngineModel 
        {
            get => engineModel;
            set => engineModel = value;
        }
        internal bool IsEngineWorking 
        {
            get => isEngineWorking;
            set => isEngineWorking = value;
        }
        internal bool IsEngineStarted 
        {
            get => isEngineStarted;
            set => isEngineStarted = value;
        }
    }
}
