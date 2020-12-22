using System;

namespace Lab10Decorator
{
    abstract class DecoratorOptions : AutoBase
    {
        public DecoratorOptions(AutoBase au, string title)
        {
            AutoProperty = au;
            Title = title;
        }

        public AutoBase AutoProperty { protected get; set; }
        public string Title { get; set; }
    }
}