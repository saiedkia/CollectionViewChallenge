using System.Collections.Generic;

namespace CollectionViewChallenge.Models
{
    public class MerchantCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Merchant> Merchants { get; set; }
    }
}
