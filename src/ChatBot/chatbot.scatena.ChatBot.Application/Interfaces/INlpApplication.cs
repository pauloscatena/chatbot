using System.Threading.Tasks;

namespace chatbot.scatena.ChatBot.Application.Interfaces
{
    public interface INlpApplication
    {
        Task<string> ProcessText(string text);
    }
}