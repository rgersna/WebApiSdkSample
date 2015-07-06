
using OrionApiSdk.Classes.Enums;
namespace OrionApiSdk.Classes.Portfolio
{
    public class EntityOption
    {
        public object childParameter { get; set; }
        public string entity { get; set; }
        public int? entityId { get; set; }
        public string entityName { get; set; }
        public int? userDefineDefinitionId { get; set; }
        public int? userDefineDataId { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int? type { get; set; }
        public string code { get; set; }
        public int? sequence { get; set; }
        public string value { get; set; }
        public string[] options { get; set; }
        public string input { get; set; }
    }

}
