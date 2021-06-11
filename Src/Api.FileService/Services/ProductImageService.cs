using System;
using System.IO;
using System.IO.Abstractions;
using System.Threading.Tasks;
using Api.Core.Common.Contracs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Api.FileService.Services
{
    public class IProductImageService : IProductImageServise
    {
        private readonly string _rootPhat;
        private IFileSystem FileSystem { get; }
        public IProductImageService(IFileSystem fileSystem, IWebHostEnvironment env)
        {
            FileSystem = fileSystem;

            _rootPhat = Path.Combine(env.WebRootPath, "ProductImage");
            if (!Directory.Exists(_rootPhat))
            {
                Directory.CreateDirectory(_rootPhat);
            }
        }

        async Task<string> IProductImageServise.SaveImageAcync(IFormFile file)
        {
            var filePath = Path.Combine(_rootPhat, Guid.NewGuid() + "_" + file.FileName);
            var fileStreamToSave = FileSystem.File.Create(filePath);

            await file.CopyToAsync(fileStreamToSave);
            fileStreamToSave.Close();
            return filePath;
        }
    }
}
