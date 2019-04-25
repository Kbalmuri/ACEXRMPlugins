using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Crm.Sdk.Messages;
using System.Reflection;

namespace BillCodes_Calsi {
    class Program {


        private struct InterestField {
            public string CheckBoxFieldName;
            public string DropDwonFieldName;
        }

        List<InterestField> interestField = new List<InterestField>();
        //public struct ContactInterestAttributes {

        //    public string name;
        //    public ContactInterestAttributes(string game) {
        //        this.name = "Kiran";
        //    }

        //    //public static string[] InterestAdvocacyforHE = { "aceit_interestadvocacyforhe_checkbox", "aceit_interest_advocacyfor_he" };
        //    //public static string[] InterestAnnualMeeting = { "aceit_interest_annualmeeting_checkbox", "aceit_interest_annualmeeting" };
        //    //public static string[] InterestAdultLearning = { "aceit_interestadultlearning_checkbox", "aceit_interest_adult_learning" };
        //    //public static string[] InterestCREDITCorporateCPL = { "aceit_interestcupinstitutionalcpl_checkbox", "aceit_interest_cup_institutionalcpl" };
        //}
       static void Main(string[] args) {
            
     
    }

        public void Init() {
            interestField.Add(new InterestField() {
                CheckBoxFieldName = "aceit_interestadvocacyforhe_checkbox",
                DropDwonFieldName = "aceit_interest_intlizationglobalization"
            }

 );
            //add other fields here ...
        }
        }
    }

   



            // Get the connection string saved in App.config.
            //string CRM_String_Connection = ConfigurationManager.ConnectionStrings["CRM_String_Connection"].ConnectionString;

            //// Do the actual connection to CRM using a CRM Service Client object, sending user credentials as parameter.
            //CrmServiceClient crmConn = new CrmServiceClient(CRM_String_Connection);

            //// Get Organization Service Proxy. This is needed to excecute any CRUD operation in CRM.
            //IOrganizationService crmService = crmConn.OrganizationServiceProxy;

            //Guid listGuid = new Guid("DB540FF0-32DB-E511-B8BC-0050569E5B20");
            ////8D90799D-1499-E511-9DFF-0050569E5B20
            ////08F96234-0852-E811-80F6-005056869FFC

            //Entity listEntity = crmService.Retrieve("list", listGuid, new ColumnSet("query", "createdfromcode"));

            //int entityCode = (int)listEntity.GetAttributeValue<OptionSetValue>("createdfromcode").Value;
            //string columnName = string.Empty;
            //if(entityCode == 1) {
            //    columnName = "accountid";
            //}else if (entityCode == 2) {
            //    columnName = "contactid";
            //}
            //else {
            //    columnName = "leadid";
            //}
            //    var fetchQuery = (string)listEntity.Attributes["query"];
            //    // Convert the FetchXML into a query expression.
            //    var conversionRequest = new FetchXmlToQueryExpressionRequest {
            //        FetchXml = fetchQuery
            //    };
            //    var conversionResponse =(FetchXmlToQueryExpressionResponse)crmService.Execute(conversionRequest);


            //    int fetchCount = 5000;
            //    int pageNumber = 1;

            //    QueryExpression queryExpression = conversionResponse.Query;
            //    queryExpression.NoLock = true;
            //    queryExpression.PageInfo = new PagingInfo();
            //    queryExpression.PageInfo.Count = fetchCount;
            //    queryExpression.PageInfo.PageNumber = pageNumber;
            //    queryExpression.PageInfo.PagingCookie = null;
            //queryExpression.ColumnSet = new ColumnSet();
            //queryExpression.ColumnSet.Columns.Add(columnName);

            //int totalcountresult = 0;
            //    while (true) {
            //        EntityCollection collections = crmService.RetrieveMultiple(queryExpression);
            //        if (collections.Entities.Count > 0) {

            //        totalcountresult = totalcountresult + collections.Entities.Count;

            //        }
            //        if (collections.MoreRecords) {
            //            queryExpression.PageInfo.PageNumber++;
            //            queryExpression.PageInfo.PagingCookie = collections.PagingCookie;
            //        }
            //        else {
            //            break;
            //        }

            //    }



            //EntityCollection result = crmService.RetrieveMultiple(queryExpression);

            // Run the query with the FetchXML.
            //var fetchExpression = new FetchExpression(fetchQuery);
            //EntityCollection fetchResult = crmService.RetrieveMultiple(fetchExpression);

            //int count = result.Entities.Count;

            //string xml = CreateXml()












            //List<Entity> allIPEDS = GetAllAccount(crmService);

            //if (allIPEDS.Count > 0) {
            //    foreach (var child in allIPEDS) {


            //    }
            //}

            // Console.WriteLine("IPEDS Org Name: {0}", child["ace_name"]);
            //Console.ReadLine();

      

        //private static List<Entity> GetAllAccount(IOrganizationService crmService) {
        //    int i = 0;
        //    int fetchCount = 5000;
        //    int pageNumber = 1;
        //    List<Entity> AllAccount = new List<Entity>();
        //    QueryExpression ipedsQuery = new QueryExpression("ace_organizationipeds");
        //    ipedsQuery.NoLock = true;
        //    ipedsQuery.ColumnSet = new ColumnSet();
        //    ipedsQuery.ColumnSet.Columns.Add("ace_billcode");
        //    ipedsQuery.ColumnSet.Columns.Add("ace_generalexpensesbudget");
        //    ipedsQuery.ColumnSet.Columns.Add("ace_ipedsduesyear");
        //    ipedsQuery.ColumnSet.Columns.Add("ace_twoorfouryear");
        //    ipedsQuery.ColumnSet.Columns.Add("ace_fulltimeenrollment");
        //    ipedsQuery.ColumnSet.Columns.Add("ace_duesbilltoid");
        //    FilterExpression andFilter = new FilterExpression(LogicalOperator.And);
        //    andFilter.AddCondition("statecode", ConditionOperator.Equal, 0);

        //    ipedsQuery.Criteria.AddFilter(andFilter);

        //    ipedsQuery.LinkEntities.Add(new LinkEntity("ace_organizationipeds", "account", "ace_organizationid", "accountid", JoinOperator.Inner));
        //    ipedsQuery.LinkEntities[0].EntityAlias = "primarycontact";

        //    //link to account entity
        //    //LinkEntity linkAccount = new LinkEntity("ace_organizationipeds", "account", "ace_organizationid", "accountid", JoinOperator.Inner);     
        //    //ipedsQuery.LinkEntities.Add(linkAccount);

        //    ipedsQuery.PageInfo = new PagingInfo();
        //    ipedsQuery.PageInfo.Count = fetchCount;
        //    ipedsQuery.PageInfo.PageNumber = pageNumber;
        //    ipedsQuery.PageInfo.PagingCookie = null;

        //    while (true) {
        //        EntityCollection collections = crmService.RetrieveMultiple(ipedsQuery);
                
        //        if (collections.Entities.Count > 0) {

        //            foreach (Entity e in collections.Entities) {
        //                i++;

        //                AllAccount.Add(e);

        //            }
        //        }
        //        if (collections.MoreRecords) {
        //            ipedsQuery.PageInfo.PageNumber++;
        //            ipedsQuery.PageInfo.PagingCookie = collections.PagingCookie;
        //        }
        //        else {
        //            break;
        //        }

        //    }
        //    return AllAccount;
        //}
    

