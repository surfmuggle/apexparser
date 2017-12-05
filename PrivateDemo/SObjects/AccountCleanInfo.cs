namespace PrivateDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class AccountCleanInfo : SObject
	{
		public bool IsDeleted {set;get;}

		public string Name {set;get;}

		public DateTime CreatedDate {set;get;}

		public string CreatedById {set;get;}

		public User CreatedBy {set;get;}

		public DateTime LastModifiedDate {set;get;}

		public string LastModifiedById {set;get;}

		public User LastModifiedBy {set;get;}

		public DateTime SystemModstamp {set;get;}

		public string AccountId {set;get;}

		public Account Account {set;get;}

		public DateTime LastMatchedDate {set;get;}

		public DateTime LastStatusChangedDate {set;get;}

		public string LastStatusChangedById {set;get;}

		public User LastStatusChangedBy {set;get;}

		public bool IsInactive {set;get;}

		public string CompanyName {set;get;}

		public string Phone {set;get;}

		public string Street {set;get;}

		public string City {set;get;}

		public string State {set;get;}

		public string PostalCode {set;get;}

		public string Country {set;get;}

		public double Latitude {set;get;}

		public double Longitude {set;get;}

		public string GeocodeAccuracy {set;get;}

		public Address Address {set;get;}

		public string Website {set;get;}

		public string TickerSymbol {set;get;}

		public double AnnualRevenue {set;get;}

		public int NumberOfEmployees {set;get;}

		public string Industry {set;get;}

		public string Ownership {set;get;}

		public string DunsNumber {set;get;}

		public string Sic {set;get;}

		public string SicDescription {set;get;}

		public string NaicsCode {set;get;}

		public string NaicsDescription {set;get;}

		public string YearStarted {set;get;}

		public string Fax {set;get;}

		public string AccountSite {set;get;}

		public string Description {set;get;}

		public string Tradestyle {set;get;}

		public string DandBCompanyDunsNumber {set;get;}

		public string DunsRightMatchGrade {set;get;}

		public int DunsRightMatchConfidence {set;get;}

		public string CompanyStatusDataDotCom {set;get;}

		public bool IsReviewedCompanyName {set;get;}

		public bool IsReviewedPhone {set;get;}

		public bool IsReviewedAddress {set;get;}

		public bool IsReviewedWebsite {set;get;}

		public bool IsReviewedTickerSymbol {set;get;}

		public bool IsReviewedAnnualRevenue {set;get;}

		public bool IsReviewedNumberOfEmployees {set;get;}

		public bool IsReviewedIndustry {set;get;}

		public bool IsReviewedOwnership {set;get;}

		public bool IsReviewedDunsNumber {set;get;}

		public bool IsReviewedSic {set;get;}

		public bool IsReviewedSicDescription {set;get;}

		public bool IsReviewedNaicsCode {set;get;}

		public bool IsReviewedNaicsDescription {set;get;}

		public bool IsReviewedYearStarted {set;get;}

		public bool IsReviewedFax {set;get;}

		public bool IsReviewedAccountSite {set;get;}

		public bool IsReviewedDescription {set;get;}

		public bool IsReviewedTradestyle {set;get;}

		public bool IsReviewedDandBCompanyDunsNumber {set;get;}

		public bool IsDifferentCompanyName {set;get;}

		public bool IsDifferentPhone {set;get;}

		public bool IsDifferentStreet {set;get;}

		public bool IsDifferentCity {set;get;}

		public bool IsDifferentState {set;get;}

		public bool IsDifferentPostalCode {set;get;}

		public bool IsDifferentCountry {set;get;}

		public bool IsDifferentWebsite {set;get;}

		public bool IsDifferentTickerSymbol {set;get;}

		public bool IsDifferentAnnualRevenue {set;get;}

		public bool IsDifferentNumberOfEmployees {set;get;}

		public bool IsDifferentIndustry {set;get;}

		public bool IsDifferentOwnership {set;get;}

		public bool IsDifferentDunsNumber {set;get;}

		public bool IsDifferentSic {set;get;}

		public bool IsDifferentSicDescription {set;get;}

		public bool IsDifferentNaicsCode {set;get;}

		public bool IsDifferentNaicsDescription {set;get;}

		public bool IsDifferentYearStarted {set;get;}

		public bool IsDifferentFax {set;get;}

		public bool IsDifferentAccountSite {set;get;}

		public bool IsDifferentDescription {set;get;}

		public bool IsDifferentTradestyle {set;get;}

		public bool IsDifferentDandBCompanyDunsNumber {set;get;}

		public bool IsDifferentStateCode {set;get;}

		public bool IsDifferentCountryCode {set;get;}

		public bool CleanedByJob {set;get;}

		public bool CleanedByUser {set;get;}

		public bool IsFlaggedWrongCompanyName {set;get;}

		public bool IsFlaggedWrongPhone {set;get;}

		public bool IsFlaggedWrongAddress {set;get;}

		public bool IsFlaggedWrongWebsite {set;get;}

		public bool IsFlaggedWrongTickerSymbol {set;get;}

		public bool IsFlaggedWrongAnnualRevenue {set;get;}

		public bool IsFlaggedWrongNumberOfEmployees {set;get;}

		public bool IsFlaggedWrongIndustry {set;get;}

		public bool IsFlaggedWrongOwnership {set;get;}

		public bool IsFlaggedWrongDunsNumber {set;get;}

		public bool IsFlaggedWrongSic {set;get;}

		public bool IsFlaggedWrongSicDescription {set;get;}

		public bool IsFlaggedWrongNaicsCode {set;get;}

		public bool IsFlaggedWrongNaicsDescription {set;get;}

		public bool IsFlaggedWrongYearStarted {set;get;}

		public bool IsFlaggedWrongFax {set;get;}

		public bool IsFlaggedWrongAccountSite {set;get;}

		public bool IsFlaggedWrongDescription {set;get;}

		public bool IsFlaggedWrongTradestyle {set;get;}

		public string DataDotComId {set;get;}
	}
}
