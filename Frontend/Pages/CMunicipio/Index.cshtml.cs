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
        private readonly IRMunicipio _repoMunicipio;
        public IEnumerable<Municipio> Municipios { get; set; }

        public IndexModel(IRMunicipio repoMunicipio){
            this._repoMunicipio = repoMunicipio;
        }
        public void OnGet(){
            Municipios = _repoMunicipio.ListarMunicipios();
        }
    }
}
