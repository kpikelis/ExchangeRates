using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEB.WebServiceIntegration.Client;
using SEB.WebServiceIntegration.Service;
using Rhino.Mocks;
using SEB.WebServiceIntegration.Configuration;

namespace SEB.WeServiceIntegrationTests
{
    [TestClass]
    public class WebServiceIntegrationTest
    {
        private ExchangeRatesClient _exchangeRatesClient;
        private ExchangeRatesService _exchangeRatesService;

        [TestInitialize]
        public void SetUpWebServiceIntegrationTests()
        {
            //create configuration for web service
            var configMock = MockRepository.GenerateStub<IExchangeRatesConfigurationProvider>();
            configMock.Stub(x => x.GetConfiguration()).Return(WebServiceIntegrationTestData.GetWebServiceIntegrationConfiguration());
            _exchangeRatesClient = new ExchangeRatesClient(configMock);
            _exchangeRatesService = new ExchangeRatesService(_exchangeRatesClient);
        }

        [TestMethod]
        public void GetExchangeRatesByDateTest()
        {
            var inputData = WebServiceIntegrationTestData.GetExchangeRatesByDateInput();
            var getExchangeRatesByDateResponse = _exchangeRatesService.GetExchangeRatesByDate(inputData).GetAwaiter().GetResult();
            //Assert
            Assert.IsNotNull(getExchangeRatesByDateResponse, string.Format("{0} is null", nameof(getExchangeRatesByDateResponse)));
        }
    }
}
