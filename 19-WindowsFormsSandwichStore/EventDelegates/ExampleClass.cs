using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegates
{
    class ExampleClass
    {
        // Declare a delegates
        public delegate void DoSomething(int sum);

        public DoSomething Something;

        // assign
        public ExampleClass()
        {
            //Something = FunctionOne;

            //// call the functionOne
            ////if(Something != null) Something(123);
            //// same as above
            //Something?.Invoke(345);

            //// call funtionTow
            //Something = FunctionTwo;
            //Something?.Invoke(123);

            // call both
            Something += FunctionOne;
            Something += FunctionTwo;
            Something?.Invoke(999);

        }

        private void FunctionOne(int num)
        {
            Console.WriteLine($"Function one called with value: {num}");
        }

        private void FunctionTwo(int num)
        {
            Console.WriteLine($"Function two called with value: {num}");
        }
    }
}
