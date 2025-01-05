namespace EscapeGameService.Dto.SubCategory
{
    public class GetSubCategoryDto
    {
        public int SubCatId { get; set; }
        public int CatId { get; set; }
        public string SubCatName { get; set; } = string.Empty;
    }
}
