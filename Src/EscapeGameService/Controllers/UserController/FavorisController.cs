using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers.UserController
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FavorisController : ControllerBase
    {
        public FavorisController()
        { 
        }
        #region Favoris
        //ajouter un escape games de ses favoris
        //enlever un escapes games de ses favoris
        #endregion

        #region hasbeenDone
        //indiquer qu'un escapes game a été fait 
        //indiquer qu'un escape game sn' apas été fait 
        #endregion

        #region Feedback
        //écrire un feedback sur un escapes game
        //modifier son feedback
        //supreimer un feedback
        #endregion
    }
}
