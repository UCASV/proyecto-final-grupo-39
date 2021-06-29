namespace Proyecto_final.Model
{
    public class Citizen
    {
        public string id { get; set; }
        public string residence { get; set; }
        public string name { get; set; }
        public string? email { get; set; }
        public string phoneNumber { get; set; }
        public bool priority { get; set; }

        public Citizen(string ids, string residences, string names, string? emails, string phoneNumbers, bool prioritys)
        {
            id = ids;
            residence = residences;
            name = names;
            email = emails;
            phoneNumber = phoneNumbers;
            priority = prioritys;
        }
    }
}