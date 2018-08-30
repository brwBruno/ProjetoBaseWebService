using NUnit.Framework;
using Ribeiro.MF7.Applications.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Applications.Tests.Initializer
{
    public class TestApplicationBase
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            AutoMapperInitializer.Reset();
            AutoMapperInitializer.Initialize();
        }
    }
}
