using System.Text;

namespace AbiDemoBlazor.Helper
{
    internal static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PostAsync(this HttpClient client, string requestUri, string jsonString)
        {
            return client.PostAsync(requestUri, new StringContent(jsonString, Encoding.UTF8, "application/json"));
        }
    }
}
