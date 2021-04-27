using ForeverGaming.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForeverGaming.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ValidationController : Controller
    {
        private Repository<Genre> genreData { get; set; }
        private Repository<Type> typeData { get; set; }
        private Repository<Format> formatData { get; set; }

        public ValidationController(GameContext ctx)
        {
            genreData = new Repository<Genre>(ctx);
            typeData = new Repository<Type>(ctx);
            formatData = new Repository<Format>(ctx);
        }

        public JsonResult CheckGenre(string genreId, string operation)
        {
            var validate = new Validate(TempData);
            validate.CheckGenre(genreId, operation, genreData);
            if (validate.IsValid)
            {
                validate.MarkGenreChecked();
                return Json(true);
            }
            else
            {
                return Json(validate.ErrorMessage);
            }
        }

        public JsonResult CheckType(string typeId, string operation)
        {
            var validate = new Validate(TempData);
            validate.CheckType(typeId, operation, typeData);
            if (validate.IsValid)
            {
                validate.MarkTypeChecked();
                return Json(true);
            }
            else
            {
                return Json(validate.ErrorMessage);
            }
        }

        public JsonResult CheckFormat(string formatId, string operation)
        {
            var validate = new Validate(TempData);
            validate.CheckFormat(formatId, operation, formatData);
            if (validate.IsValid)
            {
                validate.MarkFormatChecked();
                return Json(true);
            }
            else
            {
                return Json(validate.ErrorMessage);
            }
        }
    }
}
