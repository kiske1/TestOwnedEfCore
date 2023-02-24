using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOwned2.Entities
{
    public class ValueObject
    {
        public ValueObject(string field1, string field2)
        {
            Field1 = field1;
            Field2 = field2;
        }

        public string Field1 { get; private set; }
        public string Field2 { get; private set; }
    }
}
