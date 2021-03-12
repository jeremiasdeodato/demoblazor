using Fluxor;

namespace BlazorDemo.Store
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounter action)
        {
            //TS => {...state, Count: state.Count }
            return state with
            {
                Count = state.Count + 1
            };
        }
    }
}