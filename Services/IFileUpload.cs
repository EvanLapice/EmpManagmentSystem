using System.ComponentModel.DataAnnotations;

namespace EmpManagmentSystem.Services
{
    public interface IFileUpload
    {
        Task<bool> UploadFile(IFormFile file);
        string? FileName { get; set; }

    }
}
