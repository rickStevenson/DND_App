namespace DND_App.Web.Repository
{
    public interface IImageRepository
    {
        Task<string> UploadAsync(IFormFile formFile);
    }
}
