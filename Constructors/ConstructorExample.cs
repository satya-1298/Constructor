using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class ConstructorExample
    {
        //It is having same name as the class name
        //It is similar to method however it does not have return type
        //no.of constructors can be created but with different parameters
        public ConstructorExample() 
        {
            Console.WriteLine("hello");
        }
        public ConstructorExample(string name) 
        {
            Console.WriteLine(name);
        }
    }
}
