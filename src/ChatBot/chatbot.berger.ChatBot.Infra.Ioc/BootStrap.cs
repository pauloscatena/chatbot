using System;
using chatbot.berger.ChatBot.Application;
using chatbot.berger.ChatBot.Application.Interfaces;
using chatbot.berger.ChatBot.Domain;
using chatbot.berger.ChatBot.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace chatbot.berger.ChatBot.Infra.Ioc
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
