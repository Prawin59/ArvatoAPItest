using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CurrencyConverter
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly global::CurrencyConverter.CurrencyConverter _currencyConverter = new global::CurrencyConverter.CurrencyConverter();
        private double _result;
        private System.Exception exception;


        public CurrencyConverter(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the amount is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _currencyConverter.Amount =  number;
        }

        [Given("Convert from currency is (.*)")]
        public void GivenFromCurrencyIs(string fromCurrency)
        {
            _currencyConverter.FromCurrency = fromCurrency;
        }

        [Given("to Currency is (.*)")]
        public void GivenTOCurrencyIs(string toCurrency)
        {
            _currencyConverter.ToCurrency = toCurrency;
        }

        [When("the amount is convertd")]
        public void WhenTheAmountIsConverted()
        {
            try
            {
                _result = _currencyConverter.Convert();
            }
            catch (System.Exception ex)
            {
                _result = 0;
                exception = ex;
            }
        }
      
        [Then("the result in NOK is (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            _result.Should().Be(result);

        }
        [Then("the result in INR is (.*)")]
        public void AfterEurTOInr(double result)
        {
            _result.Should().Be(result);

        }
        [Then("the result should be(.*)")]
        public void Subscription(double result)
        {
            _result.Should().Be(result);

        }
        
            [Then("the result for NOK in negative amount is(.*)")]
        public void Negitiveamount(double result)
        {
            _result.Should().Be(result);

        }
    }
}