namespace StorefrontRetail.Helpers
{
    public static class GlobalSetting
    {
        private const string BASE_URL = "https://10.0.2.2:5001/api";
        public static readonly string PromotionalProductUrl = $"{BASE_URL}/product/get-promotional-products";
    }
}