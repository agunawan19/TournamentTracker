using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        public TournamentViewerForm()
        {
            InitializeComponent();
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {
            Translate();
        }

        private void Translate()
        {
            Text = Localization.Resources.TournamentViewerTitle;
            headerLabel.Text = Localization.Resources.TournamentViewerHeaderLabel;
            tournamentNameLabel.Text = Localization.Resources.None;
            translateToFrenchButton.Text = Localization.Resources.French;
            translateToEnglishButton.Text = Localization.Resources.English;
            translateToJapaneseButton.Text = Localization.Resources.Japanese;
        }

        private void TranslateToFrenchButton_Click(object sender, EventArgs e)
        {
            TranslateTo("fr");
        }

        private void TranslateToEnglishButton_Click(object sender, EventArgs e)
        {
            TranslateTo("en");
        }

        private void TranslateToJapaneseButton_Click(object sender, EventArgs e)
        {
            TranslateTo("ja");
        }

        private void TranslateTo(string cultureName)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureName);

            if (Thread.CurrentThread.CurrentUICulture.Name == cultureInfo.Name)
            {
                return;
            }

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Translate();
            SetControlsLayout();
        }

        private void SetControlsLayout()
        {
            tournamentNameLabel.Left = headerLabel.Width + 20;
        }
    }
}
