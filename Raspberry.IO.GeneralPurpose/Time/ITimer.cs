using System;

namespace Raspberry.IO.GeneralPurpose.Time
{
    internal interface ITimer
    {
        /// <summary>
        /// Gets or sets the interval, in milliseconds.
        /// </summary>
        /// <value>
        /// The interval, in milliseconds.
        /// </value>
        decimal Interval { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        /// <value>
        /// The action.
        /// </value>
        Action Action { get; set; }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <param name="delay">The delay before the first occurence, in milliseconds.</param>
        void Start(decimal delay);

        /// <summary>
        /// Stops this instance.
        /// </summary>
        void Stop();
    }
}