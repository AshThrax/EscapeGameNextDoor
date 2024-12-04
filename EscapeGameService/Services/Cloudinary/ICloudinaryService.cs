namespace EscapeGameService.Services
{
    public interface ICloudinaryService
    {
        /// <summary>
        ///  Upload an new image
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        Task<string> UploadAsync(IFormFile file);
        /// <summary>
        ///  retrieve an imge by his id
        /// </summary>
        /// <param name="imageId"></param>
        /// <returns></returns>
        Task GetAsync(string imageId);
        /// <summary>
        /// delete a ressource
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        bool DeleteAsync(string image);
    }
}
