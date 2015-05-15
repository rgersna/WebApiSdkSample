using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using OrionApiSdk.Classes.Portfolio;
using System.Text;
using System;
using OrionApiSdk.Classes.Enums;
using OrionApiSdk.Classes;

namespace OrionApiSdk.Code
{
    public class Portfolio : ApiBase
    {
        internal Portfolio(HttpClient httpClient) : base(httpClient) { }

        #region Clients

        /// <summary>
        /// Returns a verbose client object for the specified client id.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public Client Client(int clientId)
        {
            var endpoint = string.Format("Portfolio/Clients/{0}", clientId);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Client>(j);

            return d;
        }

        public List<Client> Clients(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Clients?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson( endpoint );
            var d = JsonConvert.DeserializeObject<List<Client>>(j);

            return d;
        }

        public List<ClientSimple> ClientsSimple(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Clients/Simple?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<ClientSimple>>(j);

            return d;
        }

        public List<SimpleValue> ClientsValue(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Clients/Value?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<SimpleValue>>(j);

            return d;
        }

        public List<ClientSimple> ClientsSearch(string searchText)
        {
            var endpoint = string.Format("Portfolio/Clients/Simple/Search?search={0}", searchText);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<ClientSimple>>(j);

            return d;
        }

        public List<SimpleValue> ClientsSearchValue(string searchText)
        {
            var endpoint = string.Format("Portfolio/Clients/Value/Search?search={0}", searchText);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<SimpleValue>>(j);

            return d;
        }

        /// <summary>
        /// Returns an initialized new ClientVerbose object
        /// </summary>
        /// <returns></returns>
        public ClientVerbose ClientVerboseNew()
        {
            var endpoint = string.Format("Portfolio/Clients/Verbose/New");

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<ClientVerbose>(j);

            return d;
        }

        /// <summary>
        /// Returns a verbose client object for the specified client id.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public ClientVerbose ClientVerbose( int clientId )
        {
            var endpoint = string.Format("Portfolio/Clients/Verbose/{0}", clientId);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<ClientVerbose>(j);

            return d;
        }

        /// <summary>
        /// Adds or Updates the client record, and returns the updated ClientVerbose object.  If the client.Id == 0, the record will be added, if it has a client id, the client record will be updated.
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public ClientVerbose ClientSave(ClientVerbose clientVerbose) {
            var endpoint = string.Empty;
            var j = string.Empty;

            if( clientVerbose.id == 0 ) {
                // new 
                endpoint = string.Format("Portfolio/Clients/Verbose");
                j = base.PostJson(endpoint, clientVerbose);
            } else {
                // update
                endpoint = string.Format("Portfolio/Clients/Verbose/{0}", clientVerbose.id);
                j = base.PutJson(endpoint, clientVerbose);
            }



           var d = JsonConvert.DeserializeObject<ClientVerbose>( j );


            return d;
        }

        public string ClientSSN(int clientId, string reason)
        {
            var endpoint = string.Format("Portfolio/Clients/{0}/SSNTaxId", clientId);
            dynamic req = new System.Dynamic.ExpandoObject();
            //req.SSN = "";
            req.Reason = reason;
            //var req = new UpdateSSN { Reason = reason, SSN = null };
            var j = base.PutJson(endpoint, req as object);
            var d = JsonConvert.DeserializeObject<string>(j);
            
            return d;
        }
        #endregion

        #region Registrations
        public List<RegistrationSimple> RegistrationsSimple(int top = 50000, int skip = 0,  bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Registrations/Simple?isActive={0}&$top={1}&$skip={2}", isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<RegistrationSimple>>(j);

            return d;
        }

        public Registration Registration(int registrationId)
        {
            var endpoint = string.Format("Portfolio/Registrations/{0}", registrationId);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Registration>(j);

            return d;
        }
        public RegistrationVerbose RegistrationVerbose( int registrationId )
        {
            var endpoint = string.Format("Portfolio/Registrations/Verbose/{0}", registrationId );
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<RegistrationVerbose > (j);

            return d;
        }

        public RegistrationVerbose RegistrationVerboseNew() {
            var endpoint = string.Format( "Portfolio/Registrations/Verbose/New" );
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<RegistrationVerbose>(j);

            return d;
        }

        public RegistrationVerbose RegistrationSave(RegistrationVerbose registrationVerbose )
        {
            var endpoint = string.Empty;
            var j = string.Empty;

            if (registrationVerbose.id == 0)
            {
                // new 
                endpoint = string.Format("Portfolio/Registrations/Verbose");
                j = base.PostJson(endpoint, registrationVerbose);
            }
            else
            {
                // update
                endpoint = string.Format("Portfolio/Registrations/Verbose/{0}", registrationVerbose.id);
                j = base.PutJson(endpoint, registrationVerbose);
            }



            var d = JsonConvert.DeserializeObject<RegistrationVerbose>(j);


            return d;
        }

        public List<RegistrationSimple> RegistrationsSearch(string searchText, int top = 50000, int skip = 0)
        {
            var endpoint = string.Format("Portfolio/Registrations/Simple/Search?$top={0}&$skip={1}&search={2}", top, skip, searchText);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<RegistrationSimple>>(j);

            return d;
        }

        public List<Registration> Registrations(int top = 50000, int skip = 0, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Registrations?isActive={0}&$top={1}&$skip={2}", isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Registration>>(j);

            return d;
        }

        public List<Registration> RegistrationsForClient(int clientId) {
            var endpoint = string.Format( "Portfolio/Clients/{0}/Registrations", clientId );
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Registration>>(j);

            return d;
        }

        public RegistrationVerbose RegistrationVerbose(int registrationId, bool beneficiaries = false, 
            bool suitability = false, bool notes = false, bool userdefinedfields = false, bool entityoptions = false)
        {
            ///Portfolio/Registrations/Verbose/1?expand=portfolio&expand=beneficiaries&expand=suitability&expand=notes&expand=userdefinedfields&expand=entityoptions
            var endpoint = string.Format("Portfolio/Registrations/Verbose/{0}?expand=portfolio", registrationId);
            if (beneficiaries)
                endpoint = endpoint += "&expand=beneficiaries";
            if (suitability)
                endpoint = endpoint += "&expand=suitability";
            if (userdefinedfields)
                endpoint = endpoint += "&expand=userdefinedfields";
            if (entityoptions)
                endpoint = endpoint += "&expand=entityoptions";
           
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<RegistrationVerbose>(j);

            return d;
        }

        public string GetSSNForBeneficiary(int registrationId, int beneficiaryId, string reason)
        {
            ///Portfolio/Registrations/{key:int}/Beneficiary/{0}/SSN
            var endpoint = string.Format("Portfolio/Registrations/{0}/Beneficiary/{1}/SSN?reason={2}"
                , registrationId,beneficiaryId,reason);
            dynamic req = new System.Dynamic.ExpandoObject();
            //req.SSN = "";
            req.Reason = reason;
            //var req = new UpdateSSN { Reason = reason, SSN = null };
            var j = base.PutJson(endpoint, req as object);
            var d = JsonConvert.DeserializeObject<string>(j);

            return d;
        }

        #endregion

        #region Representatives/Advisors
        public List<Simple> RepresentativesSimple(int top = 50000, int skip = 0)
        {
            var endpoint = string.Format("Portfolio/Representatives/Simple?$top={0}&$skip={1}", top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public Representative Representatives(int repId)
        {
            var endpoint = string.Format("Portfolio/Representatives/{0}", repId);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Representative>(j);

            return d;
        }

        

        #endregion

        #region Accounts
      
        public Account Accounts(int accountId)
        {
            var endpoint = String.Format("Portfolio/Accounts/{0}", accountId);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Account>(j);
            return d;
        }

        public Account Accounts(string accountNumber)
        {
            var endpoint = String.Format("Portfolio/Accounts/{0}", accountNumber);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Account>(j);
            return d;
        }


        public List<Account> Accounts(int top = 50000, int skip = 0, bool? isActive = null, bool? isManaged = null
            ,DateTime? createdDateStart = null, AccountFilterValues? newAccountFilter = null, string accountFilter = null
            ,ReturnStyle returnStyle = ReturnStyle.Standard)
        {
            string dateString = null;
            if (createdDateStart.HasValue)
                dateString = createdDateStart.Value.ToShortDateString();

            var endpoint = string.Format(@"Portfolio/Accounts?isActive={0}&isManaged={1}&createdDateStart={2}
                &newAccountFilter={3}&accountFilter={4}&returnStyle={5}&$top={6}&$skip={7}"
                , isActive, isManaged, createdDateStart, newAccountFilter, accountFilter, returnStyle, top, skip);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Account>>(j);

            return d;
        }

        public List<AccountSimple> AccountsSimple(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Accounts/Simple?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimple>>(j);

            return d;
        }

        public List<AccountSimpleValue> AccountsValue(int top = 50000, int skip = 0, bool? hasValue = null, bool? isActive = null)
        {
            var endpoint = string.Format("Portfolio/Accounts/Value?hasValue={0}&isActive={1}&$top={2}&$skip={3}", hasValue, isActive, top, skip);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimpleValue>>(j);

            return d;
        }

        public List<AccountSimple> AccountsSearch(string searchText)
        {
            var endpoint = string.Format("Portfolio/Accounts/Simple/Search?search={0}", searchText);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimple>>(j);

            return d;
        }

        public List<AccountSimpleValue> AccountsValueSearch(string searchText)
        {
            var endpoint = string.Format("Portfolio/Accounts/Value/Search?search={0}", searchText);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountSimpleValue>>(j);

            return d;
        }

        #region Accounts Verbose

        public List<AccountVerbose> AccountsVerbose( ) {
            var endpoint = string.Format("Portfolio/Accounts/Verbose");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountVerbose>>(j);

            return d;
        }

        public AccountVerbose AccountVerbose(int accountId)
        {
            var endpoint = string.Format("Portfolio/Accounts/Verbose/{0}", accountId);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);

            return d;
        }

        public AccountVerbose AccountVerboseNew()
        {
            var endpoint = string.Format("Portfolio/Accounts/Verbose/New");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);

            return d;
        }

        public AccountVerbose AccountSave(AccountVerbose accountVerbose)
        {
            var endpoint = string.Empty;
            var j = string.Empty;

            if (accountVerbose.id == 0)
            {
                // new 
                endpoint = string.Format("Portfolio/Accounts/Verbose");
                j = base.PostJson(endpoint, accountVerbose);
            }
            else
            {
                // update
                endpoint = string.Format("Portfolio/Accounts/Verbose/{0}", accountVerbose.id);
                j = base.PutJson(endpoint, accountVerbose);
            }



            var d = JsonConvert.DeserializeObject<AccountVerbose>(j);


            return d;
        }
        #endregion

        #endregion

        #region Assets

        public List<Asset> Assets(int top = 50000, int skip = 0, int? clientId = null, int? registrationId = null
            , int? accountId = null, int? productId = null, bool includeCostBasis = false)
        {
            var endpoint = string.Format("Portfolio/Assets?clientId={0}&registrationId={1}&accountId={2}&productId={3}&includeCostBasis={4}&$top={5}&skip={6}"
                , clientId, registrationId, accountId, productId, includeCostBasis, top, skip);
            var j = base.GetJson(endpoint);

            var d = JsonConvert.DeserializeObject<List<Asset>>(j);
            return d;

        }

     
        public AssetVerbose AssetsVerbose(int id, AssetVerboseOptions? options )
        {
            var endpoint = String.Format("Portfolio/Assets/Verbose/{0}", id);
            
            var i=0;
            if(options.HasValue)
            {
                endpoint += "?";
                foreach (AssetVerboseOptions value in Enum.GetValues(typeof(AssetVerboseOptions)))
                {
                    if (value == AssetVerboseOptions.None)
                        continue;

                    if (options.Value.HasFlag(value))
                    {
                         endpoint += String.Format("&expand[{0}]={1}", i, value);
                         i++;
                    }
                }
            }
            //strip out that leading ampersand
            var cleanEndpoint = endpoint.Replace("?&", "?");

            var j = base.GetJson(cleanEndpoint);
            var d = JsonConvert.DeserializeObject<AssetVerbose>(j);

            return d;
        }

        public Asset Assets(int assetId, bool includeCostBasis = false)
        {
            var endpoint = string.Format("Portfolio/Assets/{0}?includeCostBasis={1}", assetId, includeCostBasis);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Asset>(j);

            return d;
        }


        #endregion
        
        #region Products

        public List<Product> Products(string productFilter = null, DateTime? ownedOnDate = null, string searchTicker = null
            , string exactTicker = null, string exactCusip = null, string searchCusip = null, string exactDownloadSymbol = null
            , string searchDownloadSymbol = null, string exactSymbol = null, string searchsymbol = null, string searchName = null
            , string searchId = null, ProductTypes? productType = null, ReturnStyle? returnStyle = null)
        {
            var url = @"Portfolio/Products?productFilter={0}&ownedOnDate={1}&searchTicker={2}&exactTicker={3}&exactCusip={4}" +
                       "&searchCusip={5}&exactDownloadSymbol={6}&searchDownloadSymbol={7}&exactSymbol={8}" + 
                       "&searchSymbol={9}&searchName={10}&searchId={11}&productType={12}&returnStyle={13}";
            var endpoint = string.Format(url,
                productFilter, ownedOnDate, searchTicker, exactTicker, exactCusip, searchCusip, exactDownloadSymbol
                , searchDownloadSymbol, exactSymbol, searchsymbol, searchName, searchId, productType, returnStyle);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Product>>(j);

            return d;
        }

        public Product Products(int productId, ReturnStyle? returnStyle = null)
        {
            var endpoint = string.Format("Portfolio/Products/{0}?returnStyle={1}", productId, returnStyle);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Product>(j);

            return d;
        }

        #endregion

        #region Transactions

        public TransactionVerbose Transaction(int Id)
        {
            TransactionVerbose d = null;
            var endpoint = string.Format("Portfolio/Transactions/Verbose/{0}", Id);
            var j = base.GetJson(endpoint);
            try
            {
                d = JsonConvert.DeserializeObject<TransactionVerbose>(j);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            return d;
        }

        public List<Transaction> Transactions(TradeStatuses? status = null
         , DateTime? startDate = null, DateTime? endDate = null, int[] transTypeIds = null
         , int? clientId = null, int? registrationId = null, int? accountId = null, int? assetId = null
         , int? transactionId = null, ReturnStyle? returnStyle = null)
        {
            var endpoint = new StringBuilder();
            endpoint.AppendFormat(@"Portfolio/Transactions?status={0}&startDate={1}&endDate={2}
            &clientId={3}&registrationId={4}&accountId={5}&assetId={6}
            &transactionId={7}&returnStyle={8}"
                , status, FDate(startDate), FDate(endDate), clientId, registrationId, accountId, assetId, transactionId, returnStyle);

            if (transTypeIds != null)
                for (int i = 0; i < transTypeIds.Length; i++)
                    endpoint.AppendFormat("&transTypeId{0}={1}", i, transTypeIds[i]);

            var j = base.GetJson(endpoint.ToString());
            var d = JsonConvert.DeserializeObject<List<Transaction>>(j);

            return d;
        }

        public Transaction Transactions(int Id)
        {
            var endpoint = string.Format("Portfolio/Transactions/{0}", Id);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Transaction>(j);

            return d;
        }

        public TransactionVerbose Transactions(TransactionVerbose transaction)
        {
            var endpoint = string.Empty;
            var j = string.Empty;

            if (transaction.Id == 0)
            {
                endpoint = string.Format("Portfolio/Transactions/Verbose");
                j = base.PostJson(endpoint, transaction);
            }
            else
            {
                // update
                endpoint = string.Format("Portfolio/Transactions/Verbose/{0}", transaction.Id);
                j = base.PutJson(endpoint, transaction);
            }
            
            var d = JsonConvert.DeserializeObject<TransactionVerbose>(j);
            return d;
        }
        #endregion

        #region Lookup Tables
        public List<AccountStatus> AccountStatuses()
        {
            var endpoint = string.Format("Portfolio/AccountStatuses");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountStatus>>(j);

            return d;
        }

        public List<AccountTypeSimple> AccountTypes()
        {
            var endpoint = string.Format("Portfolio/Registrations/Types");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<AccountTypeSimple>>(j);

            return d;
        }

        public List<Simple> BrokerDealersSimple()
        {
            var endpoint = string.Format("Portfolio/BrokerDealers/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<Simple> CustodiansSimple()
        {
            var endpoint = string.Format("Portfolio/Custodians/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<Simple> FundFamiliesSimple()
        {
            var endpoint = string.Format("Portfolio/FundFamilies/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<RepresentativeSimple> RepresentativesSimple()
        {
            var endpoint = string.Format("Portfolio/Representatives/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<RepresentativeSimple>>(j);

            return d;
        }

        public List<Simple> PlatformsSimple()
        {
            var endpoint = string.Format("Portfolio/Platforms/Simple");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }

        public List<ProductCategory> ProductCategories()
        {
            var endpoint = string.Format("Portfolio/ProductCategories");
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<ProductCategory>>(j);

            return d;
        }

        #endregion

        private string FDate(DateTime? d)
        {
            if(d.HasValue)
                return d.Value.ToString("yyyy-MM-dd");
            else
                return null;
        }
    }
}
