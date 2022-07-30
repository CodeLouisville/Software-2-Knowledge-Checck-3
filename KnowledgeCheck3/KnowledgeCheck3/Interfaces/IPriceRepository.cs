using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3.Interfaces
{
    public interface IPriceRepository
    {
        public decimal GetUpToDatePrice(int productId);
    }
}
