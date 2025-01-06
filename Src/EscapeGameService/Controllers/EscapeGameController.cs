
using EscapeGameService.Dto.EscapeGame;
using EscapeGameService.Services.Escapesgame;
using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EscapeGameController : GenericControlleur<Escapegame, GetEscapeGameDto, AddEscapeGameDto, UpdateEscapeGameDto>
    {
        public EscapeGameController(IEscapeGameServices serviceT) : base(serviceT)
        {
        }
        #region escapesGame 
        //récuperer la liste des escapes games
        //récuperer un escapes game par son id
        #endregion

        #region Activityplaces
        //récupérer la liste des endroit lier aux activité
        //récupérer la liste des types d'activité pour un escapes donner
        #endregion
        #region Event
        //récupérer la liste des endroit lier aux activité
        //récupérer la liste des types d'activité pour un escapes donner
        #endregion
    }
}
