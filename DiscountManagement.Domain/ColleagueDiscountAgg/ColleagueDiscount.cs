using _0_Framework.Domain;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
    public class ColleagueDiscount : BaseEntity
    {
        public long ProductId { get; private set; }
        public int DiscountRate { get; private set; }
        public bool IsRemoved { get; private set; }

        public ColleagueDiscount(long productId, int discountRate)
        {
            ProductId = productId;
            DiscountRate = discountRate;
            IsRemoved = true;
        }

        public void Edit(long productId, int discountRate)
        {
            ProductId = productId;
            DiscountRate = discountRate;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void ReStore()
        {
            IsRemoved = false;
        }
    }
}
