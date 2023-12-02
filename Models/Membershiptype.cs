namespace tp.Models
{
    public class Membershiptype
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ?SignUpFee { get; set; }
        public int ?DurationInMonth { get; set; }
        public float ? DiscountRate { get; set; }

        public ICollection<Customers> ?Customers { get; set; } // Navigation property

    }
}
