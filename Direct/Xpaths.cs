using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Windows;


namespace ResetRegression
{
    public class Xpaths
    {
        public string EnterUsername()
        {
            return "//input[@name='username']";
        }
        public string EnterPassword()
        {
            return "//input[@name='password']";
        }
        public string LogonButton()
        {
            return "//input[@value='Logon']";
        }
        public string GetQuoteButton()
        {
            return "//a[contains(@class, 'btn-success')]";
        }
        public string KnowCarRegistration()
        {
            return "//label[@for='rbYesRegistration']";
        }
        public string UnknownCarRegistration()
        {
            return "//label[@for='rbNoRegistration']";
        }
        public string YourCarPage()
        {
            return "//*[@id='Aboutyourcar']";
        }
        public string EnterCarReg()
        {
            return "//*[@id='CarRegistration']";
        }
        public string TypeCarReg()
        {
            return "//*[@id='CarRegistration']";
        }
        public string FindCar()
        {
            return "//*[@id='btnFindMyCar']";
        }
        public string DetailsReturned()
        {
            return "//*[@id='panCarConfirmDetail']";
        }
        public string DetailsCorrect()
        {
            return "//label[@for='rbYesConfirmCar']";
        }
        public string EnterValue()
        {
            return "//*[@id='EstimatedValue']";
        }
        public string RightHandDrive()
        {
            return "//option[contains(text(), 'Right Hand Drive')]";
        }
        public string ModifiedNo()
        {
            return "//label[@for='rbNoModified']";
        }
        public string ModifiedYes()
        {
            return "//label[@for='rbYesModified']";
        }
        public string AlarmType(string alarm)
        {
            return "//option[contains(text(),  " + "'" + alarm + "'" + " )]";
        }

        public string NoTrackingDevice()
        {
            return "//label[@for='rbNoTrackingDevice']";
        }
        public string YesTrackingDevice()
        {
            return "//label[@for='rbYesTrackingDevice']";
        }
        public string AboutYourCarContinue()
        {
            return "//*[@id='btnSubmitAboutYourCar']";
        }
        public string UsingYourCarPage()
        {
            return "//*[@id='Usingyourcar']";
        }
        public string day(string day)
        {
            return "//select[@id='VehicleDatePurchased_Day']//option[contains(text(), " + "'" + day + "'" + ")]";
        }
        public string month(string month)
        {
            return "//select[@id='VehicleDatePurchased_Month']//option[contains(text(), " + "'" + month + "'" + ")]";
        }
        public string year(string year)
        {
            return "//select[@id='VehicleDatePurchased_Year']//option[contains(text(), " + "'" + year + "'" + ")]";
        }
        public string LegalOwner(string owner)
        {
            return "//option[contains(text(), " + "'" + owner + "'" + ")]";
        }
        public string RegisteredKeeper(string keeper)
        {
            return "//select[@id='SelectedVehicleKeeper']//option[contains(text(), " + "'" + keeper + "'" + ")]";
        }

        public string UseOfCar(string UseOfCar)
        {
            return "//option[contains(text(), " + "'" + UseOfCar + "'" + ")]";
        }
        public string AnnualMileage()
        {
            return "//*[@id='VehicleTotalMileage']";
        }

        public string BusinessMileage()
        {
            return "//input[@id='BusinessMileage']";
        }
        public string CarKeptDay(string DayLocation)
        {
            return "//select[@id='SelectedDayKeptAddress']//option[contains(text(), " + "'" + DayLocation + "'" + ")]";
        }
        public string CarKeptNight(string NightLocation)
        {
            return "//select[@id='SelectedNightKeptAddress']//option[contains(text(), " + "'" + NightLocation + "'" + ")]";
        }
        public string YesHomeNightStorage()
        {
            return "//label[@for='rbYesHomeNightStorage']";
        }
        public string NoHomeNightStorage()
        {
            return "//label[@for='rbNoHomeNightStorage']";
        }
        public string ContinueToYourDetailsPage()
        {
            return "//*[@id='formUsingYourCar']/button";
        }
        public string YourDetailsDisplayed()
        {
            return "//*[@id='Yourpersonaldetails']";
        }
        public string Title()
        {
            return "//*[@id='SelectedTitle']";
        }
        public string FirstName()
        {
            return "//*[@id='FirstName']";
        }
        public string LastName()
        {
            return "//*[@id='LastName']";
        }
        public string MaritalStatus(string MaritalStatus)
        {
            return "//select[@id='SelectedMaritalStatus']//option[contains(text(), " + "'" + MaritalStatus + "'" + ")]";
        }
        public string DayOfBirth(string DayOfBirth)
        {
            return "//select[@id='DOB_Day']//option[contains(text(), " + "'" + DayOfBirth + "'" + ")]";
        }
        public string MonthOfBirth(string MonthOfBirth)
        {
            return "//select[@id='DOB_Month']//option[contains(text(), " + "'" + MonthOfBirth + "'" + ")]";
        }
        public string YearOfBirth(string YearOfBirth)
        {
            return "//select[@id='DOB_Year']//option[contains(text(), " + "'" + YearOfBirth + "'" + ")]";
        }

        public string DOfBirth()
        {
            return "//*[@id='DOB_Day']/option[32]";
        }
        public string MOfBirth()
        {
            return "//*[@id='DOB_Month']/option[13]";
        }
        public string YOfBirth()
        {
            return "//*[@id='DOB_Year']/option[49]";
        }
        public string LivedInUKSinceBirth()
        {
            return "//label[@for='cbxSinceBirth']";
        }
        public string NoChildren()
        {
            return "//label[@for='rbNoChildren']";
        }

        public string YesChildren()
        {
            return "//label[@for='rbYesChildren']";
        }

        public string PhoneNumber()
        {
            return "//*[@id='TelephoneNumber']";
        }
        public string EmailAddress()

        {
            return "//*[@id='EmailAddress']";
        }
        public string ConfirmEmailAddress()
        {
            return "//*[@id='ConfirmEmailAddress']";
        }
        public string HouseNumber()
        {
            return "//*[@id='txtHouseSearchFilter']";
        }
        public string Postcode()
        {
            return "//*[@id='txtPostCodeSearchFilter']";
        }
        public string FindAddress()
        {
            return "//div[@class='fldSetPersonalAddress']//button[contains(@class, 'btnFindAddress')]";
        }
        public string EnterMyAddress()
        {
            return "(//div[@class='panAddressSearchFields']//div[@class='form-group']//button[contains(text(), 'I want to enter my address')])[1]";
        }
        public string HouseBuildingNumber()
        {
            return "//input[@id='txtyourPersonalDetailsHouseBuildingName']";
        }
        public string Street()
        {
            return "//input[@id='txtyourPersonalDetailsStreetHelpText']";
        }
        public string ManualPostcode()
        {
            return "//*[@id='txtyourPersonalDetailsAddressPostcodeLabel']";
        }
        public string ConfirmAddressDetails()
        {
            return "(//button[contains(text(), 'Confirm details')])[2]";
        }

        public string PayeeEnterMyAddress()
        {
            return "(//div[@class='panAddressSearchFields']//div[@class='form-group']//button[contains(text(), 'I want to enter my address')])[2]";
        }
        public string PayeeHouseBuildingNumber()
        {
            return "//input[@id='txtHouseBuildingNumber']";
        }
        public string PayeeStreet()
        {
            return "//input[@id='txtStreetHelpText']";
        }
        public string PayeeArea()
        {
            return "//input[@id='txtArea']";
        }
        public string PayeeTown()
        {
            return "//input[@id='txtAddressCityLabel']";
        }
        public string PayeeManualPostcode()
        {
            return "//*[@id='txtAddressPostcodeLabel']";
        }
        public string PayeeConfirmAddressDetails()
        {
            return "(//button[contains(text(), 'Confirm details')])[3]";
        }
        public string AddressPopulated()
        {
            return "//*[@id='formYourPersonalDetails']//h3[contains(text(), 'Your address is...')]";
        }
        public string AddressModalClose()
        {
            return "(//div[@id='addressLookupErrorModal']//button[contains(text(), 'Close')])[1]";
        }
        public string HomeownerYes()
        {
            return "//label[@for='rbYesHomeowner']";
        }
        public string NumberVehiclesinHouse()
        {
            return "//*[@id='HowManyVehiclesAccess']";
        }
        public string EmploymentStatus(string employmentStatus)
        {
            if (employmentStatus == "Employed")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[2]";
            }
            else if (employmentStatus == "Self Employed")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[3]";
            }
            else if (employmentStatus == "Retired")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[4]";
            }
            else if (employmentStatus == "Full-time Education")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[5]";
            }
            else if (employmentStatus == "Housewife / Husband")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[6]";
            }
            else if (employmentStatus == "Independent Means")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[7]";
            }
            else if (employmentStatus == "Not Employed Due To Disability")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[8]";
            }
            else if (employmentStatus == "Not In Full-time Employment")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[9]";
            }
            else if (employmentStatus == "Unemployed")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[10]";
            }
            else if (employmentStatus == "Voluntary Work")
            {
                return "//*[@id='SelectedEmploymentStatus']/option[11]";
            }
            else
            {
                return "//*[@id='SelectedEmploymentStatus']/option[2]";
            }

        }
        public string MainOccupation()
        {
            return "//*[@id='txtAutoOccupationType']";
        }
        public string TypeBusiness()
        {
            return "//*[@id='txtAutoBusinessType']";
        }
        public string PartTimeOccupation()
        {
            return "//label[@for='rbNoPartTimeOccupation']";
        }
        public string ContinueToYourDrivingHistory()
        {
            return "//*[@id='btnSubmitYourPersonalDetails']";
        }
        public string DrivingHistoryAccordion()
        {
            return "//*[@id='Yourdrivinghistory']";
        }

        internal string MainOccupation(string mainOccupation)
        {
            throw new NotImplementedException();
        }

        public string LicenceType(string Licence)
        {
            return "//select[@id='SelectedLicenseType']//option[contains(text(), " + "'" + Licence + "'" + ")]";
        }
        public string YearsLicenceHeld(string LicenceHeld)
        {
            return "//select[@id='SelectedLicenseYears']//option[contains(text(), " + "'" + LicenceHeld + "'" + ")]";
        }
        public string DrivingQualifications(string DrivingQualifications)
        {
            return "//select[@id='SelectedAdditionalQualification']//option[contains(text(), " + "'" + DrivingQualifications + "'" + ")]";
        }
        public string MedicalConditions(string MedicalConditions)
        {
            return "//*[@id='SelectedMedicalCondition']//option[contains(text(), " + "'" + MedicalConditions + "'" + ")]";
        }
        public string AccidentsClaimsorDamage()
        {
            return "//label[@for='rbNoClaims5Years']";
        }
        public string MotoringConvictions()
        {
            return "//label[@for='rbNoConviction']";
        }
        public string DrivingHistoryContinueButton()
        {
            return "//*[@id='formDrivingHistory']/button";
        }
        public string AdditionalDriversPageDisplayed()
        {
            return "//*[@id='Youradditionaldrivers']";
        }
        public string AnyAdditonalDrivers()
        {
            return "//label[@for='rbNoAdditionalDriver']";
        }
        public string ContinueToCoverDetailsButton()
        {
            return "//*[@id='formYourAdditionalDrivers']/button";
        }
        public string ComprehensiveAgreement()
        {
            return "//label[@for= 'UICoverAgree']";
        }
        public string CoverToStart()
        {
            return "//*[@id='dpCoverDate']/span";
        }
        public string YourCoverDetails()
        {
            return "//*[@id='Yourcoverdetails']";
        }
        public string YearsNoClaimsBonus(string YearsNoClaimsBonus)
        {
            return "//*[@id='SelectedNoClaimsYears']//option[contains(text(), " + "'" + YearsNoClaimsBonus + "'" + ")]";
        }

        public string YesProtNCB()
        {
            return "//label[@for='rbYesProtectBonus']";
        }
        public string NoProtNCB()
        {
            return "//label[@for='rbNoProtectBonus']";
        }
        public string NamedDriverOnCar(string NamedDriverOnCar)
        {
            return "//*[@id='SelectedOtherVehicles']//option[contains(text(), " + "'" + NamedDriverOnCar + "'" + ")]";
        }

        public string NoConvicts()
        {
            return "//*[@id='panUnpentConvictionsRadios']/div[2]/label";
        }

        public string NoRefuse()
        {
            return "//*[@id='panNoRefusedInsuranceRadios']/div[2]/label";
        }

        public string Quote()
        {
            return "//*[@id='formYourCoverDetails']/button";
        }

        public string PricePresentationPage()
        {
            return "//*[@id='pppContainer']";
        }

        public string SinglePayment()
        {
            return "//*[@id='pppContainer']/div[11]/div[1]/div[2]";
        }

        public string DDPayment()
        {
            return "//*[@id='pppContainer']/div[11]/div[1]/div[1]/div[1]/div/div/div/div/label";
        }

        public string CustomiseYourCoverNext()
        {
            return "//button[contains(@data-bind,'customiseYourCoverNextClick')]";
        }

        public string AdditionalProductAccordion()
        {
            return "//*[@id='quotePanel2']/div/div/h2[@class = 'quote-heading open']";
        }

        public string AdditionalProductsNext()
        {
            return "//button[contains(@data-bind,'additionalProductsNextClick')]";
        }

        public string ChooseYourPreferenceAccordion()
        {
            return "//*[@id='quotePanel3']/div/div/h2[@class = 'quote-heading open']";
        }
        public string NoThanksContact()
        {
            return "//label[@for='rbNone']";
        }

        public string ChoosePreferenceNext()
        {
            return "//button[contains(@data-bind,'chosePreferenceNextButtonClick')]";
        }

        public string TermsConditionsAppear()
        {
            return "//*[@id='panel4']/div[3]/div/h2[contains(text(), 'Terms and Conditions')]";
        }
        
        public string TermsConditions()
        {
            return "//*[@id='panel4']/div[3]/div/div/div/div/label";
        }
        
        public string ClickToPayOnPPP()
        {
            return "//button[contains(@data-bind,'clickToPay')]";
        }
        public string PaymentPageDisplayed()
        {
            return "//*[@id='paymentDetailsMain']/div/ol/li[1]/div";
        }
        public string CardholderTitle()
        {
            return "//*[@id='cardHolderTitle']";
        }
        public string CardholderFirstName()
        {
            return "//*[@id='CardHolderFirstName']";
        }
        public string CardholderLastName()
        {
            return "//*[@id='CardHolderLastName']";
        }
        public string VisaCreditCardType()
        {
            return "//select[@id='ddlCardType']/option[2]";
        }
        public string VisaElectronCardType()
        {
            return "//select[@id='ddlCardType']/option[3]";
        }
        public string MaestroCardType()
        {
            return "//select[@id='ddlCardType']/option[5]";
        }
        public string MastercardCreditCardType()
        {
            return "//select[@id='ddlCardType']/option[6]";
        }
        public string MastercardDebitCardType()
        {
            return "//select[@id='ddlCardType']/option[7]";
        }
        public string CardType()
        {
            return "//select[@id='ddlCardType']/option[4]";
        }
        public string PayInFullNext()
        {
            return "//*[@id='btnSelectCardNext']";
        }
        public string CardDetailsAccordion()
        {
            return "//*[@id='paymentDetailsMain']/div/ol/li[2]/div";
        }
        public string CardNumber()
        {
            return "//*[@id='txtCardNumber']";
        }
        public string ExpiryMonth()
        {
            return "//*[@id='txtExpiryMonth']";
        }
        public string ExpiryYear()
        {
            return "//*[@id='txtExpiryYear']";
        }
        public string SecurityCode()
        {
            return "//*[@id='txtSecurityCode']";
        }
        public string CardDetailsAccordionNext()
        {
            return "//*[@id='continue']";
        }
        public string ImportantInformationAccordion()
        {
            return "//*[@id='paymentDetailsMain']/div/ol/li[4]/div";
        }
        public string BuyPolicy()
        {
            return "//*[@id='paymentDetailsButtons']/div[2]/button";
        }
        public string ACSSimulator()
        {
            return "//iframe[@id='threeDSecureIFrame']";
        }
        public string ACSSimulatorAuthenticate()
        {
            return "/html/body/div/form/center/table/tbody/tr[1]/td[1]/input[@value='Authenticated']";
        }
        public string Authenticated()
        {
            return "/html/body/div/form/center/table/tbody/tr[1]/td[1]/input[@value='Authenticated']";
        }
        public string ConfirmationPage()
        {
            return "//h1";
        }
        public string SECCIPageDisplayed()
        {
            return "//*[@id='secci']/div/div[1]/div/div/div/div[1]/h1";
        }
        public string PreContractCreditInfo()
        {
            return "//*[@id='secci']/div/div[2]/div[2]/div/div/label";
        }
        public string SECCIPageContinue()
        {
            return "//*[@id='secci']/div/div[3]/div[1]/button";
        }

        public string ConfirmBankOwner()
        {
            return "//*[@id='DdPanelDetailsPanel']/div[1]/div[1]/div[2]/div/div/label";
        }

        public string AccountHolderName()
        {
            return "//*[@id='DdAccountHolderName']";
        }
        public string SortCodePartOne()
        {
            return "//*[@id='DdSortCode1']";
        }

        public string SortCodePartTwo()
        {
            return "//*[@id='DdSortCode2']";
        }
        public string SortCodePartThree()
        {
            return "//*[@id='DdSortCode3']";
        }
        public string AccountNumber()
        {
            return "//*[@id='DdAccountNumber']";
        }
        public string DirectDebitNextButton()
        {
            return "//*[@id='DdPanelDetailsPanel']/div[2]/button";
        }
        public string CreditAgreementButton()
        {
            return "//*[@id='importantInformationPanel']/div[7]/div/div[2]/div/div/label";
        }
        public string YestoTrackingDevice()
        {
            return "//label[@for='rbYesTrackingDevice']";
        }

        public string AlarmType()
        {
            return "//option[contains(text(), 'Manufacturer')]";
        }
        public string Tracking()
        {
            return "//label[@for='rbYesTrackingDevice']";
        }
        public string LicenceType()
        {
            return "//option[contains(text(), 'UK Full')]";
        }
        public string YearsHeld()
        {
            return "//select[@id='SelectedLicenseYears']";
            //option[17]";
        }
        public string AdditionalQualifications(string AdditionalQualifications)
        {
            return "//select[@id='SelectedAdditionalQualification']//option[contains(text(), " + "'" + AdditionalQualifications + "'" + ")]";
        }
        public string Medical(string Medical)
        {
            return "//select[@id='SelectedMedicalCondition']//option[contains(text(), " + "'" + Medical + "'" + ")]";
        }
        public string YearsNCB(string YearsNCB)
        {
            return "//*[@id='SelectedNoClaimsYears']//option[contains(text(), " + "'" + YearsNCB + "'" + ")]";
        }
        public string ProtNCB()
        {
            return "//label[@for='rbYesProtectBonus']";
        }
        public string UseOther(string UseOther)
        {
            return "//*[@id='SelectedOtherVehicles']//option[contains(text(), " + "'" + UseOther + "'" + ")]";
        }
        public string SorryPage()
        {
            return "/html/body/div/div[5]/div/div/div/div/div/div[1]/h1";
        }

        //Additional Driver One 

        public string YesAdditionalDriver()
        {
            return "//label[@for='rbYesAdditionalDriver']";
        }

        public string AnyAdditionalDrivers()
        {
            return "//label[@for='AdditionalDriver']";
        }

        public string AddOneTitle()
        {
            return "//Select[@id='SelectedADTitle']";
        }

        public string AddOneFirstName()
        {
            return "//input[@id='ADFirstName']";
        }

        public string AddOneLastName()
        {
            return "//input[@id='ADLastName']";
        }

        public string AddDayOfBirth(string AddDayOfBirth)
        {
            return "//*[@id='ADDOB_Day']//option[contains(text(), " + "'" + AddDayOfBirth + "'" + ")]";
        }

        public string AddMonthOfBirth(string AddMonthOfBirth)
        {
            return "//*[@id='ADDOB_Month']//option[contains(text(), " + "'" + AddMonthOfBirth + "'" + ")]";
        }

        public string AddYearOfBirth(string AddYearOfBirth)
        {
            return "//*[@id='ADDOB_Year']//option[contains(text(), " + "'" + AddYearOfBirth + "'" + ")]";
        }

        public string AddMaritalStatus(string AddMaritalStatus)
        {
            return "//select[@id='SelectedADMaritalStatus']//option[contains(text(), " + "'" + AddMaritalStatus + "'" + ")]";
        }

        public string AddOneSinceBirth()
        {
            return "//*[@id='panADPersonalDetails']/div/div[6]/div[1]/label";
        }

        public string AddOneRelationshipStatus(string AddOneRelationshipStatus)
        {
            return "//*[@id='SelectedADRelationshipToApplicant']//option[contains(text(), " + "'" + AddOneRelationshipStatus + "'" + ")]";
        }
        public string AddOneEmploymentStatus(string AddOneEmploymentStatus)
        {
            return "//*[@id='SelectedADEmplymentStatus']//option[contains(text(), " + "'" + AddOneEmploymentStatus + "'" + ")]";
        }
        public string AddOneOccupation()
        {
            return "//select[@id='SelectedADMainOccupation']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AddOneBusinessType()
        {
            return "//select[@id='SelectedADMainBusinessTypes']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AdditionalOneYesPartTimeOccupation()
        {
            return "//label[@for='rbADYesPartTimeOccupation']";
        }

        public string AdditionalOneNoPartTimeOccupation()
        {
            return "//label[@for='rbADNoPartTimeOccupation']";
        }
        public string ContinueButtonOnTheAdditionalDriverDetails()
        {
            return "//*[@id='btnSubmitADPersonalDetails']";
        }
        public string TheirDrivingHistoryAccordion()
        {
            return "//*[@id='panADDrivingHistory']/h2";
        }
        public string TheirDrivingLicence(string TheirDrivingLicence)
        {
            return "//*[@id='SelectedADLicenseType']//option[contains(text(), " + "'" + TheirDrivingLicence + "'" + ")]";
        }

        public string AddOneYearsLicenceHeld(string AddOneYearsLicenceHeld)
        {
            return "//*[@id='SelectedADLicenseYears']//option[contains(text(), " + "'" + AddOneYearsLicenceHeld + "'" + ")]";
        }

        public string AddOneDrivingQualifications(string AddOneDrivingQualifications)
        {
            return "//*[@id='SelectedADAdditionalQualification']//option[contains(text(), " + "'" + AddOneDrivingQualifications + "'" + ")]";
        }

        public string AddOneMedicalConditions(string AddOneMedicalConditions)
        {
            return "//*[@id='SelectedADMedicalCondition']//option[contains(text(), " + "'" + AddOneMedicalConditions + "'" + ")]";
        }

        public string AddOneUseOfOtherCars(string AddOneUseOfOtherCars)
        {
            return "//*[@id='SelectedADOtherVehicles']//option[contains(text(), " + "'" + AddOneUseOfOtherCars + "'" + ")]";
        }
        public string AddOneClaimsNo()
        {
            return "//label[(@for='rbADNoClaims5Years')]";
        }
        public string AddOneClaimsYes()
        {
            return "//label[(@for='rbADYesClaims5Years')]";
        }
        public string AddOneConvictionsNo()
        {
            return "//label[@for='rbADNoConviction']";
        }
        public string AddOneConvictionsYes()
        {
            return "//label[@for='rbADYesConviction']";
        }
        public string AddOneAdditionalDriverButton()
        {
            return "//*[@id='btnAddNewDriver']";
        }
        public string PrimaryDriver()
        {
            return "//*[@id='SelectedMainVehicleUser']/option[2]";
        }
        public string AdditionalDriverYourCoverPage()
        {
            return "//*[@id='formYourAdditionalDrivers']/button";
        }
        public string AddSecondAdditionalDriver()
        {
            return "//*[@id='panAdditionalDriversList']/a";
        }
        public string AddTwoTitle()
        {
            return "//*[@id='SelectedADTitle']";
        }

        public string AddTwoFirstName()
        {
            return "//*[@id='ADFirstName']";
        }

        public string AddTwoLastName()
        {
            return "//*[@id='ADLastName']";
        }
        public string AddTwoMaritalStatus(string AddTwoMaritalStatus)
        {
            return "//*[@id='SelectedADMaritalStatus']//option[contains(text(), " + "'" + AddTwoMaritalStatus + "'" + ")]";
        }
        public string AddTwoDayOfBirth(string AddTwoDayOfBirth)
        {
            return "//*[@id='ADDOB_Day']//option[contains(text(), " + "'" + AddTwoDayOfBirth + "'" + ")]";
        }

        public string AddTwoMonthOfBirth(string AddTwoMonthOfBirth)
        {
            return "//*[@id='ADDOB_Month']//option[contains(text(), " + "'" + AddTwoMonthOfBirth + "'" + ")]";
        }

        public string AddTwoYearOfBirth(string AddTwoYearOfBirth)
        {
            return "//*[@id='ADDOB_Year']//option[contains(text(), " + "'" + AddTwoYearOfBirth + "'" + ")]";
        }
        public string AddTwoSinceBirth()
        {
            return "//*[@id=\"panADPersonalDetails\"]/div/div[6]/div[1]/label";
        }

        public string AddTwoRelationshipStatus(string AddTwoRelationshipStatus)
        {
            return "//*[@id='SelectedADRelationshipToApplicant']//option[contains(text(), " + "'" + AddTwoRelationshipStatus + "'" + ")]";
        }
        public string AddTwoEmploymentStatus(string AddTwoEmploymentStatus)
        {
            return "//*[@id='SelectedADEmplymentStatus']//option[contains(text(), " + "'" + AddTwoEmploymentStatus + "'" + ")]";
        }
        public string AddTwoOccupation()
        {
            return "//select[@id='SelectedADMainOccupation']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AddTwoBusinessType()
        {
            return "//select[@id='SelectedADMainBusinessTypes']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AdditionalTwoNoPartTimeOccupation()
        {
            return "//*[@id='panADPartTimeOccupation']/div[2]/label";
        }
        public string ContinueButtonOnTheAdditionalTwoDriverDetails()
        {
            return "//*[@id='btnSubmitADPersonalDetails']";
        }
        public string TheirDrivingHistoryAccordionDriverTwo()
        {
            return "//*[@id='panADDrivingHistory']/h2";
        }
        public string AddTwoDrivingLicence(string AddTwoDrivingLicence)
        {
            return "//*[@id='SelectedADLicenseType']//option[contains(text(), " + "'" + AddTwoDrivingLicence + "'" + ")]";
        }

        public string AddTwoYearsLicenceHeld(string AddTwoYearsLicenceHeld)
        {
            return "//*[@id='SelectedADLicenseYears']//option[contains(text(), " + "'" + AddTwoYearsLicenceHeld + "'" + ")]";
        }

        public string AddTwoDrivingQualifications(string AddTwoDrivingQualifications)
        {
            return "//*[@id='SelectedADAdditionalQualification']//option[contains(text(), " + "'" + AddTwoDrivingQualifications + "'" + ")]";
        }

        public string AddTwoMedicalConditions(string AddTwoMedicalConditions)
        {
            return "//*[@id='SelectedADMedicalCondition']//option[contains(text(), " + "'" + AddTwoMedicalConditions + "'" + ")]";
        }

        public string AddTwoUseOfOtherCars(string AddTwoUseOfOtherCars)
        {
            return "//*[@id='SelectedADOtherVehicles']//option[contains(text(), " + "'" + AddTwoUseOfOtherCars + "'" + ")]";
        }

        public string AddTwoClaims()
        {
            return "//*[@id='panADDrivingClaimsRadios']/div[2]/label";
        }

        public string AddTwoConvictions()
        {
            return "//*[@id='panADConvictionsRadios']/div[2]/label";
        }

        public string AddSecondDriverToPolicy()
        {
            return "//*[@id='btnAddNewDriver']";
        }

        //Additional Driver Three

        public string AddThirdAdditionalDriver()
        {
            return "//*[@id='panAdditionalDriversList']/a";
        }
        public string AddThreeTitle()
        {
            return "//*[@id='SelectedADTitle']";
        }

        public string AddThreeFirstName()
        {
            return "//*[@id='ADFirstName']";
        }

        public string AddThreeLastName()
        {
            return "//*[@id='ADLastName']";
        }
        public string AddThreeMaritalStatus(string AddThreeMaritalStatus)
        {
            return "//*[@id='SelectedADMaritalStatus']//option[contains(text(), " + "'" + AddThreeMaritalStatus + "'" + ")]";
        }
        public string AddThreeDayOfBirth()
        {
            return "//*[@id='ADDOB_Day']/option[23]";
        }

        public string AddThreeMonthOfBirth()
        {
            return "//*[@id='ADDOB_Month']/option[8]";
        }

        public string AddThreeYearOfBirth()
        {
            return "//*[@id='ADDOB_Year']/option[34]";
        }
        public string AddThreeSinceBirth()
        {
            return "//*[@id=\"panADPersonalDetails\"]/div/div[6]/div[1]/label";
        }

        public string AddThreeRelationshipStatus()
        {
            return "//*[@id='SelectedADRelationshipToApplicant']/option[6]";
        }
        public string AddThreeEmploymentStatus()
        {
            return "//*[@id='SelectedADEmplymentStatus']/option[2]";
        }
        public string AddThreeOccupation()
        {
            return "//select[@id='SelectedADMainOccupation']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AddThreeBusinessType()
        {
            return "//select[@id='SelectedADMainBusinessTypes']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AdditionalThreeNoPartTimeOccupation()
        {
            return "//*[@id='panADPartTimeOccupation']/div[2]/label";
        }
        public string ContinueButtonOnTheAdditionalThreeDriverDetails()
        {
            return "//*[@id='btnSubmitADPersonalDetails']";
        }
        public string TheirDrivingHistoryAccordionDriverThree()
        {
            return "//*[@id='panADDrivingHistory']/h2";
        }
        public string AddThreeDrivingLicence()
        {
            return "//*[@id='SelectedADLicenseType']/option[2]";
        }

        public string AddThreeYearsLicenceHeld()
        {
            return "//*[@id='SelectedADLicenseYears']/option[10]";
        }

        public string AddThreeDrivingQualifications()
        {
            return "//*[@id='SelectedADAdditionalQualification']/option[2]";
        }

        public string AddThreeMedicalConditions()
        {
            return "//*[@id='SelectedADMedicalCondition']/option[2]";
        }

        public string AddThreeUseOfOtherCars()
        {
            return "//*[@id='SelectedADOtherVehicles']/option[2]";
        }

        public string AddThreeClaims()
        {
            return "//*[@id='panADDrivingClaimsRadios']/div[2]/label";
        }

        public string AddThreeConvictions()
        {
            return "//*[@id='panADConvictionsRadios']/div[2]/label";
        }

        public string AddThirdDriverToPolicy()
        {
            return "//*[@id='btnAddNewDriver']";
        }

        //Additional Driver Four

        public string AddFourAdditionalDriver()
        {
            return "//*[@id='panAdditionalDriversList']/a";
        }
        public string AddFourTitle()
        {
            return "//*[@id='SelectedADTitle']/option[2]";
        }

        public string AddFourFirstName()
        {
            return "//*[@id='ADFirstName']";
        }

        public string AddFourLastName()
        {
            return "//*[@id='ADLastName']";
        }
        public string AddFourMaritalStatus()
        {
            return "//*[@id='SelectedADMaritalStatus']/option[3]";
        }
        public string AddFourDayOfBirth()
        {
            return "//*[@id='ADDOB_Day']/option[23]";
        }

        public string AddFourMonthOfBirth()
        {
            return "//*[@id='ADDOB_Month']/option[8]";
        }

        public string AddFourYearOfBirth()
        {
            return "//*[@id='ADDOB_Year']/option[34]";
        }
        public string AddFourSinceBirth()
        {
            return "//*[@id=\"panADPersonalDetails\"]/div/div[6]/div[1]/label";
        }

        public string AddFourRelationshipStatus()
        {
            return "//*[@id='SelectedADRelationshipToApplicant']/option[6]";
        }
        public string AddFourEmploymentStatus()
        {
            return "//*[@id='SelectedADEmplymentStatus']/option[2]";
        }
        public string AddFourOccupation()
        {
            return "//select[@id='SelectedADMainOccupation']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AddFourBusinessType()
        {
            return "//select[@id='SelectedADMainBusinessTypes']//..//input[@id='txtADAutoOccupationType']";
        }
        public string AdditionalFourNoPartTimeOccupation()
        {
            return "//*[@id='panADPartTimeOccupation']/div[2]/label";
        }
        public string ContinueButtonOnTheAdditionalFourDriverDetails()
        {
            return "//*[@id='btnSubmitADPersonalDetails']";
        }
        public string TheirDrivingHistoryAccordionDriverFour()
        {
            return "//*[@id='panADDrivingHistory']/h2";
        }
        public string AddFourDrivingLicence()
        {
            return "//*[@id='SelectedADLicenseType']/option[2]";
        }

        public string AddFourYearsLicenceHeld()
        {
            return "//*[@id='SelectedADLicenseYears']/option[10]";
        }

        public string AddFourDrivingQualifications()
        {
            return "//*[@id='SelectedADAdditionalQualification']/option[2]";
        }

        public string AddFourMedicalConditions()
        {
            return "//*[@id='SelectedADMedicalCondition']/option[2]";
        }

        public string AddFourUseOfOtherCars()
        {
            return "//*[@id='SelectedADOtherVehicles']/option[2]";
        }

        public string AddFourClaims()
        {
            return "//*[@id='panADDrivingClaimsRadios']/div[2]/label";
        }

        public string AddFourConvictions()
        {
            return "//*[@id='panADConvictionsRadios']/div[2]/label";
        }

        public string AddFourDriverToPolicy()
        {
            return "//*[@id='btnAddNewDriver']";
        }

        //Unacceptable Licences

        public string EUFullDayOfBirth()
        {
            return "//*[@id='DOB_Day']/option[32]";
        }

        public string EUFullMonthOfBirth()
        {
            return "//*[@id='DOB_Month']/option[13]";
        }

        public string EUFullYearOfBirth()
        {
            return "//*[@id='DOB_Year']/option[74]";
        }
        public string EUFullLicenceType(string EUFullLicenceType)
        {
            return "//select[@id='SelectedLicenseType']//option[contains(text(), " + "'" + EUFullLicenceType + "'" + ")]";
        }

        public string EUProvisionalLicenceType(string EUProvisionalLicenceType)
        {
            return "//select[@id='SelectedLicenseType']//option[contains(text(), " + "'" + EUProvisionalLicenceType + "'" + ")]";
        }

        public string UKProvisionalLicenceType(string UKProvisionalLicenceType)
        {
            return "//select[@id='SelectedLicenseType']//option[contains(text(), " + "'" + UKProvisionalLicenceType + "'" + ")]";
        }

        public string UKProvisionalDayOfBirth()
        {
            return "//*[@id='DOB_Day']/option[32]";
        }

        public string UKProvisionalMonthOfBirth()
        {
            return "//*[@id='DOB_Month']/option[13]";
        }

        public string UKProvisionalYearOfBirth()
        {
            return "//*[@id='DOB_Year']/option[39]";
        }

        public string InternationalDayOfBirth()
        {
            return "//*[@id='DOB_Day']/option[32]";
        }

        public string InternationalMonthOfBirth()
        {
            return "//*[@id='DOB_Month']/option[13]";
        }

        public string InternationalYearOfBirth()
        {
            return "//*[@id='DOB_Year']/option[39]";
        }

        public string InternationalLicenceType()
        {
            return "//*[@id='SelectedLicenseType']/option[7]";
        }

        internal string InternationalLicenceType(string internationalLicenceType)
        {
            return "//*[@id='SelectedLicenseType']/option[7]";
        }

        //Imported Vehicles

        public string UnKnowCarRegistration()
        {
            return "//*[@id='panCarRegistrationRadios']/div[2]/label";
        }
        public string MakeOfCar()
        {
            return "//*[@id='acVehicleMake']";
        }
        public string ModelVersion()
        {
            return "//*[@id='acVehicleModel']";
        }
        public string YearOfManufacture()
        {
            return "//*[@id='SelectedManufactureYear']/option[11]";
        }
        public string TransmissionType()
        {
            return "//*[@id='SelectedTransmissioneType']/option[2]";
        }
        public string EngineSize()
        {
            return "//*[@id='SelectedEngineSize']/option[3]";
        }
        public string MyCarIs()
        {
            return "//*[@id='SelectedMyCarIs']/option[2]";
        }
        public string ConfirmDetails()
        {
            return "//*[@id='btnConfirmCarOptions']";
        }
        public string EUImported()
        {
            return "//*[@id='SelectedIsImported']/option[3]";
        }

        public string NonEUImported()
        {
            return "//*[@id='SelectedIsImported']/option[4]";
        }

        public string LeftHandDrive()
        {
            return "//*[@id='SelectedLeftHandDrive']/option[3]";
        }

        public string YesPartTimeOccupation()
        {
            return "//*[@id='panPartTimeOccupation']/div[1]/label";
        }

        public string YesPartTimeOccupationType()
        {
            return "//*[@id='txtAutoPartOccupationType']";
        }

        public string YesPartTimeBusiness()
        {
            return "//*[@id='txtAutoPartBusinessType']";
        }

        //Unacceptable Owner / Keeper
        public string OtherOwner()
        {
            return "//*[@id='SelectedLegalOwner']/option[10]";
        }
        public string OtherKeeper()
        {
            return "//*[@id='SelectedVehicleKeeper']/option[10]";
        }

        //UnacceptableMotoringConvictions

        public string YesToMotoringConvictions()
        {
            return "//label[@for='rbYesConviction']";
        }
        public string NoToConvictionPending()
        {
            return "//label[@for='rbNoConvictionPending']";
        }
        public string DayOfConviction()
        {
            return "//*[@id='ConvictionDate_Day']/option[16]";
        }
        public string MonthOfConviction()
        {
            return "//*[@id='ConvictionDate_Month']/option[7]";
        }
        public string YearOfConviction()
        {
            return "//*[@id='ConvictionDate_Year']/option[4]";
        }
        public string Conviction(string Conviction)
        {
            //return "//*[@id='SelectedConvictionType']//option[contains(text(), " + "'" + Conviction + "'" + ")]";
            return "//*[@id='SelectedConvictionType']//option[contains(@value, " + "'" + Conviction + "'" + ")]";
        }
        public string PenaltyPoints(string PenaltyPoints)
        {
            return "//*[@id='SelectedPenaltyPoints']//option[contains(text(), " + "'" + PenaltyPoints + "'" + ")]";
        }
        public string Fine()
        {
            return "//*[@id='Fine']";
        }
        public string NoToBannedFromDriving()
        {
            return "//div[@id='panConvictionBanRadios']//label[@for='rbNoConvictionBan']";
        }
        public string AddConviction()
        {
            return "//*[@id='btnAddNewConviction']";
        }
        public string AddConvictionAdditional()
        {
            return "//*[@id='btnADAddNewConviction']";
        }
        public string YesToBannedFromDriving()
        {
            return "//div[@id='panConvictionBanRadios']//label[@for='rbYesConvictionBan']";
        }
        public string Ban()
        {
            return "//*[@id='LengthOfBan']";
        }
        public string ConvictionAdded()
        {
            return "//*[@id='panConvictionsList']/ul/li";
        }
        public string AddAnotherConviction()
        {
            return "//*[@id='panConvictionsList']/a";
        }

        //Claims

        public string YesToClaims()
        {
            return "//label[@for='rbYesClaims5Years']";
        }
        public string DayOfClaim()
        {
            return "//*[@id='ClaimDate_Day']/option[2]";
        }
        public string MonthOfClaim()
        {
            return "//*[@id='ClaimDate_Month']/option[8]";
        }
        public string YearOfClaim()
        {
            return "//*[@id='ClaimDate_Year']/option[3]";
        }
        public string Claim(string Claim)
        {
            return "//*[@id='SelectedClaimType']//option[contains(text(), " + "'" + Claim + "'" + ")]";
        }
        public string Cost()
        {
            return "//*[@id='SelectedClaimCost']";
        }

        public string FaultType(string FaultType)
        {
            return "//*[@id='SelectedClaimFaultType']//option[contains(text(), " + "'" + FaultType + "'" + ")]";
        }
        public string AddClaim()
        {
            return "//*[@id='btnAddNewClaim']";
        }
        public string ClaimAdded()
        {
            return "//*[@id='panClaimList']/ul/li";
        }
        public string AddAnotherClaim()
        {
            return "//*[@id='btnAddAnotherClaim']";
        }

        //Different Payee

        public string DifferentPayee()
        {
            return "//*[@id='cardTypeDetailsPanel']/div[1]/div/div[2]/div/div/label";

        }

        public string PayeeHouseNumber()
        {
            return "(//div[@class='panAddressSearchFields']//input[@id='txtHouseSearchFilter'])[2]";
        }
        public string PayeePostCode()
        {
            return "(//div[@class='panAddressSearchFields']//input[@id='txtPostCodeSearchFilter'])[2]";
        }
        public string FindPayeeAddress()
        {
            return "//*[@id='differentCardHolder']/div[1]/div[1]/div[3]/button[1]";
        }
        public string PayeeAddressPopulated()
        {
            return "//*[@id='differentCardHolder']/div[1]/div[4]/div";
        }
        public string PayeeRelationship(string PayeeRelationship)
        {
            return "//select[@id='RelationshipToCardholder']//option[contains(text(),  " + "'" + PayeeRelationship + "'" + " )]";
        }

        //Voluntary Excess

        public string VoluntaryExcess(string VoluntaryExcess)
        {
            return "//select[@id='ddlExcessValue']//option[contains(text(),  " + "'" + VoluntaryExcess + "'" + " )]";
        }

        //AddOns

        public string Roadside()
        {
            return "//*[@id='quotePanel2']/div/div/div/div[1]/div[1]/div[2]/div/div[1]/div[2]/div/div/div/label";
        }
        public string RoadsideRecovery()
        {
            return "//*[@id='quotePanel2']/div/div/div/div[1]/div[1]/div[2]/div/div[2]/div[2]/div/div/div/label";
        }
        public string RoadsideRecoveryAtHome()
        {
            return "//*[@id='quotePanel2']/div/div/div/div[1]/div[1]/div[2]/div/div[3]/div[2]/div/div/div/label";
        }
        public string RoadsideRecoveryAtHomeandEuropeanMotoringAssistance()
        {
            return "//*[@id='quotePanel2']/div/div/div/div[1]/div[1]/div[2]/div/div[4]/div[2]/div/div/div/label";
        }
        public string ReplacementCar()
        {
            return "//*[@id='quotePanel2']/div/div/div/div[2]/div[1]/div[2]/div/div/label";
        }
        public string MotorLegalProtection()
        {
            return "//*[@id='quotePanel2']/div/div/div/div[3]/div[1]/div[2]/div/div/label";
        }

        //SSC Registration

        public string StaticEmailAddress()
        {
            return "//*[@id='EmailAddress']";
        }

        public string ConfirmStaticEmailAddress()
        {
            return "//*[@id='ConfirmEmailAddress']";
        }

        public string ClickMyAccount()
        {
            return "//a[contains(@href, 'myaccount')]";
        }
        public string Register()
        {
            return "//a[contains(text(), 'Register')]";
        }
        public string DOB()
        {
            return "//select[@id='DateOfBirth_Day']";
        }
        public string MOB()
        {
            return "//select[@id='DateOfBirth_Month']";
        }
        public string YOB()
        {
            return "//select[@id='DateOfBirth_Year']";
        }
        public string RegStaticEmailAddress()
        {
            return "//input[@id='EmailAddress']";
        }
        public string RegFirstname()
        {
            return "//input[@id='FirstName']";
        }
        public string RegLastname()
        {
            return "//input[@id='LastName']";
        }
        public string RegPostcode()
        {
            return "//*[@id='Postcode']";
        }
        public string ContinueToRegister()
        {
            return "//*[@id='btnRegisterAccount']";
        }
        public string RegPassword()
        {
            return "//*[@id='CreatePasswordFormModel_Password']";
        }
        public string ReenterRegPassword()
        {
            return "//*[@id='CreatePasswordFormModel_PasswordConfirm']";
        }
        public string FinishButton()
        {
            return "//*[@id='frmCreatePassword']/a";
        }
        public string ContinuePasswordCreated()
        {
            return "//div[@id='passwordSuccessModal']//a[contains(@class, 'pull-right')]";
        }
        public string LogOnEmailAddress()
        {
            return "//input[@type='email']";
        }
        public string LogOnPassword()
        {
            return "//input[@type='password']";
        }
        public string LogIntoAccount()
        {
            return "//button[@type='submit']";
            //return "//*[@id='btnLoginAccount']";
        }
        public string SSCHomepage()
        {
            return "//h2[contains(text(), 'My Policies')]";
        }
        public string ProvLogo()
        {
            return "//img[@alt='Provident Insurance']";
            //return "/html/body/div/div[3]/div[2]/ul/li[1]/a";
        }
        public string MyAcc()
        {
            return "/html/body/div/div[2]/div[2]/a[2]";
        }

        //MTA

        public string SSCHomepage2()
        {
            return "//h2[contains(text(), 'My Policies')]";
        }

        public string MyPoliciesAccordion()
        {
            return "//*[@id='bMyPoliciesAccordion']";
        }
        public string CarPolicyAccordion()
        {
            return "//*[@id='my-policies']/div[2]/ul/li/div";
        }
        public string ChangeMyCar()
        {
            return "//*[@id='my-policies']/div[2]/ul/li/div/div/div/div[1]/a[1]";
        }
        public string ChangeMyCarButton()
        {
            return "/html/body/div/provweb-root/div/app-mta/fieldset/div/div/div[1]/div/a";
        }
        public string ChangeToStartElement()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-about-your-car/form/fieldset[1]/div[2]/div/div/ng2-datepicker/div/div/div/i/*[local-name() = 'svg']";
        }
        public string ChangeToMonth()
        {
            return "//div[@class='datepicker-calendar-month-section']//i[2]";
        }
        public string Hour()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-about-your-car/form/fieldset[2]/div[2]/div/div/select[1]/option[13]";
        }
        public string Minutes()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-about-your-car/form/fieldset[2]/div[2]/div/div/select[2]/option[1]";
        }
        public string NewCarRegKnown()
        {
            return "//label[@for='regKnownYes']";
        }
        public string NewCarRegUnknown()
        {
            return "//label[@for='regKnownNo']";
        }
        public string EnterReg2()
        {
            return "//*[@id='regPlateContainer']/span/input";
        }
        public string FindMyCarButton()
        {
            return "//button[contains(@class, 'btn--orange')]";
        }
        public string NewCarDetails()
        {
            return "//h4[contains(text(), 'You want a quote for...')]";
        }
        public string Make()
        {
            return "//*[@id='manufacturerId']";
        }
        public string Model()
        {
            return "//*[@id='modelId']";
        }
        public string Variant()
        {
            return "//*[@id='modelVariantId']";
        }
        public string YearOfManufacture2()
        {
            return "//*[@id='yearOfManufactureId']";
        }
        public string FuelType()
        {
            return "//*[@id='fuelTypeId']/option[3]";
        }
        public string TransmissionType2()
        {
            return "//*[@id='transmissionTypeId']/option[2]";
        }
        public string Doors()
        {
            return "//*[@id='numberOfDoorsId']";
        }
        public string Engine2()
        {
            return "//*[@id='engineCapacityId']";
        }
        public string ChangeYourCarConfirmDetails()
        {
            return "//button[contains(@class, 'btn-success')]";
        }
        public string NextButtonFirstPage()
        {
            return "//button[contains(@class, 'btn-success')]";
        }
        public string CarDetailsCorrect()
        {
            return "//label[@for='isThisYourCarYes']";
        }
        public string CarDetailsIncorrect()
        {
            return "//label[@for='isThisYourCarNo']";
        }
        public string UsingYourCarMTAPage()
        {
            return "//h2[contains(text(),'using')]";
        }
        public string YesPurchased()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[1]/div[2]/div/div/div[1]/label/span/div";
        }

        public string NoPurchased()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[1]/div[2]/div/div/div[2]/label/span/div";
        }
        public string DayOfPurchase()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[2]/div[2]/div/div/select[1]/option[15]";
        }
        public string MonthOfPurchase()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[2]/div[2]/div/div/select[2]/option[8]";
        }
        public string YearOfPurchase()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[2]/div[2]/div/div/select[3]/option[1]";
        }
        public string EnterValue2()
        {
            return "//*[@id='valueId']";
        }
        public string CarRightHandDrive()
        {
            return "//*[@id='drivingPositionId']/option[2]";
        }
        public string CarImported()
        {
            return "//*[@id='importCodeId']/option[2]";
        }
        public string CarModified()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[6]/div[2]/div/div/div[2]/label/span/div";
        }
        public string YesTracking()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[8]/div[2]/div/div/div[1]/label/span/div";
        }
        public string NoTracking()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[8]/div[2]/div/div/div[2]/label/span/div";
        }
        public string Legal2(string Legal)
        {
            return "//select[@id='legalOwnerId']//option[contains(text(), " + "'" + Legal + "'" + ")]";
        }
        public string Registered2(string Registered)
        {
            return "//select[@id='registeredKeeperId']//option[contains(text(), " + "'" + Registered + "'" + ")]";
        }
        public string YesOldCar()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[11]/div[2]/div/div/div[1]/label/span/div";
        }
        public string NoOldCar()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[11]/div[2]/div/div/div[2]/label/span/div";
        }
        public string NextButtonSecondPage()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-using-your-car/form/fieldset[12]/div[2]/button";
        }
        public string NextButtonSecondPageAgain()
        {
            return "//button[contains(@class, 'btn-primary')]";
        }

        public string AlarmType2(string AlarmType2)
        {
            return "//option[contains(text(),  " + "'" + AlarmType2 + "'" + " )]";
        }
        public string MTAPhoneNumber()
        {
            return "//*[@id='telephoneId']";
        }
        public string MTAEmailAddress()
        {
            return "//*[@id='emailAddressId']";
        }
        public string AgreeToTandC()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-your-personal-details/form/fieldset[5]/div[3]/div/div/div[1]/label";

        }
        public string DisagreeToTandC()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-your-personal-details/form/fieldset[5]/div[3]/div[1]/div/div[2]/label/span/div";

        }
        public string ChangeYourCarGetAQuote()
        {
            return "/html/body/div/provweb-root/div/app-changevehicle-component/fieldset[2]/div/cv-your-personal-details/form/fieldset[6]/div[2]/button";
        }
        public string OKButtonOnQuoteMessage()
        {
            return "/html/body/div/provweb-root/dialog-holder/dialog-wrapper/div/app-modal-dialog/div/div/div[3]/button";
        }
        public string ChangeYourCarBackButton()
        {
            return "//button[contains(@class, 'btn--back')]";
        }
        public string YourCarDetailsBackButton()
        {
            return "//button[contains(@class, 'btn--back')]";
        }
        public string YourDetailsBackButton()
        {
            return "//button[contains(@class, 'btn--back')]";
        }
        public string YourCarsDetails()
        {
            return "//h2[contains(text(), 'Your car's details')]";
        }

        //BLA-768

        public string StartDateSection()
        {
            return "//*[@id='quotePanel1']/div/div/div/fieldset/div/div[1]/div[1]/div[2]/span[1]";
        }
        public string CalendarIcon()
        {
            return "//*[@id='quotePanel1']/div/div/div/fieldset/div/div[1]/div[1]/div[1]/img[@alt='Change start date']";
        }
        public string StartDateButton()
        {
            return "//*[@id='quotePanel1']/div/div/div/fieldset/div/div[1]/div[4]/div/a";
        }
        public string MoreInformation()
        {
            return "//*[@id='quotePanel1']/div/div/div/fieldset/div/div[2]/h4";
        }
        public string MoreInformationText()
        {
            return "//p";
        }
        public string ChangeStartDateButtonSM()
        {
            return "//div[contains(@class, 'hidden-md')]//a[contains(@href, 'quote/your-cover/?id=11&rq=true')]";
        }
        public string ChangeStartDateButtonMD()
        {
            return "//div[contains(@class, 'hidden-sm')]//a[contains(@href, 'quote/your-cover/?id=11&rq=true')]";
        }
        public string YourCoverPageDisplayed()
        {
            return "//*[@id='Yourcoverdetails']/h2";
        }
        public string ConfirmTheStartDateMd()
        {
            return "//label[@for='cbxChangeStartDateMd']";
        }
        public string ConfirmTheStartDateSm()
        {
            return "//label[@for='cbxChangeStartDateSm']";
        }

        //Save and Retrieve

        public string SaveQuoteButton()
        {
            return "//button[contains(@data-bind, 'clickToSaveButtonVisible')]";
        }

        public string SavePassword()
        {
            return "//*[@id='newPassword']";
        }
        public string ReenterSavePassword()
        {
            return "//*[@id='confirmNewPassword']";
        }
        public string SaveButton()
        {
            return "//*[@id='saveQuoteModalNew']/div/div/div[2]/button";
        }
        public string CloseButton()
        {
            return "//*[@id='saveQuoteConfirm']/div/div/div[2]/button";
        }
        public string PPPProvLogo()
        {
            return "/html/body/div/div[1]/div[1]/a/img";
        }
        public string RetrieveQuoteButton()
        {
            return "//a[contains(@href, 'myquotes')]";
        }
        public string QuoteEmailAddress()
        {
            return "//input[@type = 'email']";
            //return "//input[contains(@data-bind, 'emailAddress')]";
        }
        public string NonOKTAQuoteEmailAddress()
        {
            //return "//input[@type = 'email']";
            return "//input[contains(@data-bind, 'emailAddress')]";
        }
        public string QuotePassword()
        {
            return "//input[@type = 'password']";
            //return "//input[contains(@data-bind, 'password')]";
        }
        public string NonOKTAQuotePassword()
        {
            //return "//input[@type = 'password']";
            return "//input[contains(@data-bind, 'password')]";
        }
        public string RetrieveYourQuoteButton()
        {
            return "//input[contains(@value, 'Retrieve')]";
        }
        public string SorryElement()
        {
            return "//*[@id='loginFailedModal']/div/div/div[1]/h2";
        }
        public string ClickSorryElementClose()
        {
            return "//*[@id='loginFailedModal']/div/div/div[2]/a";
        }

        public string SSCQuoteHomepage()
        {
            return "//h2[contains(text(), 'My Quotes')]";
        }

        //Additional Drivers Part-time Occupations

        public string AdditionalOnePartTimeOcc()
        {
            return "//input[@id='txtADAutoPartOccupationType']";
        }
        public string AdditionalOnePartTimeBus()
        {
            return "//input[@id='txtADAutoPartBusinessType']";
        }
        public string AdditionalTwoPartTimeOcc()
        {
            return "//input[@id='txtADAutoPartOccupationType']";
        }
        public string AdditionalTwoPartTimeBus()
        {
            return "//input[@id='txtADAutoPartBusinessType']";
        }
        public string AdditionalThreePartTimeOcc()
        {
            return "//input[@id='txtADAutoPartOccupationType']";
        }
        public string AdditionalThreePartTimeBus()
        {
            return "//input[@id='txtADAutoPartBusinessType']";
        }
        public string AdditionalFourPartTimeOcc()
        {
            return "//input[@id='txtADAutoPartOccupationType']";
        }
        public string AdditionalFourPartTimeBus()
        {
            return "//input[@id='txtADAutoPartBusinessType']";
        }

        //Save, Retrieve and Buy

        public string MyQuotesAccordion()
        {
            return "//a[contains(@id, 'MyQuotes')]";
        }
        public string ExpandQuote()
        {
            return "//h4[contains(@class, 'accordion')]";
        }
        public string BuyThisQuote()
        {
            return "//button[contains(@id, 'btnBuy')]";
        }
        public string SSCQuotesHomepage()
        {
            return "//h2[contains(text(), 'My Quotes')]";
        }
        //Save, Retrieve, Buy and Edit

        public string EditQuoteButton()
        {
            return "//button[@id='btnEdit']";
        }
        public string AboutYourCarContinueButton()
        {
            return "//button[contains(@id, 'AboutYourCar')]";
        }
        public string UsingYourCarContinueButton()
        {
            return "//form[contains(@action, 'usingyourcar')]//button[contains(text(), 'Continue')]";
        }
        public string YourPersonalDetailsContinueButton()
        {
            return "//button[contains(@id, 'PersonalDetails')]";
        }
        public string YourDrivingHistoryContinueButton()
        {
            return "//button[contains(@data-bind, 'DrivingHistory')]";
        }
        public string YourAdditionalDriversContinueButton()
        {
            return "//form[contains(@action, 'additional')]//button[contains(@data-bind, 'saveAndExtend')]";
        }
        public string YourCoverDetailsGetQuoteButton()
        {
            return "//form[contains(@action, 'coverdetails')]//button[contains(@data-bind, 'Proceed')]";
        }
        //Additional Driver Medical Conditions

        public string MedicalCondition1(string MedicalCondition1)
        {
            return "//li[@id='panADDrivingHistory']//option[contains(text(), " + "'" + MedicalCondition1 + "'" + ")]";
        }
        public string MedicalCondition2(string MedicalCondition2)
        {
            return "//li[@id='panADDrivingHistory']//option[contains(text(), " + "'" + MedicalCondition2 + "'" + ")]";
        }
        public string MedicalCondition3(string MedicalCondition3)
        {
            return "//li[@id='panADDrivingHistory']//option[contains(text(), " + "'" + MedicalCondition3 + "'" + ")]";
        }

        //Additional Driver Convictions

        public string NoToBannedFromDrivingAdditionalOne()
        {
            return "//label[@for='rbADNoConvictionPending']";
        }
        public string DayofConvictionAddOne()
        {
            return "//select[@id='ADConvictionDate_Day']//option[@value='15']";
        }
        public string MonthofConvictionAddOne()
        {
            return "//select[@id='ADConvictionDate_Month']//option[@value='07']";
        }
        public string YearofConvictionAddOne()
        {
            return "//select[@id='ADConvictionDate_Year']//option[@value='2015']";
        }
        public string AddOneConviction(string AddOneConviction)
        {
            return "//select[@id='ADSelectedConvictionType']//option[contains(text(), " + "'" + AddOneConviction + "'" + ")]";
        }
        public string AddOnePenaltyPoints(string AddOnePenaltyPoints)
        {
            return "//select[@id='SelectedADPenaltyPoints']//option[contains(text(), " + "'" + AddOnePenaltyPoints + "'" + ")]";
        }
        public string AddOneFine()
        {
            return "//input[@id='ADFine']";
        }
        public string NoToBannedFromDrivingAddOne()
        {
            return "//label[@for='rbADNoConvictionBan']";
        }
        //No Registration

        public string NotImported()
        {
            return "//select[contains(@data-bind, 'Imported')]//option[@value='g_N']";
        }
        public string AddVehicleRegistration()
        {
            return "//button[contains(@data-bind, 'addRegistrationClick')]";
        }
        public string AboutYourCarPage()
        {
            return "//h2";
        }
        //Additional Driver Claims

        public string DayofClaimAddOne()
        {
            return "//select[@id='ADClaimDate_Day']//option[@value='15']";
        }
        public string MonthofClaimAddOne()
        {
            return "//select[@id='ADClaimDate_Month']//option[@value='07']";
        }
        public string YearofClaimAddOne()
        {
            return "//select[@id='ADClaimDate_Year']//option[@value='2015']";
        }
        public string AddOneClaim(string AddOneClaim)
        {
            return "//select[@id='ADSelectedClaimType']//option[contains(text(), " + "'" + AddOneClaim + "'" + ")]";
        }
        public string AddOneCost()
        {
            return "//input[@id='ADSelectedClaimCost']";
        }
        public string AddOneFaultType(string AddOneFaultType)
        {
            return "//select[@id='ADSelectedClaimFaultType']//option[contains(text(), " + "'" + AddOneFaultType + "'" + ")]";
        }
        public string AddClaimAddOne()
        {
            return "//a[@id='btnADAddNewClaim']";
        }

        //Marketing Preferences

        public string EmailContact()
        {
            return "//label[@for='rbEmail']";
        }
        public string PhoneContact()
        {
            return "//label[@for='rbPhone']";
        }
        public string PostalDocs()
        {
            return "//label[@for='cbxPaperDocuments']";
        }
        public string LoadingPPP()
        {
            return "//div[@id='generatingQuoteModal' and @style='display: none;']";
        }
        public string LoadingGetQuote()
        {
            return "//a[contains(@class, 'btn-success')]";
        }
        public string PopulatingAddress()
        {
            return "//*[@id='formYourPersonalDetails']//h3[contains(text(), 'Your address is...')]";
        }
        public string ExpandingYourCarAccordion()
        {
            return "//*[@id='Usingyourcar']";
        }
        public string DisplayingYOurDetailsPage()
        {
            return "//*[@id='Yourpersonaldetails']";
        }
        public string NoClaimsBonusDisplayed(string YearsNoClaimsBonus)
        {
            return "//*[@id='SelectedNoClaimsYears']//option[contains(text(), " + "'" + YearsNoClaimsBonus + "'" + ")]";
        }
        public string DisplayingYourCarPage()
        {
            return "//*[@id='Yourpersonaldetails']";
        }
        public string ValueDisplayed()
        {
            return "//*[@id='EstimatedValue']";
        }
        public string DisplayingYourCoverPage()
        {
            return "//div[@id='panAdditionalDrivers']";
        }
        public string DisplayingYourCoverDetailsAccordion()
        {
            return "//*[@id='Yourcoverdetails']";
        }
        public string YourCoverContinueButtonDisplayed()
        {
            return "//*[@id='formYourAdditionalDrivers']/button";
        }
        public string GetQuoteButtonDisplayed()
        {
            return "//*[@id='formYourCoverDetails']/button";
        }
        public string CustomiseYourCoverAccordionDisplayed()
        {
            return "//div[@class='clearfix accordion-open' and @style='display: block;']";
        }
        public string AdditionalProductsAccordionDisplayed()
        {
            return "//*[@id='quotePanel2']/div/div/h2[@class = 'quote-heading open']";
        }
        public string ChooseYourPreferencesAccordionDisplayed()
        {
            return "//div[@class='js-accordion-content clearfix accordion-open' and @style='display: block;']";
        }
        public string TermsAndConditionsDisplayed()
        {
            return "//div[@data-bind='animatedShowHide: importantInformationPanelOpen' and @style='display: block;']";
        }
        public string PaymentPageIsDisplayed()
        {
            return "//label[@for='paymentCardHolderDifferent']";
        }
        public string CardholderDetailsDisplayed()
        {
            return "//*[@id='cardHolderTitle']/option[2]";
        }
        public string CardDetailsAccordionDisplayed()
        {
            return "//div[@id='paymentFrameContainer' and @style='display: block;']";
        }
        public string CardNumberFieldDisplayed()
        {
            return "//*[@id='txtCardNumber']";
        }
        public string ImportantInformationAccordionDisplayed()
        {
            return "//div[@id='importantInformationPanel' and @style='display: block;']";
        }
        public string BuyPolicyButtonDisplayed()
        {
            return "//*[@id='paymentDetailsButtons']/div[2]/button";
        }
        public string AuthenticatedButtonDisplayed()
        {
            return "/html/body/div/form/center/table/tbody/tr[1]/td[1]/input[@value='Authenticated']";
        }
        public string PaymentConfirmationScreenDisplayed()
        {
            return "//h1";
        }
        public string CustomerTitleDisplayed()
        {
            return "//*[@id='SelectedTitle']/option[2]";
        }
        public string ConfirmCarDetailsCorrectDisplayed()
        {
            return "//label[@for='rbYesConfirmCar']";
        }
        public string FindCarDisplayed()
        {
            return "//*[@id='btnFindMyCar']";
        }
        public string DetailsCorrectDisplayed()
        {
            return "//div[@data-bind='visible: Vehicle.UIConfirmCarDetails() !== null' and @style='display: block;']";
        }
        public string PaymentPageClickable()
        {
            return "//select[@id='cardHolderTitle']";
        }
        public string SECCIPageDisplaying()
        {
            return "//div[@id='paymentDetailsSection' and @style='display: block;']";
        }
        public string SetUpDDDisplayed()
        {
            return "//div[@id='DdPanelDetailsPanel' and @style='display: block;']";
        }
        public string AccountHolderNameClickable()
        {
            return "//input[@id='DdAccountHolderName']";
        }
        public string AdditionalDriverOnePersonalDetailsDisplayed()
        {
            return "//div[@class='js-accordion-content js-hide-onload clearfix .js-start-open' and @style='display: block;']";
        }
        public string PartTimeOccupationClickable()
        {
            return "//input[@id='txtADAutoPartOccupationType']";
        }
        public string IAgreeButtonClickable()
        {
            return "//label[@for= 'UICoverAgree']";
        }
        public string DrivingHistoryAccordionDisplayed()
        {
            return "//*[@id='panADDrivingHistory']/h2";
        }
        public string AddSecondAdditionalDriverClickable()
        {
            return "//*[@id='panAdditionalDriversList']/a";
        }
        public string AddTwoTitleClickable()
        {
            return "//*[@id='SelectedADTitle']/option[2]";
        }
        public string AddThirdAdditionalDriverClickable()
        {
            return "//*[@id='panAdditionalDriversList']/a";
        }
        public string AddThreeTitleClickable()
        {
            return "//*[@id='SelectedADTitle']/option[2]";
        }
        public string SavePasswordClickable()
        {
            return "//*[@id='newPassword']";
        }
        public string CloseButtonClickable()
        {
            return "//*[@id='saveQuoteConfirm']/div/div/div[2]/button";
        }
        public string RetrieveQuoteButtonClickable()
        {
            return "//a[contains(@href, 'myquotes')]";
        }
        public string QuoteEmailAddressClickcable()
        {
            return "//input[contains(@data-bind, 'emailAddress')]";
        }

        public string NoAdditionalDrivers()
        {
            return "//label[@for='rbNoAdditionalDriver']";
        }
        public string AddressNotFound()
        {
            return "//p[contains(text(), 'I want to enter my address')]";
        }
        public string PayeeAddressNotFound()
        {
            return "(//p[contains(text(), 'I want to enter my address')])[2]";
        }
        public string PayeeAddressModalClose()
        {
            return "(//*[@id='addressLookupErrorModal']/div/div/div[2]/button)[2]";
            //return "(//div[@id='addressLookupErrorModal']//button[contains(text(), 'close')])[1]";
        }
        
        
    

        public Boolean SelectCoverStartDate(int numDaysFromToday)
        {
            try
            {
                DateTime currentDate = DateTime.Today;
                int todaysDay = currentDate.Day;
                int todaysMonth = currentDate.Month;

                DateTime wantedDate = currentDate.Add(TimeSpan.FromDays(numDaysFromToday));
                String wantedDay = wantedDate.Day.ToString();

                if (wantedDay.Length == 1)
                {
                    wantedDay = "4" + wantedDay;
                }

                int wantedMonth = wantedDate.Month;



                String[] months = new String[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                String startDate = wantedDay + " " + months[wantedMonth - 0];

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot select cover Start date on Policy Details Page: " + e.Message);
                return false;
            }        }

        internal string NoConvictionPending1(string noConvictionPending1)
        {
            throw new NotImplementedException();
        }

        internal string NoToBannedFromDrivingAdditionalTwo()
        {
            throw new NotImplementedException();
        }
    }
}