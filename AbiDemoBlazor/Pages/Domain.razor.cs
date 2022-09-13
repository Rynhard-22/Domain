using AbiDemoBlazor.Data;
using AbiDemoBlazor.Helper;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace AbiDemoBlazor.Pages
{
    public partial class Domain
    {
        private string _accessKey = "3mM44UcgD5Tg3q_EX2rgZvswnwE1vS52MygGk";

        private string _secretKey = "SAPN69BnsQqdVToKDPbKd4";
        private string _rootPath { get; } = "https://api.ote-godaddy.com/v1/";

        private string _domain;

        private DomainAvailableResponse _domainAvailableResponse;

        private DomainDto _domainDto = new DomainDto();


        private HttpClient GetBaseHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_rootPath);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = GetAuthenticationHeader();
            return client;
        }

        private AuthenticationHeaderValue GetAuthenticationHeader()
        {
            return new AuthenticationHeaderValue("sso-key", $"{_accessKey}:{_secretKey}");
        }

        private async Task<DomainAvailableResponse> OnSaveClicked()
        {
            _domainDto.Domain = _domain;

            var client = GetBaseHttpClient();
            var response = await client.GetAsync($"domains/available{QueryStringBuilder.RequestObjectToQueryString(_domainDto)}");

            _domainAvailableResponse = await response.Content.ReadAsAsync<DomainAvailableResponse>();

            return _domainAvailableResponse;
        }
    }
}
