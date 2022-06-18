namespace BLL.Model.Query
{
    public class QueryModel
    {
        public string Contain { get; set; } = "";

        public bool Asc { get; set; } = true;

        public string OrderBy { get; set; } = "Id";

        public int Skip { get; set; } = 0;

        public int Take { get; set; } = 10;

        public string[]? Tables { get; set; } = new string[0];
    }
}
