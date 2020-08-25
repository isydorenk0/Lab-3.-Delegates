using System.Windows.Forms;

namespace LabC
{
    public class PhoneSpeaker : IPlayback
    {
        private IOutput Output;
        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        public void Display(TextBox data)
        {
            Output.DisplayLine(data, $"{nameof(PhoneSpeaker)} sound");
        }
    }
}
