﻿using Radio.Core.Context;
using Radio.Core.Enum;
using System;

namespace Radio.Core.Context
{
    public class RadioContext : IRadioContext
    {
        private int _upperLimit;
        private int _targetNumber;
        private int _noOfMistakes;
        private int _enteredNumber;
        private NumberState _state;

        public int UpperLimit => _upperLimit;
        public int TargetNumber => _targetNumber;
        public int NoOfMistakes => _noOfMistakes;
        public int MaxNoOfMistakes => (_targetNumber / 5) + 5;
        public int EnteredNumber => _enteredNumber;

        public NumberState State => _state;

        public void SetUpperLimit(int upperLimit) {
            _upperLimit = upperLimit;
            GenerateTargetNumber();
        }

        public void SetEnteredNumber(int enteredNumber) =>
            _enteredNumber = enteredNumber;

        public void SetNumberState(NumberState state) =>
            _state = state;

        private void GenerateTargetNumber() =>
            _targetNumber = new Random().Next(1, _upperLimit);

        public void SetNoOfMistakes(int noOfMistakes) =>
            _noOfMistakes = noOfMistakes;
    }
}