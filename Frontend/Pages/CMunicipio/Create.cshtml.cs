using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio{
    public class CreateModel : PageModel{
        private readonly IRMunicipio _repoMunicipio;
        [BindProperty]
        public Municipio Municipio { get; set; }
        public CreateModel(IRMunicipio repoMunicipio){
            this._repoMunicipio = repoMunicipio;
        }
        public ActionResult OnGet(){
            return Page();
        }
        public ActionResult OnPost(){
            ViewData["Error"] = "Enviado"; 
            if(!ModelState.IsValid){
                return Page();
            }
            ViewData["Error"] = Municipio.Id; 
            bool funciono=_repoMunicipio.CrearMunicipio(Municipio);
            if(funciono){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"] = "Municipio registrado previamente"; 
                return Page();
            }
        }
    }
}