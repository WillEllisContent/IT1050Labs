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

        public void AddPerson(Person NewPerson)
        {
         int age = NewPerson.Age;
         int spouseage = NewPerson.SpouseAge;
        _sumOfAllAges = _sumOfAllAges + age;
        _totalNumberOfPeople = _totalNumberOfPeople + 1;
        }
    }
}