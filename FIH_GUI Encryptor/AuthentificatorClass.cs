using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace FIH_GUI_Encryptor
{
    internal class Authentificator
    {
        private static readonly HttpClient HttpClient;
        private static readonly string gistId = @"7aaee48c3ced0fc2b5bf4ba64920aa18";
        private static readonly string accessToken = @"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";

        static Authentificator()
        {
            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Add("User-Agent", "FIH_GUI Encryptor");
        }

        public class User
        {
            public int Index { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

            public class Account
            {
                static public string Save(List<User> users)
                {
                    string json = string.Empty;
                    try
                    {
                        // Transform the accounts to the desired structure
                        var transformedAccounts = users.Select(user => new Dictionary<string, object>
                        {
                            { user.Index.ToString(), new { user.Username, user.Password, user.Email } }
                        });

                        // Serialize the transformed accounts to JSON
                        json = JsonSerializer.Serialize(transformedAccounts, new JsonSerializerOptions { WriteIndented = true });

                        Console.WriteLine($"Succesfully converted to json");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error converting accounts to JSON: {ex.Message}");
                    }
                    return json;
                }

                static public List<User> Get(string json)
                {
                    // Deserialize the JSON into a list of dictionaries
                    var array = JsonSerializer.Deserialize<List<Dictionary<string, Dictionary<string, string>>>>(json);

                    // Convert the dictionaries back to a list of accounts
                    var users = array.SelectMany(dict =>
                    {
                        return dict.Select(entry =>
                        {
                            var index = int.Parse(entry.Key);
                            var accountDetails = entry.Value;

                            return new User
                            {
                                Index = index,
                                Username = accountDetails["Username"],
                                Password = accountDetails["Password"],
                                Email = accountDetails["Email"]
                            };
                        });
                    }).ToList();

                    return users ?? new List<User>();
                }
            
                static public List<User> Remove(List<User> users, string username)
                {
                    // Find the account with the specified index and remove it
                    User accountToRemove = users.FirstOrDefault(user => user.Username == username);
                    if (accountToRemove != null)
                    {
                        users.Remove(accountToRemove);
                        Console.WriteLine($"Account with username {username} removed.");
                    }
                    else
                    {
                        Console.WriteLine($"Account with username {username} not found.");
                    }
                    return users;
                }
            }

            public User()
            {
                Index = -1;
                Username = string.Empty;
                Password = string.Empty;
                Email = string.Empty;
            }

            public User(int index, string username, string password, string email)
            {
                Index = index;
                Username = username;
                Password = password;
                Email = email;
            }
        }

        class Gist
        {
            public static async Task<string> Read()
            {
                string apiUrl = $"https://api.github.com/gists/{gistId}";

                HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("token", accessToken);

                HttpResponseMessage response = await HttpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // Parse the JSON using System.Text.Json.JsonSerializer
                    JsonDocument doc = JsonDocument.Parse(jsonContent);

                    // Access the properties in a more type-safe manner
                    JsonElement root = doc.RootElement;
                    JsonElement filesElement = root.GetProperty("files");
                    JsonElement accountsFileElement = filesElement.GetProperty("Accounts.txt");
                    string content = accountsFileElement.GetProperty("content").GetString();

                    return content;
                }
                else
                {
                    ConsoleLog.WriteLine("Authentificator-Gist-Read", $"Error reading Gist. Status Code: {response.StatusCode}");
                    Console.WriteLine("Authentificator-Gist-Read", $"More information: {await response.Content.ReadAsStringAsync()}");
                    throw new HttpRequestException($"Error reading the database. Status Code: {response.StatusCode}");
                }
            }

            private static async Task<string> GetContent()
            {
                string apiUrl = $"https://api.github.com/gists/{gistId}";

                HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("token", accessToken);

                HttpResponseMessage response = await HttpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // Parse the JSON using System.Text.Json.JsonSerializer
                    JsonDocument doc = JsonDocument.Parse(jsonContent);

                    // Access the properties in a more type-safe manner
                    JsonElement root = doc.RootElement;
                    JsonElement filesElement = root.GetProperty("files");
                    JsonElement accountsFileElement = filesElement.GetProperty("Accounts.txt");
                    string content = accountsFileElement.GetProperty("content").GetString();

                    return content;
                }
                else
                {
                    ConsoleLog.WriteLine("Authentificator-Gist-GetContent", $"Error fetching Gist details. Status Code: {response.StatusCode}");
                    Console.WriteLine("Authentificator-Gist-GetContent", $"More information: {await response.Content.ReadAsStringAsync()}");
                    throw new HttpRequestException($"Error fetching database details. Status Code: {response.StatusCode}");
                }
            }

            public static async Task Update(string newContent, bool overWrite = false)
            {
                string apiUrl = $"https://api.github.com/gists/{gistId}";

                string combinedContent = string.Empty;
                if (overWrite == false)
                {
                    string existingContent = await GetContent();
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
                                "Accounts.txt", new Dictionary<string, object>
                                {
                                    { "content", combinedContent }
                                }
                            }
                        }
                    }
                };

                string jsonPayload = System.Text.Json.JsonSerializer.Serialize(payload);

                HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("token", accessToken);

                HttpContent content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await HttpClient.PatchAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    ConsoleLog.WriteLine("Authentificator-Gist-Update", "Database updated successfully!");
                }
                else
                {
                    ConsoleLog.WriteLine("Authentificator-Gist-Update", $"Error whilst updating Gist. Status Code: {response.StatusCode}");
                    ConsoleLog.WriteLine("Authentificator-Gist-Update", $"More information: {await response.Content.ReadAsStringAsync()}");
                    throw new HttpRequestException($"Error whilst updating the database. Status Code: {response.StatusCode}");
                }
            }
        }

        public static async Task<List<User>> FetchUsers()
        {
            string raw_data = await Gist.Read();
            return User.Account.Get(raw_data) ?? new List<User>();
        }
        
        public static async Task UpdateUsers(List<User> users, bool overwrite = false)
        {
            string content = User.Account.Save(users);
            await Gist.Update(content, overwrite);
        }

        // Maybe implement both User user as paramter for more flexibility.
        public static async Task DeleteUser(string username)
        {
            await UpdateUsers(User.Account.Remove(await FetchUsers(), username));
        }
    }
}
