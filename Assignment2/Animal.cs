namespace Assignment2
{
    public sealed class Animal
    {
        private Animal() { }
        private static Animal _animalInstance;
        public static Animal GetInstance()
        {
            if (_animalInstance == null)
            {
                _animalInstance = new Animal();
            }
            return _animalInstance;
        }
    }
}
