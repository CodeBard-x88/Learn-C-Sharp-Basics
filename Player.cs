using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_C_
{
    internal class Player
    {
        //By default, methods and attributes are private
        // public: can be accessed inside and outside of the assembly
        // internal: can be accessed within the assembly
        // protected: can be accessed within the class and child classes
        // protected internal: the member is accessible within the same and derived classes and also within the
        //                     assembly 

        private int age;


        
        public Player(int n)
        {
            age = n;
        }

        public void Printage()
        {
            Console.WriteLine(age);
        }
    }
}
