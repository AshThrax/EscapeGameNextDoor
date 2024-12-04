
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using EscapeGameService.Models.Params;
using Microsoft.Extensions.Options;

namespace EscapeGameService.Services
{
    public class CloudinaryService : ICloudinaryService
    {
        private readonly Cloudinary _cloudinary;
        private readonly IOptions<CloudDinarySettings> options;
        public CloudinaryService(IOptions<CloudDinarySettings> options) 
        {
             this.options = options;
             Account CloudAccount= new Account(options.Value.Cloud,
                                               options.Value.ApiKey,
                                               options.Value.ApiSecret);
            _cloudinary= new Cloudinary(CloudAccount);
            _cloudinary.Api.Secure=true;
        }

        public bool DeleteAsync(string image)
        {
            try
            {
                if (string.IsNullOrEmpty(image))
                {
                    throw new ArgumentNullException(nameof(image));
                }

                var removeFromCloud=  _cloudinary.DeleteResources(image);
                return removeFromCloud.Partial;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task  GetAsync(string imageId)
        {
            await Task.Run(() =>
            {
                throw new Exception("not implemented ");
            });
        }

        public async Task<string> UploadAsync(IFormFile file)
        {
            try
            {
                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream);
                memoryStream.Position = 0;

                var uploadparams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, memoryStream),
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadparams);

                if (uploadResult.Error != null)
                {
                    throw new Exception($"Cloudinary error occured: {uploadResult.Error.Message}");
                }

                return uploadResult.SecureUrl.ToString();   

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
