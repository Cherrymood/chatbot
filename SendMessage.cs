public string SendMessage(string message)
{
    var request = new RestRequest("", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddHeader("Authorization", $"Bearer {_apiKey}");

    var requestBody = new
        {
            prompt = message,
            max_tokens = 100,
            n = 1,
            stop = (string?)null,
            temperature = 0.7,
        };
    request.AddJsonBody(JsonConvert.SerializeObject(requestBody));
    var response = _client.Execute(request);
    var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content ?? string.Empty);


}