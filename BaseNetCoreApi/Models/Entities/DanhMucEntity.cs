using Microsoft.AspNetCore.Identity;

namespace BaseNetCoreApi.Models.Entities
{

    public class DanhMucEntity
    {
        public DanhMucEntity()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public DanhMucEntity(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public DanhMucEntity(string value, string text, string index)
        {
            Value = value;
            Text = text;
            Index = index;
        }

        public DanhMucEntity(string value, string text, string index, string palce, string size, string mergeCell,
            string numbFormat, string parentName, string groupParentName)
        {
            Value = value;
            Text = text;
            Index = index;
            Place = palce;
            Size = size;
            MergeCell = mergeCell;
            NumbFormat = numbFormat;
            ParentName = parentName;
            GroupParentName = groupParentName;
        }

        public DanhMucEntity(string value, string text, string index, string palce, string size, string mergeCell,
            string numbFormat, string parentName, string megerParent, string groupParentName, string megerGroupParent,
            string megerGroupParentName2, int countParent)
        {
            Value = value;
            Text = text;
            Index = index;
            Place = palce;
            Size = size;
            MergeCell = mergeCell;
            NumbFormat = numbFormat;
            ParentName = parentName;
            MegerParentName = megerParent;
            GroupParentName = groupParentName;
            MegerGroupParentName = megerGroupParent;
            MegerGroupParentName2 = megerGroupParentName2;
            CountParent = countParent;
        }

        public string Value { get; set; }
        public string Value2 { get; set; }
        public string Text { get; set; }
        public string Index { get; set; }
        public string Place { get; set; }
        public string Size { get; set; }
        public string MergeCell { get; set; }
        public string NumbFormat { get; set; }
        public string ParentName { get; set; }
        public string MegerParentName { get; set; }
        public string GroupParentName { get; set; }
        public string MegerGroupParentName { get; set; }
        public string MegerGroupParentName2 { get; set; }
        public int CountParent { get; set; }
        public int RowIndex { get; set; } = -1;
        public int CellIndex { get; set; } = -1;
    }
}

