using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IPublicationService _publicationService;
        public PublicationController(IPublicationService publicationService)
        {
            _publicationService = publicationService;
        }


        #region publication
        //récupérer les 
        #endregion
        #region publicationType
        //récupérer les type de like 
        #endregion
        #region Haslikes
        //ajouter un like 
        //enlever un like 
        #endregion
    }
}