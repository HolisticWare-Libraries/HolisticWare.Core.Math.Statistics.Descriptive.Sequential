// /*
//    Copyright (c) 2018-3
//
//    moljac
//    UnitTests.cs
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
using System;

using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

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
using Fact=NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

using Core.Math.Statistics.Descriptive;

namespace UnitTests.Core.Math.Statistics.Descriptive.Sequential.Sync.Qualitative.Classes
{
    [TestClass] // for MSTest - NUnit [TestFixture] and XUnit not needed
    public partial class UnitTestsQualitativePersons
    {
        Dictionary<EyeColor, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)> fc =
            new Dictionary<EyeColor, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>()
                                    {
                                        { EyeColor.Blue, ( 4, 0.500, 4 ) },
                                        { EyeColor.Gray, ( 2, 0.250, 6 ) },
                                        { EyeColor.Green, ( 1, 0.125, 7 ) },
                                        { EyeColor.Hazel, ( 1, 0.125, 8 ) },
                                    };

        [Test()]
        public void Frequencies()
        {
            IEnumerable<EyeColor> data_eyecolors =
                                                    from Person p in Persons
                                                    select p.EyeColor;

            IEnumerable<KeyValuePair<EyeColor, (uint FrequencyAbsolute, double FrequencyRelative, uint FrequencyCumulative)>> f;
            f = data_eyecolors.Frequencies();


            #if NUNIT && !NUNIT_LITE
            CollectionAssert.AreEquivalent
                                (
                                    f,
                                    fc
                                );
            #elif XUNIT
            Assert.Equal
                                (
                                    f,
                                    fc
                                );
            #elif MSTEST
            CollectionAssert.AreEquivalent
                                (
                                    f.ToList(),
                                    fc
                                );
            #endif
    
            return;
        }


        public List<Person> Persons
        {
            get
            {
                return
                    new List<Person>()
                {
                    new Person()
                    {
                        NameFirst = "Namette",
                        NameLast = "Lastnameson",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2001, 05, 01),
                        EyeColor = EyeColor.Blue,
                    },
                    new Person()
                    {
                        NameFirst = "Namely",
                        NameLast = "Lastnameson",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2002, 03, 31),
                        EyeColor = EyeColor.Blue,
                    },
                    new Person()
                    {
                        NameFirst = "Nameron",
                        NameLast = "Lastnamitch",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2000, 05, 01),
                        EyeColor = EyeColor.Green,
                    },
                    new Person()
                    {
                        NameFirst = "Namette",
                        NameLast = "Lastnamitch",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(1998, 06, 21),
                        EyeColor = EyeColor.Hazel,
                    },
                    new Person()
                    {
                        NameFirst = "Firster",
                        NameLast = "Lastnameson",
                        Gender = Gender.Male,
                        DateOfBirth = new DateTime(2004, 05, 01),
                        EyeColor = EyeColor.Blue,
                    },
                    new Person()
                    {
                        NameFirst = "Surnam",
                        NameLast = "Lastnamitch",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(1987, 11, 10),
                        EyeColor = EyeColor.Gray,
                    },
                    new Person()
                    {
                        NameFirst = "Namer",
                        NameLast = "Lastnameson",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2001, 05, 01),
                        EyeColor = EyeColor.Blue,
                    },
                    new Person()
                    {
                        NameFirst = "Namer",
                        NameLast = "Lastnamitch",
                        Gender = Gender.Female,
                        DateOfBirth = new DateTime(2001, 05, 01),
                        EyeColor = EyeColor.Gray,
                    },
                };
            }            
        }
    }
}
