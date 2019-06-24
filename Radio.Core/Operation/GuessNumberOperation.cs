using Radio.Core.Context;

namespace Radio.Core.Operation
{
    public class GuessNumberOperation : IOperation
    {
        public void Execute(IRadioContext context)
        {
            if (context.NoOfMistakes == context.MaxNoOfMistakes)
                context.SetNumberState(Enum.NumberState.GameOver);
            else
                switch (context.TargetNumber.CompareTo(context.EnteredNumber))
                {
                    case -1:
                        context.SetNumberState(Enum.NumberState.Smaller);
                        context.SetNoOfMistakes(context.NoOfMistakes + 1);
                        context.SetPoints(context.Points - 100);
                        break;
                    case 0:
                        context.SetNumberState(Enum.NumberState.Bullseye);

                        if (context.NoOfMistakes < 5)
                            context.SetPoints(context.Points + 500);

                        break;
                    case 1:
                        context.SetNumberState(Enum.NumberState.Bigger);
                        context.SetNoOfMistakes(context.NoOfMistakes + 1);
                        context.SetPoints(context.Points - 100);
                        break;
                }
        }
    }
}
