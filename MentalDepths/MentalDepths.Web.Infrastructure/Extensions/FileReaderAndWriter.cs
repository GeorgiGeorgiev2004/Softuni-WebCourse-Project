
namespace MentalDepths.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Http;
    public class FileReaderAndWriter
    {
        public byte[] TurnFileToByteArray(IFormFile ff) 
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ff.CopyToAsync(ms);
                var fileBytes = ms.ToArray();
                return fileBytes;
            }
        }
    }
}
