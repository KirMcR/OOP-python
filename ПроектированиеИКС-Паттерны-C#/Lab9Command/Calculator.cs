namespace Lab9Command
{
    internal class Calculator
    {
        private readonly ArithmeticUnit _arithmeticUnit;
        private readonly ControlUnit _controlUnit;

        public Calculator()
        {
            _arithmeticUnit = new ArithmeticUnit();
            _controlUnit = new ControlUnit();
        }

        private double Run(Command command)
        {
            _controlUnit.StoreCommand(command);
            _controlUnit.ExecuteCommand();
            return _arithmeticUnit.Register;
        }

        public double Add(double operand)
        {
            return Run(new Add(_arithmeticUnit, operand));
        }
        //методы добавлены вКалькулятор
        public double Sub(double operand)
        {
            return Run(new Sub(_arithmeticUnit, operand));
        }

        public double Multiply(double operand)
        {
            return Run(new Multiply(_arithmeticUnit, operand));
        }

        public double Div(double operand)
        {
            return Run(new Div(_arithmeticUnit, operand));
        }

        public double Redo()
        {
            _controlUnit.Redo();
            return _arithmeticUnit.Register;
        }

        public double Redo(int i)
        {
            _controlUnit.Redo(i);
            return _arithmeticUnit.Register;
        }

        public double Undo()
        {
            _controlUnit.Undo();
            return _arithmeticUnit.Register;
        }

        public double Undo(int i)
        {
            _controlUnit.Undo(i);
            return _arithmeticUnit.Register;
        }
    }
}