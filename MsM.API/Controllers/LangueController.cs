using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MsM.API.Controllers
{
    [RoutePrefix("api/Langue")]

    public class LangueController : ApiController
    {
        [AllowAnonymous]
        [Route("")]
        // GET api/Langue
        /// Retourne la liste des langues gérer par le système.
        public IHttpActionResult Get()
        {
            // Pour les tests on retourne des valeurs en dur....
            return Ok(Langue.CreateLangue());
        }

        public class Langue
        {
            public int Id { get; set; }
            public string Libelle { get; set; }

            public static List<Langue> CreateLangue()
             {
                List<Langue> l = new List<Langue>
                {
                    new Langue {Id=1, Libelle="Français" },
                    new Langue {Id=2, Libelle="English" },
                };
                return l;
            }
        }

    }
}
