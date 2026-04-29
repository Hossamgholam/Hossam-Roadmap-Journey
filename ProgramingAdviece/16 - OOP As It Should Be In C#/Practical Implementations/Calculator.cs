using System;
namespace ConsoleApp1
{
    class ClsCalculator
    {
        private enum Operation{Clear,Add,SubTract,Divide,Multiply};
        private int _value=0;
        private int _input=0;
        
        private Operation enOperation=Operation.Clear;
      
        
        public void Clear()
        {
            enOperation=Operation.Clear;
            _input=0;
          
            _value=0;
        }
        public void add(int number)
        {
            enOperation=Operation.Add;
            _input=number;
            
            _value+=number;
        }
        public void SubTract(int Number)
        {
            enOperation=Operation.SubTract;
            _input=Number;
           
            _value-=Number;
        }
        public void Divide(int Number)
        {
            enOperation=Operation.Divide;

            if (Number<=0)
            {
                Number=1;
            }
            _input=Number;
           
            _value/=Number;

        }
        public void Multiply(int Number)
        {
            enOperation=Operation.Multiply;
            _input=Number;
            
            _value*=Number;
        }
        
        public void PrintResult()
        {
            Console.WriteLine($"Result after {enOperation} {_input} is :{_value}");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsCalculator c1=new ClsCalculator();
            c1.Clear();
            c1.add(10);
            c1.PrintResult();
            c1.add(100);
            c1.PrintResult();
            c1.SubTract(20);
            c1.PrintResult();
            c1.Divide(0);
            c1.PrintResult();
            c1.Divide(2);
            c1.PrintResult();
            c1.Multiply(3);
            c1.PrintResult();

            c1.Clear();
            c1.PrintResult();
        }
    }
}