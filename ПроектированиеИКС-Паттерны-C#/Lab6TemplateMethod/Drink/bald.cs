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
            Console.WriteLine("������� ������� ������");
        }

        protected override void Cutting()
        {
            Console.WriteLine("������������� �����");
        }
    }
}