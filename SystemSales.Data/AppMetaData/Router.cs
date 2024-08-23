namespace SystemSales.Data.AppMetaData
{
    public class Router
    {
        public const string SingleRoute = "/{id}";
        public const string Url = "APi";
        public static class CustomerRoute
        {
            public const string prefix = Url + "/Customer";
            public const string List = prefix + "/List";
            public const string GetByCode = prefix + "/customerCode";
            public const string Create = prefix + "/Create";
            public const string Edit = prefix + "/Edit";
            public const string Delete = prefix + "/Delete" + "/{item}";
            public const string Paginated = prefix + "/Paginated";
            public const string Search = prefix + "/Search";
        }
        public static class CustomerTransactionRoute
        {
            public const string prefix = Url + "/CustomerTransaction";
            public const string List = prefix + "/List";
            public const string GetByCode = prefix + "/customerCode";
            public const string Create = prefix + "/Create";
            public const string Edit = prefix + "/Edit";
            public const string Delete = prefix + "/Delete" + SingleRoute;
            public const string Paginated = prefix + "/Paginated";
            public const string Search = prefix + "/Search";
        }
    }
}
