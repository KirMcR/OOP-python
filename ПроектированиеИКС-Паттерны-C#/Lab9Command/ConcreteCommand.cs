namespace Lab9Command
{
    internal class Add : Command
    {
        public Add(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('+', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('-', Operand);
        }
    }
    //добавлена команда вычитания
    internal class Sub : Command
    {
        public Sub(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('-', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('+', Operand);
        }
    }
    //+умножение
    internal class Multiply : Command
    {
        public Multiply(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('*', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('/', Operand);
        }
    }
    //деление
    internal class Div : Command
    {
        public Div(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('/', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('*', Operand);
        }
    }
}