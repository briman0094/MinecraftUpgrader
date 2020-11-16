﻿namespace MinecraftLauncher
{
	partial class MainForm
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
			if (disposing && (this.components != null))
			{
				this.components.Dispose();
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
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Panel panel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.PictureBox pictureBox1;
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.lbInstanceStatus = new System.Windows.Forms.Label();
			this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.btnRebuild = new System.Windows.Forms.Button();
			this.appToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.lbMinecraftPath = new System.Windows.Forms.LinkLabel();
			label2 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
			this.buttonLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label2.Location = new System.Drawing.Point(12, 152);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(412, 44);
			label2.TabIndex = 22;
			label2.Text = "Arcanox\'s Minecraft Server";
			label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			panel1.Controls.Add(this.buttonRefresh);
			panel1.Controls.Add(this.btnGo);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point(206, 0);
			panel1.Margin = new System.Windows.Forms.Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(206, 75);
			panel1.TabIndex = 3;
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.buttonRefresh.FlatAppearance.BorderSize = 0;
			this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
			this.buttonRefresh.Location = new System.Drawing.Point(182, 51);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(24, 24);
			this.buttonRefresh.TabIndex = 3;
			this.appToolTip.SetToolTip(this.buttonRefresh, "Refresh modpack info");
			this.buttonRefresh.UseVisualStyleBackColor = false;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// btnGo
			// 
			this.btnGo.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGo.FlatAppearance.BorderSize = 0;
			this.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.btnGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
			this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.ForeColor = System.Drawing.Color.White;
			this.btnGo.Location = new System.Drawing.Point(0, 0);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(206, 75);
			this.btnGo.TabIndex = 2;
			this.btnGo.Text = "Go!";
			this.btnGo.UseVisualStyleBackColor = false;
			this.btnGo.Click += new System.EventHandler(this.OnBtnGoClick);
			// 
			// pictureBox1
			// 
			pictureBox1.Image = global::MinecraftLauncher.Properties.Resources.Arcanox;
			pictureBox1.Location = new System.Drawing.Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(412, 137);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 21;
			pictureBox1.TabStop = false;
			this.appToolTip.SetToolTip(pictureBox1, "Art by Firestoem!");
			// 
			// lbInstanceStatus
			// 
			this.lbInstanceStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbInstanceStatus.AutoSize = true;
			this.lbInstanceStatus.Location = new System.Drawing.Point(14, 303);
			this.lbInstanceStatus.Name = "lbInstanceStatus";
			this.lbInstanceStatus.Size = new System.Drawing.Size(81, 13);
			this.lbInstanceStatus.TabIndex = 15;
			this.lbInstanceStatus.Text = "Instance Status";
			// 
			// buttonLayoutPanel
			// 
			this.buttonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLayoutPanel.ColumnCount = 2;
			this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonLayoutPanel.Controls.Add(this.btnRebuild, 0, 0);
			this.buttonLayoutPanel.Controls.Add(panel1, 1, 0);
			this.buttonLayoutPanel.Location = new System.Drawing.Point(12, 202);
			this.buttonLayoutPanel.Name = "buttonLayoutPanel";
			this.buttonLayoutPanel.RowCount = 1;
			this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.buttonLayoutPanel.Size = new System.Drawing.Size(412, 75);
			this.buttonLayoutPanel.TabIndex = 16;
			// 
			// btnRebuild
			// 
			this.btnRebuild.BackColor = System.Drawing.SystemColors.Control;
			this.btnRebuild.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRebuild.Enabled = false;
			this.btnRebuild.FlatAppearance.BorderSize = 0;
			this.btnRebuild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.btnRebuild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
			this.btnRebuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRebuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRebuild.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRebuild.Location = new System.Drawing.Point(3, 3);
			this.btnRebuild.Name = "btnRebuild";
			this.btnRebuild.Size = new System.Drawing.Size(200, 69);
			this.btnRebuild.TabIndex = 2;
			this.btnRebuild.Text = "Repair/Reinstall";
			this.btnRebuild.UseVisualStyleBackColor = false;
			this.btnRebuild.Click += new System.EventHandler(this.OnBtnRebuildClick);
			// 
			// appToolTip
			// 
			this.appToolTip.AutomaticDelay = 100;
			this.appToolTip.AutoPopDelay = 10000;
			this.appToolTip.InitialDelay = 100;
			this.appToolTip.ReshowDelay = 100;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 285);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Minecraft path:";
			// 
			// lbMinecraftPath
			// 
			this.lbMinecraftPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbMinecraftPath.AutoSize = true;
			this.lbMinecraftPath.Location = new System.Drawing.Point(98, 285);
			this.lbMinecraftPath.Name = "lbMinecraftPath";
			this.lbMinecraftPath.Size = new System.Drawing.Size(33, 13);
			this.lbMinecraftPath.TabIndex = 20;
			this.lbMinecraftPath.TabStop = true;
			this.lbMinecraftPath.Text = "None";
			this.lbMinecraftPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbMinecraftPath_LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(436, 326);
			this.Controls.Add(label2);
			this.Controls.Add(pictureBox1);
			this.Controls.Add(this.buttonLayoutPanel);
			this.Controls.Add(this.lbInstanceStatus);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbMinecraftPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(330, 200);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Minecraft Launcher";
			this.Load += new System.EventHandler(this.OnFormLoad);
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
			this.buttonLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbInstanceStatus;
		private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel;
		private System.Windows.Forms.Button btnRebuild;
		private System.Windows.Forms.ToolTip appToolTip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel lbMinecraftPath;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.Button btnGo;
	}
}

