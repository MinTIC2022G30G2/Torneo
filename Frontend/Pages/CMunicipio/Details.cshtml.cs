using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio{
    public class DetailsModel : PageModel{
        private readonly IRMunicipio _repositorio;
        [BindProperty]
        public Municipio item { get;set; }
        public DetailsModel(IRMunicipio repositorio){
            this._repositorio = repositorio;
        }
        public ActionResult OnGet(int id){
            item = _repositorio.Buscar(id);
            return Page();
        }
    }
}
