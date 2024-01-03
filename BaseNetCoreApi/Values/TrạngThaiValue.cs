using BaseNetCoreApi.Models.Entities;

namespace BaseNetCoreApi.Values
{
    public class TrangThaiValue
    {

        public static int TAO_MOI = 0;
        public static int HIEU_LUC = 1;
        public static int KHONG_HIEU_LUC = 2;
        public static List<DanhMucEntity> getList(bool isAll = false, string textAll = "Tất cả")
        {
            List<DanhMucEntity> lst = new List<DanhMucEntity>();
            if (isAll)
                lst.Add(new DanhMucEntity("", textAll));
            lst.Add(new DanhMucEntity(TAO_MOI.ToString(), getText(TAO_MOI)));
            lst.Add(new DanhMucEntity(HIEU_LUC.ToString(), getText(HIEU_LUC)));
            lst.Add(new DanhMucEntity(KHONG_HIEU_LUC.ToString(), getText(KHONG_HIEU_LUC)));
            return lst;
        }
        public static string getText(int value)
        {
            switch (value)
            {
                case 0:
                    return "Tạo mới";
                case 1:
                    return "Hiệu lực";
                case 2:
                    return "Tạm ngưng";
                case 3:
                    return "Hủy";
                default:
                    return "Hủy;";
            }
        }
    }
}
