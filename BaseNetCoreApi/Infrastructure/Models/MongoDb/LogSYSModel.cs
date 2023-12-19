using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BaseNetCoreApi.Infrastructure.Models.MongoDb
{
    public class LogSYSModel
    {
        /// <summary>
        /// Mã năm học
        /// </summary>
        [Required]
        public int MA_NAM_HOC { get; set; }
        /// <summary>
        /// Mã tỉnh
        /// </summary>
        [Required]
        public string MA_TINH { get; set; }
        /// <summary>
        /// Mã tỉnh
        /// </summary>
        [Required]
        public string MA_HUYEN { get; set; }
        /// <summary>
        /// Mã xã
        /// </summary>
        [Required]
        public string MA_XA { get; set; }

        [BsonId]
        [BsonIgnoreIfDefault]
        [IgnoreDataMember]
        public ObjectId _id { get; set; }
        [Required]
        public string TEN_BANG { get; set; }
        [Required]
        public string HANH_DONG { get; set; }
        public string IP { get; set; }
        public string URL { get; set; }
        public string USER_AGENT { get; set; }
        [Required]
        public string KEY_VAL { get; set; }
        public string GHI_CHU { get; set; }
        public string NGUOI_TAO { get; set; }
        [IgnoreDataMember]
        public DateTime NGAY_TAO { get; set; }
    }
}
