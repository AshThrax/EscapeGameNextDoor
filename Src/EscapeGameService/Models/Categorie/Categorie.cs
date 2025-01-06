namespace EscapeGameService.Models;

public class Categorie
    {

        public int CatId { get; set; }
        public string CatName { get; set; } = string.Empty;
        public List<SubCategorie>? SubCategories { get; set; }
    }

