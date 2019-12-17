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

        private void Form1_Load(object sender, EventArgs e)
        {
            Translate();
        }

        private void Translate()
        {
            Text = Localization.Resource.TournamentViewerTitle;
            headerLabel.Text = Localization.Resource.TournamentViewerHeaderLabel;
            tournamentName.Text = Localization.Resource.None;
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TranslateTo("fr-FR");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TranslateTo("en-US");
        }
    }
}
