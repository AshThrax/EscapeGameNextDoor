namespace EscapeGameService.Models;

    public class SubCategorie
    {
        public int SubCatId { get; set; }
        public int CatId { get; set; }
        public string SubCatName { get; set; } = string.Empty;

        public Categorie? Categorie { get; set; }
    }

