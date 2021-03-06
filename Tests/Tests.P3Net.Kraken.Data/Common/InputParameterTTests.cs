﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using P3Net.Kraken.Data.Common;
using P3Net.Kraken.UnitTesting;

namespace Tests.P3Net.Kraken.Data.Common
{
    [TestClass]
    public class InputParameterTTests : UnitTest
    {
        #region Ctor
        
        [TestMethod]
        public void Ctor_WithName ()
        {
            var target = new InputParameter<int>("@p1");

            //Assert
            target.Name.Should().Be("@p1");
            target.DbType.Should().Be(DbType.Int32);
        }

        [TestMethod]
        public void Ctor_NameIsEmpty ()
        {            
            Action action = () => new InputParameter<int>("");

            action.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void Ctor_NameIsNull ()
        {
            Action action = () => new InputParameter<int>(null);

            action.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void Ctor_WithUnknownType ()
        {
            var target = new InputParameter<Tuple<string>>("@p1");

            //Assert
            target.DbType.Should().Be(DbType.Object);
        }
        #endregion

        #region WithValue

        [TestMethod]
        public void WithValue_IsValid ()
        {
            var expected = 40;

            var target = new InputParameter<int>("@in1")
                                .WithValue(expected);

            //Assert
            target.Value.Should().Be(expected);
        }
        #endregion
    }
}
