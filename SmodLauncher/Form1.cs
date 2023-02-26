using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using DiscordRPC;
using DiscordRPC.Logging;

namespace SmodLauncher
{


    public partial class Form1 : Form
    {

        public DiscordRpcClient client;
        public DiscordRpcClient killme;
        bool hasbeenstarted = false;

        void Initialize()
        {

            client = new DiscordRpcClient("1079144109031301221");

            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "singleplayer",
                State = "in launcher",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "st's mod",
                }
            });
        }

        void SetPlayingStatus()
        {

            killme = new DiscordRpcClient("1079144109031301221");

            killme.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            killme.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            killme.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            killme.Initialize();

            killme.SetPresence(new RichPresence()
            {
                Details = "singleplayer",
                State = "playing",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "st's mod",
                }
            });
        }

        public Form1()
        {
            InitializeComponent();
            Initialize();
            if (System.Environment.HasShutdownStarted)
            {
                client.Dispose();
                // eh, idrk probably will do it unless game was launched
                if (hasbeenstarted == true)
                {
                    // dont do anything
                }
                if (hasbeenstarted == false)
                {
                    // never been launched (why the fuck are you even using the launcher?)
                    killme.Dispose();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process st = new Process();
            st.StartInfo.FileName = Environment.CurrentDirectory + @"\stmod.exe ";
            st.StartInfo.Arguments = "-game smod";
            st.Start();
            bool hasbeenlaunched = true;
            SetPlayingStatus();
            var isRunning = !st.HasExited;
            void p_Exited(object sender, EventArgs e)
            {
                killme.Dispose();
                Initialize();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process marketplace = new Process();
            marketplace.StartInfo.FileName = @"C:\Windows\explorer.exe ";
            marketplace.StartInfo.Arguments = "https://discord.gg/QaESs7NnfH";
            marketplace.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process hammerplusplus = new Process();
            hammerplusplus.StartInfo.FileName = Environment.CurrentDirectory + @"\bin\hammerplusplus.exe ";
            hammerplusplus.Start();
        }
    }
}