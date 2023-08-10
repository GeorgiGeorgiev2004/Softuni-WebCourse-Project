namespace MentalDepths.Web.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Internal;
    using System.IO;

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

        public IFormFile TurnByeArrayToFile(byte[] bt)
        {
            using (MemoryStream ms = new MemoryStream(bt))
            {
                return new FormFile(ms, 0, bt.Length, "name", "fileName");
            }
        }
    }
}
