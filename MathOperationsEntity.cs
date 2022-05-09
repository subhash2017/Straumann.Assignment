using System;

namespace Straumann.Assignment
{
    public class MathOperationsEntity
    {
        public int OperationId { get; set; }
        public string OperationType { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public enum MathOperationsType
    {
        Add, 
        Subtract,
        Multiple, 
        Division
    }
}
