using System.Threading.Tasks;
using chatbot.berger.ChatBot.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace chatbot.berger.ChatBot.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BotController: ControllerBase
    {
        private readonly INlpApplication _nlpApplication;
        public BotController(INlpApplication nlpApplication)
        {
            _nlpApplication = nlpApplication;            
        }

        [HttpGet]
        public async Task<IActionResult> Get(string text)
        {
            return Ok(await _nlpApplication.ProcessText(text));
        }
    }
}