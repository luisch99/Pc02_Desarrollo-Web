namespace practica2
{
    public class Customer
    {
        public int Id { get; set; }

       
        public string FullName { get; set; }

       
        public String Email { get; set; }

        public String Country { get; set; }

        public int Phone { get; set; }


        public Customer()
        {

        }
        public Customer(int Id,string FullName, string Email, String Country, int Phone)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Email = Email;
            this.Country = Country;
            this.Phone = Phone;

        }
    }

  
}
