using System.Threading.Tasks;
using chatbot.berger.ChatBot.Application.Interfaces;
using chatbot.berger.ChatBot.Domain.Interfaces;

namespace chatbot.berger.ChatBot.Application
{
    public class NlpApplication : INlpApplication
    {
        private readonly INlpService _nlpService;
        public NlpApplication(INlpService nlpService)
        {
            _nlpService = nlpService;
        }
        public async Task<string> ProcessText(string text)
        {
            return await _nlpService.ProcessText(text);
        }
    }
}