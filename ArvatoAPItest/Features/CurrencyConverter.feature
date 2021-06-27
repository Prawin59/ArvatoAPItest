Feature: CurrencyConverter
	

@ConvertFromEURToNINR
Scenario: Convertfrom EUR to INR
	Given the amount is 50	
	Given Convert from currency is EUR
	Given to Currency is INR
	When the amount is convertd
	Then the result in INR is 4429.517

@ConvertFromNOKToINR
Scenario: Convertfrom EUR to NOK
	Given the amount is 100	
	Given Convert from currency is EUR
	Given to Currency is NOK
	When the amount is convertd
	Then the result in NOK is 1012.516

	@ConvertFromUSDToNOK
Scenario: Convertfrom USD to NOK
	Given the amount is 10	
	Given Convert from currency is USD
	Given to Currency is NOK
	When the amount is convertd
	Then the result should be 0

	@ConvertFromEURToNOKwithNegitives
Scenario: Convertfrom EUR to NOK with Negitive amount
	Given the amount is -100	
	Given Convert from currency is EUR
	Given to Currency is NOK
	When the amount is convertd
	Then the result for NOK in negative amount is -1012.516
