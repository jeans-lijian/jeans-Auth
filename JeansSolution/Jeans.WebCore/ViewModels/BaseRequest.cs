namespace Jeans.WebCore.ViewModels
{
    public class BaseRequest
    {
        public int Draw { get; set; }

        public int Start { get; set; } = 1;

        public int Length { get; set; } = 10;

        public int PageIndex
        {
            get
            {
                return (Start / Length) + 1;
            }
        }
    }
}
