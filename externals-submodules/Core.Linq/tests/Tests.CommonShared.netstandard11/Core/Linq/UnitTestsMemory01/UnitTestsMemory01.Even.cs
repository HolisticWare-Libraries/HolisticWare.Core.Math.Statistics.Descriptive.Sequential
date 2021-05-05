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
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
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
using System.Text;
using Core.Linq;
using System.Collections;
using System.Linq;

namespace Tests.CommonShared.Core.Linq
{
    public partial class UnitTestsMemory01
    {
        [Benchmark()]
        public IEnumerable<byte> Memory_Byte_Even(Memory<byte> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Byte_Even_Test()
        {
            IEnumerable<byte> calculated_even_byte = Memory_Byte_Even(data_array_byte.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_byte, 
                                        data_array_even_result_actual_byte
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_even_byte, 
                                        data_array_even_result_actual_byte
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_byte.ToList(),
                                        data_array_even_result_actual_byte
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<short> Memory_Short_Even(Memory<short> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Short_Even_Test()
        {
            IEnumerable<short> calculated_even_short = Memory_Short_Even(data_array_short.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_short, 
                                        data_array_even_result_actual_short
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_even_short, 
                                        data_array_even_result_actual_short
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_short.ToList(),
                                        data_array_even_result_actual_short
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<ushort> Memory_UShort_Even(Memory<ushort> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_UShort_Even_Test()
        {
            IEnumerable<ushort> calculated_even_ushort = Memory_UShort_Even(data_array_ushort.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_ushort, 
                                        data_array_even_result_actual_ushort
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_even_ushort, 
                                        data_array_even_result_actual_ushort
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_ushort.ToList(),
                                        data_array_even_result_actual_ushort
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<int> Memory_Int_Even(Memory<int> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Int_Even_Test()
        {
            IEnumerable<int> calcuated_even_int = Memory_Int_Even(data_array_int.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calcuated_even_int, 
                                        data_array_even_result_actual_int
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calcuated_even_int, 
                                        data_array_even_result_actual_int
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calcuated_even_int.ToList(),
                                        data_array_even_result_actual_int
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<uint> Memory_UInt_Even(Memory<uint> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_UInt_Even_Test()
        {
            IEnumerable<uint> calculated_even_uint = Memory_UInt_Even(data_array_uint.AsMemory());

            // Assert
        #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_uint, 
                                        data_array_even_result_actual_uint
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_even_uint, 
                                        data_array_even_result_actual_uint
                                    );
        #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_uint.ToList(),
                                        data_array_even_result_actual_uint
                                    );
        #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<long> Memory_Long_Even(Memory<long> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_Long_Even_Test()
        {
            IEnumerable<long> calculated_even_long = Memory_Long_Even(data_array_long.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_long, 
                                        data_array_even_result_actual_long
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_even_long, 
                                        data_array_even_result_actual_long
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_long.ToList(),
                                        data_array_even_result_actual_long
                                    );
            #endif

            return;
        }

        [Benchmark()]
        public IEnumerable<ulong> Memory_ULong_Even(Memory<ulong> memory)
        {
            return memory.Even();
        }

        [Test()]
        public void Memory_ULong_Even_Test()
        {
            IEnumerable<ulong> calculated_even_ulong = Memory_ULong_Even(data_array_ulong.AsMemory());

            // Assert
            #if NUNIT
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_ulong, 
                                        data_array_even_result_actual_ulong
                                    );
            #elif XUNIT
            Assert.Equal
                                    (
                                        calculated_even_ulong,
                                        data_array_even_result_actual_ulong
                                    );
            #elif MSTEST
            CollectionAssert.AreEqual
                                    (
                                        calculated_even_ulong.ToList(),
                                        data_array_even_result_actual_ulong
                                    );
            #endif

            return;
        }

     }
}
