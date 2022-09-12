using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages.CMunicipio{
    public class IndexModel : PageModel{
        private readonly IRMunicipio _repositorio;
        public IEnumerable<Municipio> items { get; set; }
        public IndexModel(IRMunicipio repositorio){
            this._repositorio = repositorio;
        }
        public void OnGet(){
            items = _repositorio.Listar();
        }
    }
}
