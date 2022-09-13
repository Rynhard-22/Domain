namespace AbiDemoBlazor.Helper
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed internal class QueryStringToUpperAttribute : Attribute
    {
    }
}
