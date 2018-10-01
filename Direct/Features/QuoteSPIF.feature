Feature: QuoteSPF
this is the description for the quoteSteps


Background: 
Given I have navigated to the "url" page
Given I select Get a quote
Then the Your Car page is displayed

Scenario Outline: 1 -Quote and Buy SPF
Given I am testing "Quote and Buy SPF, Variant 0 in QuoteAndBuySPF"
When I select "yes"
And I enter the registration "<registration>"
And I select Find Car
Then the details of the car are returned
When I select "Yes" to are these details correct
And the What's the value of your car question is displayed
Then I enter the value "<value>"
And I select "Right" Hand Drive in Is your car right or left-hand drive
And I select "No" to Has your car been modified in any way?
And I select "<AlarmType>" in What type of alarm or immobiliser does your car have
And I select "<Tracking>" to Is your car fitted with a tracking device?
When I select the Continue button
Then the Using your car accordion is expanded
When I select that I purchased the car on "2" "January" "2016"
And I select the Legal owner as "<LegalOwner>"
And I select the Registered keeper as "<RegisteredKeeper>"
And I select use of car as "<UseOfCar>"
And I enter my personal annual mileage as "<AnnualMileage>" 
And I select "<DayLocation>" for where my car is kept during the day
And I select "<NightLocation>" for where my car is kept at night
And I select "Yes" my car is kept at my home address at night
When I select the Continue button to move to the your details page
Then the Your Details page is displayed
When I select my title "Mr", First name "aaaaa", and last name "T"
And I select my marital status as "<MaritalStatus>"
And I select my date of birth as "31" "December" "1960"
And I select that I "have" lived in the uk since birth
And I select that I "<Children>" have any children under the age of Sixteen in the house
And I enter my phone number "01"
And I enter my email address "TSP-"
And I confirm my email address "TSP-"
When I enter my house number "8" and postcode "DD3 6SX"
And I select Find my address
Then the address details are populated
And I select "Yes" to Are you a homeowner
And I enter "1" into How many vehicles in your household do you have access to
When I select my employment type as "<EmploymentType>"
And I enter occupation as "<Occupation>"
And I enter business as "<Business>"
And I select "No" to Do you have a part time occupation
And I select the Continue button on the Your Details page
Then the Your driving history accordion is expanded
When I select my type of driving licence as "<Licence>"
And I select how many years I have held my licence as "<LicenceHeld>"
And I select "<Qualifications>" for Do you have any additional driving qualifications
And I select "<MedicalConditions>" for Do you have any medical conditions
And I select "No" for any accidents, claims or damage
And I select "No" for motoring convictions
And I select the Continue button on the Driving History page
Then the Your Cover page is displayed
When I select "No" for adding any other drivers
And I select the Continue button on the Your Cover page
Then the Your cover details accordion is expanded
When I select the "I agree" button on the Your Cover Details page
And I select cover starts "12" days from today
And I select How many years no claims bonus I have as "<NCB>"
And I select "<NCBProtect>" for protecting NCB
And I select use of other vehicles as "<OtherVehicles>"
And I select "No" for unspent criminal convictions
And I select "No" for insurance refused or cancelled
And I select the "Get your quote" button
Then the PPP is displayed
And I select "Pay in full" on the PPP
And I select to confirm the start date
And the test should populate the users details to the log 

Examples: 
| registration | value | AlarmType                  | Tracking | LegalOwner    | RegisteredKeeper        | UseOfCar                                                                    | AnnualMileage | DayLocation                | NightLocation              | MaritalStatus   | Children | EmploymentType		| Occupation             | Business             | Licence        | LicenceHeld | Qualifications            | MedicalConditions                      | NCB | NCBProtect | OtherVehicles                        |
| FR11SSS      | 3000  | Thatcham Category 1        | Yes      | Proposer      | Proposer                | Social, Domestic And Pleasure Only                                          | 8000          | On A Driveway              | In A Locked Garage         | Widowed         | No       | Employed			| Accountant             | Accountancy          | UK Full        | 7           | No						   | No									    | 7   | No         | No									  |

