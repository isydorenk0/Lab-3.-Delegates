using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Common.GetPlayableType;
using static Common.GetPlayback;

namespace LabC
{
    public partial class ShowPlaybackForm : Form
    {
        public ShowPlaybackForm()
        {
            InitializeComponent();
            var enumValues = Enum.GetValues(typeof(HeadSetTypes)).Cast<object>().Select(x => new { Value = x, Name = x.ToString() }).ToList();
            this.Playback.DataSource = enumValues;
            this.Playback.ValueMember = "Value";
            this.Playback.DisplayMember = "Name";
            this.Playback.DrawMode = DrawMode.OwnerDrawFixed;
            this.Playback.ItemHeight = RadioButtonRenderer.GetGlyphSize(
                Graphics.FromHwnd(IntPtr.Zero),
                        RadioButtonState.CheckedNormal).Height + 4;
            this.Playback.DrawItem += (obj, ea) =>
            {
                var lb = (ListBox)obj;
                ea.DrawBackground();
                var text = lb.GetItemText(lb.Items[ea.Index]);
                var r = ea.Bounds;
                r.Offset(ea.Bounds.Height, 0);
                RadioButtonRenderer.DrawRadioButton(ea.Graphics,
                    new Point(ea.Bounds.Location.X, ea.Bounds.Location.Y + 2), r, text,
                    lb.Font, TextFormatFlags.Left, false,
                    (ea.State & DrawItemState.Selected) == DrawItemState.Selected ?
                    RadioButtonState.CheckedNormal : RadioButtonState.UncheckedNormal);
            };
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            textOutput.Clear();
            var selected = Playback.SelectedValue;
            HeadSetTypes selectedType;
            if (!Enum.TryParse(selected.ToString(), out selectedType))
            {
                MessageBox.Show("Try again", "Parsing error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                textOutput.Text = $"{selectedType.ToString()} playback selected";
                textOutput.Text += Environment.NewLine;
                textOutput.Text += "Set playback to Mobile...";
                textOutput.Text += Environment.NewLine;
                textOutput.Text += "Play sound in Mobile:";
                textOutput.Text += Environment.NewLine;
                IPlayback headSetPlay = GetPlaybackType(selectedType);
                headSetPlay.Display(textOutput);   
            }
        }
    }
}
