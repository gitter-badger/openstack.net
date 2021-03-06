﻿namespace OpenStackNetTests.Live
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public partial class ContentDeliveryTests
    {
        private LiveTestConfiguration _configuration;

        internal TestCredentials Credentials
        {
            get
            {
                return _configuration.TryGetSelectedCredentials();
            }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _configuration = LiveTestConfiguration.LoadDefaultConfiguration();
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }
    }
}
