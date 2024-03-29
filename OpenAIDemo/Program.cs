using OpenAI.GPT3.Extensions;
using OpenAIDemo;
using OpenAIDemo.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey =
        "???"); // enter your api key
        services.AddHostedService<OpenAICompletionService>();
        //services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();
