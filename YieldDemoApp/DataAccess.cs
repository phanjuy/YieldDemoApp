using System.Collections.Generic;

namespace YieldDemoApp
{
    public class DataAccess
    {
        public static IEnumerable<Person> GetPeople()
        {
            List<Person> output = new();

            output.Add(new Person("Duy", "Phan"));
            output.Add(new Person("Gordon", "Kiên"));
            output.Add(new Person("Gavin", "Chí"));

            return output;
        }
    }
}