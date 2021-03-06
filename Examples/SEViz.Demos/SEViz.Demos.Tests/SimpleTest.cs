// <copyright file="SimpleTest.cs">Copyright ©  2015</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEViz.Demos;
using SEViz.Monitoring;

namespace SEViz.Demos.Tests
{
    /// <summary>This class contains parameterized unit tests for Simple</summary>
    [PexClass(typeof(Simple))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SimpleTest
    {
        /// <summary>Test stub for ForLoop(Int32, Boolean)</summary>
        [SEViz]
        [PexMethod]
        public void ForLoopTest(
            [PexAssumeUnderTest]Simple target,
            int bound,
            bool decision
        )
        {
            target.ForLoop(bound, decision);
            // TODO: add assertions to method SimpleTest.ForLoopTest(Simple, Int32, Boolean)
        }

        /// <summary>Test stub for IfBranching(Int32)</summary>
        [SEViz]
        [PexMethod]
        public bool IfBranchingTest([PexAssumeUnderTest]Simple target, int condition)
        {
            bool result = target.IfBranching(condition);
            return result;
            // TODO: add assertions to method SimpleTest.IfBranchingTest(Simple, Int32)
        }

        /// <summary>Test stub for SwitchBranching(Int32)</summary>
        [SEViz]
        [PexMethod]
        public int SwitchBranchingTest([PexAssumeUnderTest]Simple target, int condition)
        {
            int result = target.SwitchBranching(condition);
            return result;
            // TODO: add assertions to method SimpleTest.SwitchBranchingTest(Simple, Int32)
        }

        /// <summary>Test stub for SwitchAndFor(Int32, Boolean, Int32)</summary>
        [SEViz]
        [PexMethod]
        public int SwitchAndForTest(
            [PexAssumeUnderTest]Simple target,
            int type,
            bool b,
            int bound
        )
        {
            int result = target.SwitchAndFor(type, b, bound);
            return result;
            // TODO: add assertions to method SimpleTest.SwitchAndForTest(Simple, Int32, Boolean, Int32)
        }
    }
}
