namespace MentalDepths.Web.Infrastructure.Extensions
{
    public class FileManipulator
    {
        public byte[] ConvertToByteArray(string path)
        {
            byte[] arr= File.ReadAllBytes(path);
            return arr;
        }
    }
}
