using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio{
    public class DeleteModel : PageModel{
        private readonly IRMunicipio _repositorio;
        [BindProperty]
        public Municipio item { get;set; }
        public DeleteModel(IRMunicipio repositorio){
            this._repositorio=repositorio;
        }
        public ActionResult OnGet(int id){
            if(_repositorio.Buscar(id) == null){
                ViewData["Error"]="Registro no encontrado";
                return Page();
            }
            return Page();
        }
        public ActionResult OnPost(int id){
            if(_repositorio.Eliminar(item.Id)){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="Fallo al eliminar el registro";
                return Page();
            }
        }
    }
}
