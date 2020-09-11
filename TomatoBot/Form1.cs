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

        HardwareStatusDisplayInterface HardwareStatus = new HardwareStatusDisplayInterface();

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
            if (!HardwareStatus.CanInitialize())
            {
                sendSerialCommandCheckbox.Checked = false;
                sendSerialCommandCheckbox.Enabled = false;
            }


        }

    }
}
