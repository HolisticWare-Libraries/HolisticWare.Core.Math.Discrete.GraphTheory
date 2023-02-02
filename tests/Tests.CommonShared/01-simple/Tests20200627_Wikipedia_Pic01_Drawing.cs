// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
using ShortRunJob = HolisticWare.Core.Testing.BenchmarkTests.ShortRunJob;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Core.Math.Discrete.GraphTheory.Graphs;

namespace UnitTests.Core.Math.Discrete.GraphTheory.Graphs
{
    /// <summary>
    /// Test01
    /// </summary>
    /// <see href="https://www.geeksforgeeks.org/graph-data-structure-and-algorithms/"/>
    [TestClass]
    public partial class Tests20200627_Wikipedia_Pic01_Drawing
    {
        [Test]
        public void GraphCreate()
        {
            // create object
            Node<int>   n1 = new Node<int>();
                        // modify property
                        n1.Label = "1";

            // create object
            Node<int> n2 = new Node<int>();
                        // modify property
                        n2.Label = 2.ToString();

            // create object with initializer
            Node<int> n3 = new Node<int>()
                                {
                                    Label = "3"
                                };
            Node<int> n4 = new Node<int>()
                                {
                                    Label = "4"
                                };
            Node<int> n5 = new Node<int>()
                                {
                                    Label = "5"
                                };
            Node<int> n6 = new Node<int>()
                                {
                                    Label = "6"
                                };

            //Console.WriteLine($" Node n1 = {n1.ToString()}");
            //Console.WriteLine($" Node n2 = {n2.ToString()}");

            // declaration
            Edge<string, int> e1;
            // definition
            e1 = new Edge<string, int>(n6, n4);
            e1.Label = "n6, n4";

            Edge<string, int> e2 = new Edge<string, int>(n4, n3)
                                            {
                                                Label = "n4, n3"
                                            };
            Edge<string, int> e3 = new Edge<string, int>(n4, n5)
                                            {
                                                Label = "n4, n5"
                                            };
            Edge<string, int> e4 = new Edge<string, int>(n2, n3)
                                            {
                                                Label = "n2, n3"
                                            };
            Edge<string, int> e5 = new Edge<string, int>(n5, n2)
                                            {
                                                Label = "n5, n2"
                                            };
            Edge<string, int> e6 = new Edge<string, int>(n2, n1)
                                            {
                                                Label = "n2, n1"
                                            };
            Edge<string, int> e7 = new Edge<string, int>(n5, n1)
                                            {
                                                Label = "n5, n1"
                                            };

            Console_WriteLine($" Edge<string, int> e1 = {e1.ToString()}");
            Console_WriteLine($" Edge<string, int> e2 = {e2.ToString()}");


            Graph<int, string> g = new Graph<int, string>();

            g.Add(n1);
            
            return;
        }

        public void Console_WriteLine(string message)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(System.Console.OpenStandardOutput()))
            {
                writer.WriteLine(message);
            }

        }

    }
}
