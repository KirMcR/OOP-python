using System;

namespace Lab6TemplateMethod.Drink
{
    public class beautiful : haircut
    {
        public beautiful() : base("beautiful")
        {
        }

        protected override void Prepare()
        {
            Console.WriteLine("ДАстаем ножницы");
        }

        protected override void Cutting()
        {
            Console.WriteLine("Профилируе немного");
        }
    }
}