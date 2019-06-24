using Radio.Core.Enum;
using Radio.Core.Operation;
using System.Collections.Generic;

namespace Radio.Core.Factory
{
    public class RadioOperationFactory : IOperationFactory
    {
        private static RadioOperationFactory _instance;
        public static RadioOperationFactory Instance =>
            _instance ?? (_instance = new RadioOperationFactory());
        

        private Dictionary<RadioOperation, IOperation> _operations = new Dictionary<RadioOperation, IOperation>();

        private RadioOperationFactory()
        {
            _operations.Add(RadioOperation.GuessNumber, new GuessNumberOperation());
            _instance = this;
        }

        public IOperation Operation(RadioOperation operation) =>
            _operations[operation];
    }
}
