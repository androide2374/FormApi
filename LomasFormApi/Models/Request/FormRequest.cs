namespace LomasFormApi.Models.Request
{
    public class FormRequest
    {
        public string Description { get; set; } = null!;
        public int FormType { get; set; }
        public string Name { get; set; } = null!;
        public string UserId { get; set; }
    }
}
