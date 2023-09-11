namespace PrototypeWithVectors
{
    partial class PrototypeCmdDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputAlpha = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.cmdStartDrawingLetter = new System.Windows.Forms.Button();
            this.bottomLeftDistance = new System.Windows.Forms.TextBox();
            this.bottomRightDistance = new System.Windows.Forms.TextBox();
            this.topLeftDistance = new System.Windows.Forms.TextBox();
            this.topRightDistance = new System.Windows.Forms.TextBox();
            this.theta1Text = new System.Windows.Forms.TextBox();
            this.theta5Text = new System.Windows.Forms.TextBox();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.cmdConnectSerialPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.xTrack = new System.Windows.Forms.TrackBar();
            this.yTrack = new System.Windows.Forms.TrackBar();
            this.xTrackValue = new System.Windows.Forms.TextBox();
            this.yTrackValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // inputAlpha
            // 
            this.inputAlpha.Location = new System.Drawing.Point(544, 155);
            this.inputAlpha.Name = "inputAlpha";
            this.inputAlpha.Size = new System.Drawing.Size(100, 20);
            this.inputAlpha.TabIndex = 1;
            this.inputAlpha.Text = "A";
            this.inputAlpha.TextChanged += new System.EventHandler(this.inputAlpha_TextChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(496, 426);
            this.zedGraphControl1.TabIndex = 2;
            // 
            // cmdStartDrawingLetter
            // 
            this.cmdStartDrawingLetter.Location = new System.Drawing.Point(656, 153);
            this.cmdStartDrawingLetter.Name = "cmdStartDrawingLetter";
            this.cmdStartDrawingLetter.Size = new System.Drawing.Size(99, 23);
            this.cmdStartDrawingLetter.TabIndex = 3;
            this.cmdStartDrawingLetter.Text = "Start Drawing";
            this.cmdStartDrawingLetter.UseVisualStyleBackColor = true;
            this.cmdStartDrawingLetter.Click += new System.EventHandler(this.cmdStartDrawingLetter_Click);
            // 
            // bottomLeftDistance
            // 
            this.bottomLeftDistance.Location = new System.Drawing.Point(903, 204);
            this.bottomLeftDistance.Name = "bottomLeftDistance";
            this.bottomLeftDistance.ReadOnly = true;
            this.bottomLeftDistance.Size = new System.Drawing.Size(100, 20);
            this.bottomLeftDistance.TabIndex = 4;
            // 
            // bottomRightDistance
            // 
            this.bottomRightDistance.Location = new System.Drawing.Point(903, 230);
            this.bottomRightDistance.Name = "bottomRightDistance";
            this.bottomRightDistance.ReadOnly = true;
            this.bottomRightDistance.Size = new System.Drawing.Size(100, 20);
            this.bottomRightDistance.TabIndex = 4;
            // 
            // topLeftDistance
            // 
            this.topLeftDistance.Location = new System.Drawing.Point(903, 256);
            this.topLeftDistance.Name = "topLeftDistance";
            this.topLeftDistance.ReadOnly = true;
            this.topLeftDistance.Size = new System.Drawing.Size(100, 20);
            this.topLeftDistance.TabIndex = 4;
            // 
            // topRightDistance
            // 
            this.topRightDistance.Location = new System.Drawing.Point(903, 282);
            this.topRightDistance.Name = "topRightDistance";
            this.topRightDistance.ReadOnly = true;
            this.topRightDistance.Size = new System.Drawing.Size(100, 20);
            this.topRightDistance.TabIndex = 4;
            // 
            // theta1Text
            // 
            this.theta1Text.Location = new System.Drawing.Point(903, 357);
            this.theta1Text.Name = "theta1Text";
            this.theta1Text.ReadOnly = true;
            this.theta1Text.Size = new System.Drawing.Size(100, 20);
            this.theta1Text.TabIndex = 5;
            // 
            // theta5Text
            // 
            this.theta5Text.Location = new System.Drawing.Point(903, 383);
            this.theta5Text.Name = "theta5Text";
            this.theta5Text.ReadOnly = true;
            this.theta5Text.Size = new System.Drawing.Size(100, 20);
            this.theta5Text.TabIndex = 6;
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(544, 34);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 7;
            // 
            // cmdConnectSerialPort
            // 
            this.cmdConnectSerialPort.Location = new System.Drawing.Point(544, 78);
            this.cmdConnectSerialPort.Name = "cmdConnectSerialPort";
            this.cmdConnectSerialPort.Size = new System.Drawing.Size(75, 23);
            this.cmdConnectSerialPort.TabIndex = 8;
            this.cmdConnectSerialPort.Text = "Connect";
            this.cmdConnectSerialPort.UseVisualStyleBackColor = true;
            this.cmdConnectSerialPort.Click += new System.EventHandler(this.cmdConnectSerialPort_Click);
            // 
            // xTrack
            // 
            this.xTrack.Location = new System.Drawing.Point(525, 204);
            this.xTrack.Maximum = 200;
            this.xTrack.Minimum = -200;
            this.xTrack.Name = "xTrack";
            this.xTrack.Size = new System.Drawing.Size(372, 45);
            this.xTrack.TabIndex = 9;
            this.xTrack.TickFrequency = 10;
            // 
            // yTrack
            // 
            this.yTrack.Location = new System.Drawing.Point(525, 332);
            this.yTrack.Maximum = 200;
            this.yTrack.Minimum = -200;
            this.yTrack.Name = "yTrack";
            this.yTrack.Size = new System.Drawing.Size(372, 45);
            this.yTrack.TabIndex = 9;
            this.yTrack.TickFrequency = 10;
            // 
            // xTrackValue
            // 
            this.xTrackValue.Location = new System.Drawing.Point(639, 256);
            this.xTrackValue.Name = "xTrackValue";
            this.xTrackValue.ReadOnly = true;
            this.xTrackValue.Size = new System.Drawing.Size(100, 20);
            this.xTrackValue.TabIndex = 10;
            // 
            // yTrackValue
            // 
            this.yTrackValue.Location = new System.Drawing.Point(639, 374);
            this.yTrackValue.Name = "yTrackValue";
            this.yTrackValue.ReadOnly = true;
            this.yTrackValue.Size = new System.Drawing.Size(100, 20);
            this.yTrackValue.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "End Program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrototypeCmdDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yTrackValue);
            this.Controls.Add(this.xTrackValue);
            this.Controls.Add(this.yTrack);
            this.Controls.Add(this.xTrack);
            this.Controls.Add(this.cmdConnectSerialPort);
            this.Controls.Add(this.cmbSerialPorts);
            this.Controls.Add(this.theta5Text);
            this.Controls.Add(this.theta1Text);
            this.Controls.Add(this.topRightDistance);
            this.Controls.Add(this.topLeftDistance);
            this.Controls.Add(this.bottomRightDistance);
            this.Controls.Add(this.bottomLeftDistance);
            this.Controls.Add(this.cmdStartDrawingLetter);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.inputAlpha);
            this.Name = "PrototypeCmdDlg";
            this.Text = "Connect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrototypeCmdDlg_FormClosed);
            this.Load += new System.EventHandler(this.PrototypeCmdDlg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputAlpha;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button cmdStartDrawingLetter;
        private System.Windows.Forms.TextBox bottomLeftDistance;
        private System.Windows.Forms.TextBox bottomRightDistance;
        private System.Windows.Forms.TextBox topLeftDistance;
        private System.Windows.Forms.TextBox topRightDistance;
        private System.Windows.Forms.TextBox theta1Text;
        private System.Windows.Forms.TextBox theta5Text;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Button cmdConnectSerialPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar xTrack;
        private System.Windows.Forms.TrackBar yTrack;
        private System.Windows.Forms.TextBox xTrackValue;
        private System.Windows.Forms.TextBox yTrackValue;
        private System.Windows.Forms.Button button1;
    }
}

