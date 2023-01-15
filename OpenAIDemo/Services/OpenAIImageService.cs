using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels.ResponseModels.ImageResponseModel;

namespace OpenAIDemo.Services
{
    public class OpenAIImageService : BackgroundService
    {

        readonly IOpenAIService _openAIServices;

        public OpenAIImageService(IOpenAIService openAIServices)
        {
            _openAIServices = openAIServices;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.Write("::");
                ImageCreateResponse result = await _openAIServices.Image.CreateImage(new ImageCreateRequest()
                {
                    Prompt = Console.ReadLine(),
                    N = 1,// sonuç sayısı
                    Size = StaticValues.ImageStatics.Size.Size256,
                    ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
                    User = "test"

                });

                Console.WriteLine(string.Join("\n", result.Results.Select(r => r.Url)));
            }
        }
    }
}
