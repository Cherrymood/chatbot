﻿class Program
        {
            static void Main(string[] args)
            {
                string apiKey = "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";
                var chatGPTClient = new ChatGPTClient(apiKey);

                Console.WriteLine("Welcome to the ChatGPT chatbot! Type 'exit' to quit.");
            }
        }