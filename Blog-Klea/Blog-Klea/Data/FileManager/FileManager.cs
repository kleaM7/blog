using Blog_Klea.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Klea.Data.FileManager
{
    public class FileManager : IFileManager
    {
        private string _imagePath;
        string a = "C:\\Users\\Xhers\\source\\repos\\Blog-Klea\\Blog-Klea\\wwwroot\\content\\blog";

        public FileManager(IConfiguration config)
        {
            _imagePath = a;
        }

        public async Task<string> SaveImage(IFormFile image)
        {
            string a = "";
            try
            { 
                var save_path = Path.Combine(_imagePath);
                if (!Directory.Exists(save_path))
                {
                    Directory.CreateDirectory(save_path);
                }
                var mime = image.FileName.Substring(image.FileName.LastIndexOf('.'));
                var fileName = $"img_{DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss")}{mime}";

               // Console.WriteLine(fileName);
 
                using (var f = new FileStream(Path.Combine(save_path, fileName), FileMode.Create))
                {
                    await image.CopyToAsync(f);
                }
        
                return fileName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                return ex.Message;
            }
         }

    }

}
