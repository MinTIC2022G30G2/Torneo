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
        
        private readonly IRMunicipio _repoMunicipio;
        [BindProperty]
        public Municipio Municipio { get;set; }
        public DeleteModel(IRMunicipio repoMunicipio){
            this._repoMunicipio=repoMunicipio;
        }
        public ActionResult OnGet(int id){
            ViewData["Title"]="Eliminar Municipio";
            Municipio = _repoMunicipio.BuscarMunicipio(id);
            if(Municipio == null){
                ViewData["Error"]="Municipio no encontrado";
                return Page();
            }
            return Page();
        }
        public ActionResult OnPost(){
            bool funciono=_repoMunicipio.EliminarMunicipio(Municipio.Id);
            if(funciono){
                return RedirectToPage("./Index");
            }else{
                ViewData["Error"]="Fallo al eliminar el registro";
                return Page();
            }
        }
    }
}
