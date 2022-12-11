using NobelPrize;
using System.Text.Json;

var prizesJson = File.ReadAllText("prizes.json");
var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var prizes = JsonSerializer.Deserialize<Prize[]>(prizesJson, options);
