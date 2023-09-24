class Program
        {
            static void Main(string[] args)
            {
                string apiKey = "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";
                var chatGPTClient = new ChatGPTClient(apiKey);

                Console.WriteLine("Welcome to the ChatGPT chatbot! Type 'exit' to quit.");
            while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("You: ");
                    Console.ResetColor();
                    string input = Console.ReadLine() ?? string.Empty;

                    if (input.ToLower() == "exit")
                        break;

                    string response = chatGPTClient.SendMessage(input);

                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    Console.Write("Chatbot: ");
                    Console.ResetColor(); 
                    Console.WriteLine(response);
                }
            }
        }