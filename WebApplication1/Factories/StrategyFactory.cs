using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1
{
    public class StrategyFactory : IStrategyFactory
    {
        private IEnumerable<IGenericStrategy> _strategies;

        public StrategyFactory(IEnumerable<IGenericStrategy> strategies)
        {
            _strategies = strategies;
        }


        public IGenericStrategy GetStrategy(object T)
        {
            var supportedStrategy = _strategies
               .FirstOrDefault(x => x.Type == T.GetType());

            if (supportedStrategy == null)
            {
                throw new InvalidOperationException($"No supported strategy found for object'{T.GetType().ToString()}'.");
            }

            return supportedStrategy;

        }


    }
}
