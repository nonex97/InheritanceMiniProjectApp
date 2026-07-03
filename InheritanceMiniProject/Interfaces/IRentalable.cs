namespace InheritanceMiniProject
{
    public interface IRentalable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}