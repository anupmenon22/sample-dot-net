using System.ComponentModel.DataAnnotations;

namespace SampleDotNetApp.Models
{
    public class MessageModel
    {
        [Display(Name = "Your Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Your Message")]
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }

        public string Result { get; set; }
        public bool IsSuccess { get; set; }
        public bool ShowResult { get; set; }
    }
}
