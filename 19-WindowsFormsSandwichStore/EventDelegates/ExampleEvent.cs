using System;

namespace EventDelegates
{
    internal class ExampleEvent
    {
        //public EventHandler Someaction;
        //public Action Someaction = () => { };
        public Action<int> Someaction;
        public ExampleEvent()
        {
            //Someaction(this, EventArgs.Empty);
            //Someaction = () => { };
            Someaction += FunctionOne;
            Someaction += FuntionTwo;
        }

        private void FuntionTwo(int num)
        {
            Console.WriteLine($"Function Two called with the value: {num}");
        }

        private void FunctionOne(int num)
        {
            Console.WriteLine($"Function One called with the value: {num}");
        }
    }
}