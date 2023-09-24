public string SendMessage(string message)
        {
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {_apiKey}");
            