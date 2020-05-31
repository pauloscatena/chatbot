using System.Threading.Tasks;

namespace chatbot.scatena.ChatBot.Domain.Interfaces
{
    public interface INlpService
    {
        Task<string> ProcessText(string text);
    }
}