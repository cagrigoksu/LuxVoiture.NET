using MongoDB.Bson;

namespace LuxVoiture.Models
{
    public class UserModel
    {
        public string? Id { get; set; }

        public string? UserEmail { get; set; }

        public string? UserPwd { get; set; }

        public string? UserPwdConf { get; set; }

        public DateTime? TimeCreated {  get; set; } 
        public Boolean? Deleted {  get; set; }
        public DateTime? TimeDeleted { get; set;}
    }
}
