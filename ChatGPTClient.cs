using System;
using RrestSharp;
using Json;


public class ChatGPTClient
{
    private readonly string _apiKey;
    private readonly RestClient _client;

    public ChatGPTClient(string apiKey)
    {
        _apiKey = apiKey;
        _client = new RestClient ("https://api.openai.com/v1/engines/text-davinci-003/completions");
    }

}
