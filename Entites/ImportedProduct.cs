using System.Globalization;
namespace exercise_inheritance_and_polymorphism.Entites
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee})";
        }
    }
}