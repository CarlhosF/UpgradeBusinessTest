namespace UpgradeBusinessTest._02.Core.Wrappers
{
    public class PageWrapper<TEntity>
    {
        public int TotalRecords { get; set; }
        public int TotalPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public TEntity Data { get; set; }
    }
}
