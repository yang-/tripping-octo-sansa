namespace CIBackend
{
    using System;

    /// <summary>
    ///   The <see cref="CounterLogic" /> class is used to implement all platform non-specific, C# only code that can be
    ///   shared between all mobile platforms being developed for, in this case iOS and Android. Use it to hold calculations and common
    ///   processes such as communication with web services, databases, etc.
    /// </summary>
    [Serializable]
    public class CounterLogic
    {
        /// <summary>
        ///   Creates a new instance of the <see cref="CounterLogic" /> class
        /// </summary>
        public CounterLogic()
        {
            Counter = 0;
        }

        /// <summary>
        ///   Creates a new instance of the <see cref="CounterLogic" /> class
        /// </summary>
        /// <param name="counter">The initial value for the counter</param>
        public CounterLogic(int counter)
        {
            // Save the initial state
            Counter = counter;
        }

        /// <summary>
        ///   Gets or sets the current value for the counter this <see cref="CounterLogic" /> objects
        /// </summary>
        public int Counter { get; set; }

        /// <summary>
        ///   Decrements the counter and returns the new value
        /// </summary>
        /// <returns>The value of the counter after decrementing</returns>
        public int Decrement()
        {
            return --Counter;
        }

        /// <summary>
        ///   Increments the counter and returns the new value
        /// </summary>
        /// <returns>The value of the counter after incementing</returns>
        public int Increment()
        {
            return ++Counter;
        }
    }
}
