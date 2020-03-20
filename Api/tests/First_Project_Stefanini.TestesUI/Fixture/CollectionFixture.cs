using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace First_Project_Stefanini.TestesUI.Fixture
{
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TestFixture>
    {

    }
}
