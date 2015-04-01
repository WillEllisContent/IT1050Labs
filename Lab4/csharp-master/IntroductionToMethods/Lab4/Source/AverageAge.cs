namespace Lab4
{
    public class AverageAge
    {
        private double _sumOfAllAges;
        private int _totalNumberOfPeople;

        public double Get()
        {
            return _sumOfAllAges / _totalNumberOfPeople;
        }

        public void AddPerson(Person personAdd)
        {
            _sumOfAllAges = _sumOfAllAges + personAdd.Age;
            _totalNumberOfPeople = _totalNumberOfPeople + 1;
        }
    }
}