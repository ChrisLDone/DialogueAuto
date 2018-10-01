using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;
using NUnit.Framework;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Xml;
using Direct.StepDefs;


namespace ResetRegression
{

    [Binding]
    public class FeatureSteps

    {

        public IWebElement _sinceBirthIndicator;


        public Xpaths xpath_Directory = new Xpaths();



        public string AccountHolder { get; private set; }
        public string MainOccupation { get; private set; }

        [Given(@"I have navigated to the ""(.*)"" page")]
        public void GivenIHaveNavigatedToThePage(string url)
        {
            CommonComponents.BrowserOptions(CommonComponents._Browser);
            Thread.Sleep(2000);
            CommonComponents.EnvironmentOptions(CommonComponents._url);
            Thread.Sleep(5000);
        }

        //[Given(@"I have entered my ""(.*)"" and ""(.*)"" and selected the ""(.*)"" button")]
        //public void GivenIHaveEnteredMyAndAndSelectedTheButton(string username, string password, string Logon)
        //{
        //    if (CommonComponents._url == "PreProd")
        //    {
        //        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterUsername())).SendKeys(CommonComponents._userName);
        //        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterPassword())).SendKeys(CommonComponents._passWord);
        //        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LogonButton())).Click();
        //        WaitForElementToBeClickable(xpath_Directory.GetQuoteButton());
        //    }
        //    else
        //    {
        //        WaitForElementToBeClickable(xpath_Directory.GetQuoteButton());
        //    }
        //}

        [Given(@"I select Get a quote")]
        public void GivenISelectGetAQuote()
        {
            WaitForElementToBeClickable(xpath_Directory.GetQuoteButton());
        }

        [When(@"I select ""(.*)""")]
        public void WhenISelect(string carReg)

        {
            if (carReg == "yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.KnowCarRegistration())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UnknownCarRegistration())).Click();
            }
        }

        [When(@"I enter the registration ""(.*)""")]
        public void WhenIEnterTheRegistration(string EnterReg)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterCarReg())).SendKeys(EnterReg);
            //Thread.Sleep(3000);
        }

        [When(@"I select Find Car")]
        public void WhenISelectFindCar()
        {

            WaitForElementToShow(xpath_Directory.FindCarDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FindCar())).Click();
        }

        [When(@"I select ""(.*)"" to are these details correct")]
        public void WhenISelectToAreTheseDetailsCorrect(string YesDetails)
        {
            WaitForElementToShow(xpath_Directory.DetailsCorrectDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DetailsCorrect())).Click();
        }

        [When(@"the What's the value of your car question is displayed")]
        public void WhenTheWhatSTheValueOfYourCarQuestionIsDisplayed()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterValue()));
        }

        [When(@"I select that I purchased the car on ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectThatIPurchasedTheCarOn(string day, string month, string year)
        {
            Thread.Sleep(1000);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.day(day))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.month(month))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.year(year))).Click();
        }

        [When(@"I select the Legal owner as ""(.*)""")]
        public void TheLegalOwner(string LegalOwner)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LegalOwner(LegalOwner))).Click();
        }

        [When(@"I select the Registered keeper as ""(.*)""")]
        public void TheRegisteredKeeper(string RegisteredKeeper)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RegisteredKeeper(RegisteredKeeper))).Click();
        }

        [When(@"I enter my personal annual mileage as ""(.*)""")]
        public void WhenIEnterMyPersonalAnnualMileageAs(string Mileage)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AnnualMileage())).SendKeys(Mileage);

        }

        [When(@"I select ""(.*)"" for where my car is kept during the day")]
        public void WhenISelectForWhereMyCarIsKeptDuringTheDay(string CarKeptDay)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarKeptDay(CarKeptDay))).Click();
        }

        [When(@"I select ""(.*)"" for where my car is kept at night")]
        public void WhenISelectForWhereMyCarIsKeptAtNight(string CarKeptNight)

        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarKeptNight(CarKeptNight))).Click();
        }


        [When(@"I select ""(.*)"" my car is kept at my home address at night")]
        public void WhenISelectMyCarIsKeptAtMyHomeAddressAtNight(string KeptAtHomeAddressOvernight)
        {
            if (KeptAtHomeAddressOvernight == "Yes")
            {
                WaitForElementToBeClickable(xpath_Directory.YesHomeNightStorage());
            }
            else
            {
                WaitForElementToBeClickable(xpath_Directory.NoHomeNightStorage());
            }
        }

        [When(@"I select the Continue button to move to the your details page")]
        public void WhenISelectTheContinueButtonToMoveToTheYourDetailsPage()
        {
            WaitForElementToBeClickable(xpath_Directory.ContinueToYourDetailsPage());
            //CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinueToYourDetailsPage())).Click();
        }

        [When(@"I select my title ""(.*)"", First name ""(.*)"", and last name ""(.*)""")]
        public void WhenISelectMyTitleFirstNameAndLastName(string Title, string FirstName, string LastName)
        {
            {
                CommonComponents._title = Title;
                CommonComponents._firstName = FirstName;
                CommonComponents._lastName = LastName + CommonComponents.RandomString(8);
                WaitForElementToBeClickable(xpath_Directory.Title());
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Title())).SendKeys(CommonComponents._title);
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FirstName())).SendKeys(CommonComponents._firstName);
                Thread.Sleep(500);
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LastName())).SendKeys(CommonComponents._lastName);
            }
        }
        [When(@"I select my marital status as ""(.*)""")]
        public void WhenISelectMyMaritalStatusAs(string MaritalStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MaritalStatus(MaritalStatus))).Click();
        }

        [When(@"I select my date of birth as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectMyDateOfBirthAs(string DayOfBirth, string MonthOfBirth, string YearOfBirth)
        {
            CommonComponents._DayOfBirth = DayOfBirth;
            CommonComponents._MonthOfBirth = MonthOfBirth;
            CommonComponents._YearOfBirth = YearOfBirth;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DayOfBirth(DayOfBirth))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MonthOfBirth(MonthOfBirth))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearOfBirth(YearOfBirth))).Click();
        }

        [When(@"I select my DoB as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectMyDoBAs(string DofBirth, string MofBirth, string YofBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YOfBirth())).Click();
        }


        [When(@"I select that I ""(.*)"" lived in the uk since birth")]
        public void WhenISelectThatILivedInTheUkSinceBirth(string LivedInUKSinceBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LivedInUKSinceBirth())).Click();
        }

        [When(@"I select that I ""(.*)"" have any children under the age of Sixteen in the house")]
        public void WhenISelectThatIHaveAnyChildrenUnderTheAgeOfSixteenInTheHouse(string Children)
        {
            if (Children == "No")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoChildren())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesChildren())).Click();
            }
        }

        [When(@"I enter my phone number ""(.*)""")]
        public void WhenIEnterMyPhoneNumber(string PhoneNumber)
        {
            CommonComponents._PhoneNumber = PhoneNumber;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PhoneNumber())).SendKeys(CommonComponents._PhoneNumber);
        }

        [When(@"I enter my email address ""(.*)""")]
        public void WhenIEnterMyEmailAddress(string EmailAddress)
        {

            CommonComponents._emailAddress = CommonComponents._url + "-" + EmailAddress + CommonComponents.RandomString(8) + "@citestemail.co.uk";
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EmailAddress())).SendKeys(CommonComponents._emailAddress);

        }

        [When(@"I confirm my email address ""(.*)""")]
        public void WhenIConfirmMyEmailAddress(string ConfirmEmailAddress)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmEmailAddress())).SendKeys(CommonComponents._emailAddress);
        }

        [When(@"I enter my house number ""(.*)"" and postcode ""(.*)""")]
        public void WhenIEnterMyHouseNumberAndPostcode(string HouseNumber, string Postcode)
        {
            CommonComponents._postCode = Postcode;
            CommonComponents._houseNumber = HouseNumber;
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.HouseNumber())).SendKeys(HouseNumber);
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Postcode())).SendKeys(Postcode);
        }

        [When(@"I select Find my address")]
        public void WhenISelectFindMyAddress()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FindAddress())).Click();
            Thread.Sleep(1000);
            bool HasFoundAddress = false;
            var ssccount = 0;
            while (!HasFoundAddress)
            {
                var AddressNotFoundModal = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddressNotFound()));
                if (ssccount < 3)
                {
                    if (AddressNotFoundModal.Displayed)
                    {
                        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddressModalClose())).Click();
                        Thread.Sleep(1000);
                        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Postcode())).SendKeys(CommonComponents._postCode);
                        Thread.Sleep(2000);
                        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FindAddress())).Click();
                        Thread.Sleep(2000);
                        ssccount++;
                    }
                    else
                    {
                        HasFoundAddress = true;
                        Thread.Sleep(2000);
                    }

                }
                else
                {
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddressModalClose())).Click();
                    Thread.Sleep(2000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterMyAddress())).Click();
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterMyAddress())).Click();
                    Thread.Sleep(2000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.HouseBuildingNumber())).SendKeys(CommonComponents._houseNumber);
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Street())).SendKeys("Test Street");
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ManualPostcode())).SendKeys(CommonComponents._postCode);
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmAddressDetails())).Click();
                    Thread.Sleep(3000);
                    HasFoundAddress = true;

                }
            }
        }

        [When(@"I select my employment type as ""(.*)""")]
        public void WhenISelectMyEmploymentTypeAs(string PassedEmploymentStatus)
        {
            //This first line pulls the data passed into this step into the CommonComponents._employmentStatus container declared at the top of this doc
            CommonComponents._employmentStatus = PassedEmploymentStatus;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EmploymentStatus(PassedEmploymentStatus))).Click();
        }


        [When(@"I enter occupation as ""(.*)""")]
        public void WhenIEnterOccupationAs(string MainOccupation)
        {
            //*These if statements make a call, contextually.They appraise whether or not the current account that's being tested
            //* is of type "Retired" - if they are, then they skip the step(the code within the IF statement is only executed
            //* in the cases where the person is not retired)
            //* IF employed - this will run
            // *If retired, the if causes it to skip over*/
            if (CommonComponents._employmentStatus == "Retired" ||
                CommonComponents._employmentStatus == "Independent Means" ||
                CommonComponents._employmentStatus == "Not Employed Due To Disability" ||
                CommonComponents._employmentStatus == "Voluntary Work" ||
                CommonComponents._employmentStatus == "Unemployed")
            {
                return;
            }
            else
            {
                CommonComponents._occupation = MainOccupation;
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MainOccupation())).SendKeys(MainOccupation);
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MainOccupation())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            }
        }



        [When(@"I enter business as ""(.*)""")]
        public void WhenIEnterBusinessAs(string TypeBusiness)
        {
            if (CommonComponents._employmentStatus == "Retired" ||
                CommonComponents._employmentStatus == "Voluntary Work" ||
               CommonComponents._employmentStatus == "Independent Means")
            {
                return;
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TypeBusiness())).SendKeys(TypeBusiness + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            }
        }

        [When(@"I select ""(.*)"" to Do you have a part time occupation")]
        public void WhenISelectToDoYouHaveAPartTimeOccupation(string NoPartTimeOccupation)
        {
            if (CommonComponents._employmentStatus != "Unemployed")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PartTimeOccupation())).Click();
            }
        }


        [When(@"I select my type of driving licence as ""(.*)""")]
        public void WhenISelectMyTypeOfDrivingLicenceAs(string LicenceType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LicenceType(LicenceType))).Click();
        }

        [When(@"I select how many years I have held my licence as ""(.*)""")]
        public void WhenISelectHowManyYearsIHaveHeldMyLicenceAs(string YearsLicenceHeld)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearsLicenceHeld(YearsLicenceHeld))).Click();
        }

        [When(@"I select ""(.*)"" for Do you have any additional driving qualifications")]
        public void WhenISelectForDoYouHaveAnyAdditionalDrivingQualifications(string DrivingQualifications)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DrivingQualifications(DrivingQualifications))).Click();
        }

        [When(@"I select ""(.*)"" for Do you have any medical conditions")]
        public void WhenISelectForDoYouHaveAnyMedicalConditions(string MedicalConditions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MedicalConditions(MedicalConditions))).Click();
        }

        [When(@"I select ""(.*)"" for any accidents, claims or damage")]
        public void WhenISelectForAnyAccidentsClaimsOrDamage(string AccidentsClaimsorDamage)
        {
            if (AccidentsClaimsorDamage == "No")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AccidentsClaimsorDamage())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesToClaims())).Click();
                Thread.Sleep(1000);
            }
        }

        [When(@"I select ""(.*)"" for motoring convictions")]
        public void WhenISelectForMotoringConvictions(string MotoringConvictions)
        {
            if (MotoringConvictions == "No")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MotoringConvictions())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesToMotoringConvictions())).Click();
                Thread.Sleep(1000);
            }
        }

        [When(@"I select ""(.*)"" for adding any other drivers")]
        public void WhenISelectForAddingAnyOtherDrivers(string AnyAdditionalDrivers)
        {
            //WaitForElementToShow(xpath_Directory.AnyAdditonalDrivers());
            Thread.Sleep(2000);
            WaitForElementToBeClickable(xpath_Directory.NoAdditionalDrivers());
        }

        [When(@"I select cover starts ""(.*)"" days from today")]
        public void WhenISelectCoverStartsDaysFromToday(string CoverToStart)
        {
            CommonComponents._coverdate = CoverToStart;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CoverToStart())).Click();
        }

        [When(@"I select How many years no claims bonus I have as ""(.*)""")]
        public void WhenISelectHowManyYearsNoClaimsBonusIHaveAs(string YearsNoClaimsBonus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearsNoClaimsBonus(YearsNoClaimsBonus))).Click();
        }

        [When(@"I select ""(.*)"" for protecting NCB")]
        public void WhenISelectForProtectingNCB(string ProtNCB)
        {
            if (ProtNCB == "Yes")
            {
                WaitForElementToBeClickable(xpath_Directory.YesProtNCB());
            }
            else
            {
                WaitForElementToBeClickable(xpath_Directory.NoProtNCB());
            }
        }

        [When(@"I select use of other vehicles as ""(.*)""")]
        public void WhenISelectUseOfOtherVehiclesAs(string NamedDriverOnCar)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NamedDriverOnCar(NamedDriverOnCar))).Click();
        }

        [When(@"I select ""(.*)"" for unspent criminal convictions")]
        public void WhenISelectForUnspentCriminalConvictions(string NoConvict)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoConvicts())).Click();
        }

        [When(@"I select ""(.*)"" for insurance refused or cancelled")]
        public void WhenISelectForInsuranceRefusedOrCancelled(string NoRefuse)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoRefuse())).Click();
        }

        [Then(@"the Your Car page is displayed")]
        public void ThenTheYourCarPageIsDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.DisplayingYourCarPage());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourCarPage()));
        }

        [Then(@"the details of the car are returned")]
        public void ThenTheDetailsOfTheCarAreReturned()
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.ConfirmCarDetailsCorrectDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DetailsReturned()));
        }

        [Then(@"I enter the value ""(.*)""")]
        public void ThenIEnterTheValue(string Value)
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.ValueDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterValue())).SendKeys(Value);
        }

        [Then(@"I select ""(.*)"" Hand Drive in Is your car right or left-hand drive")]
        public void ThenISelectHandDriveInIsYourCarRightOrLeft_HandDrive(string RightLeftHandDrive)
        {
            if (RightLeftHandDrive == "Right")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RightHandDrive())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LeftHandDrive())).Click();
            }
        }


        [Then(@"I select ""(.*)"" to Has your car been modified in any way\?")]
        public void ThenISelectToHasYourCarBeenModifiedInAnyWay(string Modifications)
        {
            if (Modifications == "No")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ModifiedNo())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ModifiedYes())).Click();
            }
        }

        [Then(@"I select ""(.*)"" in What type of alarm or immobiliser does your car have")]
        public void AlarmTypes(string AlarmType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AlarmType(AlarmType))).Click();
        }

        [Then(@"I select ""(.*)"" to Is your car fitted with a tracking device\?")]
        public void ThenISelectToIsYourCarFittedWithATrackingDevice(string TrackingDevice)
        {
            if (TrackingDevice == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesTrackingDevice())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoTrackingDevice())).Click();
            }

        }

        [Then(@"the Using your car accordion is expanded")]
        public void ThenTheUsingYourCarAccordionIsExpanded()
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.ExpandingYourCarAccordion());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UsingYourCarPage()));
        }

        [Then(@"the Your Details page is displayed")]
        public void ThenTheYourDetailsPageIsDisplayed()
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.DisplayingYOurDetailsPage());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourDetailsDisplayed()));
        }

        [Then(@"the address details are populated")]
        public void ThenTheAddressDetailsArePopulated()
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.PopulatingAddress());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddressPopulated()));
        }

        [Then(@"I select ""(.*)"" to Are you a homeowner")]
        public void ThenISelectToAreYouAHomeowner(string HomeownerYes)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.HomeownerYes())).Click();
        }

        [Then(@"I enter ""(.*)"" into How many vehicles in your household do you have access to")]
        public void ThenIEnterIntoHowManyVehiclesInYourHouseholdDoYouHaveAccessTo(string NumberVehiclesinHousehold)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NumberVehiclesinHouse())).SendKeys(NumberVehiclesinHousehold);
        }

        [Then(@"the Your driving history accordion is expanded")]
        public void ThenTheYourDrivingHistoryAccordionIsExpanded()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DrivingHistoryAccordion()));
 
        }

        [Then(@"the Your Cover page is displayed")]
        public void ThenTheYourCoverPageIsDisplayed()
        {
            WaitForElementToShow(xpath_Directory.AdditionalDriversPageDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalDriversPageDisplayed()));
        }

        [Then(@"the Your cover details accordion is expanded")]
        public void ThenTheYourCoverDetailsAccordionIsExpanded()
        {
            WaitForElementToShow(xpath_Directory.DisplayingYourCoverDetailsAccordion());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourCoverDetails()));
            Thread.Sleep(1000);
        }

        [When(@"I select the ""(.*)"" button on the Your Cover Details page")]
        public void WhenISelectTheButtonOnTheYourCoverDetailsPage(string IAgree)
        {
            WaitForElementToBeClickable(xpath_Directory.IAgreeButtonClickable());
        }

        [Then(@"the PPP is displayed")]
        public void ThenThePPPIsDisplayed()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PricePresentationPage()));
        }
        [When(@"I select the Continue button")]
        public void WhenISelectTheContinueButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AboutYourCarContinue())).Click();
        }

        [When(@"I select use of car as ""(.*)""")]
        public void WhenISelectUseOfCarAs(string UseOfCar)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UseOfCar(UseOfCar))).Click();
            if (UseOfCar == "Business Use By Spouse Only" ||
                UseOfCar == "Business Use By You" ||
                UseOfCar == "Business Use By All Drivers" ||
                UseOfCar == "Commercial Travelling" ||
                UseOfCar == "Business Use By You And Spouse / Civil Partner")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.BusinessMileage())).SendKeys("1000");
            }
            else return;



        }

        [When(@"I select the Continue button on the Your Details page")]
        public void WhenISelectTheContinueButtonOnTheYourDetailsPage()
        {
            WaitForElementToBeClickable(xpath_Directory.ContinueToYourDrivingHistory());
        }

        [When(@"I select the Continue button on the Driving History page")]
        public void WhenISelectTheContinueButtonOnTheDrivingHistoryPage()
        {
            WaitForElementToBeClickable(xpath_Directory.DrivingHistoryContinueButton());
        }

        [When(@"I select the Continue button on the Your Cover page")]
        public void WhenISelectTheContinueButtonOnTheYourCoverPage()
        {
            WaitForElementToBeClickable(xpath_Directory.ContinueToCoverDetailsButton());
        }

        [When(@"I select the ""(.*)"" button")]
        public void WhenISelectTheButton(string GetQuote)
        {
            WebDriverWait wait = new WebDriverWait(CommonComponents.driver, new TimeSpan(0, 0, 30));

            WaitForElementToShow(xpath_Directory.GetQuoteButtonDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Quote())).Click();
        }

        [Then(@"I select ""(.*)"" on the PPP")]
        public void ThenISelectOnThePPP(string SinglePayment)
        {
            WaitForElementToBeClickable(xpath_Directory.SinglePayment());

            var collectPolicyNum = CommonComponents.driver.FindElement(By.XPath("//div[@id='panelQuoteSummary']/div/p[1]"));
            string[] wordbywordpolicynum = collectPolicyNum.Text.Split(' ');
            CommonComponents._policyNumber = wordbywordpolicynum[wordbywordpolicynum.Length - 1];

            Thread.Sleep(500);
        }
        [When(@"I select the ""(.*)"" button on the Customise your cover accordion")]
        public void WhenISelectTheButtonOnTheCustomiseYourCoverAccordion(string CustomiseYourCoverNext)
        {
            WaitForElementToShow(xpath_Directory.CustomiseYourCoverAccordionDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CustomiseYourCoverNext())).Click();
        }

        [Then(@"the Add Additional Products accordion is displayed")]
        public void ThenTheAddAdditionalProductsAccordionIsDisplayed()
        {
            WaitForElementToShow(xpath_Directory.AdditionalProductsAccordionDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalProductAccordion()));
        }

        [When(@"I select the ""(.*)"" button on the Add Additional Products accordion")]
        public void WhenISelectTheButtonOnTheAddAdditionalProductsAccordion(string AdditionalProductsNext)
        {
            WaitForElementToBeClickable(xpath_Directory.AdditionalProductsNext());
        }

        [Then(@"the Choose Your Preferences accordion is displayed")]
        public void ThenTheChooseYourPreferencesAccordionIsDisplayed()
        {
            WaitForElementToShow(xpath_Directory.ChooseYourPreferencesAccordionDisplayed());

        }

        [When(@"I select ""(.*)"" for the marketing preferences")]
        public void WhenISelectForTheMarketingPreferences(string ContactOption)
        {
            if (ContactOption == "Email")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EmailContact())).Click();
            }
            else if (ContactOption == "Phone")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PhoneContact())).Click();
            }
            else if (ContactOption == "Email & Phone")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EmailContact())).Click();
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PhoneContact())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoThanksContact())).Click();
            }

        }

        [When(@"I select the ""(.*)"" button on the Choose Your Preferences accordion")]
        public void WhenISelectTheButtonOnTheChooseYourPreferencesAccordion(string ChooseYourPreferenceNext)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChoosePreferenceNext())).Click();
        }

        [Then(@"the Terms and Conditions are displayed")]
        public void ThenTheTermsAndConditionsAreDisplayed()
        {
            WaitForElementToShow(xpath_Directory.TermsAndConditionsDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TermsConditionsAppear())).Click();
        }

        [When(@"I select the radio button to accept the Terms and Conditions")]
        public void WhenISelectTheRadioButtonToAcceptTheTermsAndConditions()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TermsConditions())).Click();
        }

        [When(@"select the ""(.*)"" button")]
        public void WhenSelectTheButton(string Payment)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ClickToPayOnPPP())).Click();
        }

        [Then(@"the Payment Page is displayed")]
        public void ThenThePaymentPageIsDisplayed()
        {
            WaitForElementToBeClickable(xpath_Directory.PaymentPageClickable());
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PaymentPageDisplayed()));

        }

        [When(@"I select my title ""(.*)"", First name ""(.*)"", and last name ""(.*)"" on the Payment Page")]
        public void WhenISelectMyTitleFirstNameAndLastNameOnThePaymentPage(string Title, string FirstName, string LastName)
        {

            WaitForElementToShow(xpath_Directory.CardholderDetailsDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CardholderTitle())).SendKeys(CommonComponents._title + Keys.Tab);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CardholderFirstName())).SendKeys(CommonComponents._firstName + Keys.Tab);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CardholderLastName())).SendKeys(CommonComponents._lastName + Keys.Tab);

        }

        [When(@"I select ""(.*)"" as the card type")]
        public void WhenISelectAsTheCardType(string CardType)
        {
            if (CardType == "Visa Credit Card")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.VisaCreditCardType())).Click();
            }
            else if (CardType == "Visa Electron")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.VisaElectronCardType())).Click();
            }
            else if (CardType == "Maestro")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MaestroCardType())).Click();
            }
            else if (CardType == "Mastercard Credit")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MastercardCreditCardType())).Click();
            }
            else if (CardType == "Mastercard Debit")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MastercardDebitCardType())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CardType())).Click();
            }
        }

        [When(@"I select the ""(.*)"" button in the Pay In Full accordion")]
        public void WhenISelectTheButtonInThePayInFullAccordion(string PayInFullNext)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayInFullNext())).Click();
        }

        [Then(@"the Card Details accordion will be expanded")]
        public void ThenTheCardDetailsAccordionWillBeExpanded()
        {
            WaitForElementToShow(xpath_Directory.CardDetailsAccordionDisplayed());
        }

        [When(@"I enter CardNumber as ""(.*)""")]
        public void WhenIEnterCardNumberAs(string CardNumber)
        {
           
            CommonComponents.driver.SwitchTo().Frame("paymentIframe");
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CardNumber())).SendKeys(CardNumber);
        }

        [When(@"I enter expiry month as ""(.*)""")]
        public void WhenIEnterExpiryMonthAs(string ExpiryMonth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ExpiryMonth())).SendKeys(ExpiryMonth);
        }

        [When(@"I enter expiry year as ""(.*)""")]
        public void WhenIEnterExpiryYearAs(string ExpiryYear)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ExpiryYear())).SendKeys(ExpiryYear);
        }

        [When(@"I enter Security Code as ""(.*)""")]
        public void WhenIEnterSecurityCodeAs(string SecurityCode)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SecurityCode())).SendKeys(SecurityCode);
        }

        [When(@"I select the ""(.*)"" button in the card details accordion")]
        public void WhenISelectTheButtonInTheCardDetailsAccordion(string CardDetailsAccordionNext)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CardDetailsAccordionNext())).Click();
            CommonComponents.driver.SwitchTo().DefaultContent();
        }

        [Then(@"the Important Information accordion is expanded")]
        public void ThenTheImportantInformationAccordionIsExpanded()
        {
            WaitForElementToShow(xpath_Directory.ImportantInformationAccordionDisplayed());
        }

        [When(@"I select the ""(.*)"" button on the Payment Page")]
        public void WhenISelectTheButtonOnThePaymentPage(string BuyPolicy)
        {
            WaitForElementToShow(xpath_Directory.BuyPolicyButtonDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.BuyPolicy())).Click();
        }

        [Then(@"the ACS Simulator is displayed")]
        public void ThenTheACSSimulatorIsDisplayed()
        {
            CommonComponents.driver.SwitchTo().Frame("threeDSecureIFrame");
        }

        [When(@"I select ""(.*)"" on the ACS Simulator")]
        public void WhenISelectOnTheACSSimulator(string Authenticated)
        {
            WaitForElementToShow(xpath_Directory.AuthenticatedButtonDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Authenticated())).Click();
            CommonComponents.driver.SwitchTo().DefaultContent();
        }

        [Then(@"the Payment Confirmation page is displayed")]
        public void ThenThePaymentConfirmationPageIsDisplayed()
        {
            WaitForElementToShow(xpath_Directory.PaymentConfirmationScreenDisplayed());

            var ConfirmationPageHeaderText = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmationPage()));
            FindText(xpath_Directory.ConfirmationPage(), "Welcome to Provident Insurance");
            CommonComponents.TakeScreenshot();
            CommonComponents.driver.Quit();
        }

        //DD Section
        [Then(@"I select Monthly Instalments on the PPP")]
        public void ThenISelectMonthlyInstalmentsOnThePPP()
        {
            WaitForElementToShow(xpath_Directory.LoadingPPP());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DDPayment())).Click();

            var collectPolicyNum = CommonComponents.driver.FindElement(By.XPath("//*[@id='panelQuoteSummary']/div/p[1]"));
            string[] wordbywordpolicynum = collectPolicyNum.Text.Split(' ');
            CommonComponents._policyNumber = wordbywordpolicynum[wordbywordpolicynum.Length - 1];

            Thread.Sleep(500);
        }
        [Then(@"the SECCI page is displayed")]
        public void ThenTheSECCIPageIsDisplayed()
        {
            WaitForElementToShow(xpath_Directory.SECCIPageDisplaying());
        }
        [When(@"I select the radio button to agree to the above Pre-Contract Credit Information")]
        public void WhenISelectTheRadioButtonToAgreeToTheAbovePre_ContractCreditInformation()
        {
            WaitForElementToBeClickable(xpath_Directory.PreContractCreditInfo());
        }

        [When(@"I select the Continue button on the SECCI page")]
        public void WhenISelectTheContinueButtonOnTheSECCIPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SECCIPageContinue())).Click();
        }

        [When(@"I select the tick to confirm that the bank account is mine")]
        public void WhenISelectTheTickToConfirmThatTheBankAccountIsMine()
        {
            WaitForElementToShow(xpath_Directory.SetUpDDDisplayed());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmBankOwner())).Click();
        }

        [When(@"I enter the AccountHolderName as ""(.*)""")]
        public void WhenIEnterTheAccountHolderNameAs(string AccountHolderName)
        {
            WaitForElementToBeClickable(xpath_Directory.AccountHolderNameClickable());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AccountHolderName())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AccountHolderName())).SendKeys(AccountHolderName);
        }
        [When(@"I enter SortCodePartOne as ""(.*)""")]
        public void WhenIEnterSortCodePartOneAs(string SortCodePartOne)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SortCodePartOne())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SortCodePartOne())).SendKeys(SortCodePartOne);
        }
        [When(@"I enter SortCodePartTwo as ""(.*)""")]
        public void WhenIEnterSortCodePartTwoAs(string SortCodePartTwo)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SortCodePartTwo())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SortCodePartTwo())).SendKeys(SortCodePartTwo);
        }

        [When(@"I enter SortCodePartThree as ""(.*)""")]
        public void WhenIEnterSortCodePartThreeAs(string SortCodePartThree)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SortCodePartThree())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SortCodePartThree())).SendKeys(SortCodePartThree);
        }
        [When(@"I enter AccountNumber as ""(.*)""")]
        public void WhenIEnterAccountNumberAs(string AccountNumber)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AccountNumber())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AccountNumber())).SendKeys(AccountNumber);
        }
        [When(@"I select the DirectDebitNextButton")]
        public void WhenISelectTheDirectDebitNextButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DirectDebitNextButton())).Click();
        }
        [When(@"I select the CreditAgreement button")]
        public void WhenISelectTheCreditAgreementButton()
        {
            WaitForElementToBeClickable(xpath_Directory.CreditAgreementButton());
        }
        [Then(@"I select ""(.*)"" to the alarm type question")]
        public void ThenISelectToTheAlarmTypeQuestion(string AlarmType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AlarmType())).Click();
        }
        [Then(@"I select ""(.*)"" to the Is your car fitted with a tracking device question")]
        public void ThenISelectToTheIsYourCarFittedWithATrackingDeviceQuestion(string Tracking)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Tracking())).Click();
        }
        [When(@"I select my licence type as ""(.*)""")]
        public void WhenISelectMyLicenceTypeAs(string LicenceType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LicenceType(LicenceType))).Click();
        }

        [When(@"I select years I've held my driving licence as ""(.*)""")]
        public void WhenISelectYearsIVeHeldMyDrivingLicenceAs(string YearsHeld)
        {
            CommonComponents.WaitForElementToBeClickable(xpath_Directory.YearsHeld());
            //CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearsHeld())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearsHeld())).SendKeys(YearsHeld);
        }

        [When(@"I select my additional driving qualifications as ""(.*)""")]
        public void WhenISelectMyAdditionalDrivingQualificationsAs(string AdditionalQualifications)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalQualifications(AdditionalQualifications))).Click();
        }

        [When(@"I select my medical conditions as ""(.*)""")]
        public void WhenISelectMyMedicalConditionsAs(string Medical)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Medical(Medical))).Click();
        }

        [When(@"I select ""(.*)"" for years NCB")]
        public void WhenISelectForYearsNCB(string YearsNCB)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearsNCB(YearsNCB))).Click();
        }

        [When(@"I select ""(.*)"" I want to protect my NCB")]
        public void WhenISelectIWantToProtectMyNCB(string ProtNCB)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ProtNCB())).Click();
        }

        [When(@"I select ""(.*)"" I don't have use of other vehicles")]
        public void WhenISelectIDonTHaveUseOfOtherVehicles(string UseOther)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UseOther(UseOther))).Click();
        }

        [Then(@"the We're Sorry page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            Console.WriteLine("Asserting text");
            FindText(xpath_Directory.SorryPage(), "We're sorry…");
            CommonComponents.TakeScreenshot();
            CommonComponents.driver.Quit();
        }

        //Additional Driver One 

        [When(@"I select ""(.*)"" to would you like to add any other drivers to your policy")]
        public void WhenISelectToWouldYouLikeToAddAnyOtherDriversToYourPolicy(string YesAdditionalDrivers)
        {
            WaitForElementToShow(xpath_Directory.AnyAdditonalDrivers());

            WaitForElementToBeClickable(xpath_Directory.YesAdditionalDriver());
        }

        [Then(@"I select the additional driver one title as ""(.*)"", First name ""(.*)"", and last name ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneTitleAsFirstNameAndLastName(string AddOneTitle, string AddOneFirstName, string AddOneLastName)
        {
            //WaitForElementToShow(xpath_Directory.AdditionalDriverOnePersonalDetailsDisplayed());
            CommonComponents.WaitForElementToBeClickable(xpath_Directory.AddOneTitle());
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneTitle())).SendKeys(AddOneTitle);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneFirstName())).SendKeys(AddOneFirstName);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneLastName())).SendKeys(AddOneLastName);
        }

        [Then(@"I select the additional driver one martial status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneMartialStatusAs(string AddMaritalStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddMaritalStatus(AddMaritalStatus))).Click();
        }

        [Then(@"I select the additional driver one date of birth as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneDateOfBirthAs(string AddDayOfBirth, string AddMonthOfBirth, string AddYearOfBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddDayOfBirth(AddDayOfBirth))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddMonthOfBirth(AddMonthOfBirth))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddYearOfBirth(AddYearOfBirth))).Click();
        }

        [Then(@"I select the additional driver one has been in the UK since birth")]
        public void ThenISelectTheAdditionalDriverOneHasBeenInTheUKSinceBirth()
        {
            _sinceBirthIndicator = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneSinceBirth()));
            _sinceBirthIndicator.Click();
        }

        [Then(@"I select the additional driver one relationship to you as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneRelationshipToYouAs(string AddOneRelationshipStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneRelationshipStatus(AddOneRelationshipStatus))).Click();
        }

        [Then(@"I select the additional driver one current employment status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneCurrentEmploymentStatusAs(string AddOneEmploymentStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneEmploymentStatus(AddOneEmploymentStatus))).Click();
        }

        [Then(@"I select the additional driver one occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneOccupationAs(string AddOneOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneOccupation())).SendKeys(AddOneOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneOccupation())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneOccupation())).Click();
        }

        [Then(@"I select the additional driver one business type as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneBusinessTypeAs(string AddOneBusinessType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneBusinessType())).SendKeys(AddOneBusinessType);
            Thread.Sleep(1000);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneBusinessType())).SendKeys(Keys.ArrowDown + Keys.Enter);
        }

        [Then(@"I select the additional driver one Part Time occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOnePartTimeOccupationAs(string AdditionalOnePartTimeOccupation)
        {
            if (AdditionalOnePartTimeOccupation == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOneYesPartTimeOccupation())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOneNoPartTimeOccupation())).Click();
            }
        }

        [When(@"I select Continue button on the additional driver details page")]
        public void WhenISelectContinueButtonOnTheAdditionalDriverDetailsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinueButtonOnTheAdditionalDriverDetails())).Click();
        }

        [Then(@"the Their Driving History accordion is expanded")]
        public void ThenTheTheirDrivingHistoryAccordionIsExpanded()
        {
            WaitForElementToShow(xpath_Directory.DrivingHistoryAccordionDisplayed());

        }

        [Then(@"I select the additional driver one type of driving licence as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneTypeOfDrivingLicenceAs(string TheirDrivingLicence)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TheirDrivingLicence(TheirDrivingLicence))).Click();

        }

        [Then(@"I select the additional driver one have held their licence for ""(.*)"" years")]
        public void ThenISelectTheAdditionalDriverOneHaveHeldTheirLicenceForYears(string AddOneYearsLicenceHeld)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneYearsLicenceHeld(AddOneYearsLicenceHeld))).Click();

        }

        [Then(@"I select the additional driver one additonal driving qualifications as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneAdditonalDrivingQualificationsAs(string AddOneDrivingQualifications)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneDrivingQualifications(AddOneDrivingQualifications))).Click();

        }

        [Then(@"I select the additional driver one medical conditions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneMedicalConditionsAs(string AddOneMedicalConditions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneMedicalConditions(AddOneMedicalConditions))).Click();

        }

        [Then(@"I select the additional driver one use of other vehicles as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOneUseOfOtherVehiclesAs(string AddOneUseOfOtherCars)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneUseOfOtherCars(AddOneUseOfOtherCars))).Click();

        }

        [Then(@"I select the additional driver one previous claims as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOnePreviousClaimsAs(string AddOneClaims)
        {
            if (AddOneClaims == "No")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneClaimsNo())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneClaimsYes())).Click();
            }
        }

        [Then(@"I select the additional driver one previous convictions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverOnePreviousConvictionsAs(string AddOneConvictions)
        {
            if (AddOneConvictions == "No")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneConvictionsNo())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneConvictionsYes())).Click();
            }
        }

        [When(@"I select the additional driver one add driver button")]
        public void WhenISelectTheAdditionalDriverOneAddDriverButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneAdditionalDriverButton())).Click();
            Thread.Sleep(500);
        }

        [When(@"I select the main driver for who is going to use the car the most")]
        public void WhenISelectTheMainDriverForWhoIsGoingToUseTheCarTheMost()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PrimaryDriver())).Click();
        }

        [When(@"I select the Continue button on the Additional Driver Your Cover page")]
        public void WhenISelectTheContinueButtonOnTheAdditionalDriverYourCoverPage()
        {
            WaitForElementToBeClickable(xpath_Directory.AdditionalDriverYourCoverPage());
        }

        //Additional Driver 2

        [When(@"I select Add Another on the additional driver one accordion")]
        public void WhenISelectAddAnotherOnTheAdditionalDriverOneAccordion()
        {
            WaitForElementToBeClickable(xpath_Directory.AddSecondAdditionalDriverClickable());
        }

        [Then(@"I select the additional driver two title as ""(.*)"", First name ""(.*)"", and last name ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoTitleAsFirstNameAndLastName(string AddTwoTitle, string AddTwoFirstName, string AddTwoLastName)
        {
            WaitForElementToBeClickable(xpath_Directory.AddTwoTitleClickable());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoTitle())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoTitle())).SendKeys(AddTwoTitle);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoFirstName())).SendKeys(AddTwoFirstName);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoLastName())).SendKeys(AddTwoLastName);
        }

        [Then(@"I select the additional driver two martial status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoMartialStatusAs(string AddTwoMaritalStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoMaritalStatus(AddTwoMaritalStatus))).Click();
        }

        [Then(@"I select the additional driver two date of birth as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoDateOfBirthAs(string AddTwoDayOfBirth, string AddTwoMonthOfBirth, string AddTwoYearOfBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoDayOfBirth(AddTwoDayOfBirth))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoMonthOfBirth(AddTwoMonthOfBirth))).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoYearOfBirth(AddTwoYearOfBirth))).Click();
        }

        [Then(@"I select additional driver two has been in the UK since birth")]
        public void ThenISelectAdditionalDriverTwoHasBeenInTheUKSinceBirth()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoSinceBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoSinceBirth())).Click();
        }

        [Then(@"I select the additional driver two relationship to you as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoRelationshipToYouAs(string AddTwoRelationshipStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoRelationshipStatus(AddTwoRelationshipStatus))).Click();
        }

        [Then(@"I select the additional driver two current employment status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoCurrentEmploymentStatusAs(string AddTwoEmploymentStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoEmploymentStatus(AddTwoEmploymentStatus))).Click();
        }

        [Then(@"I select the additional driver two occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoOccupationAs(string AddTwoOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoOccupation())).SendKeys(AddTwoOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoOccupation())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoOccupation())).Click();
        }

        [Then(@"I select the additional driver two business type as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoBusinessTypeAs(string AddTwoBusinessType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoBusinessType())).SendKeys(AddTwoBusinessType);
            Thread.Sleep(1500);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoBusinessType())).SendKeys(Keys.ArrowDown + Keys.Enter);
        }

        [Then(@"I select the additional driver two Part Time occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoPartTimeOccupationAs(string AdditionalTwoPartTimeOccupation)
        {
            if (AdditionalTwoPartTimeOccupation == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOneYesPartTimeOccupation())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOneNoPartTimeOccupation())).Click();
            }
        }

        [When(@"I select Continue button on the additional driver two details page")]
        public void WhenISelectContinueButtonOnTheAdditionalDriverTwoDetailsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinueButtonOnTheAdditionalTwoDriverDetails())).Click();
            Thread.Sleep(1000);
        }

        [Then(@"the Their Driving History accordion is expanded for additional driver two")]
        public void ThenTheTheirDrivingHistoryAccordionIsExpandedForAdditionalDriverTwo()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TheirDrivingHistoryAccordionDriverTwo()));
        }

        [Then(@"I select the additional driver two type of driving licence as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoTypeOfDrivingLicenceAs(string AddTwoDrivingLicence)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoDrivingLicence(AddTwoDrivingLicence))).Click();
        }

        [Then(@"I select the additional driver two have held their licence for ""(.*)"" years")]
        public void ThenISelectTheAdditionalDriverTwoHaveHeldTheirLicenceForYears(string AddTwoYearsLicenceHeld)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoYearsLicenceHeld(AddTwoYearsLicenceHeld))).Click();
        }

        [Then(@"I select the additional driver two additonal driving qualifications as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoAdditonalDrivingQualificationsAs(string AddTwoDrivingQualifications)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoDrivingQualifications(AddTwoDrivingQualifications))).Click();
        }

        [Then(@"I select the additional driver two medical conditions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoMedicalConditionsAs(string AddTwoMedicalConditions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoMedicalConditions(AddTwoMedicalConditions))).Click();
        }

        [Then(@"I select the additional driver two use of other vehicles as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoUseOfOtherVehiclesAs(string AddTwoUseOfOtherCars)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoUseOfOtherCars(AddTwoUseOfOtherCars))).Click();
        }

        [Then(@"I select the additional driver two previous claims as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoPreviousClaimsAs(string AddTwoClaims)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoClaims())).Click();
        }

        [Then(@"I select the additional driver two previous convictions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverTwoPreviousConvictionsAs(string AddTwoConvictions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddTwoConvictions())).Click();
        }

        [Then(@"I select the Add Driver for additional drive two")]
        public void ThenISelectTheAddDriverForAdditionalDriveTwo()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddSecondDriverToPolicy())).Click();
            Thread.Sleep(500);
        }
        [Then(@"I select the Continue button on the Additional Driver Your Cover page")]
        public void ThenISelectTheContinueButtonOnTheAdditionalDriverYourCoverPage()
        {
            WaitForElementToBeClickable(xpath_Directory.AdditionalDriverYourCoverPage());
        }

        //Additional Driver Three

        [Then(@"I select Add Another on the additional driver one accordion to add a third driver")]
        public void ThenISelectAddAnotherOnTheAdditionalDriverOneAccordionToAddAThirdDriver()
        {
            WaitForElementToBeClickable(xpath_Directory.AddThirdAdditionalDriverClickable());

        }

        [Then(@"I select the additional driver three title as ""(.*)"", First name ""(.*)"", and last name ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeTitleAsFirstNameAndLastName(string AddThreeTitle, string AddThreeFirstName, string AddThreeLastName)
        {
            WaitForElementToBeClickable(xpath_Directory.AddThreeTitleClickable());

            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeTitle())).SendKeys(AddThreeTitle);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeFirstName())).SendKeys(AddThreeFirstName);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeLastName())).SendKeys(AddThreeLastName);
        }

        [Then(@"I select the additional driver three martial status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeMartialStatusAs(string AddThreeMaritalStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeMaritalStatus(AddThreeMaritalStatus))).Click();
        }

        [Then(@"I select the additional driver three date of birth as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeDateOfBirthAs(int AddThreeDayOfBirth, string AddThreeMonthOfBirth, int AddThreeYearOfBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeDayOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeMonthOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeYearOfBirth())).Click();
        }

        [Then(@"I select additional driver three has been in the UK since birth")]
        public void ThenISelectAdditionalDriverThreeHasBeenInTheUKSinceBirth()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeSinceBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeSinceBirth())).Click();
        }

        [Then(@"I select the additional driver three relationship to you as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeRelationshipToYouAs(string AddThreeRelationshipStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeRelationshipStatus())).Click();
        }

        [Then(@"I select the additional driver three current employment status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeCurrentEmploymentStatusAs(string AddThreeEmploymentStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeEmploymentStatus())).Click();
        }

        [Then(@"I select the additional driver three occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeOccupationAs(string AddThreeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeOccupation())).SendKeys(AddThreeOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeOccupation())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeOccupation())).Click();

        }

        [Then(@"I select the additional driver three business type as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeBusinessTypeAs(string AddThreeBusinessType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeBusinessType())).SendKeys(AddThreeBusinessType);
            Thread.Sleep(1500);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeBusinessType())).SendKeys(Keys.ArrowDown + Keys.Enter);

        }

        [Then(@"I select the additional driver three Part Time occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreePartTimeOccupationAs(string AdditionalThreePartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreeNoPartTimeOccupation())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreeNoPartTimeOccupation())).Click();

        }

        [When(@"I select Continue button on the additional driver three details page")]
        public void WhenISelectContinueButtonOnTheAdditionalDriverThreeDetailsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinueButtonOnTheAdditionalThreeDriverDetails())).Click();
            Thread.Sleep(1000);

        }

        [Then(@"the Their Driving History accordion is expanded for additional driver three")]
        public void ThenTheTheirDrivingHistoryAccordionIsExpandedForAdditionalDriverThree()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TheirDrivingHistoryAccordionDriverThree()));
        }

        [Then(@"I select the additional driver three type of driving licence as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeTypeOfDrivingLicenceAs(string AddThreeDrivingLicence)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeDrivingLicence())).Click();
        }

        [Then(@"I select the additional driver three have held their licence for ""(.*)"" years")]
        public void ThenISelectTheAdditionalDriverThreeHaveHeldTheirLicenceForYears(int AddThreeYearsLicenceHeld)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeYearsLicenceHeld())).Click();
        }

        [Then(@"I select the additional driver three additonal driving qualifications as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeAdditonalDrivingQualificationsAs(string AddThreeDrivingQualifications)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeDrivingQualifications())).Click();
        }

        [Then(@"I select the additional driver three medical conditions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeMedicalConditionsAs(string AddThreeMedicalConditions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeMedicalConditions())).Click();
        }

        [Then(@"I select the additional driver three use of other vehicles as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreeUseOfOtherVehiclesAs(string AddThreeUseOfOtherCars)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeUseOfOtherCars())).Click();
        }

        [Then(@"I select the additional driver three previous claims as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreePreviousClaimsAs(string AddThreeClaims)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeClaims())).Click();
        }

        [Then(@"I select the additional driver three previous convictions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverThreePreviousConvictionsAs(string AddThreeConvictions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThreeConvictions())).Click();
        }

        [Then(@"I select the Add Driver for additional drive three")]
        public void ThenISelectTheAddDriverForAdditionalDriveThree()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddThirdDriverToPolicy())).Click();
            Thread.Sleep(500);
        }

        //Additional Driver Four

        [Then(@"I select Add Another on the additional driver three accordion")]
        public void ThenISelectAddAnotherOnTheAdditionalDriverThreeAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourAdditionalDriver())).Click();
            Thread.Sleep(1500);

        }

        [Then(@"I select the additional driver four title as ""(.*)"", First name ""(.*)"", and last name ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourTitleAsFirstNameAndLastName(string AddFourTitle, string AddFourFirstName, string AddFourLastName)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourTitle())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourFirstName())).SendKeys(AddFourFirstName);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourLastName())).SendKeys(AddFourLastName);
        }

        [Then(@"I select the additional driver four martial status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourMartialStatusAs(string AddFourMaritalStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourMaritalStatus())).Click();
        }

        [Then(@"I select the additional driver four date of birth as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourDateOfBirthAs(int AddFourDayOfBirth, string AddFourMonthOfBirth, int AddFourYearOfBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourDayOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourMonthOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourYearOfBirth())).Click();
        }


        [Then(@"I select additional driver four has been in the UK since birth")]
        public void ThenISelectAdditionalDriverFourHasBeenInTheUKSinceBirth()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourSinceBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourSinceBirth())).Click();
        }


        [Then(@"I select the additional driver four relationship to you as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourRelationshipToYouAs(string AddFourRelationshipStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourRelationshipStatus())).Click();
        }

        [Then(@"I select the additional driver four current employment status as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourCurrentEmploymentStatusAs(string AddFourEmploymentStatus)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourEmploymentStatus())).Click();
        }


        [Then(@"I select the additional driver four occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourOccupationAs(string AddFourOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourOccupation())).SendKeys(AddFourOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourOccupation())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourOccupation())).Click();
        }

        [Then(@"I select the additional driver four business type as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourBusinessTypeAs(string AddFourBusinessType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourBusinessType())).SendKeys(AddFourBusinessType);
            Thread.Sleep(1500);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourBusinessType())).SendKeys(Keys.ArrowDown + Keys.Enter);
            Thread.Sleep(1500);
        }

        [Then(@"I select the additional driver four Part Time occupation as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourPartTimeOccupationAs(string AdditionalFourPartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourNoPartTimeOccupation())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourNoPartTimeOccupation())).Click();
        }

        [When(@"I select Continue button on the additional driver four details page")]
        public void WhenISelectContinueButtonOnTheAdditionalDriverFourDetailsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinueButtonOnTheAdditionalFourDriverDetails())).Click();
            Thread.Sleep(1000);
        }

        [Then(@"the Their Driving History accordion is expanded for additional driver four")]
        public void ThenTheTheirDrivingHistoryAccordionIsExpandedForAdditionalDriverFour()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TheirDrivingHistoryAccordionDriverFour()));
        }

        [Then(@"I select the additional driver four type of driving licence as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourTypeOfDrivingLicenceAs(string AddFourDrivingLicence)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourDrivingLicence())).Click();
        }

        [Then(@"I select the additional driver four have held their licence for ""(.*)"" years")]
        public void ThenISelectTheAdditionalDriverFourHaveHeldTheirLicenceForYears(int AddFourYearsLicenceHeld)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourYearsLicenceHeld())).Click();
        }

        [Then(@"I select the additional driver four additonal driving qualifications as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourAdditonalDrivingQualificationsAs(string AddFourDrivingQualifications)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourDrivingQualifications())).Click();
        }

        [Then(@"I select the additional driver four medical conditions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourMedicalConditionsAs(string AddFourMedicalConditions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourMedicalConditions())).Click();
        }

        [Then(@"I select the additional driver four use of other vehicles as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourUseOfOtherVehiclesAs(string AddFourUseOfOtherCars)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourUseOfOtherCars())).Click();
        }

        [Then(@"I select the additional driver four previous claims as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourPreviousClaimsAs(string AddFourClaims)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourClaims())).Click();
        }

        [Then(@"I select the additional driver four previous convictions as ""(.*)""")]
        public void ThenISelectTheAdditionalDriverFourPreviousConvictionsAs(string AddFourConvictions)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourConvictions())).Click();
        }


        [Then(@"I select the Add Driver for additional driver four")]
        public void ThenISelectTheAddDriverForAdditionalDriverFour()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddFourDriverToPolicy())).Click();
            Thread.Sleep(500);
        }

        //Unacceptable Licences

        [When(@"I select my date of birth for EU Full Driver as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectMyDateOfBirthForEUFullDriverAs(string EUFullDayofBirth, string EUFullMonthofBirth, string EUFullYearofBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EUFullDayOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EUFullMonthOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EUFullYearOfBirth())).Click();
        }

        [When(@"I select my EU licence type as ""(.*)""")]
        public void WhenISelectMyEULicenceTypeAs(string EUFullLicenceType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EUFullLicenceType(EUFullLicenceType))).Click();
        }

        [When(@"I select my EU Provisional licence type as ""(.*)""")]
        public void WhenISelectMyEUProvisionalLicenceTypeAs(string EUProvisionalLicenceType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EUProvisionalLicenceType(EUProvisionalLicenceType))).Click();
        }

        [When(@"I select my date of birth for UK Provisional Licence Driver as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectMyDateOfBirthForUKProvisionalLicenceDriverAs(string UKProvisionalDayofBirth, string UKProvisionalMonthofBirth, string UKProvisionalYearofBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UKProvisionalDayOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UKProvisionalMonthOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UKProvisionalYearOfBirth())).Click();
        }

        [When(@"I select my UK Provisional licence type as ""(.*)""")]
        public void WhenISelectMyUKProvisionalLicenceTypeAs(string UKProvisionalLicenceType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UKProvisionalLicenceType(UKProvisionalLicenceType))).Click();
        }

        [When(@"I select my date of birth for International Licence Driver as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectMyDateOfBirthForInternationalLicenceDriverAs(string InternationalDayofBirth, string InternationalMonthofBirth, string InternationalYearofBirth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.InternationalDayOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.InternationalMonthOfBirth())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.InternationalYearOfBirth())).Click();
        }


        [When(@"I select my International licence type as ""(.*)""")]
        public void WhenISelectMyInternationalLicenceTypeAs(string InternationalLicenceType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.InternationalLicenceType(InternationalLicenceType))).Click();
        }

        //Imported Vehicles

        [When(@"I select ""(.*)"" I do not know the car registration")]
        public void WhenISelectIDoNotKnowTheCarRegistration(string UnknownCarRegistration)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UnknownCarRegistration())).Click();
            Thread.Sleep(2500);
        }

        [When(@"I enter the ""(.*)""")]
        public void WhenIEnterThe(string MakeOfCar)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MakeOfCar())).SendKeys(MakeOfCar);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MakeOfCar())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            Thread.Sleep(2500);
        }

        [When(@"I enter the model version as ""(.*)""")]
        public void WhenIEnterTheModelVersionAs(string ModelVersion)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ModelVersion())).SendKeys(ModelVersion);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ModelVersion())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            Thread.Sleep(2500);
        }

        [When(@"I select the year of manufacture as ""(.*)""")]
        public void WhenISelectTheYearOfManufactureAs(string YearOfManufacture)
        {
            WaitForElementToBeClickable(xpath_Directory.YearOfManufacture());
        }

        [When(@"I select the transmission type as ""(.*)""")]
        public void WhenISelectTheTransmissionTypeAs(string TransmissionType)
        {
            WaitForElementToBeClickable(xpath_Directory.TransmissionType());
        }

        [When(@"I select the engine size as ""(.*)""")]
        public void WhenISelectTheEngineSizeAs(string EngineSize)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EngineSize())).Click();
            Thread.Sleep(2000);
        }

        [When(@"I select my car is ""(.*)""")]
        public void WhenISelectMyCarIs(string MyCarIs)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MyCarIs())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I select the Confirm Details button")]
        public void WhenISelectTheConfirmDetailsButton()
        {
            WaitForElementToBeClickable(xpath_Directory.ConfirmDetails());
        }
        [Then(@"I select ""(.*)"" to the has your car been imported question")]
        public void ThenISelectToTheHasYourCarBeenImportedQuestion(string EUImported)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EUImported())).Click();
        }

        [Then(@"I select Non-EU Imported ""(.*)"" to the has your car been imported question")]
        public void ThenISelectNon_EUImportedToTheHasYourCarBeenImportedQuestion(string NonEuImported)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NonEUImported())).Click();
        }

        //Left Hand Drive
        [Then(@"I select Left Hand Drive ""(.*)""  in Is your car right or left-hand drive")]
        public void ThenISelectLeftHandDriveInIsYourCarRightOrLeft_HandDrive(string LeftHandDrive)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LeftHandDrive())).Click();
        }

        //Part Time Occupation
        [When(@"I select ""(.*)"" to the question Do you have a part time occupation")]
        public void WhenISelectToTheQuestionDoYouHaveAPartTimeOccupation(string YesPartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeOccupation())).Click();
        }


        //PartTimeOccupation
        [When(@"I enter my part-time occupation as ""(.*)""")]
        public void WhenIEnterMyPart_TimeOccupationAs(string PartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeOccupationType())).SendKeys(PartTimeOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeOccupationType())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeOccupationType())).Click();
        }



        [When(@"I enter my part-time business as ""(.*)""")]
        public void WhenIEnterMyPart_TimeBusinessAs(string YesPartTimeBusiness)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeBusiness())).SendKeys(YesPartTimeBusiness);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeBusiness())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPartTimeBusiness())).Click();
        }

        //Unacceptable Owner / Keeper

        [When(@"I select the Other for Legal owner as")]
        public void WhenISelectTheOtherForLegalOwnerAs()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.OtherOwner())).Click();
        }
        [When(@"I select Other for Registered keeper")]
        public void WhenISelectOtherForRegisteredKeeper()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.OtherKeeper())).Click();
        }

        //UnacceptableConvictions

        [When(@"I select Yes to the motoring convictions question")]
        public void WhenISelectYesToTheMotoringConvictionsQuestion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesToMotoringConvictions())).Click();
            Thread.Sleep(1000);
        }
        [When(@"I select No to is this conviction still pending")]
        public void WhenISelectNoToIsThisConvictionStillPending()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoToConvictionPending())).Click();
            Thread.Sleep(1000);
        }

        [When(@"I enter the date of the conviction as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenIEnterTheDateOfTheConvictionAs(string DayofConviction, string MonthofConviction, string YearofConviction)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DayOfConviction())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MonthOfConviction())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearOfConviction())).Click();
        }

        [When(@"I select the type of conviction as ""(.*)""")]
        public void WhenISelectTheTypeOfConvictionAs(string Conviction)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Conviction(Conviction))).Click();
        }

        [When(@"I enter tne amount of penalty points as ""(.*)""")]
        public void WhenIEnterTneAmountOfPenaltyPointsAs(string PenaltyPoints)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PenaltyPoints(PenaltyPoints))).Click();
        }

        [When(@"I enter the amount of the fine as ""(.*)""")]
        public void WhenIEnterTheAmountOfTheFineAs(string Fine)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Fine())).SendKeys(Fine);
        }

        [When(@"I select No for the were you banned from driving question")]
        public void WhenISelectNoForTheWereYouBannedFromDrivingQuestion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoToBannedFromDriving())).Click();
            Thread.Sleep(1500);
        }
        [When(@"I select Add on the convictions page")]
        public void WhenISelectAddOnTheConvictionsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddConviction())).Click();
            Thread.Sleep(1500);
        }
        [When(@"I select Add on the convictions page for additional driver one")]
        public void WhenISelectAddOnTheConvictionsPageForAdditionalDriverOne()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddConvictionAdditional())).Click();
            Thread.Sleep(1500);
        }

        [When(@"I select Yes for the were you banned from driving question")]
        public void WhenISelectYesForTheWereYouBannedFromDrivingQuestion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesToBannedFromDriving())).Click();
        }

        [When(@"I enter the length of the ban as ""(.*)""")]
        public void WhenIEnterTheLengthOfTheBanAs(string Ban)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Ban())).SendKeys(Ban);
        }
        [Then(@"the conviction is added")]
        public void ThenTheConvictionIsAdded()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConvictionAdded()));
            Thread.Sleep(1000);
        }

        [When(@"I select the Add another button")]
        public void WhenISelectTheAddAnotherButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddAnotherConviction())).Click();
            Thread.Sleep(1000);
        }

        //Claims
        [When(@"I select Yes for any accidents, claims or damage")]
        public void WhenISelectYesForAnyAccidentsClaimsOrDamage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesToClaims())).Click();
            Thread.Sleep(1000);
        }

        [When(@"I select the date of the claim as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectTheDateOfTheClaimAs(string DayofClaim, string MonthofClaim, string YearofClaim)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DayOfClaim())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MonthOfClaim())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearOfClaim())).Click();
        }

        [When(@"I select the type of claim as ""(.*)""")]
        public void WhenISelectTheTypeOfClaimAs(string Claim)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Claim(Claim))).Click();
        }

        [When(@"I enter the cost of the claim as ""(.*)""")]
        public void WhenIEnterTheCostOfTheClaimAs(string Cost)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Cost())).SendKeys(Cost);
        }

        [When(@"I select the fault as ""(.*)""")]
        public void WhenISelectTheFaultAs(string FaultType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FaultType(FaultType))).Click();
        }

        [When(@"I select the Add button to add the claim")]
        public void WhenISelectTheAddButtonToAddTheClaim()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddClaim())).Click();
            Thread.Sleep(1500);
        }

        [Then(@"the claim is added")]
        public void ThenTheClaimIsAdded()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ClaimAdded()));
            Thread.Sleep(1000);
        }
        [When(@"I select Add another claim")]
        public void WhenISelectAddAnotherClaim()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddAnotherClaim())).Click();
            Thread.Sleep(1000);
        }

        //Different Payee

        [When(@"I select the radio button to confirm the policyholder and cardholder are different")]
        public void WhenISelectTheRadioButtonToConfirmThePolicyholderAndCardholderAreDifferent()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DifferentPayee())).Click();
            Thread.Sleep(1000);
        }

        [When(@"I enter the housenumber of the payee ""(.*)"" and the postcode ""(.*)""")]
        public void WhenIEnterTheHousenumberOfThePayeeAndThePostcode(string PayeeHouseNumber, string PayeePostCode)
        {
            CommonComponents._payeeHouseNumber = PayeeHouseNumber;
            CommonComponents._payeePostcode = PayeePostCode;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeHouseNumber())).SendKeys(PayeeHouseNumber);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeePostCode())).SendKeys(PayeePostCode);
        }

        [When(@"I select the Find My Address button")]
        public void WhenISelectTheFindMyAddressButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FindPayeeAddress())).Click();
            Thread.Sleep(1000);
            bool FoundPayeeAddress = false;
            var Payeecount = 0;
            while (!FoundPayeeAddress)
            {
                var PayeeAddressNotFoundModal = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeAddressNotFound()));
                if (Payeecount < 3)
                {
                    if (PayeeAddressNotFoundModal.Displayed)
                    {
                        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeAddressModalClose())).Click();
                        Thread.Sleep(3000);
                        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeePostCode())).SendKeys(CommonComponents._payeePostcode);
                        Thread.Sleep(3000);
                        CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FindPayeeAddress())).Click();
                        Thread.Sleep(2000);
                        Payeecount++;
                    }
                    else
                    {
                        FoundPayeeAddress = true;
                        Thread.Sleep(3000);
                    }
                }
                else
                {
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeAddressModalClose())).Click();
                    Thread.Sleep(2000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeEnterMyAddress())).Click();
                    //CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeEnterMyAddress())).Click();
                    Thread.Sleep(2000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeHouseBuildingNumber())).SendKeys(CommonComponents._houseNumber);
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeStreet())).SendKeys("Test Street");
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeArea())).SendKeys("Test Area");
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeTown())).SendKeys("Test Town");
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeManualPostcode())).SendKeys(CommonComponents._postCode);
                    Thread.Sleep(1000);
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeConfirmAddressDetails())).Click();
                    Thread.Sleep(3000);
                    FoundPayeeAddress = true;
                }
            }
        }

        [Then(@"the address details of the payee will be populated")]
        public void ThenTheAddressDetailsOfThePayeeWillBePopulated()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeAddressPopulated()));
        }

        [When(@"I select the relationship to the cardholder as ""(.*)""")]
        public void WhenISelectTheRelationshipToTheCardholderAs(string PayeeRelationship)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PayeeRelationship(PayeeRelationship))).Click();
        }

        //Voluntary Excess

        [Then(@"I select the voluntary excess as ""(.*)""")]
        public void ThenISelectTheVoluntaryExcessAs(string VoluntaryExcess)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.VoluntaryExcess(VoluntaryExcess))).Click();
        }

        //AddOns

        [Then(@"I select ""(.*)""")]
        public void ThenISelect(string BreakdownCover)
        {
            if (BreakdownCover == "Roadside")
            {
                WaitForElementToBeClickable(xpath_Directory.Roadside());
            }
            if (BreakdownCover == "Roadside & Recovery")
            {
                WaitForElementToBeClickable(xpath_Directory.RoadsideRecovery());
            }
            if (BreakdownCover == "Roadside, Recovery & At Home")
            {
                WaitForElementToBeClickable(xpath_Directory.RoadsideRecoveryAtHome());
            }
            if (BreakdownCover == "Roadside, Recovery, At Home and European Motoring Assistance")
            {
                WaitForElementToBeClickable(xpath_Directory.RoadsideRecoveryAtHomeandEuropeanMotoringAssistance());
            }
        }

        [Then(@"I select Yes for Replacement Car Cover")]
        public void ThenISelectYesForReplacementCarCover()
        {
            WaitForElementToBeClickable(xpath_Directory.ReplacementCar());
        }

        [Then(@"I select Yes for Motor Legal Protection")]
        public void ThenISelectYesForMotorLegalProtection()
        {
            WaitForElementToBeClickable(xpath_Directory.MotorLegalProtection());
        }

        //SSC Registration

        [When(@"I enter my email address as ""(.*)""")]
        public void WhenIEnterMyEmailAddressAs(string StaticEmailAddress)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.StaticEmailAddress())).SendKeys(StaticEmailAddress);
        }

        [When(@"I confirm my email address as ""(.*)""")]
        public void WhenIConfirmMyEmailAddressAs(string ConfirmStaticEmailAddress)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmStaticEmailAddress())).SendKeys(ConfirmStaticEmailAddress);
        }

        [Then(@"the Payment Confirmation page is displayed with the policy number")]
        public void ThenThePaymentConfirmationPageIsDisplayedWithThePolicyNumber()
        {
            var ConfirmationPage = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmationPage()));
            FindText(xpath_Directory.ConfirmationPage(), "Welcome to Provident Insurance");

            Thread.Sleep(3000);
        }

        [When(@"I select the My Account button")]
        public void WhenISelectTheMyAccountButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ClickMyAccount())).Click();
            Thread.Sleep(3000);
        }

        [When(@"I select the Register button")]
        public void WhenISelectTheRegisterButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Register())).Click();
        }
        [When(@"I enter my ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenIEnterMy(string StaticEmailAddress, string RegFirstname, string RegLastname)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RegStaticEmailAddress())).SendKeys(CommonComponents._emailAddress);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RegFirstname())).SendKeys(CommonComponents._firstName);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RegLastname())).SendKeys(CommonComponents._lastName);
        }

        [When(@"I enter my DOB as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenIEnterMyDOBAs(string DOB, string MOB, string YOB)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DOB())).SendKeys(CommonComponents._DayOfBirth);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MOB())).SendKeys(CommonComponents._MonthOfBirth);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YOB())).SendKeys(CommonComponents._YearOfBirth);
        }

        [When(@"I enter my Postcode as ""(.*)""")]
        public void WhenIEnterMyPostcodeAs(string RegPostcode)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RegPostcode())).SendKeys(RegPostcode);
            Thread.Sleep(10000);
        }

        [When(@"I click the continue button to proceed")]
        public void WhenIClickTheContinueButtonToProceed()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinueToRegister())).Click();
            Thread.Sleep(2000);
        }

        [When(@"I enter my Password as ""(.*)""")]
        public void WhenIEnterMyPasswordAs(string RegPassword)
        {
            CommonComponents._passWord = RegPassword;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RegPassword())).SendKeys(CommonComponents._passWord);
        }
        [When(@"I reenter my Password as ""(.*)""")]
        public void WhenIReenterMyPasswordAs(string ReenterRegPassword)
        {
            CommonComponents._passWord = ReenterRegPassword;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ReenterRegPassword())).SendKeys(CommonComponents._passWord);
            Thread.Sleep(5000);
        }

        [When(@"I click the Finish button")]
        public void WhenIClickTheFinishButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FinishButton())).Click();
            Thread.Sleep(5000);
        }
        [When(@"I select the Continue button on the new password created pop up")]
        public void WhenISelectTheContinueButtonOnTheNewPasswordCreatedPopUp()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ContinuePasswordCreated())).Click();
            Thread.Sleep(1500);
        }

        [When(@"I select my name as title ""(.*)"", First name ""(.*)"", and last name ""(.*)""")]
        public void WhenISelectMyNameAsTitleFirstNameAndLastName(string Title, string RegFirstName, string RegLastName)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Title())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FirstName())).SendKeys(RegFirstName);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LastName())).SendKeys(RegLastName);
        }
        [When(@"I enter my ""(.*)"" and logon password as ""(.*)""")]
        public void WhenIEnterMyAndLogonPasswordAs(string LogOnEmailAddress, string LogOnPassword)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LogOnEmailAddress())).SendKeys(CommonComponents._emailAddress);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LogOnPassword())).SendKeys(CommonComponents._passWord);
            Thread.Sleep(10000);
        }

        [When(@"I select the Login to your account button")]
        public void WhenISelectTheLoginToYourAccountButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.LogIntoAccount())).Click();
            Thread.Sleep(20000);
        }
        [Then(@"the SSC Homepage is displayed")]
        public void ThenTheSSCHomepageIsDisplayed()
        {
            Console.WriteLine("Asserting text");
            Thread.Sleep(3000);
            FindText(xpath_Directory.SSCHomepage(), "My Policies");
            Thread.Sleep(3000);
            CommonComponents.driver.Close();
        }
        [When(@"I select the Provident logo at the top of the page")]
        public void WhenISelectTheProvidentLogoAtTheTopOfThePage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ProvLogo())).Click();
            Thread.Sleep(2000);
        }

        [When(@"I select the My Account button at the top of the page")]
        public void WhenISelectTheMyAccountButtonAtTheTopOfThePage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MyAcc())).Click();
            Thread.Sleep(2000);
        }

        //MTA

        [Then(@"I land on the SSC Homepage")]
        public void ThenILandOnTheSSCHomepage()
        {
            Console.WriteLine("Asserting text");
            Thread.Sleep(3000);
            FindText(xpath_Directory.SSCHomepage2(), "My Policies");
            Thread.Sleep(3000);
        }

        [When(@"I expand the My Policies Accordion")]
        public void WhenIExpandTheMyPoliciesAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MyPoliciesAccordion())).Click();
            Thread.Sleep(3000);
        }

        [When(@"I expand the relevant Car Policy Accordion")]
        public void WhenIExpandTheRelevantCarPolicyAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarPolicyAccordion())).Click();
            Thread.Sleep(2000);
        }

        [When(@"I select the Change My Car button")]
        public void WhenISelectTheChangeMyCarButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeMyCar())).Click();
            Thread.Sleep(4000);
        }

        [When(@"I select the button to change my car")]
        public void WhenISelectTheButtonToChangeMyCar()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeMyCarButton())).Click();
            Thread.Sleep(3000);
        }
        [When(@"I select to open the calendar")]
        public void WhenISelectToOpenTheCalendar()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeToStartElement())).Click();
            Thread.Sleep(1000);
        }

        [When(@"I select the Month I want the change to start as ""(.*)""")]
        public void WhenISelectTheMonthIWantTheChangeToStartAs(string ChangeToMonth)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeToMonth())).Click();
            Thread.Sleep(1000);
        }
        [When(@"I select the change to start ""(.*)"" days from today")]
        public void WhenISelectTheChangeToStartDaysFromToday(string ChangeToStart)
        {
            Thread.Sleep(1000);
            CommonComponents.driver.FindElement(By.XPath("/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-about-your-car/form/fieldset[1]/div[2]/div/div/ng2-datepicker/div/div[2]/div[2]/div/div[3]/span[27]")).Click();
            Thread.Sleep(1000);
        }

        [When(@"I select the time for the change to start as ""(.*)"" ""(.*)""")]
        public void WhenISelectTheTimeForTheChangeToStartAs(string Hour, string Minutes)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Hour())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Minutes())).Click();
        }

        [When(@"I select ""(.*)"" to the Do you know the registration of your new car question")]
        public void WhenISelectToTheDoYouKnowTheRegistrationOfYourNewCarQuestion(string RegistrationOfNewCar)
        {
            if (RegistrationOfNewCar == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NewCarRegKnown())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NewCarRegUnknown())).Click();
            }
        }
        [When(@"I select the Find my car button")]
        public void WhenISelectTheFindMyCarButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FindMyCarButton())).Click();
            Thread.Sleep(5000);
        }

        [When(@"I enter the new car registration number as ""(.*)""")]
        public void WhenIEnterTheNewCarRegistrationNumberAs(string EnterReg2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterReg2())).SendKeys(EnterReg2);
        }
        [Then(@"the details of the new car are displayed")]
        public void ThenTheDetailsOfTheNewCarAreDisplayed()
        {
            Console.WriteLine("Asserting text");
            Thread.Sleep(1000);
            FindText(xpath_Directory.NewCarDetails(), "You want a quote for...");
            Thread.Sleep(1000);
        }
        [When(@"I enter the make of car as ""(.*)""")]
        public void WhenIEnterTheMakeOfCarAs(string Make)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Make())).SendKeys(Make);
        }

        [When(@"I enter the model of the car as ""(.*)""")]
        public void WhenIEnterTheModelOfTheCarAs(string Model)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Model())).SendKeys(Model);
        }

        [When(@"I enter the model variant as ""(.*)""")]
        public void WhenIEnterTheModelVariantAs(string Variant)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Variant())).SendKeys(Variant);
        }

        [When(@"I enter the year of manufacture as ""(.*)""")]
        public void WhenIEnterTheYearOfManufactureAs(string YearOfManufacture2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearOfManufacture2())).SendKeys(YearOfManufacture2);
        }

        [When(@"I select the Fuel type as ""(.*)""")]
        public void WhenISelectTheFuelTypeAs(string FuelType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.FuelType())).Click();
        }

        [When(@"I select the transmission type for the new car as ""(.*)""")]
        public void WhenISelectTheTransmissionTypeForTheNewCarAs(string TransmissionType2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.TransmissionType2())).Click();
        }

        [When(@"I select the number of doors as ""(.*)""")]
        public void WhenISelectTheNumberOfDoorsAs(string Doors)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Doors())).SendKeys(Doors);
        }

        [When(@"I enter the engine size as ""(.*)""")]
        public void WhenIEnterTheEngineSizeAs(string Engine2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Engine2())).SendKeys(Engine2);
        }
        [When(@"I select the Confirm Details button on the Change your car page")]
        public void WhenISelectTheConfirmDetailsButtonOnTheChangeYourCarPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeYourCarConfirmDetails())).Click();
        }
        [When(@"I select ""(.*)"" to confirm if the details are correct")]
        public void WhenISelectToConfirmIfTheDetailsAreCorrect(string ConfirmCarDetails)
        {
            if (ConfirmCarDetails == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarDetailsCorrect())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarDetailsIncorrect())).Click();
            }
        }

        [When(@"I select the Next button on the first page")]
        public void WhenISelectTheNextButtonOnTheFirstPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NextButtonFirstPage())).Click();
            Thread.Sleep(4000);
        }

        [When(@"I select that the vehicle has ""(.*)"" been purchased")]
        public void WhenISelectThatTheVehicleHasBeenPurchased(string Purchased)
        {
            if (Purchased == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesPurchased())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoPurchased())).Click();
            }
        }

        [When(@"I select the date purchased as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void WhenISelectTheDatePurchasedAs(string DayofPurchase, string MonthofPurchase, string YearofPurchase)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DayOfPurchase())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MonthOfPurchase())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearOfPurchase())).Click();
        }

        [When(@"I enter the estimated value of your car as ""(.*)""")]
        public void WhenIEnterTheEstimatedValueOfYourCarAs(string Value2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EnterValue2())).SendKeys(Value2);
        }

        [When(@"I select that the car is right hand drive")]
        public void WhenISelectThatTheCarIsRightHandDrive()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarRightHandDrive())).Click();
        }

        [When(@"I select that the car is not imported")]
        public void WhenISelectThatTheCarIsNotImported()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarImported())).Click();
        }

        [When(@"I select that the car has not been modified in anyway")]
        public void WhenISelectThatTheCarHasNotBeenModifiedInAnyway()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CarModified())).Click();
        }

        [When(@"I select ""(.*)"" for the alarm type of the new car")]
        public void WhenISelectForTheAlarmTypeOfTheNewCar(string AlarmType2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AlarmType2(AlarmType2))).Click();
        }

        [When(@"I select ""(.*)"" to the question is you car fitted with a tracking device")]
        public void WhenISelectToTheQuestionIsYouCarFittedWithATrackingDevice(string Tracking)
        {
            if (Tracking == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesTracking())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoTracking())).Click();
            }
        }

        [When(@"I select the Legal owner of the new car as ""(.*)""")]
        public void WhenISelectTheLegalOwnerOfTheNewCarAs(string Legal2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Legal2(Legal2))).Click();
        }

        [When(@"I select the registered keeper of the new car as ""(.*)""")]
        public void WhenISelectTheRegisteredKeeperOfTheNewCarAs(string Registered2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.Registered2(Registered2))).Click();
        }

        [When(@"I select ""(.*)"" to the question am I keeping the old car")]
        public void WhenISelectToTheQuestionAmIKeepingTheOldCar(string OldCar)
        {
            if (OldCar == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesOldCar())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoOldCar())).Click();
            }
        }

        [When(@"I select the next button on the second page")]
        public void WhenISelectTheNextButtonOnTheSecondPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NextButtonSecondPage())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I select the next button again on the second page")]
        public void WhenISelectTheNextButtonAgainOnTheSecondPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NextButtonSecondPageAgain())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I enter the optional phone number as ""(.*)""")]
        public void WhenIEnterTheOptionalPhoneNumberAs(string MTAPhoneNumber)
        {
            if (CommonComponents._PhoneNumber == null) { CommonComponents._PhoneNumber = MTAPhoneNumber; }
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MTAPhoneNumber())).SendKeys(CommonComponents._PhoneNumber);
        }

        [When(@"I enter the optional email address as ""(.*)""")]
        public void WhenIEnterTheOptionalEmailAddressAs(string MTAEmailAddress)
        {
            if (CommonComponents._emailAddress == null) { CommonComponents._emailAddress = MTAEmailAddress; }
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MTAEmailAddress())).SendKeys(CommonComponents._emailAddress);
        }

        [When(@"I select ""(.*)"" to the terms and conditions")]
        public void WhenISelectToTheTermsAndConditions(string TandC)
        {
            if (TandC == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AgreeToTandC())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DisagreeToTandC())).Click();
            }
        }

        [When(@"I select the change your car Get A Quote button")]
        public void WhenISelectTheChangeYourCarGetAQuoteButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeYourCarGetAQuote())).Click();
            Thread.Sleep(25000);
        }

        [When(@"I select the OK button on the quote request message")]
        public void WhenISelectTheOKButtonOnTheQuoteRequestMessage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.OKButtonOnQuoteMessage())).Click();
            Thread.Sleep(20000);
            CommonComponents.driver.Close();
        }
        [When(@"I select the Back button on the Change your car page")]
        public void WhenISelectTheBackButtonOnTheChangeYourCarPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeYourCarBackButton())).Click();
        }

        [When(@"I select the Back button on the Your Car's Details page")]
        public void WhenISelectTheBackButtonOnTheYourCarSDetailsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourCarDetailsBackButton())).Click();
        }
        [When(@"I select the Back button on the Your Details page")]
        public void WhenISelectTheBackButtonOnTheYourDetailsPage()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourDetailsBackButton())).Click();
        }
        [Then(@"the Your Car's Details page is displayed")]
        public void ThenTheYourCarSDetailsPageIsDisplayed()
        {
            Console.WriteLine("Asserting text");
            Thread.Sleep(1000);
            FindText(xpath_Directory.YourCarsDetails(), "Your car's details");
            Thread.Sleep(2000);
        }






        /*
 * test method section
*/
        private void FindText(string xPath, string expectedText)
        {
            var found = false;

            while (!found)
            {
                try
                {
                    var test = CommonComponents.driver.FindElement(By.XPath(xPath));
                    var text = test.Text;

                    if (text == expectedText)
                    {
                        found = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }


        [Then(@"the calendar icon is displayed")]
        public void ThenTheCalendarIconIsDisplayed()
        {
            var CalendarIcon = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.CalendarIcon()));
            Thread.Sleep(2000);
        }

        [Then(@"the change start date button is displayed")]
        public void ThenTheChangeStartDateButtonIsDisplayed()
        {
            var StartDateButton = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.StartDateButton()));
            FindText(xpath_Directory.StartDateButton(), "Change start date");
            Thread.Sleep(2000);
        }
        [When(@"I select the More Information button")]
        public void WhenISelectTheMoreInformationButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MoreInformation())).Click();
            Thread.Sleep(2000);
        }

        [Then(@"the more information section expands and contains the text '(.*)'")]
        public void ThenTheMoreInformationSectionExpandsAndContainsTheText(string PossiblyNeeded)
        {
            var MoreInformationText = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MoreInformationText()));
            FindText(xpath_Directory.MoreInformationText(), "Your policy will start at 00:01 on the date you’ve selected. You can change your start date by clicking Change start date, but please be aware that");
            Thread.Sleep(2000);
        }
        [When(@"I select the Change Start Date button")]
        public void WhenISelectTheChangeStartDateButton()
        {
            var found = false;

            while (!found)
            {
                try
                {
                    Console.Write("This is hitting small screen version");
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeStartDateButtonSM())).Click();
                    found = true;
                    Thread.Sleep(2000);

                }
                catch
                {
                    Console.Write("This is hitting big screen version");
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ChangeStartDateButtonMD())).Click();
                    found = true;
                    Thread.Sleep(2000);
                }
            }
        }


        [Then(@"the Your Cover page is displayed with the start date field visable")]
        public void ThenTheYourCoverPageIsDisplayedWithTheStartDateFieldVisable()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourCoverPageDisplayed()));
            Thread.Sleep(2000);
        }

        [Then(@"I select to confirm the start date")]
        public void ThenISelectToConfirmTheStartDate()
        {

            var found = false;

            while (!found)
            {
                try
                {
                    Console.Write("This is hitting small screen version");
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmTheStartDateSm())).Click();
                    found = true;

                }
                catch
                {
                    Console.Write("This is hitting big screen version");
                    CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ConfirmTheStartDateMd())).Click();
                    found = true;
                }
            }
        }

        [Then(@"the browser is closed")]
        public void ThenTheBrowserIsClosed()
        {
            CommonComponents.driver.Close();
        }

        //Save and Retrieve

        [When(@"I select the Click to Save button")]
        public void WhenISelectTheClickToSaveButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SaveQuoteButton())).Click();
        }

        [When(@"I enter my new password as ""(.*)""")]
        public void WhenIEnterMyNewPasswordAs(string SavePassword)
        {
            WaitForElementToBeClickable(xpath_Directory.SavePasswordClickable());
            CommonComponents._passWord = SavePassword;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SavePassword())).SendKeys(CommonComponents._passWord);
        }

        [When(@"I reenter my new password as ""(.*)""")]
        public void WhenIReenterMyNewPasswordAs(string ReenterSavePassword)
        {
            CommonComponents._passWord = ReenterSavePassword;
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ReenterSavePassword())).SendKeys(CommonComponents._passWord);
        }
        [When(@"I select the save button")]
        public void WhenISelectTheSaveButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SaveButton())).Click();
        }
        [When(@"I select the close button on the Thank You modal")]
        public void WhenISelectTheCloseButtonOnTheThankYouModal()
        {
            WaitForElementToBeClickable(xpath_Directory.CloseButtonClickable());
            Thread.Sleep(500);
        }
        [When(@"I select the Provident logo at the top of the PPP")]
        public void WhenISelectTheProvidentLogoAtTheTopOfThePPP()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PPPProvLogo())).Click();
        }
        [When(@"I select the Retrieve a quote button")]
        public void WhenISelectTheRetrieveAQuoteButton()
        {
            WaitForElementToBeClickable(xpath_Directory.RetrieveQuoteButtonClickable());
        }
        [When(@"I enter my email address used for the quote")]
        public void WhenIEnterMyEmailAddressUsedForTheQuote()
        {
            if (CommonComponents._okta == "On")
            {
                WaitForElementToBeClickable(xpath_Directory.QuoteEmailAddress());
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.QuoteEmailAddress())).SendKeys(CommonComponents._emailAddress);
            }
            else
            {
                WaitForElementToBeClickable(xpath_Directory.NonOKTAQuoteEmailAddress());
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NonOKTAQuoteEmailAddress())).SendKeys(CommonComponents._emailAddress);
            }
        }

        [When(@"I enter my quote password")]
        public void WhenIEnterMyQuotePassword()
        {
            if (CommonComponents._okta == "On")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.QuotePassword())).SendKeys(CommonComponents._passWord);
                Thread.Sleep(5000);
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NonOKTAQuotePassword())).SendKeys(CommonComponents._passWord);
                Thread.Sleep(5000);
            }
            //Thread.Sleep(50000);
        }

        [When(@"I select the Retrieve your quote button")]
        public void WhenISelectTheRetrieveYourQuoteButton()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RetrieveYourQuoteButton())).Click();
            Thread.Sleep(3000);
            if (CommonComponents.driver.FindElement(By.XPath(xpath_Directory.SorryElement())).Displayed)
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ClickSorryElementClose())).Click();
                Thread.Sleep(20000);
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.RetrieveYourQuoteButton())).Click();
            }
        }
        [Then(@"the SSC Homepage is displayed showing the quote")]
        public void ThenTheSSCHomepageIsDisplayedShowingTheQuote()
        {
            Console.WriteLine("Asserting text");
            Thread.Sleep(3000);
            FindText(xpath_Directory.SSCQuoteHomepage(), "My Quotes");
            Thread.Sleep(3000);           
        }
        [Then(@"the details of the quote are displayed")]
        public void ThenTheDetailsOfTheQuoteAreDisplayed()
        {
            WaitForElementToBeClickable(xpath_Directory.BuyThisQuote());
            Thread.Sleep(1500);
            CommonComponents.TakeScreenshot();
            CommonComponents.driver.Quit();
        }




        //Additional Drivers Part-time Occupations

        [Then(@"I enter the additional driver one part-time occupation as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverOnePart_TimeOccupationAs(string DriverOnePartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOnePartTimeOcc())).SendKeys(DriverOnePartTimeOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOnePartTimeOcc())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOnePartTimeOcc())).Click();
        }

        [Then(@"I enter the additional driver one part-time business as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverOnePart_TimeBusinessAs(string DriverOnePartTimeBusiness)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOnePartTimeBus())).SendKeys(DriverOnePartTimeBusiness);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOnePartTimeBus())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalOnePartTimeBus())).Click();
        }

        [Then(@"I enter the additional driver two part-time occupation as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverTwoPart_TimeOccupationAs(string DriverTwoPartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalTwoPartTimeOcc())).SendKeys(DriverTwoPartTimeOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalTwoPartTimeOcc())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalTwoPartTimeOcc())).Click();
        }

        [Then(@"I enter the additional driver two part-time business as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverTwoPart_TimeBusinessAs(string DriverTwoPartTimeBusiness)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalTwoPartTimeBus())).SendKeys(DriverTwoPartTimeBusiness);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalTwoPartTimeBus())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalTwoPartTimeBus())).Click();
        }
        [Then(@"I enter the additional driver three part-time occupation as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverThreePart_TimeOccupationAs(string DriverThreePartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreePartTimeOcc())).SendKeys(DriverThreePartTimeOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreePartTimeOcc())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreePartTimeOcc())).Click();
        }

        [Then(@"I enter the additional driver three part-time business as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverThreePart_TimeBusinessAs(string DriverThreePartTimeBusiness)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreePartTimeBus())).SendKeys(DriverThreePartTimeBusiness);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreePartTimeBus())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalThreePartTimeBus())).Click();
        }
        [Then(@"I enter the additional driver four part-time occupation as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverFourPart_TimeOccupationAs(string DriverFourPartTimeOccupation)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourPartTimeOcc())).SendKeys(DriverFourPartTimeOccupation);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourPartTimeOcc())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourPartTimeOcc())).Click();
        }

        [Then(@"I enter the additional driver four part-time business as ""(.*)""")]
        public void ThenIEnterTheAdditionalDriverFourPart_TimeBusinessAs(string DriverFourPartTimeBusiness)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourPartTimeBus())).SendKeys(DriverFourPartTimeBusiness);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourPartTimeBus())).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AdditionalFourPartTimeBus())).Click();
        }
        //Save, Retrieve and Buy

        [Then(@"the SSC Homepage is displayed with the quote available")]
        public void ThenTheSSCHomepageIsDisplayedWithTheQuoteAvailable()
        {
            WaitForElementToShow(xpath_Directory.SSCQuoteHomepage());

            Console.WriteLine("Asserting text");
            Thread.Sleep(3000);
            FindText(xpath_Directory.SSCQuotesHomepage(), "My Quotes");
        }

        [When(@"I select to expand the My Quotes accordion")]
        public void WhenISelectToExpandTheMyQuotesAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MyQuotesAccordion())).Click();
            Thread.Sleep(2000);
        }

        [When(@"I select the relevant quote")]
        public void WhenISelectTheRelevantQuote()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.ExpandQuote())).Click();
            Thread.Sleep(2000);
        }

        [When(@"I select the button to Buy this quote")]
        public void WhenISelectTheButtonToBuyThisQuote()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.BuyThisQuote())).Click();
            Thread.Sleep(10000);
        }
        [When(@"I select the button to Edit this quote")]
        public void WhenISelectTheButtonToEditThisQuote()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.EditQuoteButton())).Click();
            Thread.Sleep(5000);
        }
        [When(@"I select the Continue button on the About Your Car accordion")]
        public void WhenISelectTheContinueButtonOnTheAboutYourCarAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AboutYourCarContinueButton())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I select the Continue button on the Using Your Car accordion")]
        public void WhenISelectTheContinueButtonOnTheUsingYourCarAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.UsingYourCarContinueButton())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I select the Continue button on the Your Personal Details accordion")]
        public void WhenISelectTheContinueButtonOnTheYourPersonalDetailsAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourPersonalDetailsContinueButton())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I select the Continue button on the Your Driving History accordion")]
        public void WhenISelectTheContinueButtonOnTheYourDrivingHistoryAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourDrivingHistoryContinueButton())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I select the Contonue button on the Your Additional Drivers accordion")]
        public void WhenISelectTheContonueButtonOnTheYourAdditionalDriversAccordion()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YourAdditionalDriversContinueButton())).Click();
            Thread.Sleep(2000);
        }
        [When(@"I update the tracking device to ""(.*)""")]
        public void WhenIUpdateTheTrackingDeviceTo(string TrackingDevice2)
        {
            if (TrackingDevice2 == "Yes")
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YesTrackingDevice())).Click();
            }
            else
            {
                CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoTrackingDevice())).Click();
            }
        }
        //Additional Driver Medical Conditions

        [Then(@"I select the medical condition for additional driver one as ""(.*)""")]
        public void ThenISelectTheMedicalConditionForAdditionalDriverOneAs(string MedicalCondition1)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MedicalCondition1(MedicalCondition1))).Click();
        }

        [Then(@"I select the medical condition for additional driver two as ""(.*)""")]
        public void ThenISelectTheMedicalConditionForAdditionalDriverTwoAs(string MedicalCondition2)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MedicalCondition2(MedicalCondition2))).Click();
        }

        [Then(@"I select the medical condition for additional driver three as ""(.*)""")]
        public void ThenISelectTheMedicalConditionForAdditionalDriverThreeAs(string MedicalCondition3)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MedicalCondition3(MedicalCondition3))).Click();
        }
        //Additional Driver Convictions

        [Then(@"I select No to is this conviction for additional driver one still pending")]
        public void ThenISelectNoToIsThisConvictionForAdditionalDriverOneStillPending()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoToBannedFromDrivingAdditionalOne())).Click();
            Thread.Sleep(2000);
        }

        [Then(@"I enter the date of the conviction for additional driver one as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenIEnterTheDateOfTheConvictionForAdditionalDriverOneAs(string AddOneDayofConviction, string AddOneMonthofConviction, string AddOneYearofConviction)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DayofConvictionAddOne())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MonthofConvictionAddOne())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearofConvictionAddOne())).Click();
        }

        [Then(@"I select the type of conviction for additional driver one as ""(.*)""")]
        public void ThenISelectTheTypeOfConvictionForAdditionalDriverOneAs(string AddOneConviction)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneConviction(AddOneConviction))).Click();
        }

        [Then(@"I enter tne amount of penalty points for additional driver one as ""(.*)""")]
        public void ThenIEnterTneAmountOfPenaltyPointsForAdditionalDriverOneAs(string AddOnePenaltyPoints)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOnePenaltyPoints(AddOnePenaltyPoints))).Click();
        }

        [Then(@"I enter the amount of the fine for additional driver one as ""(.*)""")]
        public void ThenIEnterTheAmountOfTheFineForAdditionalDriverOneAs(string AddOneFine)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneFine())).SendKeys(AddOneFine);
        }

        [Then(@"I select No for the were you banned from driving question for additional driver one")]
        public void ThenISelectNoForTheWereYouBannedFromDrivingQuestionForAdditionalDriverOne()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NoToBannedFromDrivingAddOne())).Click();
        }
        //No Registration

        [Then(@"I select that my car is not imported")]
        public void ThenISelectThatMyCarIsNotImported()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.NotImported())).Click();
        }
        [When(@"I select the Add vehicle registration button")]
        public void WhenISelectTheAddVehicleRegistrationButton()
        {
            WaitForElementToBeClickable(xpath_Directory.AddVehicleRegistration());
        }
        [Then(@"the About Your Car page is displayed")]
        public void ThenTheAboutYourCarPageIsDisplayed()
        {
            var ConfirmationPageHeaderText = CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AboutYourCarPage()));
            FindText(xpath_Directory.AboutYourCarPage(), "About your car");
            Thread.Sleep(3000);
        }

        //Additional Driver Claims

        [Then(@"I enter the date of the claim for additional driver one as ""(.*)"" ""(.*)"" ""(.*)""")]
        public void ThenIEnterTheDateOfTheClaimForAdditionalDriverOneAs(string AddOneDayofClaim, string AddOneMonthofClaim, string AddOneYearofClaim)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.DayofClaimAddOne())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.MonthofClaimAddOne())).Click();
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.YearofClaimAddOne())).Click();
        }
        [Then(@"I select the type of incident for additional driver one as ""(.*)""")]
        public void ThenISelectTheTypeOfIncidentForAdditionalDriverOneAs(string AddOneClaim)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneClaim(AddOneClaim))).Click();
        }
        [Then(@"I enter the cost of the claim for additional driver one as ""(.*)""")]
        public void ThenIEnterTheCostOfTheClaimForAdditionalDriverOneAs(string AddOneCost)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneCost())).SendKeys(AddOneCost);
        }
        [Then(@"I select the fault for additional driver one as ""(.*)""")]
        public void ThenISelectTheFaultForAdditionalDriverOneAs(string AddOneFaultType)
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddOneFaultType(AddOneFaultType))).Click();
        }
        [When(@"I select the Add button to add the claim for additional driver one")]
        public void WhenISelectTheAddButtonToAddTheClaimForAdditionalDriverOne()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.AddClaimAddOne())).Click();
            Thread.Sleep(1500);
        }
        //Marketing Preferences

        [When(@"I select to request postal docs")]
        public void WhenISelectToRequestPostalDocs()
        {
            CommonComponents.driver.FindElement(By.XPath(xpath_Directory.PostalDocs())).Click();
            Thread.Sleep(1500);
        }

        //Logging stubs
        public Boolean WaitForElementToShow(string ElementToShow)
        {
            Boolean elementShown=false;
            try
            {
                elementShown = CommonComponents.driver.FindElement(By.XPath(ElementToShow)).Displayed;
            }
            catch (Exception e)
            {
                Thread.Sleep(1000);
                WaitForElementToShow(ElementToShow);
            }
            return elementShown;
        }
        public void WaitForElementToBeClickable(string ElementToBeClickable)
        {
            try
            {
                Boolean elementShown = CommonComponents.driver.FindElement(By.XPath(ElementToBeClickable)).Displayed;
                CommonComponents.driver.FindElement(By.XPath(ElementToBeClickable)).Click();
            }
            catch (Exception e)
            {
                Thread.Sleep(1000);
                WaitForElementToBeClickable(ElementToBeClickable);
            }
            return;
        }


        [Given(@"I am testing ""(.*)""")]
        public void GivenIAmTesting(string p0)
        {
            CommonComponents._nameoftest = p0;
        }
        [Then(@"the test window should close")]
        public void ThenTheTestWindowShouldClose()
        {
            CommonComponents.driver.Quit();
        }


        [Then(@"the test should populate the users details to the log")]
        public void ThenTheTestShouldPopulateTheUsersDetailsToTheLog()
        {
            CommonComponents.logwriter();
        }
    }
}

public class Page
{
}



