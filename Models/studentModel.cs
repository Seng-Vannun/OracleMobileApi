using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
namespace OracleMobileApi.Models
{
    [Table("STUDENT")]
    public class studentModel
    {
        public int ID { get; set; }
        [Column("FIRST_NAME")]
        public string first_name { get; set; }
        [Column("LAST_NAME")]
        public string last_name { get; set; }
        [Column("GENDER")]
        public string Gender { get; set; }
        [Column("CONTACTNUMBER")]
        public string ContactNumber { get; set; }
        [Column("DOB")]
        public DateTime dob { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("PROFILE_PICTURE")]
        [JsonProperty("ProfilePicture", NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Profile_Picture { get; set; } 
        [Column("STATUS")]
        public int Status { get; set; }
    }
}
