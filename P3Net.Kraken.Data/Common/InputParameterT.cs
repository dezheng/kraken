/*
 * Copyright � 2007 Michael Taylor
 * All Rights Reserved
 */
using System;
using System.Data;

namespace P3Net.Kraken.Data.Common
{
    /// <summary>Represents an input parameter.</summary>
    /// <typeparam name="T">The CLR type of the parameter.</typeparam>
    public class InputParameter<T> : DataParameter<T>
    {
        #region Construction

        /// <summary>Initializes an instance of the <see cref="InputParameter{T}"/> class.</summary>
        /// <param name="name">The name of the parameter.</param>
        public InputParameter(string name) : base(name, ParameterDirection.Input)
        { }        
        #endregion

        /// <summary>Sets the value of the parameter.</summary>
        /// <param name="value">The parameter value.</param>
        /// <returns>The updated parameter.</returns>
        public InputParameter<T> WithValue(T value)
        {
            Value = value;

            return this;
        }
    }
}
