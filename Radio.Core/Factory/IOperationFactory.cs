using Radio.Core.Enum;
using Radio.Core.Operation;

namespace Radio.Core.Factory
{
    public interface IOperationFactory
    {
        IOperation Operation(RadioOperation operation);
    }
}
