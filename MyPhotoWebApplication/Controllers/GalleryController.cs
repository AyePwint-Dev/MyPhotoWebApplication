using Microsoft.AspNetCore.Mvc;
using MyPhotoWebApplication.DB;
using MyPhotoWebApplication.ViewModel;

namespace MyPhotoWebApplication.Controllers
{
    public class GalleryController : Controller
    {
        private readonly GalleryAppContext _context;
        private readonly IWebHostEnvironment _env;

        public GalleryController(GalleryAppContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var images = _context.Images.ToList();
            return View(images);
        }

        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(ImageUploadViewModel model)
        {
            if (model.Image != null)
            {
                var fileName = Path.GetFileNameWithoutExtension(model.Image.FileName);
                var extension = Path.GetExtension(model.Image.FileName);
                var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";
                var filePath = Path.Combine(_env.WebRootPath, "images", uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }

                var image = new Models.Image
                {
                    FileName = uniqueFileName,
                    FilePath = "/images/" + uniqueFileName,
                    ThumbnailPath = "/images/" + uniqueFileName,
                    UploadDate = DateTime.Now
                };

                _context.Images.Add(image);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
