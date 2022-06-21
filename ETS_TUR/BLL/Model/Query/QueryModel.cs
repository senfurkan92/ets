namespace BLL.Model.Query
{
    public class QueryModel
    {
        public string Contain { get; set; } = "";

        public bool Asc { get; set; } = true;

        public string OrderBy { get; set; } = "Id";

        public int Skip { get; set; } = 0;

        public int Take { get; set; } = -1;

        public string[]? Tables { get; set; } = new string[0];
    }

    public class ActivityQueryModel : QueryModel
    {
        public int? categoryId { get; set; }
        public bool Active { get; set; } = true;
    }
}
