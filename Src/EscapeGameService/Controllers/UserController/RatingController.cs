using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers.UserController
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        public RatingController() { }

        #region RatingFromUser
            //récupération des Rating set up un user 
            //create un rating provenant  d'un utilisateur 
            //envoyer une autorisation vérifiant si l'utilisateur peut creer une review 
            //récupérer les reviews d'un utilisateur 
        #endregion
    }
}
