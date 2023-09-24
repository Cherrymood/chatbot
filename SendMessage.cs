public string SendMessage(string message)
        {
            var request = new RestRequest("", Method.Post);