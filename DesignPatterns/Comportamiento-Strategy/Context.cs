﻿namespace DesignPatterns.Comportamiento_Strategy
{
    public class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
