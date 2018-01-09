namespace FamilyBusiness.MVC.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string Pesel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthCountry { get; set; }
        public string BirthCity { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string Company { get; set; }//todo: more data for company
        public string ExaminatedPosition { get; set; }
    }
}