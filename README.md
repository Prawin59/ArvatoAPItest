API Testing form Arvato Financials interview Assesment.

Technologies

C#

***Framework***

Specflow

***Installed Packages***

FluentAsserstion,
Microsoft .net Test SDK,
Specflow Living Doc Plugin,
SpecRun.Specflow,

3rd party API Integration fixer API

Project Flow:

Currency converter class is developed to calculate the currency amount for the second currency code using latest exchange rates from fixer.io.

I have used following Fixer API to get leatest exhange reates. http://data.fixer.io/api/latest?access_key=10f744df7fbaf847bdb1c991ac5896ef&base=EUR&symbols=NOK

After dveloping the currency converter class i have used specflow to wirte the test cases in Gherkins.

In a First and second senario i cover the conversion of two curriencies with different test data. In third senario i test the available subscrption for the Fixer API. In Fourth Senario negative values has been tested.
