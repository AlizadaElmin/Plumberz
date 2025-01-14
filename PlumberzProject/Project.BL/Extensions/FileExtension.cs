using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Plumberz.BL.Extensions;

public static class FileExtension
{
    public static bool IsValidSize(this IFormFile file,int kb)
    {
        return file.Length < kb * 1024;
    }
    public static bool IsValidType(this IFormFile file,string type)
    {
        return file.ContentType.StartsWith(type);
    }

    public static async Task<string> UploadAsync(this IFormFile file, params string[] paths)
    {
        string uploadPath = Path.Combine(paths);
        if (!Path.Exists(uploadPath))
        {
            Directory.CreateDirectory(uploadPath);
        }
        string newFileName = Path.GetRandomFileName() + Path.GetExtension(file.FileName);

        using (Stream stream = File.Create(Path.Combine(uploadPath, newFileName)))
        {
            await file.CopyToAsync(stream);
        }
        return newFileName;
    }
}
