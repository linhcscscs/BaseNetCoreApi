using ClosedXML.Excel;
using NPOI.SS.UserModel;

namespace BaseNetCoreApi.Models.Model.Excel
{
    public class ExcelHeaderEntity
    {
        public ExcelHeaderEntity()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public string name { get; set; }
        public int colM { get; set; }
        public int rowM { get; set; }
        public int? parentIndex { get; set; }
        public string colName { get; set; }
        public List<ExcelHeaderEntity> lstChild { get; set; }
        public int rowIndex { get; set; }
        public double? fontSize { get; set; }
        public double? width { get; set; }
        public double? height { get; set; }
        public XLAlignmentHorizontalValues? Align { get; set; }
        public HorizontalAlignment? AlignNPOI { get; set; }
        public XLColor Color { get; set; }
        public bool Bold { get; set; } = true;
        public bool? WrapText { get; set; }
    }
}
