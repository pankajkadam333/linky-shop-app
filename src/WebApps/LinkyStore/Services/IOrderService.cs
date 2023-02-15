using LinkyStore.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinkyStore.Web.Services;
public interface IOrderService
{
    Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
}