using Domain.Entities;
using System.Text.Json.Serialization;
using static Domain.Enumerados.Enums;

namespace LomasFormApi.Models.Request
{
    public class QuestionRequestForm
    {
        public string FormId { get; set; }
        public ICollection<QuestionRequest> Questions { get; set; }
    }
    public class QuestionRequest
    {
        public string QuestionText { get; set; }
        public string QuestionImage { get; set; }
        public QuestionTypes QuestionType { get; set; }

        public ICollection<OptionsRequest> Options { get; set; }
    }
    public class OptionsRequest
    {
        public string OptionImage { get; set; }
        public string OptionText { get; set; }
    }
}
