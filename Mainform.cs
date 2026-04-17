namespace Tyrtyvshin
{
    public partial class Mainform : Form
    {
        private Control? _currentPage;
        private Button? _currentNavButton;

        public Mainform()
        {
            InitializeComponent();
            ApplyTheme();
            ShowHome();
        }

        private static class UiTheme
        {
            public static readonly Color Background = Color.FromArgb(11, 16, 32);    
            public static readonly Color Surface = Color.FromArgb(17, 26, 46);       
            public static readonly Color Surface2 = Color.FromArgb(15, 23, 48);      
            public static readonly Color Accent = Color.FromArgb(124, 58, 237);     
            public static readonly Color Text = Color.FromArgb(229, 231, 235);      
            public static readonly Color Muted = Color.FromArgb(156, 163, 175);      
        }

        private void ApplyTheme()
        {
            Font = new Font("Segoe UI", 10f);
            BackColor = UiTheme.Background;
            ForeColor = UiTheme.Text;

            sidebarPanel.BackColor = UiTheme.Surface;
            navHeaderPanel.BackColor = UiTheme.Surface;
            topBarPanel.BackColor = UiTheme.Surface;
            contentPanel.BackColor = UiTheme.Background;

            lblAppName.ForeColor = Color.White;
            lblPageTitle.ForeColor = Color.White;

            StyleNavButton(btnNavMovies);
            StyleNavButton(btnNavReviewers);
            StyleNavButton(btnNavReports);
            StyleNavButton(btnNavSettings);
            StyleNavButton(btnNavLogout, isLogout: true);
        }

        private void StyleNavButton(Button btn, bool isLogout = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(16, 0, 0, 0);
            btn.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            btn.BackColor = UiTheme.Surface;
            btn.ForeColor = isLogout ? UiTheme.Muted : UiTheme.Text;

            btn.MouseEnter += (s, e) =>
            {
                if (_currentNavButton == btn) return;
                btn.BackColor = UiTheme.Surface2;
            };
            btn.MouseLeave += (s, e) =>
            {
                if (_currentNavButton == btn) return;
                btn.BackColor = UiTheme.Surface;
            };
        }

        private void SetActiveNav(Button btn)
        {
            if (_currentNavButton != null)
            {
                _currentNavButton.BackColor = UiTheme.Surface;
                _currentNavButton.ForeColor = _currentNavButton == btnNavLogout ? UiTheme.Muted : UiTheme.Text;
            }

            _currentNavButton = btn;
            btn.BackColor = UiTheme.Accent;
            btn.ForeColor = Color.White;
        }

        private void ShowPage(Control page, string title, Button navButton)
        {
            lblPageTitle.Text = title;
            SetActiveNav(navButton);

            contentPanel.SuspendLayout();
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
            contentPanel.ResumeLayout();

            _currentPage = page;
        }

        private void ShowHome()
        {
            var home = new Panel { BackColor = UiTheme.Background, Dock = DockStyle.Fill };
            var title = new Label
            {
                AutoSize = true,
                Text = "Welcome",
                Font = new Font("Segoe UI", 22f, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(32, 32)
            };
            var sub = new Label
            {
                AutoSize = true,
                Text = "Use the sidebar to navigate.",
                Font = new Font("Segoe UI", 11f),
                ForeColor = UiTheme.Muted,
                Location = new Point(34, 80)
            };
            home.Controls.Add(title);
            home.Controls.Add(sub);

            // Home is represented by Movies as the first page for now.
            ShowPage(home, "Home", btnNavMovies);
        }

        private sealed class PlaceholderPage : UserControl
        {
            public PlaceholderPage(string title, string subtitle)
            {
                Dock = DockStyle.Fill;
                BackColor = UiTheme.Background;

                var lblTitle = new Label
                {
                    AutoSize = true,
                    Text = title,
                    Font = new Font("Segoe UI", 18f, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(32, 32)
                };
                var lblSub = new Label
                {
                    AutoSize = true,
                    Text = subtitle,
                    Font = new Font("Segoe UI", 11f),
                    ForeColor = UiTheme.Muted,
                    Location = new Point(34, 74)
                };
                Controls.Add(lblTitle);
                Controls.Add(lblSub);
            }
        }

        private void btnNavMovies_Click(object sender, EventArgs e)
        {
            var page = new PlaceholderPage("Movies", "Movie list page will be added next.");
            ShowPage(page, "Movies", btnNavMovies);
            MovieForm mf = new MovieForm();
            mf.ShowDialog();
            this.Hide();
        }

        private void btnNavReviewers_Click(object sender, EventArgs e)
        {
            var page = new PlaceholderPage("Reviewers", "Reviewer management page will be added next.");
            ShowPage(page, "Reviewers", btnNavReviewers);
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            var page = new PlaceholderPage("Reports", "Top Movies / Top Reviewers dashboards will be added next.");
            ShowPage(page, "Reports", btnNavReports);
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            var page = new PlaceholderPage("Settings", "Theme and preferences page will be added next.");
            ShowPage(page, "Settings", btnNavSettings);
        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.Show();
            Close();
        }
    }
}
