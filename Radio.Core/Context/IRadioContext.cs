using Radio.Core.Enum;

namespace Radio.Core.Context
{
    public interface IRadioContext
    {
        int UpperLimit { get; }
        int NoOfMistakes { get; }
        int MaxNoOfMistakes { get; }
        int EnteredNumber { get; }
        int TargetNumber { get; }
        NumberState State { get; }
        int Points { get; }

        void SetUpperLimit(int upperLimit);
        void SetEnteredNumber(int enteredNumber);
        void SetNumberState(NumberState state);
        void SetNoOfMistakes(int noOfMistakes);
        void SetPoints(int points);
    }
}
