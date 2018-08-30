using NUnit.Framework;
using Ribeiro.MF7.Controllers.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribeiro.MF7.Controllers.Tests.Initializer
{
    public class TestControllerBase
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            AutoMapperTestsInitializer.Reset();
            AutoMapperTestsInitializer.Initialize();
        }
    }
}
