namespace Lab9Command
{
    internal abstract class Command
    {
        protected double Operand;
        protected ArithmeticUnit Unit;
        public abstract void Execute();
        public abstract void UnExecute();
    }
}