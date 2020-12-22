using System;

namespace Lab6TemplateMethod.Drink
{
    public class bald : haircut
    {
        
        public bald() : base("bald")
        {
        }
        protected override void Prepare()
        {
            Console.WriteLine("Достать опасную бритву");
        }

        protected override void Cutting()
        {
            Console.WriteLine("Аккуратненько бреем");
        }
    }
}