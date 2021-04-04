using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace Grpc.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:310");

            var client = new Proto.Pricing.PricingClient(channel);

            var command = new Proto.CalculatePricingCommand();
            command.UnitPrice = 2000;
            command.Quantity = 3;
            command.ProductName = "Macbook Pro";

            var streamResponse = client.CalculateTotalPriceOfBasket(command);

            Console.WriteLine($"TotalPriceOfBasket: {streamResponse.TotalPrice}");            
        }
 
    }
}
