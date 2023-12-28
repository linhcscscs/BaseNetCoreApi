using Newtonsoft.Json;
using System.Text;

namespace BaseNetCoreApi.Helper
{
    public class APICSDLHelper
    {
        public string qiauth => ConfigurationHelper.QiAuth;
        public virtual string url { get; set; }
        public virtual Dictionary<string, string> header { get; set; }
        public APICSDLHelper()
        {
            header = new Dictionary<string, string>();
            header.Add("authorization", $"{qiauth}");
            if (string.IsNullOrEmpty(url))
            {
                url = ConfigurationHelper.API_CSDL("API_CSDL_URL");
            }
        }
        public virtual async Task<string> getAsync(string path)
        {
            try
            {
                using (HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{url}/{path}"))
                {
                    if (header != null && header.Any())
                    {
                        foreach (var item in header)
                        {
                            req.Headers.Add(item.Key, $"{item.Value}");
                        }
                    }
                    var client = new HttpClient();
                    var response = client.SendAsync(req).Result;

                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
            }
            catch
            {

            }
            return string.Empty;
        }
        public virtual async Task<string> postDataAsync(object data, string path)
        {
            try
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, $"{url}/{path}"))
                {
                    if (header != null && header.Any())
                    {
                        foreach (var item in header)
                        {
                            request.Headers.Add(item.Key, $"{item.Value}");
                        }
                    }
                    if (data != null)
                    {
                        var stringContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                        {
                            request.Content = stringContent;
                        }
                    }
                    var client = new HttpClient();
                    var response = client.SendAsync(request).Result;

                    var responseString = await response.Content.ReadAsStringAsync();
                    return responseString;

                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
        public virtual async Task<string> deleteDataAsync(object data, string path)
        {
            try
            {
                using (var request = new HttpRequestMessage(HttpMethod.Delete, $"{url}/{path}"))
                {
                    if (header != null && header.Any())
                    {
                        foreach (var item in header)
                        {
                            request.Headers.Add(item.Key, $"{item.Value}");
                        }
                    }
                    if (data != null)
                    {
                        var stringContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                        {
                            request.Content = stringContent;
                        }
                    }
                    var client = new HttpClient();
                    var response = await client.SendAsync(request);

                    var responseString = await response.Content.ReadAsStringAsync();
                    return responseString;

                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }

    }
}
