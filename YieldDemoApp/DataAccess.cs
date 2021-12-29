using System.Collections.Generic;

namespace YieldDemoApp
{
    public class DataAccess
    {
        public static IEnumerable<Person> GetPeople()
        {
            yield return new Person("Duy", "Phan");
            yield return new Person("Gordon", "Kiên");
            yield return new Person("Gavin", "Chí");
        }
    }
}