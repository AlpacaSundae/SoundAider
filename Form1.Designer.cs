namespace SoundAider
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            outputDropdown = new ComboBox();
            inputDropdown = new ComboBox();
            setDefaultOutputButton = new Button();
            setDefaultComOutputButton = new Button();
            setDefaultInputButton = new Button();
            setDefaultComInputButton = new Button();
            defaultOutputDeviceLabel = new Label();
            defaultComOutputDeviceLabel = new Label();
            defaultInputDeviceLabel = new Label();
            defaultComInputDeviceLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            setBothOutputButton = new Button();
            setBothInputButton = new Button();
            syncOutputCheckBox = new CheckBox();
            syncInputCheckBox = new CheckBox();
            notifyIcon = new NotifyIcon(components);
            SuspendLayout();
            // 
            // outputDropdown
            // 
            outputDropdown.FormattingEnabled = true;
            outputDropdown.Location = new Point(12, 40);
            outputDropdown.Name = "outputDropdown";
            outputDropdown.Size = new Size(180, 23);
            outputDropdown.TabIndex = 0;
            // 
            // inputDropdown
            // 
            inputDropdown.FormattingEnabled = true;
            inputDropdown.Location = new Point(242, 40);
            inputDropdown.Name = "inputDropdown";
            inputDropdown.Size = new Size(180, 23);
            inputDropdown.TabIndex = 1;
            // 
            // setDefaultOutputButton
            // 
            setDefaultOutputButton.Location = new Point(12, 69);
            setDefaultOutputButton.Name = "setDefaultOutputButton";
            setDefaultOutputButton.Size = new Size(128, 23);
            setDefaultOutputButton.TabIndex = 2;
            setDefaultOutputButton.Text = "Default Output";
            setDefaultOutputButton.UseVisualStyleBackColor = true;
            setDefaultOutputButton.Click += setDefaultOutputButton_Click;
            // 
            // setDefaultComOutputButton
            // 
            setDefaultComOutputButton.Location = new Point(12, 98);
            setDefaultComOutputButton.Name = "setDefaultComOutputButton";
            setDefaultComOutputButton.Size = new Size(128, 23);
            setDefaultComOutputButton.TabIndex = 3;
            setDefaultComOutputButton.Text = "Communication";
            setDefaultComOutputButton.UseVisualStyleBackColor = true;
            setDefaultComOutputButton.Click += setDefaultComOutputButton_Click;
            // 
            // setDefaultInputButton
            // 
            setDefaultInputButton.Location = new Point(242, 69);
            setDefaultInputButton.Name = "setDefaultInputButton";
            setDefaultInputButton.Size = new Size(128, 23);
            setDefaultInputButton.TabIndex = 4;
            setDefaultInputButton.Text = "Default Input";
            setDefaultInputButton.UseVisualStyleBackColor = true;
            setDefaultInputButton.Click += setDefaultInputButton_Click;
            // 
            // setDefaultComInputButton
            // 
            setDefaultComInputButton.Location = new Point(242, 98);
            setDefaultComInputButton.Name = "setDefaultComInputButton";
            setDefaultComInputButton.Size = new Size(128, 23);
            setDefaultComInputButton.TabIndex = 5;
            setDefaultComInputButton.Text = "Communication";
            setDefaultComInputButton.UseVisualStyleBackColor = true;
            setDefaultComInputButton.Click += setDefaultComInputButton_Click;
            // 
            // defaultOutputDeviceLabel
            // 
            defaultOutputDeviceLabel.Location = new Point(12, 124);
            defaultOutputDeviceLabel.MaximumSize = new Size(180, 0);
            defaultOutputDeviceLabel.Name = "defaultOutputDeviceLabel";
            defaultOutputDeviceLabel.Size = new Size(180, 15);
            defaultOutputDeviceLabel.TabIndex = 8;
            defaultOutputDeviceLabel.Text = "def out";
            // 
            // defaultComOutputDeviceLabel
            // 
            defaultComOutputDeviceLabel.Location = new Point(12, 139);
            defaultComOutputDeviceLabel.MaximumSize = new Size(180, 0);
            defaultComOutputDeviceLabel.Name = "defaultComOutputDeviceLabel";
            defaultComOutputDeviceLabel.Size = new Size(180, 15);
            defaultComOutputDeviceLabel.TabIndex = 9;
            defaultComOutputDeviceLabel.Text = "def com out";
            // 
            // defaultInputDeviceLabel
            // 
            defaultInputDeviceLabel.Location = new Point(242, 124);
            defaultInputDeviceLabel.MaximumSize = new Size(180, 0);
            defaultInputDeviceLabel.Name = "defaultInputDeviceLabel";
            defaultInputDeviceLabel.Size = new Size(180, 15);
            defaultInputDeviceLabel.TabIndex = 10;
            defaultInputDeviceLabel.Text = "def in";
            // 
            // defaultComInputDeviceLabel
            // 
            defaultComInputDeviceLabel.Location = new Point(242, 139);
            defaultComInputDeviceLabel.MaximumSize = new Size(180, 0);
            defaultComInputDeviceLabel.Name = "defaultComInputDeviceLabel";
            defaultComInputDeviceLabel.Size = new Size(180, 15);
            defaultComInputDeviceLabel.TabIndex = 11;
            defaultComInputDeviceLabel.Text = "def in com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 12;
            label1.Text = "Output Devices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 13;
            label2.Text = "Input Devices";
            // 
            // setBothOutputButton
            // 
            setBothOutputButton.Location = new Point(146, 69);
            setBothOutputButton.Name = "setBothOutputButton";
            setBothOutputButton.Size = new Size(46, 52);
            setBothOutputButton.TabIndex = 14;
            setBothOutputButton.Text = "Both";
            setBothOutputButton.UseVisualStyleBackColor = true;
            setBothOutputButton.Click += setBothOutputButton_Click;
            // 
            // setBothInputButton
            // 
            setBothInputButton.Location = new Point(376, 69);
            setBothInputButton.Name = "setBothInputButton";
            setBothInputButton.Size = new Size(46, 52);
            setBothInputButton.TabIndex = 15;
            setBothInputButton.Text = "Both";
            setBothInputButton.UseVisualStyleBackColor = true;
            setBothInputButton.Click += setBothInputButton_Click;
            // 
            // syncOutputCheckBox
            // 
            syncOutputCheckBox.AutoSize = true;
            syncOutputCheckBox.Location = new Point(12, 170);
            syncOutputCheckBox.Name = "syncOutputCheckBox";
            syncOutputCheckBox.Size = new Size(137, 19);
            syncOutputCheckBox.TabIndex = 18;
            syncOutputCheckBox.Text = "Sync Comms Output";
            syncOutputCheckBox.UseVisualStyleBackColor = true;
            // 
            // syncInputCheckBox
            // 
            syncInputCheckBox.AutoSize = true;
            syncInputCheckBox.Location = new Point(242, 170);
            syncInputCheckBox.Name = "syncInputCheckBox";
            syncInputCheckBox.Size = new Size(127, 19);
            syncInputCheckBox.TabIndex = 19;
            syncInputCheckBox.Text = "Sync Comms Input";
            syncInputCheckBox.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "always waiting...";
            notifyIcon.BalloonTipTitle = "im here waiting";
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "SoundAider";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 203);
            Controls.Add(syncInputCheckBox);
            Controls.Add(syncOutputCheckBox);
            Controls.Add(setBothInputButton);
            Controls.Add(setBothOutputButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(defaultComInputDeviceLabel);
            Controls.Add(defaultInputDeviceLabel);
            Controls.Add(defaultComOutputDeviceLabel);
            Controls.Add(defaultOutputDeviceLabel);
            Controls.Add(setDefaultComInputButton);
            Controls.Add(setDefaultInputButton);
            Controls.Add(setDefaultComOutputButton);
            Controls.Add(setDefaultOutputButton);
            Controls.Add(inputDropdown);
            Controls.Add(outputDropdown);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "SoundAider";
            Load += Form1_Load;
            MouseDoubleClick += Form1_MouseDoubleClick;
            MouseDown += Form1_MouseDown;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox outputDropdown;
        private ComboBox inputDropdown;
        private Button setDefaultOutputButton;
        private Button setDefaultComOutputButton;
        private Button setDefaultInputButton;
        private Button setDefaultComInputButton;
        private Label defaultOutputDeviceLabel;
        private Label defaultComOutputDeviceLabel;
        private Label defaultInputDeviceLabel;
        private Label defaultComInputDeviceLabel;
        private Label label1;
        private Label label2;
        private Button setBothOutputButton;
        private Button setBothInputButton;
        private CheckBox syncOutputCheckBox;
        private CheckBox syncInputCheckBox;
        private NotifyIcon notifyIcon;
    }
}
