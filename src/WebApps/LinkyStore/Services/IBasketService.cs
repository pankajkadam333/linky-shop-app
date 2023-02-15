using LinkyStore.Web.Models;
using System.Threading.Tasks;

namespace LinkyStore.Web.Services;
public interface IBasketService
{
    Task<BasketModel> GetBasket(string userName);
    Task<BasketModel> UpdateBasket(BasketModel model);
    Task CheckoutBasket(BasketCheckoutModel model);
}