using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Core.Services
{
    public interface IFileUploadService
    {
        Task<string> UploadSingleFile(IFormFile file, string fileLocationToSave);
        Task<List<string>> UploadFiles(List<IFormFile> files, string fileLocationToSave);
    }
}
