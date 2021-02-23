using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApp.Model
{
    public class LoanAppData
    {
        public int Id { get; set; } = 1;
        public string FirstName { get; set; } = "Micah";
        public string MiddleName { get; set; } = "James";
        public string LastName { get; set; } = "Johnson";
        public string SSN { get; set; } = "1234567890";
        public string HomePhone { get; set; } = "4052557470";
        public string WorkPhone { get; set; } = "4055551234";
        public string Email { get; set; } = "micahjj1989@gmail.com";
        public string Password { get; set; } = "password";
        public string MartialStatus { get; set; } = "single";
        public int YearsInSchool { get; set; } = 9;
        public int Dependents { get; set; } = 3;
        public bool CoBorrower { get; set; } = false;
        public string PropertyAddress { get; set; } = "123 main st";
        public string City { get; set; } = "Oklahoma City";
        public string State { get; set; } = "Oklahoma";
        public int ZipCode { get; set; } = 73159;
        public bool RentOrOwn { get; set; } = true;
        public int YearsOwnedOrRented { get; set; } = 24;
        public string MailingAddress { get; set; } = "321 plain st";
        public string MailingCity { get; set; } = "Tulsa";
        public string MailingState { get; set; } = "Oklahoma";
        public int MailingZipCode { get; set; } = 31597;
        public string Employer { get; set; } = "Teleflora";
        public string EmployerAddress { get; set; } = "111 east st";
        public string EmployerCity { get; set; } = "Norman";
        public string EmployerState { get; set; } = "Oklahoma";
        public int EmployerZipCode { get; set; } = 73179;
        public string EmployerWorkPhone { get; set; } = "4055553210";
        public string EmployeePosition { get; set; } = "Web Developer";
        public int YearsAtCurrentPosition { get; set; } = 3;
        public int YearsInIndustry { get; set; } = 5;
        public string PurposeOfLoan { get; set; } = "Purchase";
        public string PurposeOfLoanExplanation { get; set; } = "I need a home";
        public int PurchasePrice { get; set; } = 100000;
        public string PropertyPurpose { get; set; } = "primary home";
        public string AgentName { get; set; } = "Linda L";
        public string AgentPhoneNumber { get; set; } = "5556321111";
        public string LegalDescription { get; set; } = "Big Yellow House";
        public int NumberOfUnits { get; set; } = 1;
        public int YearPurchasedOfProperty { get; set; } = 1999;
        public int OriginalPriceOfProperty { get; set; } = 75000;
        public int CurrentlyOweForProperty { get; set; } = 10000;
        public int PresetValueOfLots { get; set; } = 125000;
        public int CostOfImprovements { get; set; } = 50000;
        public string NewAddressOfConstructionProperty { get; set; } = "369 lil jon ave";
        public string ConstructionCity { get; set; } = "Moore";
        public string ConstructionState { get; set; } = "Oklahoma";
        public int ConstructionZipCode { get; set; } = 73139;
        public string TypeOfMortgage { get; set; } = "FHA";
        public int AgencyCaseNumber { get; set; } = 1111;
        public int LenderCaseNumber { get; set; } = 22222;
        public int LoanAmount { get; set; } = 115000;
        public double InterestRate { get; set; } = 1.3;
        public int LoanTerm { get; set; } = 30;
        public string AmoritizationType { get; set; } = "ARM";
        public string PropertyPurchaseAddress { get; set; } = "123 main st";
        public string PropertyPurchaseCity { get; set; } = "Yukon";
        public string PropertyPurchaseState { get; set; } = "Oklahoma";
        public int YearBuilt { get; set; } = 1992;
        public int PropertyNumberOfUnits { get; set; } = 1;
        public string PropertyLegalDescription { get; set; } = "its green";
        public bool JointStatementOfAssets { get; set; } = false;



    }
}
