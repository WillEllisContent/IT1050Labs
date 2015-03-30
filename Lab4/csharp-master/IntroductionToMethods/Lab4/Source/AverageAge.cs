namespace Lab4
{
    public class AverageAge
    {
        private double _sumOfAllAges = 0;
        private int _totalNumberOfPeople = 0;

        public double Get()
        {
            return _sumOfAllAges / _totalNumberOfPeople;
        }

        public void AddPerson(Person NewPerson)
        {
         int Age = NewPerson.Age;
         _sumOfAllAges = _sumOfAllAges + Age;
         _totalNumberOfPeople = _totalNumberOfPeople + 1;
        }
    }
}