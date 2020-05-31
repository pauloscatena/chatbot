using System;
using chatbot.scatena.ChatBot.Application;
using chatbot.scatena.ChatBot.Application.Interfaces;
using chatbot.scatena.ChatBot.Domain;
using chatbot.scatena.ChatBot.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace chatbot.scatena.ChatBot.Infra.Ioc
{
    public static class BootStrap
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<INlpApplication, NlpApplication>();
            services.AddTransient<INlpService, LuisNlpService>();
        }
    }
}
