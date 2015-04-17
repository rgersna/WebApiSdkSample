using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class Representative
    {
        /*
          "id": 12,
          "repNo": "23",
          "fullName": "Brutus Bean",
          "firstName": "Brutus",
          "lastName": "Bean",
          "addressLine1": "1 Investment Road",
          "addressLine2": "",
          "city": "Elyria",
          "state": "OH",
          "zip": "44035",
          "phoneNumber": "(111) 111-1111",
          "email": "",
          "company": "Bean Investments LLC",
          "mobilePhoneNumber": "",
          "faxNumber": "",
          "brokerDealer": "ABC Securities, Inc.",
          "businessPhoneNumber": "(111) 111-1111",
          "households": 5,
          "value": 110020.91,
          "isActive": true,
          "accountingLedgerNo": "",
          "branch": "",
          "copyToRep": false,
          "createdBy": "S.Causby@trustetc.com",
          "createdDate": "2013-06-10T13:47:32.29-05:00",
          "default": false,
          "destinationDownload": false,
          "editedBy": "S.Causby@trustetc.com",
          "editedDate": "2013-06-10T13:47:32.29-05:00",
          "firmName": null,
          "hasADV": false,
          "hasU4": false,
          "importKey": null,
          "payee": null,
          "planAdministrator": null,
          "raActive": false,
          "raAmount": 0,
          "raDate": null,
          "repRestriction": "",
          "ria": 0,
          "riaName": null,
          "royalTCode": "",
          "startDate": "2013-06-10T14:43:54-05:00",
          "status": "Active/No Issues",
          "wholeSaler": null
         */
        public int id { get; set; }
        public string repNo { get; set; }
        public string fullName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string company { get; set; }
        public string mobilePhoneNumber { get; set; }
        public string faxNumber { get; set; }
        public string brokerDealer { get; set; }
        public string businessPhoneNumber { get; set; }
        public int households { get; set; }
        public decimal value { get; set; }
        public bool isActive { get; set; }
        public string accountingledgerCode { get; set; }
        public string branch { get; set; }
        public string copyToRep { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        [JsonProperty(PropertyName = "default")]
        public bool isDefault { get; set; }
        public string destinationDownload { get; set; }
        public string editedBy { get; set; }
        public DateTime editedDate { get; set; }
        public string firmName { get; set; }
        public bool hasADV { get; set; }
        public bool hasA4 { get; set; }
        public string importKey { get; set; }
        public string payee { get; set; }
        public string planAdministator { get; set; }
        public bool raActive { get; set; }
        public decimal raAmount { get; set; }
        public DateTime raDate { get; set; }
        public string repRestriction { get; set; }
        public int ria { get; set; }
        public string riaName { get; set; }
        public string royalTCode { get; set; }
        public DateTime startDate { get; set; }
        public string status { get; set; }
        /// <summary>
        /// [sic]
        /// </summary>
        public string wholeSaler { get; set; }


    }
}
