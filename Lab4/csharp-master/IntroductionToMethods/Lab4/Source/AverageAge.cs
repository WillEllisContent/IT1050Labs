namespace Lab4
{
    public class AverageAge
    {
        public double _sumOfAllAges;
        public double _totalNumberOfPeople;

        public double Get()
        {
            return _sumOfAllAges / _totalNumberOfPeople;
        }

        public void AddPerson(Person personAdd)
        {
            _sumOfAllAges = _sumOfAllAges + personAdd.Age;
            _totalNumberOfPeople = _totalNumberOfPeople + 1;

            if (personAdd.Married)
            {
              _totalNumberOfPeople = _totalNumberOfPeople + 1;
              _sumOfAllAges = _sumOfAllAges + personAdd.Spouse.Age;
            }
        }
    }
}