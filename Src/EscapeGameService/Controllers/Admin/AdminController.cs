using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers.Admin
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        
        public AdminController()
        { 
        }
        #region Publication

        #endregion
        #region publicationType
        //ajouter des types de publication
        #endregion
        #region hasLikType
        //ajouter des types de Like
        //modifier le type d'u like 
        #endregion
        #region escapesGames 
        //ajouter modifier 
        //creer un escapes games
        //supprimer un escapes games
        //changer les date d'ouverture 
        //changer l'indice de prices d'un escapes games
        //récuperer les niveau de difficulté lier a un escapes games
        //changer le niveau de difficulté
        #endregion

        #region activitiyPlace
        //ajouter un lieu d'activité proche d'un escapes games
        //enlever un lieu d'activité 
        //modifier les information lier a un lieu d'activitié 
        //
        #endregion
        #region session
        //ajouter une session d'escapes games pour un escapes games précis
        //ajouter une liste de session
        //confirmer une session d'escapes game 
        //voir le session effectuer pour tout les escapes games 
        #endregion

    }
}
