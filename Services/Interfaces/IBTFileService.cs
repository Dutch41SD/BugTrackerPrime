using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BugTrackerPrime.Services.Interfaces
{
    public interface IBTFileService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);

        public string ConvertByteArrayToFile(byte[] fileData, string extention);

        public string GetFileIcon(string file);

        public string FormatFileSize(long bytes);
    }
}
