namespace NorthWind.Sales.WebApiGateway
{
    public class NorthWindSalesApiClient
    {
        const string CreateOrderEndpoint = "create";
        readonly HttpClient HttpClient;
        public NorthWindSalesApiClient(HttpClient httpClient) =>
        HttpClient = httpClient;

        public async Task<int> CreateOrderAsync(CreateOrderDto order)
        {
            int OrderId = 0;
            var Response = await HttpClient.PostAsJsonAsync(
            CreateOrderEndpoint, order);
            if (Response.IsSuccessStatusCode)
            {
                OrderId =  await Response.Content.ReadFromJsonAsync<int>();
            }
            return OrderId;
        }
    }
}
