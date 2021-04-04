using System.Threading.Tasks;
using Grpc.Core;
using Proto;

namespace Grpc.PricingService
{
    public class PricingService : Pricing.PricingBase
    {
        public override Task<CalculatePricingResponse> CalculateTotalPriceOfBasket(CalculatePricingCommand request, ServerCallContext context)
        {
            return Task.FromResult(new CalculatePricingResponse
            {
                TotalPrice = request.Quantity * request.UnitPrice
            });
        }
    }

}