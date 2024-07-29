using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi.Observables;

namespace SoundAider
{
    public partial class Form1 : Form
    {
        private const int windowExpandedHitbox = 32; // window closes when cursor is outside the window, expand the box on all sides by this amount

        CoreAudioController controller;

        CoreAudioDevice defaultOutputDevice;
        CoreAudioDevice defaultComOutputDevice;
        CoreAudioDevice defaultInputDevice;
        CoreAudioDevice defaultComInputDevice;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Minimized;

            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new CoreAudioController();
            UpdateDefaultDevices();

            UpdateLabels();

            syncOutputCheckBox.Checked = true;

            inputDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            outputDropdown.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateDropdowns();

            controller.AudioDeviceChanged.Subscribe(DeviceStateChanged);
        }

        private void UpdateDefaultDevices()
        {
            defaultOutputDevice = controller.DefaultPlaybackDevice;
            defaultComOutputDevice = controller.DefaultPlaybackCommunicationsDevice;
            defaultInputDevice = controller.DefaultCaptureDevice;
            defaultComInputDevice = controller.DefaultCaptureCommunicationsDevice;
        }

        private void UpdateDropdowns()
        {
            MethodInvoker method = new MethodInvoker(delegate ()
            {
                var inputDevices = controller.GetCaptureDevices(DeviceState.Active);
                var outputDevices = controller.GetPlaybackDevices(DeviceState.Active);

                inputDropdown.Items.Clear();
                outputDropdown.Items.Clear();

                foreach (var device in inputDevices)
                {
                    inputDropdown.Items.Add(device.FullName);
                }

                foreach (var device in outputDevices)
                {
                    outputDropdown.Items.Add(device.FullName);
                }

                inputDropdown.SelectedItem = defaultInputDevice;
                inputDropdown.Text = defaultInputDevice.FullName;

                outputDropdown.SelectedItem = defaultOutputDevice;
                outputDropdown.Text = defaultOutputDevice.FullName;
            });

            if (inputDropdown.InvokeRequired)
            {
                inputDropdown.Invoke(method);
            }
            else
            {
                method();
            }
        }

        private void DeviceStateChanged(DeviceChangedArgs args)
        {
            switch (args.ChangedType)
            {
                case DeviceChangedType.DefaultChanged:
                    // we would only need to change devices if the device is default but not comms default
                    if (!args.Device.IsDefaultCommunicationsDevice && args.Device.IsDefaultDevice)
                    {
                        // now that we know they are out of sync, we only want to proceed if we actually want to keep them in sync :P
                        if ((args.Device.IsPlaybackDevice && syncOutputCheckBox.Checked) || (args.Device.IsCaptureDevice && syncInputCheckBox.Checked))
                        {
                            args.Device.SetAsDefaultCommunications();
                        }
                    }

                    // always update labels because we always want the labels to reflect the current default devices regardless of the synchronicity between them
                    UpdateLabels();
                    break;
                case DeviceChangedType.StateChanged:
                    // state changed means: https://learn.microsoft.com/en-us/windows/win32/api/mmdeviceapi/nf-mmdeviceapi-immnotificationclient-ondevicestatechanged
                    UpdateDefaultDevices();
                    UpdateDropdowns();
                    break;
                default:
#if DEBUG
                    MessageBox.Show("handler not implemented for: " + args.ChangedType + ", however event has been subscribed to", "DeviceStateChanged handler", MessageBoxButtons.OK, MessageBoxIcon.Information);
#endif
                    break;
            }
        }

        private void UpdateLabels()
        {
            defaultOutputDeviceLabel.BeginInvoke((MethodInvoker)(() => defaultOutputDeviceLabel.Text = controller.DefaultPlaybackDevice.FullName));
            defaultComOutputDeviceLabel.BeginInvoke((MethodInvoker)(() => defaultComOutputDeviceLabel.Text = controller.DefaultPlaybackCommunicationsDevice.FullName));
            defaultInputDeviceLabel.BeginInvoke((MethodInvoker)(() => defaultInputDeviceLabel.Text = controller.DefaultCaptureDevice.FullName));
            defaultComInputDeviceLabel.BeginInvoke((MethodInvoker)(() => defaultComInputDeviceLabel.Text = controller.DefaultCaptureCommunicationsDevice.FullName));
        }

        private void setDefaultOutputButton_Click(object sender, EventArgs e)
        {
            var outputDevices = controller.GetPlaybackDevices(DeviceState.Active);

            foreach (var device in outputDevices)
            {
                if (device.FullName == outputDropdown.Text)
                {
                    controller.DefaultPlaybackDevice = device;
                }
            }
            defaultOutputDeviceLabel.Text = controller.DefaultPlaybackDevice.FullName;
        }

        private void setDefaultComOutputButton_Click(object sender, EventArgs e)
        {
            var outputDevices = controller.GetPlaybackDevices(DeviceState.Active);

            foreach (var device in outputDevices)
            {
                if (device.FullName == outputDropdown.Text)
                {
                    controller.DefaultPlaybackCommunicationsDevice = device;
                }
            }
            defaultComOutputDeviceLabel.Text = controller.DefaultPlaybackCommunicationsDevice.FullName;
        }

        private void setDefaultInputButton_Click(object sender, EventArgs e)
        {
            var inputDevices = controller.GetCaptureDevices(DeviceState.Active);

            foreach (var device in inputDevices)
            {
                if (device.FullName == inputDropdown.Text)
                {
                    controller.DefaultCaptureDevice = device;
                }
            }
            defaultInputDeviceLabel.Text = controller.DefaultCaptureDevice.FullName;
        }

        private void setDefaultComInputButton_Click(object sender, EventArgs e)
        {
            var inputDevices = controller.GetCaptureDevices(DeviceState.Active);

            foreach (var device in inputDevices)
            {
                if (device.FullName == inputDropdown.Text)
                {
                    controller.DefaultCaptureCommunicationsDevice = device;
                }
            }
            defaultComInputDeviceLabel.Text = controller.DefaultCaptureCommunicationsDevice.FullName;
        }

        private void setBothOutputButton_Click(object sender, EventArgs e)
        {
            setDefaultOutputButton_Click(sender, e);
            setDefaultComOutputButton_Click(sender, e);
        }

        private void setBothInputButton_Click(object sender, EventArgs e)
        {
            setDefaultInputButton_Click(sender, e);
            setDefaultComInputButton_Click(sender, e);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                mousePositionTimer.Stop();
            }
        }

        private void MousePositionTimer_Tick(object sender, EventArgs e)
        {
            var expandedClientRectangle = new Rectangle(
                ClientRectangle.X - windowExpandedHitbox,
                ClientRectangle.Y - windowExpandedHitbox,
                ClientRectangle.Width + windowExpandedHitbox * 2,
                ClientRectangle.Height + windowExpandedHitbox * 2
                );
            if (!this.RectangleToScreen(expandedClientRectangle).Contains(Cursor.Position))
            {
                Hide();
                notifyIcon.Visible = true;
                mousePositionTimer.Stop();
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
                var currentScreen = Screen.FromPoint(Cursor.Position);
                this.Location = new Point(
                    // X: Centered on cursor OR fully within screen bounds
                    Math.Min(
                        Cursor.Position.X - this.Width / 2,
                        currentScreen.WorkingArea.Right - this.Width
                        ),
                    // Y: Above taskbar with autohide
                    currentScreen.Bounds.Bottom - this.Height - 48
                    );
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            mousePositionTimer.Stop();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            mousePositionTimer.Start();
        }

        private void quitSoundAider(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
