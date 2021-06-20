using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace DonateBlood.Helpers
{

    public class Uploader
    {
        
        public static string UploadProfileImage(IFormFile image,string root)
        {
            var uniqueImgName = Guid.NewGuid() + image.FileName;
            var path = Path.Combine("images", "profile");
            var folderPath = Path.Combine(root, path);
            var pathToSave = Path.Combine(folderPath, uniqueImgName);
            var dbPath = Path.Combine(path, uniqueImgName);

            using (var stream = new FileStream(pathToSave, FileMode.Create))
            {
                image.CopyTo(stream);

            }
            return dbPath;

        }

    }

}
