using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WonderlandStore;

namespace UnitTests
{
    [TestClass]
    public class DatabaseConnection
    {
        [TestMethod]
        public void DatabaseConnection_IfOpen_ReturnsTrue()
        {
            WonderlandDatabaseOperations ms = new WonderlandDatabaseOperations();
            bool v = ms.TestWonderlandDatabaseConnection();
            Assert.IsTrue(v);
        }
    }
}
