using Radio.Core.Context;

namespace Radio.Core.Operation
{
    public interface IOperation
    {
        void Execute(IRadioContext context);
    }
}
