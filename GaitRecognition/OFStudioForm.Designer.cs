﻿namespace GaitRecognition
{
    partial class OFStudioForm
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.VideoPlayerPanel = new System.Windows.Forms.Panel();
            this.OpticalFlowPanel = new System.Windows.Forms.Panel();
            this.radioButtonCamera = new System.Windows.Forms.RadioButton();
            this.radioButtonVideo = new System.Windows.Forms.RadioButton();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.textBoxVideoPath = new System.Windows.Forms.TextBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.numericFrameSkip = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPlayerControls = new System.Windows.Forms.Panel();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.VideoPlayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrameSkip)).BeginInit();
            this.panelPlayerControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.statsMenu,
            this.aboutMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(960, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileMenu
            // 
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // statsMenu
            // 
            this.statsMenu.Name = "statsMenu";
            this.statsMenu.Size = new System.Drawing.Size(65, 20);
            this.statsMenu.Text = "Statistics";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "About";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OpticalFlowPanel);
            this.MainPanel.Controls.Add(this.VideoPlayerPanel);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(960, 505);
            this.MainPanel.TabIndex = 1;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.numericFrameSkip);
            this.HeaderPanel.Controls.Add(this.btnBrowseVideo);
            this.HeaderPanel.Controls.Add(this.textBoxVideoPath);
            this.HeaderPanel.Controls.Add(this.comboBoxCameraList);
            this.HeaderPanel.Controls.Add(this.radioButtonVideo);
            this.HeaderPanel.Controls.Add(this.radioButtonCamera);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(960, 100);
            this.HeaderPanel.TabIndex = 0;
            // 
            // VideoPlayerPanel
            // 
            this.VideoPlayerPanel.Controls.Add(this.panelPlayerControls);
            this.VideoPlayerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VideoPlayerPanel.Location = new System.Drawing.Point(0, 100);
            this.VideoPlayerPanel.Name = "VideoPlayerPanel";
            this.VideoPlayerPanel.Size = new System.Drawing.Size(460, 405);
            this.VideoPlayerPanel.TabIndex = 1;
            // 
            // OpticalFlowPanel
            // 
            this.OpticalFlowPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpticalFlowPanel.Location = new System.Drawing.Point(500, 100);
            this.OpticalFlowPanel.Name = "OpticalFlowPanel";
            this.OpticalFlowPanel.Size = new System.Drawing.Size(460, 405);
            this.OpticalFlowPanel.TabIndex = 2;
            // 
            // radioButtonCamera
            // 
            this.radioButtonCamera.AutoSize = true;
            this.radioButtonCamera.Location = new System.Drawing.Point(59, 13);
            this.radioButtonCamera.Name = "radioButtonCamera";
            this.radioButtonCamera.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCamera.TabIndex = 0;
            this.radioButtonCamera.TabStop = true;
            this.radioButtonCamera.Text = "Live Camera";
            this.radioButtonCamera.UseVisualStyleBackColor = true;
            // 
            // radioButtonVideo
            // 
            this.radioButtonVideo.AutoSize = true;
            this.radioButtonVideo.Location = new System.Drawing.Point(59, 45);
            this.radioButtonVideo.Name = "radioButtonVideo";
            this.radioButtonVideo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonVideo.TabIndex = 1;
            this.radioButtonVideo.TabStop = true;
            this.radioButtonVideo.Text = "Video";
            this.radioButtonVideo.UseVisualStyleBackColor = true;
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(188, 12);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(183, 21);
            this.comboBoxCameraList.TabIndex = 2;
            // 
            // textBoxVideoPath
            // 
            this.textBoxVideoPath.Location = new System.Drawing.Point(188, 48);
            this.textBoxVideoPath.Name = "textBoxVideoPath";
            this.textBoxVideoPath.Size = new System.Drawing.Size(183, 20);
            this.textBoxVideoPath.TabIndex = 4;
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(385, 46);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseVideo.TabIndex = 5;
            this.btnBrowseVideo.Text = "Browse";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            // 
            // numericFrameSkip
            // 
            this.numericFrameSkip.Location = new System.Drawing.Point(752, 13);
            this.numericFrameSkip.Name = "numericFrameSkip";
            this.numericFrameSkip.Size = new System.Drawing.Size(52, 20);
            this.numericFrameSkip.TabIndex = 6;
            this.numericFrameSkip.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Frame Skip";
            // 
            // panelPlayerControls
            // 
            this.panelPlayerControls.Controls.Add(this.btnStop);
            this.panelPlayerControls.Controls.Add(this.btnPlayPause);
            this.panelPlayerControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayerControls.Location = new System.Drawing.Point(0, 350);
            this.panelPlayerControls.Name = "panelPlayerControls";
            this.panelPlayerControls.Size = new System.Drawing.Size(460, 55);
            this.panelPlayerControls.TabIndex = 0;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(12, 5);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 38);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 38);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // OFStudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 529);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "OFStudioForm";
            this.Text = "Optical Flow Studio";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.VideoPlayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericFrameSkip)).EndInit();
            this.panelPlayerControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem statsMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel OpticalFlowPanel;
        private System.Windows.Forms.Panel VideoPlayerPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.RadioButton radioButtonVideo;
        private System.Windows.Forms.RadioButton radioButtonCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericFrameSkip;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.TextBox textBoxVideoPath;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.Panel panelPlayerControls;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlayPause;
    }
}