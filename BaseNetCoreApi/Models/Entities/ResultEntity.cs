namespace BaseNetCoreApi.Models.Entities
{
    public class ResultEntity
    {
        public ResultEntity()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public ResultEntity(bool res, string msg)
        {
            Res = res;
            Msg = msg;
        }

        public bool Res { get; set; }
        public string Msg { get; set; }
        public object ResObject { get; set; }
    }
}
