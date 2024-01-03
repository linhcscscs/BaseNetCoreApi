using ClosedXML.Excel;
using NPOI.SS.UserModel;
using System.Data;

namespace BaseNetCoreApi.Models.Model.Excel
{
    public class ExcelEntity
    {
        public ExcelEntity()
        {
            //
            // TODO: Add constructor logic here
            //
            Color = XLColor.Black;
            Align = XLAlignmentHorizontalValues.Left;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public string NumberFormat { get; set; }
        public XLColor Color { get; set; }
        public XLAlignmentHorizontalValues Align { get; set; }
        public HorizontalAlignment AlignNPOI { get; set; }
    }
    public class DataExcel
    {
        public DataExcel()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public string Name { get; set; }
        public int rowStart { get; set; }
        public int? indexSheet { get; set; }
        public string colStart { get; set; }
        public string colEnd { get; set; }
        public DataTable dt { get; set; }
        public List<ExcelEntity> lstColumn { get; set; }
        public bool have_stt { get; set; }
    }
    public class ExcelTMPEntity
    {
        public ExcelTMPEntity()
        {
            listCell = new List<ExcelHeaderEntity>();
            dt = new DataTable();
            lstHeader = new List<ExcelHeaderEntity>();
            lstColumn = new List<ExcelEntity>();
        }
        public int indexSheet { get; set; }
        public string nameSheet { get; set; }
        public int indexSheetCopy { get; set; }
        public List<ExcelHeaderEntity> listCell { get; set; }
        public int rowHeaderStart { get; set; }
        public int rowStart { get; set; }
        public string colStart { get; set; }
        public string colEnd { get; set; }
        public DataTable dt { get; set; }
        public List<ExcelHeaderEntity> lstHeader { get; set; }
        public List<ExcelEntity> lstColumn { get; set; }
        public bool have_stt { get; set; }
    }
}
