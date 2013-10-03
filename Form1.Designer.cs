namespace MouseRecorder
{
    partial class Form1
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
            this._recordButton = new System.Windows.Forms.Button();
            this._playButton = new System.Windows.Forms.Button();
            this._stopButton = new System.Windows.Forms.Button();
            this._recordTimer = new System.Windows.Forms.Timer(this.components);
            this._playTimer = new System.Windows.Forms.Timer(this.components);
            this._repeatCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._repeatCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // _recordButton
            // 
            this._recordButton.Location = new System.Drawing.Point(12, 12);
            this._recordButton.Name = "_recordButton";
            this._recordButton.Size = new System.Drawing.Size(75, 75);
            this._recordButton.TabIndex = 0;
            this._recordButton.Text = "Record";
            this._recordButton.UseVisualStyleBackColor = true;
            this._recordButton.Click += new System.EventHandler(this._recordButton_Click);
            // 
            // _playButton
            // 
            this._playButton.Location = new System.Drawing.Point(174, 12);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(75, 75);
            this._playButton.TabIndex = 1;
            this._playButton.Text = "Play";
            this._playButton.UseVisualStyleBackColor = true;
            this._playButton.Click += new System.EventHandler(this._playButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Location = new System.Drawing.Point(93, 12);
            this._stopButton.Name = "_stopButton";
            this._stopButton.Size = new System.Drawing.Size(75, 75);
            this._stopButton.TabIndex = 2;
            this._stopButton.Text = "Stop";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
            // 
            // _recordTimer
            // 
            this._recordTimer.Interval = 10;
            this._recordTimer.Tick += new System.EventHandler(this._recordTimer_Tick);
            // 
            // _playTimer
            // 
            this._playTimer.Interval = 10;
            this._playTimer.Tick += new System.EventHandler(this._playTimer_Tick);
            // 
            // _repeatCounter
            // 
            this._repeatCounter.Location = new System.Drawing.Point(64, 94);
            this._repeatCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._repeatCounter.Name = "_repeatCounter";
            this._repeatCounter.Size = new System.Drawing.Size(185, 20);
            this._repeatCounter.TabIndex = 3;
            this._repeatCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._repeatCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Repeat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._repeatCounter);
            this.Controls.Add(this._stopButton);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this._recordButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._repeatCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _recordButton;
        private System.Windows.Forms.Button _playButton;
        private System.Windows.Forms.Button _stopButton;
        private System.Windows.Forms.Timer _recordTimer;
        private System.Windows.Forms.Timer _playTimer;
        private System.Windows.Forms.NumericUpDown _repeatCounter;
        private System.Windows.Forms.Label label1;
    }
}

