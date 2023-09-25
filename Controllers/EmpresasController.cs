using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using EmpregosOnLine.Models.ViewModels;
using EmpregosOnLine.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmpregosOnLine.Controllers
{
    public class EmpresasController : Controller
    {
        private readonly EmpresasService _empresasService;
        private readonly Cloudinary _cloudinary;

        public EmpresasController(EmpresasService empresasService, Cloudinary cloudinary)
        {
            _empresasService = empresasService;
            _cloudinary = cloudinary;
        }

        public async Task<ActionResult> Index()
        {
            var empresas = await _empresasService.GetEmpresasAsync();
            return View(empresas);
        }

        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Ocorreu um erro durante a requisição das informações." });
            }
            
            var empresa = await _empresasService.GetEmpresaAsync(id.Value);

            if (empresa == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Empresa não encontrada." });
            }

            return View(empresa);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmpresaEnderecoViewModel empresaEnderecoViewModel, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(image.FileName, image.OpenReadStream()),
                };

                var uploadResult = await _cloudinary.UploadAsync(uploadParams);
                empresaEnderecoViewModel.Empresa.UrlImagem = uploadResult.SecureUri.AbsoluteUri;
            }

            if (ModelState.IsValid)
            {
                await _empresasService.CreateEmpresaAsync(empresaEnderecoViewModel.Empresa);

                return RedirectToAction(nameof(Index));
            }
            return View(empresaEnderecoViewModel);
        }

        public async Task<ActionResult> Edit(Guid id)
        {
            var empresa = await _empresasService.GetEmpresaAsync(id);
            
            if (empresa == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Ocorreu um erro durante a requisição das informações." });
            }
            
            var viewModel = new EmpresaEnderecoViewModel { Id = empresa.Id, Empresa = empresa, Endereco = empresa.Endereco };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmpresaEnderecoViewModel empresaEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                await _empresasService.UpdateEmpresaAsync(empresaEnderecoViewModel.Empresa);
                return RedirectToAction(nameof(Index));
            }

            return View(empresaEnderecoViewModel);
        }

        public async Task<ActionResult> Delete(Guid id)
        {
            var empresa = await _empresasService.GetEmpresaAsync(id);
            if (empresa == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Ocorreu um erro durante a requisição das informações." });
            }
            return View(empresa);
        }

        [ActionName("Delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            var empresa = await _empresasService.GetEmpresaAsync(id);

            if (empresa.Vagas.Count() > 0)
            {
                return RedirectToAction(nameof(Error), new { message = "Não é possível deletar empresas que possuem uma ou mais vagas associadas." });
            }

            await _empresasService.DeleteEmpresaAsync(empresa);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Error(string message) 
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(viewModel);
        }
    }
}
