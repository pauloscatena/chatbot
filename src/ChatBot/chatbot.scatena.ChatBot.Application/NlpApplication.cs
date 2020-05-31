using System.Threading.Tasks;
using chatbot.scatena.ChatBot.Application.Interfaces;
using chatbot.scatena.ChatBot.Domain.Interfaces;

namespace chatbot.scatena.ChatBot.Application
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