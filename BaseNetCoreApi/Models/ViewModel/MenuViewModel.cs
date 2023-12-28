using System.ComponentModel.DataAnnotations;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class MenuAdminViewModel
    {
        public long MenuId { get; set; }

        public long? ParentId { get; set; }

        public string? MenuCode { get; set; }

        public int? LevelItem { get; set; }

        public string MenuName { get; set; } = null!;

        public string? Icon { get; set; }

        public string? Link { get; set; }

        public int? TypeHelp { get; set; }

        public string? DesHelp { get; set; }

        public string? LinkYoutube { get; set; }

        public string? Order { get; set; }

        public int IsView { get; set; }

        public int Status { get; set; }

        public string? MenuNameEg { get; set; }
    }
    public class MenuViewModel
    {
        public long MenuId { get; set; }

        public long? ParentId { get; set; }

        public string? MenuCode { get; set; }

        public int? LevelItem { get; set; }

        public string MenuName { get; set; } = null!;

        public string? Icon { get; set; }

        public string? Link { get; set; }

        public int? TypeHelp { get; set; }

        public string? DesHelp { get; set; }

        public string? LinkYoutube { get; set; }

        public string? Order { get; set; }

        public int IsView { get; set; }

        public int Status { get; set; }

        public string? MenuNameEg { get; set; }
    }
    public class MenuAddViewModel
    {

        public long? ParentId { get; set; }

        public string? MenuCode { get; set; }

        public int? LevelItem { get; set; }

        public string MenuName { get; set; } = null!;

        public string? Icon { get; set; }

        public string? Link { get; set; }

        public int? TypeHelp { get; set; }

        public string? DesHelp { get; set; }

        public string? LinkYoutube { get; set; }

        public string? Order { get; set; }

        public int IsView { get; set; }

        public int Status { get; set; }

        public string? MenuNameEg { get; set; }
    }
    public class MenuDeleteViewModel
    {
        [Required(ErrorMessage = "MenuId is required")]
        public long MenuId { get; set; }
    }
    public class MenuUpdateViewModel
    {
        [Required(ErrorMessage = "MenuId is required")]
        public long MenuId { get; set; }
        public long? ParentId { get; set; }

        public string? MenuCode { get; set; }

        public int? LevelItem { get; set; }

        public string MenuName { get; set; } = null!;

        public string? Icon { get; set; }

        public string? Link { get; set; }

        public int? TypeHelp { get; set; }

        public string? DesHelp { get; set; }

        public string? LinkYoutube { get; set; }

        public string? Order { get; set; }

        public int IsView { get; set; }

        public int Status { get; set; }

        public string? MenuNameEg { get; set; }
    }
}
