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
        private readonly IRMunicipio _repositorio;
        [BindProperty]
        public Municipio item { get; set; }
        public CreateModel(IRMunicipio repositorio){
            this._repositorio = repositorio;
        }
        public ActionResult OnGet(){
            return Page();
        }
        public ActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }
            if(_repositorio.Crear(item)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"] = "Registro agregado previamente"; 
                return Page();
            }
        }
    }
}