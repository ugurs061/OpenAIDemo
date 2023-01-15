using OpenAI.GPT3.Extensions;
using OpenAIDemo;
using OpenAIDemo.Services;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey =
        "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");
        services.AddHostedService<OpenAICompletionService>();
        //services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();
