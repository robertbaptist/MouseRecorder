using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MouseRecorder
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENT_MOVE = 0x01;
        private const int MOUSEEVENT_LEFTDOWN = 0x02;
        private const int MOUSEEVENT_LEFTUP = 0x04;
        private const int MOUSEEVENT_RIGHTDOWN = 0x08;
        private const int MOUSEEVENT_RIGHTUP = 0x10;
        private const int MOUSEEVENT_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENT_MIDDLEUP = 0x40;

        private struct _MouseAction
        {
            public Point Position;
            public MouseButtons Button;
        }

        private int _index = 0;
        private int _count = 0;

        private MouseButtons _currentButton;

        private List<_MouseAction> _mouseActions = new List<_MouseAction>();

        public Form1()
        {
            InitializeComponent();
            _playButton.Enabled = false;
            _stopButton.Enabled = false;
        }

        private void _playButton_Click(object sender, EventArgs e)
        {
            _playButton.Enabled = false;
            _recordButton.Enabled = false;
            _count = 0;
            _playTimer.Start();
        }

        private void _stopButton_Click(object sender, EventArgs e)
        {
            _recordButton.Enabled = true;
            _recordTimer.Stop();
            _playButton.Enabled = true;
            _stopButton.Enabled = false;
        }

        private void _recordButton_Click(object sender, EventArgs e)
        {
            _recordButton.Enabled = false;
            _mouseActions.Clear();
            _recordTimer.Start();
            _stopButton.Enabled = true;
        }

        private void _playTimer_Tick(object sender, EventArgs e)
        {
            if (_index < _mouseActions.Count)
            {
                _MouseAction mouseAction = _mouseActions[_index++];

                Cursor.Position = mouseAction.Position;

                if (_currentButton == MouseButtons.Left && mouseAction.Button != MouseButtons.Left)
                {
                    mouse_event(MOUSEEVENT_LEFTUP, (uint)mouseAction.Position.X, (uint)mouseAction.Position.Y, 0, 0);
                }
                else if (_currentButton == MouseButtons.Right && mouseAction.Button != MouseButtons.Right)
                {
                    mouse_event(MOUSEEVENT_RIGHTUP, (uint)mouseAction.Position.X, (uint)mouseAction.Position.Y, 0, 0);
                }
                else if (_currentButton == MouseButtons.Middle && mouseAction.Button != MouseButtons.Middle)
                {
                    mouse_event(MOUSEEVENT_MIDDLEUP, (uint)mouseAction.Position.X, (uint)mouseAction.Position.Y, 0, 0);
                }

                switch (mouseAction.Button)
                {
                    case MouseButtons.Left:
                        if (_currentButton != MouseButtons.Left)
                            mouse_event(MOUSEEVENT_LEFTDOWN, (uint)mouseAction.Position.X, (uint)mouseAction.Position.Y, 0, 0);
                        break;

                    case MouseButtons.Right:
                        if (_currentButton != MouseButtons.Right)
                            mouse_event(MOUSEEVENT_RIGHTDOWN, (uint)mouseAction.Position.X, (uint)mouseAction.Position.Y, 0, 0);
                        break;

                    case MouseButtons.Middle:
                        if (_currentButton != MouseButtons.Middle)
                            mouse_event(MOUSEEVENT_MIDDLEDOWN, (uint)mouseAction.Position.X, (uint)mouseAction.Position.Y, 0, 0);
                        break;
                }

                _currentButton = mouseAction.Button;

            }
            else
            {
                _index = 0;
                if (++_count == _repeatCounter.Value)
                {
                    _playButton.Enabled = true;
                    _playTimer.Stop();
                    _recordButton.Enabled = true;
                }
            }
        }

        private void _recordTimer_Tick(object sender, EventArgs e)
        {
            _mouseActions.Add(new _MouseAction { Position = new Point(Control.MousePosition.X, Control.MousePosition.Y), Button = Control.MouseButtons });
        }
    }
}
