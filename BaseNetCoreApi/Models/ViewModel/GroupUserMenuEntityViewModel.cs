using BaseNetCoreApi.Models.Entities;

namespace BaseNetCoreApi.Models.ViewModel
{
    public class GroupUserMenuEntityEditViewModel
    {
        public long GroupUserId {  get; set; }
        public List<GroupUserMenuEntity> Data { get; set; } = new List<GroupUserMenuEntity>();
    }
}
