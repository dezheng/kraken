/*
 * Copyright � 2007 Michael Taylor
 * All Rights Reserved
 */
using System;
using System.Data;

namespace P3Net.Kraken.Data.Common
{
    /// <summary>Represents an output parameter.</summary>
    /// <typeparam name="T">The CLR type of the parameter.</typeparam>
    /// <seealso cref="DbTypeMapper"/>
    public class OutputParameter<T> : DataParameter<T>
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="OutputParameter{T}"/> class.</summary>
        /// <param name="name">The name of the parameter.</param>
        public OutputParameter(string name) : base(name, ParameterDirection.Output)
        { }

        /// <summary>Initializes an instance of the <see cref="OutputParameter{T}"/> class.</summary>
        /// <param name="name">The name of the parameter.</param>
        /// <returns>The instance.</returns>
        public static OutputParameter<T> Named(string name)
        {
            return new OutputParameter<T>(name);
        }
        #endregion

        #region Public Members

        /// <summary>Gets the current typed value.</summary>
        /// <returns>The typed parameter value.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
        public T GetValue()
        {
            return TypedValue;
        }
        #endregion
    }
}
