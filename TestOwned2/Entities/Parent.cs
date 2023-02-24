using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOwned2.Entities
{
    public class Parent 
    {
        private Parent()
        {
            //Ef Core
        }

        public Parent(Guid id, string testField1, List<ValueObject> values)
        {
            Id = id;
            TestField1 = testField1;
            Values = values;
        }

        public Guid Id { get; private set; }
        public string TestField1 { get; private set; }

        public List<ValueObject> Values { get; private set; }
    }
}
