using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoBot
{
    public partial class Form1 : Form
    {
        private Timer _timer;
        private int _minutesRemaining;

        private enum PomodoroState
        {
            Working,
            Idle
        }

        HardwareStatusDisplayInterface HardwareDisplay = new HardwareStatusDisplayInterface();
        TeamChatInterface Chat = new TeamChatInterface();

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
        private const int APPCOMMAND_MEDIA_PLAY_PAUSE = 0xE0000;
        private const int APPCOMMAND_MEDIA_STOP = 0xD0000;

        private const int POMODORO_MINUTES = 25;
        private const string IDLE_TEXT = "Idle";

        private const string WORKING_SERIAL_COMMAND = "w";
        private const string IDLE_SERIAL_COMMAND = "i";

        private const string END_SOUND_PATH = "91926__corsica-s__ding.wav";

        private PomodoroState _currentState = PomodoroState.Idle;



        public Form1()
        {
            InitializeComponent();
            if (!HardwareDisplay.CanInitialize())
            {
                sendSerialCommandCheckbox.Checked = false;
                sendSerialCommandCheckbox.Enabled = false;
            }

            if (!Chat.CanInitialize())
            {
                setChatStatusCheckbox.Checked = false;
                setChatStatusCheckbox.Enabled = false;
            }

            SetupTimer();

            _minutesRemaining = POMODORO_MINUTES;
            SetWorkingState(PomodoroState.Idle);

        }

        private void SetupTimer()
        {
            _timer = new Timer();
            _timer.Tick += new EventHandler(_timer_tick);
            _timer.Interval = 60 * 1000;  // One minute


        }

        private void _timer_tick(object sender, EventArgs e)
        {
            _minutesRemaining--;

            if (_minutesRemaining <= 0)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(END_SOUND_PATH);
                player.Play();

                SetWorkingState(PomodoroState.Idle);
            }

            updateStatusLabel();
            updateWindowTitle();
            //updateLyncStatus();
        }

        private void SetWorkingState(PomodoroState newState)
        {
            _currentState = newState;
            if (newState == PomodoroState.Working && _minutesRemaining <= 0) _minutesRemaining = POMODORO_MINUTES;

            //updateLyncStatus();
            updateStatusLabel();
            updateWindowTitle();
            //sendArduinoCommand();

            if (newState == PomodoroState.Idle)
            {
                _timer.Stop();
                ResetButton.Enabled = true;
                //axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            else if (newState == PomodoroState.Working)
            {
                _timer.Start();
                ResetButton.Enabled = false;
                //axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            _minutesRemaining = POMODORO_MINUTES;
            updateStatusLabel();
            updateWindowTitle();
        }

        void updateStatusLabel()
        {
            switch (_currentState)
            {
                case PomodoroState.Idle:
                    currentStateLabel.Text = _minutesRemaining.ToString() + "  (paused)";
                    break;

                case PomodoroState.Working:
                    currentStateLabel.Text = _minutesRemaining.ToString();
                    break;
            }
        }

        void updateWindowTitle()
        {
            string text = "";

            switch (_currentState)
            {
                case PomodoroState.Idle:
                    text = "Pomodoro Automator [Idle]";
                    break;
                case PomodoroState.Working:
                    text = "Pomodoro Automator [" + _minutesRemaining.ToString() + "]";
                    break;
            }

            this.Text = text;
            //notifyIcon1.Text = text;
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            this.ToggleWorkingState();
        }

        private void ToggleWorkingState()
        {
            switch (_currentState)
            {
                case PomodoroState.Idle:
                    SetWorkingState(PomodoroState.Working);
                    break;
                case PomodoroState.Working:
                    SetWorkingState(PomodoroState.Idle);
                    break;
            }


        }
    }
}
