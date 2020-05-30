using System.Threading.Tasks;

namespace chatbot.berger.ChatBot.Application.Interfaces
{
    public interface INlpApplication
    {
        Task<string> ProcessText(string text);
    }
}