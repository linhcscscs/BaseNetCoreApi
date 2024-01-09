namespace BaseNetCoreApi.Models.Entities
{
    public class TableUploadConfigEntity
    {
        public int Id { get; set; }
        public int TableUploadName { get; set; }
        public string ColumnName { get; set; }
        public string Des { get; set; }
        public string DataType { get; set; }
        public int IsNull { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public int MaxSize { get; set; }
        public int RequireType { get; set; }
        public string ListValue { get; set; }
        public string SchemaNameRelationship { get; set; }
        public string TableNameRelationship { get; set; }
        public string ColumnNameRelationship { get; set; }
        public string ColumnWhere { get; set; }
        public string ValueWhere { get; set; }
        public string DataTypeWhere { get; set; }
        public string ColumnNameGet { get; set; }
        public string DataTypeGet { get; set; }
        public int Status { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
    }
}
