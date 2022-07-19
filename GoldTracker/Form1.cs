

namespace GoldTracker
{
    using GW2Api.NET.V2;
    using System.Threading.Tasks;

    public partial class Form1 : Form
    {
        int currTimer = 0;
        int startingCoins = 0;
        int updateTimer = 0;

        int theme = 0;

        string apiKey = "";

        Color dark_bg = Color.FromArgb(44, 54, 57);
        Color dark_title = Color.FromArgb(162, 123, 92);
        Color dark_label = Color.FromArgb(165, 201, 202);
        Color dark_text = Color.FromArgb(231, 246, 242);
        Color dark_button = Color.FromArgb(220, 215, 201);

        public Form1()
        {
            InitializeComponent();
            Text = "GW2GT";
            

            if (File.Exists("api.txt"))
            {
                string apiKey = File.ReadAllText("api.txt");
                APITextBox.Text = apiKey;
            }

            if (File.Exists("settings.txt"))
            {
                string settings = File.ReadAllText("settings.txt");
                theme = Int32.Parse(settings);
                if(theme == 1)
                {
                    ChangeTheme(dark_bg, dark_title, dark_label, dark_text, dark_button, FlatStyle.Flat);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void TimerButton1_Click(object sender, EventArgs e)
        {
            APIErrorLabel.Text = "";

            string curr = TimerButton1.Text;
            if (curr == "Start Timer")
            {
                if (string.IsNullOrEmpty(APITextBox.Text))
                {
                    APIErrorLabel.Text = "You need to enter your API key!";
                    return;
                }              
                StartTimer();
            } else
            {
                TimerButton1.Text = "Start Timer";
                StopTimer();
            }
        }

        private void APILinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://account.arena.net/applications");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        async void StartTimer()
        {          
            apiKey = APITextBox.Text;

            await File.WriteAllTextAsync("api.txt", apiKey);

            currTimer = 0;
            TimeLabel.Text = currTimer.ToString() + "s";

            int[] wallet = await GetCoins();

            if (wallet[0] == -2)
            {
                APIErrorLabel.Text = "API key is invalid!";
                return;
            }

            TimerButton1.Text = "Stop Timer";

            startingCoins = wallet[3];

            SetStartingCoins(wallet[0], wallet[1], wallet[2]);
            SetCurrentCoins(0, 0, 0);
            SetChangeCoins(0, 0, 0);
            ChangeGoldLabel.ForeColor = Color.Gray;
            ChangeSilverLabel.ForeColor = Color.Gray;
            ChangeBronzeLabel.ForeColor = Color.Gray;

            updateTimer = 600;
            SetUpdateTimer();

            timer.Start();
        }
        
        async Task<int[]> GetCoins()
        {
            var api = new Gw2ApiV2(new HttpClient())
            {
                ApiKey = apiKey
            };

            int[] output;

            try
            {
                var result = await api.GetAccountWalletAsync();
                int coins = result[0].Value;
                int[] wallet = DivideCoins(coins);
                output = new int[] { wallet[0], wallet[1], wallet[2], coins };                
            }
            catch (HttpRequestException httpError)
            {

                return new int[] { -2 };
            }

            return output;
        }

        string FormatCoin(string type, int amt)
        {
            int len = amt.ToString().Length;
            if (type == "gold")
            {
                if (len < 4)
                {
                    int zeros = 4 - len;
                    string format = "";
                    for (int i = 0; i < zeros; i++)
                    {
                        format += "0";
                    }
                    return format + amt.ToString();
                } 
                return amt.ToString();
                
            } else if (type == "silver" || type == "bronze")
            {
                if(len == 1)
                {
                    return "0" + amt.ToString();
                }
                return amt.ToString();

            }
            return "ERROR";
        }
            

        void SetStartingCoins(int gold, int silver, int bronze)
        {
            StartingGoldLabel.Text = FormatCoin("gold", gold);
            StartingSilverLabel.Text = FormatCoin("silver", silver);
            StartingBronzeLabel.Text = FormatCoin("bronze", bronze);
        }

        void SetCurrentCoins(int gold, int silver, int bronze)
        {
            CurrentGoldLabel.Text = FormatCoin("gold", gold);
            CurrentSilverLabel.Text = FormatCoin("silver", silver);
            CurrentBronzeLabel.Text = FormatCoin("bronze", bronze);
        }

        void SetChangeCoins(int gold, int silver, int bronze)
        {
            ChangeGoldLabel.Text = FormatCoin("gold", gold);
            ChangeSilverLabel.Text = FormatCoin("silver", silver);
            ChangeBronzeLabel.Text = FormatCoin("bronze", bronze);
        }

        void SetUpdateTimer()
        {
            UpdateTitleLabel.Text = "Update in " + updateTimer.ToString() + "s";
        }

        void StopTimer()
        {
            timer.Stop();
        }

        async void timer_Tick(object sender, EventArgs e)
        {
            SetUpdateTimer();
            updateTimer -= 1;

            TimeLabel.Text = currTimer.ToString() + "s";
            currTimer += 1;

            if (currTimer % 600 == 0)
            {
                updateTimer = 600;

                int[] wallet = await GetCoins();
                SetCurrentCoins(wallet[0], wallet[1], wallet[2]);

                int change = wallet[3] - startingCoins;
                int[] changeWallet = DivideCoins(Math.Abs(change));
                SetChangeCoins(changeWallet[0], changeWallet[1], changeWallet[2]);

                if (change > 0)
                {
                    ChangeGoldLabel.ForeColor = Color.Green;
                    ChangeSilverLabel.ForeColor = Color.Green;
                    ChangeBronzeLabel.ForeColor = Color.Green;
                }
                else if (change < 0)
                {
                    ChangeGoldLabel.ForeColor = Color.Red;
                    ChangeSilverLabel.ForeColor = Color.Red;
                    ChangeBronzeLabel.ForeColor = Color.Red;
                }
                else 
                {
                    ChangeGoldLabel.ForeColor = Color.Gray; 
                    ChangeSilverLabel.ForeColor = Color.Gray; 
                    ChangeBronzeLabel.ForeColor = Color.Gray; 
                }  
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void StartingGoldLabel_Click(object sender, EventArgs e)
        {

        }

        int[] DivideCoins(int coins)
        {
            bool bronze_done = false;
            bool silver_done = false;

            int bronze = coins; int silver = 0; int gold = 0;

            while (!bronze_done)
            {
                if (bronze - 100 >= 0)
                {
                    bronze -= 100;
                    silver += 1;
                }
                else
                {
                    bronze_done = true;
                }
            }

            while (!silver_done)
            {
                if (silver - 100 >= 0)
                {
                    silver -= 100;
                    gold += 1;
                }
                else
                {
                    silver_done = true;
                }
            }
            int[] output = new int[] { gold, silver, bronze };
            return output;
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        void ChangeTheme(Color background, Color title, Color labels, Color text, Color button, FlatStyle buttonStyle)
        {
            BackColor = background;
            titlelabel1.ForeColor = title;

            APIKeyLabel.ForeColor = labels;
            label1.ForeColor = labels;
            label2.ForeColor = labels;
            label3.ForeColor = labels;
            UpdateTitleLabel.ForeColor = labels;
            TimeLabel.ForeColor = labels; 

            StartingBronzeLabel.ForeColor = text;
            StartingSilverLabel.ForeColor = text;
            StartingGoldLabel.ForeColor = text;
            CurrentBronzeLabel.ForeColor = text;
            CurrentSilverLabel.ForeColor = text;
            CurrentGoldLabel.ForeColor = text;

            TimerButton1.BackColor = button;
            TimerButton1.FlatStyle = buttonStyle;
            TimerButton1.FlatAppearance.BorderColor = Color.Black;
            TimerButton1.FlatAppearance.BorderSize = 1;
            ToggleTheme.BackColor = button;
            ToggleTheme.FlatStyle = buttonStyle;
            ToggleTheme.FlatAppearance.BorderColor = Color.Black;
            ToggleTheme.FlatAppearance.BorderSize = 1;
        }

        async void ToggleTheme_Click(object sender, EventArgs e)
        {
            theme++;
            await File.WriteAllTextAsync("settings.txt", theme.ToString());

            if (theme == 0)
            {
                // Standard Theme
                ChangeTheme(Color.WhiteSmoke, Color.Black, Color.Black, Color.Black, Color.White, FlatStyle.Standard);
            }
            else if(theme == 1)
            {
                // Dark Theme
                ChangeTheme(dark_bg, dark_title, dark_label, dark_text, dark_button, FlatStyle.Flat);
            } else
            {
                // Standard Theme
                theme = 0;
                ChangeTheme(Color.WhiteSmoke, Color.Black, Color.Black, Color.Black, Color.White, FlatStyle.Standard);
            }
        }
    }
}