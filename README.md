# Weight Plate Calculator
Helps gym bros that are bad at math figure out what weights to put on a bar

[Api Endpoint](https://weightplatecalculatorapi-app.mangomushroom-796580ca.eastus2.azurecontainerapps.io/WeightPlateCalculator)

## Usage

The API is a simple POST request that takes a JSON body with the following fields:

### Sample request body
```javascript
{
    "barWeight": 45,
    "weightUnit": 0,
    "targetWeight": 315,
    "inventory": {
        "inventory": {
            "PlatePairs_55": 0,
            "PlatePairs_45": 2,
            "PlatePairs_35": 1,
            "PlatePairs_25": 3,
            "PlatePairs_15": 1,
            "PlatePairs_10": 2,
            "PlatePairs_5": 2,
            "PlatePairs_2_5": 4
        }
    }
}
```

### HTTP
```http
POST /WeightPlateCalculator HTTP/1.1
Host: weightplatecalculatorapi-app.mangomushroom-796580ca.eastus2.azurecontainerapps.io
Content-Type: application/json
Content-Length: 399

{
    "barWeight": 45,
    "weightUnit": 0,
    "targetWeight": 315,
    "inventory": {
        "inventory": {
            "PlatePairs_55": 0,
            "PlatePairs_45": 2,
            "PlatePairs_35": 1,
            "PlatePairs_25": 3,
            "PlatePairs_15": 1,
            "PlatePairs_10": 2,
            "PlatePairs_5": 2,
            "PlatePairs_2_5": 4
        }
    }
}
```

### curl
```bash
curl --location 'https://weightplatecalculatorapi-app.mangomushroom-796580ca.eastus2.azurecontainerapps.io/WeightPlateCalculator' \
--header 'Content-Type: application/json' \
--data '{
    "barWeight": 45,
    "weightUnit": 0,
    "targetWeight": 315,
    "inventory": {
        "inventory": {
            "PlatePairs_55": 0,
            "PlatePairs_45": 2,
            "PlatePairs_35": 1,
            "PlatePairs_25": 3,
            "PlatePairs_15": 1,
            "PlatePairs_10": 2,
            "PlatePairs_5": 2,
            "PlatePairs_2_5": 4
        }
    }
}'
```

### C#
```csharp
var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Post, "https://weightplatecalculatorapi-app.mangomushroom-796580ca.eastus2.azurecontainerapps.io/WeightPlateCalculator");
var content = new StringContent("{\"barWeight\":45,\"weightUnit\":0,\"targetWeight\":315,\"inventory\":{\"inventory\":{\"PlatePairs_55\":0,\"PlatePairs_45\":2,\"PlatePairs_35\":1,\"PlatePairs_25\":3,\"PlatePairs_15\":1,\"PlatePairs_10\":2,\"PlatePairs_5\":2,\"PlatePairs_2_5\":4}}}", null, "application/json");
request.Content = content;
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
```

## Response

Using the sample above with the given inventory, the response will be a JSON object with the following fields:


```json
{
    "PlatePairs_45": 2,
    "PlatePairs_35": 1,
    "PlatePairs_10": 1
}
```