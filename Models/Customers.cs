namespace tp.Models
{
    public class Customers
    {
        

        public Customers()
        {
           
        }



        public Guid Id { get; set; }

        public string Name { get; set; }
        public Membershiptype? MembershipType { get; set; }


        public ICollection<Movies>? Movies { get; set; } // Navigation property


    }
}
