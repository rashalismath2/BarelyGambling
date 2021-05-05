using BarelyGambling.Core.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Core.Services
{
    public class FileUploadService : IFileUploadService
    {
        private int _maxFileSizeInKb = 2048;
        private string[] _allowedExtensions = {".jpg",".jpeg",".png" };
        public async Task<string> UploadSingleFile(IFormFile file,string fileLocationToSave) {

            if (file.Length> _maxFileSizeInKb * 1024) {
                throw new FileSizeExceededException("Max file size of "+ _maxFileSizeInKb + " Kb exceeded");
            }

            string fileExtension = Path.GetExtension(file.FileName);
            if (!_allowedExtensions.Contains(fileExtension)) {
                throw new FileExtensionNotFoundException("Allowed file extensions are, .jpg, .jpeg, .png ");
            }

            Guid fileNameWithoutExtension = Guid.NewGuid();


            //env.WebRootPath/images/fileNameWithoutExtension.fileExtension
            string filePathToSave = fileLocationToSave + fileNameWithoutExtension+ fileExtension;
            try
            {
                using (var stream = File.Create(filePathToSave))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception)
            {
                throw new FileSavingToTheLocalStorageException("Error in saving file to the local storage");
            }

            return fileNameWithoutExtension + fileExtension;
        }

        public async Task<List<string>> UploadFiles(List<IFormFile> files, string fileLocationToSave) {
            List<string> listOfSavedItems = new List<string>();

            foreach (var file in files)
            {
                var saved = await UploadSingleFile(file,fileLocationToSave);
                listOfSavedItems.Add(saved);
            }

            return listOfSavedItems;
        }

    }
}
