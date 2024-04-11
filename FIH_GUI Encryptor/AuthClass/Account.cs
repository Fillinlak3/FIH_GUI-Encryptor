using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FIH_GUI_Encryptor.AuthClass
{
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
                            { user.Index.ToString(), new { user.Username, user.Password, user.Email, user.PrivateKey } }
                        });

                // Serialize the transformed accounts to JSON
                json = JsonSerializer.Serialize(transformedAccounts, new JsonSerializerOptions { WriteIndented = true });

                ConsoleLog.WriteLine("Authentificator-Account-Save", "Succesfully converted to JSON.");
            }
            catch (Exception ex)
            {
                ConsoleLog.WriteLine("Authentificator-Account-Save", $"Error converting accounts to JSON: {ex.Message}");
            }
            return json;
        }

        static public List<User> Get(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) return new List<User>();

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
                        Email = accountDetails["Email"],
                        PrivateKey = accountDetails["PrivateKey"]
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
                ConsoleLog.WriteLine("Authentificator-Account-Remove", $"Account with username {username} removed.");
            }
            else
            {
                ConsoleLog.WriteLine("Authentificator-Account-Remove", $"Account with username {username} not found.");
            }
            return users;
        }
    }
}
