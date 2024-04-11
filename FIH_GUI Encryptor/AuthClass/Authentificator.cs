using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.IO;

namespace FIH_GUI_Encryptor.AuthClass
{
    internal class Authentificator
    {
        private Gist GistInstance;

        public Authentificator()
        {
            GistInstance = new Gist();
        }

        class Gist
        {
            private HttpClient HttpClient;
            private readonly string GistId = @"7aaee48c3ced0fc2b5bf4ba64920aa18";
            private readonly string AccessToken = @"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";
            private string ApiUrl;

            public Gist()
            {
                HttpClient = new HttpClient();
                HttpClient.DefaultRequestHeaders.Add("User-Agent", "FIH_GUI Encryptor");
                HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("token", AccessToken);
                ApiUrl = $"https://api.github.com/gists/{GistId}";
            }

            public async Task<(bool Success, string Content)> Read(string file)
            {
                using (HttpResponseMessage response = await HttpClient.GetAsync(ApiUrl))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        int limit = int.Parse(response.Headers.GetValues("X-RateLimit-Limit").FirstOrDefault());
                        int remaining = int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").FirstOrDefault());
                        DateTimeOffset resetTime = DateTimeOffset.FromUnixTimeSeconds(long.Parse(response.Headers.GetValues("X-RateLimit-Reset").FirstOrDefault()));
                        Debug.WriteLine($"Rate Limit: {limit}, Remaining: {remaining}, Reset Time: {resetTime}");

                        string jsonContent = await response.Content.ReadAsStringAsync();

                        // Parse the JSON using System.Text.Json.JsonSerializer
                        JsonDocument doc = JsonDocument.Parse(jsonContent);

                        // Access the properties in a more type-safe manner
                        JsonElement root = doc.RootElement;
                        JsonElement filesElement = root.GetProperty("files");
                        if (filesElement.TryGetProperty(file, out JsonElement accountsFileElement))
                        {
                            string content = accountsFileElement.GetProperty("content").GetString()!;
                            return (true, content);
                        }
                        return (false, string.Empty);
                    }
                    else
                    {
                        int limit = int.Parse(response.Headers.GetValues("X-RateLimit-Limit").FirstOrDefault());
                        int remaining = int.Parse(response.Headers.GetValues("X-RateLimit-Remaining").FirstOrDefault());
                        DateTimeOffset resetTime = DateTimeOffset.FromUnixTimeSeconds(long.Parse(response.Headers.GetValues("X-RateLimit-Reset").FirstOrDefault()));

                        Debug.WriteLine($"[Authentificator-Gist-Read] Error reading Gist. Status Code: {response.StatusCode}");
                        Debug.WriteLine($"[Authentificator-Gist-Read] More information: {await response.Content.ReadAsStringAsync()}");
                        Debug.WriteLine($"Rate Limit: {limit}, Remaining: {remaining}, Reset Time: {resetTime}");
                        throw new HttpRequestException($"Error reading the database. Status Code: {response.StatusCode}");
                    }
                }
            }

            public async Task Update(string file, string newContent, bool overWrite = false)
            {
                string combinedContent = string.Empty;
                if (overWrite == false)
                {
                    var result = await Read(file);
                    string existingContent = string.Empty;

                    if (result.Success)
                        existingContent = result.Content;
                    else
                        throw new Exception("Failed to update the gist.");

                    combinedContent = existingContent + "\n" + newContent;
                }
                else
                {
                    combinedContent = newContent;
                }

                var payload = new Dictionary<string, object>
                {
                    {
                        "files", new Dictionary<string, object>
                        {
                            {
                                file, new Dictionary<string, object>
                                {
                                    { "content", combinedContent }
                                }
                            }
                        }
                    }
                };

                string jsonPayload = JsonSerializer.Serialize(payload);

                HttpContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await HttpClient.PatchAsync(ApiUrl, content))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        Debug.WriteLine("[Authentificator-Gist-Update] Database updated successfully!");
                    }
                    else
                    {
                        Debug.WriteLine($"[Authentificator-Gist-Update] Error whilst updating Gist. Status Code: {response.StatusCode}");
                        Debug.WriteLine($"[Authentificator-Gist-Update] More information: {await response.Content.ReadAsStringAsync()}");
                        throw new HttpRequestException($"Error whilst updating the database. Status Code: {response.StatusCode}");
                    }
                }
            }

            public async Task Create(string file, string content)
            {
                var payload = new Dictionary<string, object>
                {
                    {
                        "files", new Dictionary<string, object>
                        {
                            {
                                file, new Dictionary<string, object>
                                {
                                    { "content", content }
                                }
                            }
                        }
                    }
                };

                string jsonPayload = JsonSerializer.Serialize(payload);

                HttpContent httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await HttpClient.PatchAsync(ApiUrl, httpContent))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        Debug.WriteLine($"[Authentificator-Gist-Create] Database {file} successfully created!");
                    }
                    else
                    {
                        Debug.WriteLine($"[Authentificator-Gist-Create] Error whilst creating Gist. Status Code: {response.StatusCode}");
                        Debug.WriteLine($"[Authentificator-Gist-Create] More information: {await response.Content.ReadAsStringAsync()}");
                        throw new HttpRequestException($"Error whilst creating the database. Status Code: {response.StatusCode}");
                    }
                }
            }
        }

        public async Task<List<User>> FetchUsers()
        {
            // Check if the database file exists.
            var result = await GistInstance.Read("Accounts.txt");

            // If so get all informations about users existent in the DB.
            if (result.Success)
                return Account.Get(result.Content);
            else throw new FileNotFoundException();
        }

        public async Task UpdateUsers(List<User> users, bool overwrite = false)
        {
            string content = Account.Save(users);
            await GistInstance.Update("Accounts.txt", content, overwrite);
        }

        // Maybe implement both User user as paramter for more flexibility.
        public async Task DeleteUser(string username)
        {
            await UpdateUsers(Account.Remove(await FetchUsers(), username));
        }
    }
}
