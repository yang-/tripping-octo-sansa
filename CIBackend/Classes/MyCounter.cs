using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIBackend
{
    /// <summary>
    /// The <see cref="MyCounter"/> class is used to implement all platform non-specific, C# only code that can be
    /// shared between all mobile platforms being developed for, in this case iOS and Android. Use it to hold calculations and common
    /// processes such as communication with web services, databases, etc.
    /// </summary>
    [Serializable()]
    public class MyCounter
    {
        #region Private Variables
        #endregion

        #region Computed Properties
        /// <summary>
        /// Gets or sets the current value for the counter this <see cref="MyCounter"/> objects
        /// </summary>
        public int Counter { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new instance of the <see cref="MyCounter"/> class
        /// </summary>
        public MyCounter()
        {
            Counter = 0;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="MyCounter"/> class
        /// </summary>
        /// <param name="counter">The initial value for the counter</param>
        public MyCounter(int counter)
        {
            // Save the initial state
            this.Counter = counter;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Increments the counter and returns the new value
        /// </summary>
        /// <returns>The value of the counter after incementing</returns>
        public int Increment()
        {
            return ++Counter;
        }

        /// <summary>
        /// Decrements the counter and returns the new value
        /// </summary>
        /// <returns>The value of the counter after decrementing</returns>
        public int Decrement()
        {
            return --Counter;
        }
        #endregion
    }
}
