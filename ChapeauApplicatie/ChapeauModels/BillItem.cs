namespace ChapeauModels
{
    public class BillItem
    {
        public int BillItemID{ get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Alcohol { get; set; }

        public BillItem() { }

        public BillItem(int billItemID, int quantity, string description, double price, bool alcohol)
        {
            BillItemID = billItemID;
            Quantity = quantity;
            Description = description;
            Price = price;
            Alcohol = alcohol;
        }
    }
}
