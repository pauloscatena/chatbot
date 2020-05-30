using System.Threading.Tasks;

namespace chatbot.berger.ChatBot.Domain.Interfaces
{
    public interface INlpService
    {
        Task<string> ProcessText(string text);
    }
}