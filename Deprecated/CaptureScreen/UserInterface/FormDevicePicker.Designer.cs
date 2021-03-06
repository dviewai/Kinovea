﻿#region License
/*
Copyright © Joan Charmant 2010.
joan.charmant@gmail.com 
 
This file is part of Kinovea.

Kinovea is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License version 2 
as published by the Free Software Foundation.

Kinovea is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Kinovea. If not, see http://www.gnu.org/licenses/.
*/
#endregion
namespace Kinovea.ScreenManager
{
	partial class formDevicePicker
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnApply = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gpCurrentDevice = new System.Windows.Forms.GroupBox();
			this.cmbUrl = new System.Windows.Forms.ComboBox();
			this.lblStreamType = new System.Windows.Forms.Label();
			this.cmbStreamType = new System.Windows.Forms.ComboBox();
			this.lblUrl = new System.Windows.Forms.Label();
			this.btnDeviceProperties = new System.Windows.Forms.Button();
			this.lblNoConf = new System.Windows.Forms.Label();
			this.btnCamcorder = new System.Windows.Forms.Button();
			this.cmbCapabilities = new System.Windows.Forms.ComboBox();
			this.lblConfig = new System.Windows.Forms.Label();
			this.lblCurrentlySelected = new System.Windows.Forms.Label();
			this.gpOtherDevices = new System.Windows.Forms.GroupBox();
			this.cmbOtherDevices = new System.Windows.Forms.ComboBox();
			this.gpCurrentDevice.SuspendLayout();
			this.gpOtherDevices.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnApply
			// 
			this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnApply.Location = new System.Drawing.Point(115, 261);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(99, 24);
			this.btnApply.TabIndex = 76;
			this.btnApply.Text = "Apply";
			this.btnApply.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(220, 261);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 24);
			this.btnCancel.TabIndex = 77;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// gpCurrentDevice
			// 
			this.gpCurrentDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gpCurrentDevice.Controls.Add(this.cmbUrl);
			this.gpCurrentDevice.Controls.Add(this.lblStreamType);
			this.gpCurrentDevice.Controls.Add(this.cmbStreamType);
			this.gpCurrentDevice.Controls.Add(this.lblUrl);
			this.gpCurrentDevice.Controls.Add(this.btnDeviceProperties);
			this.gpCurrentDevice.Controls.Add(this.lblNoConf);
			this.gpCurrentDevice.Controls.Add(this.btnCamcorder);
			this.gpCurrentDevice.Controls.Add(this.cmbCapabilities);
			this.gpCurrentDevice.Controls.Add(this.lblConfig);
			this.gpCurrentDevice.Controls.Add(this.lblCurrentlySelected);
			this.gpCurrentDevice.Location = new System.Drawing.Point(12, 12);
			this.gpCurrentDevice.Name = "gpCurrentDevice";
			this.gpCurrentDevice.Size = new System.Drawing.Size(307, 153);
			this.gpCurrentDevice.TabIndex = 78;
			this.gpCurrentDevice.TabStop = false;
			this.gpCurrentDevice.Text = "Current device";
			// 
			// cmbUrl
			// 
			this.cmbUrl.FormattingEnabled = true;
			this.cmbUrl.Location = new System.Drawing.Point(48, 95);
			this.cmbUrl.Name = "cmbUrl";
			this.cmbUrl.Size = new System.Drawing.Size(43, 21);
			this.cmbUrl.TabIndex = 15;
			// 
			// lblStreamType
			// 
			this.lblStreamType.AutoSize = true;
			this.lblStreamType.Location = new System.Drawing.Point(16, 113);
			this.lblStreamType.Name = "lblStreamType";
			this.lblStreamType.Size = new System.Drawing.Size(17, 13);
			this.lblStreamType.TabIndex = 14;
			this.lblStreamType.Text = "T:";
			this.lblStreamType.Visible = false;
			// 
			// cmbStreamType
			// 
			this.cmbStreamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStreamType.FormattingEnabled = true;
			this.cmbStreamType.Location = new System.Drawing.Point(39, 113);
			this.cmbStreamType.Name = "cmbStreamType";
			this.cmbStreamType.Size = new System.Drawing.Size(70, 21);
			this.cmbStreamType.TabIndex = 13;
			// 
			// lblUrl
			// 
			this.lblUrl.AutoSize = true;
			this.lblUrl.Location = new System.Drawing.Point(16, 98);
			this.lblUrl.Name = "lblUrl";
			this.lblUrl.Size = new System.Drawing.Size(26, 13);
			this.lblUrl.TabIndex = 11;
			this.lblUrl.Text = "Url :";
			this.lblUrl.Visible = false;
			// 
			// btnDeviceProperties
			// 
			this.btnDeviceProperties.Location = new System.Drawing.Point(115, 113);
			this.btnDeviceProperties.Name = "btnDeviceProperties";
			this.btnDeviceProperties.Size = new System.Drawing.Size(173, 24);
			this.btnDeviceProperties.TabIndex = 10;
			this.btnDeviceProperties.Text = "Device Properties";
			this.btnDeviceProperties.UseVisualStyleBackColor = true;
			this.btnDeviceProperties.Click += new System.EventHandler(this.btnDeviceProperties_Click);
			// 
			// lblNoConf
			// 
			this.lblNoConf.BackColor = System.Drawing.Color.Transparent;
			this.lblNoConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoConf.ForeColor = System.Drawing.Color.Gray;
			this.lblNoConf.Location = new System.Drawing.Point(115, 51);
			this.lblNoConf.Name = "lblNoConf";
			this.lblNoConf.Size = new System.Drawing.Size(187, 23);
			this.lblNoConf.TabIndex = 9;
			this.lblNoConf.Text = "No other option available";
			this.lblNoConf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCamcorder
			// 
			this.btnCamcorder.FlatAppearance.BorderSize = 0;
			this.btnCamcorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCamcorder.Image = global::Kinovea.ScreenManager.Properties.Resources.camera_selected;
			this.btnCamcorder.Location = new System.Drawing.Point(16, 25);
			this.btnCamcorder.Name = "btnCamcorder";
			this.btnCamcorder.Size = new System.Drawing.Size(30, 30);
			this.btnCamcorder.TabIndex = 8;
			this.btnCamcorder.UseVisualStyleBackColor = true;
			// 
			// cmbCapabilities
			// 
			this.cmbCapabilities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCapabilities.FormattingEnabled = true;
			this.cmbCapabilities.Location = new System.Drawing.Point(115, 77);
			this.cmbCapabilities.Name = "cmbCapabilities";
			this.cmbCapabilities.Size = new System.Drawing.Size(173, 21);
			this.cmbCapabilities.TabIndex = 5;
			// 
			// lblConfig
			// 
			this.lblConfig.BackColor = System.Drawing.Color.Transparent;
			this.lblConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfig.ForeColor = System.Drawing.Color.Black;
			this.lblConfig.Location = new System.Drawing.Point(16, 75);
			this.lblConfig.Name = "lblConfig";
			this.lblConfig.Size = new System.Drawing.Size(93, 23);
			this.lblConfig.TabIndex = 4;
			this.lblConfig.Text = "Configuration";
			this.lblConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCurrentlySelected
			// 
			this.lblCurrentlySelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentlySelected.Location = new System.Drawing.Point(77, 32);
			this.lblCurrentlySelected.Name = "lblCurrentlySelected";
			this.lblCurrentlySelected.Size = new System.Drawing.Size(217, 20);
			this.lblCurrentlySelected.TabIndex = 0;
			this.lblCurrentlySelected.Text = "My Device";
			// 
			// gpOtherDevices
			// 
			this.gpOtherDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.gpOtherDevices.Controls.Add(this.cmbOtherDevices);
			this.gpOtherDevices.Location = new System.Drawing.Point(12, 171);
			this.gpOtherDevices.Name = "gpOtherDevices";
			this.gpOtherDevices.Size = new System.Drawing.Size(307, 79);
			this.gpOtherDevices.TabIndex = 79;
			this.gpOtherDevices.TabStop = false;
			this.gpOtherDevices.Text = "Select another device";
			// 
			// cmbOtherDevices
			// 
			this.cmbOtherDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbOtherDevices.FormattingEnabled = true;
			this.cmbOtherDevices.Location = new System.Drawing.Point(16, 37);
			this.cmbOtherDevices.Name = "cmbOtherDevices";
			this.cmbOtherDevices.Size = new System.Drawing.Size(272, 21);
			this.cmbOtherDevices.TabIndex = 7;
			this.cmbOtherDevices.SelectedIndexChanged += new System.EventHandler(this.cmbOtherDevices_SelectedIndexChanged);
			// 
			// formDevicePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(331, 297);
			this.Controls.Add(this.gpOtherDevices);
			this.Controls.Add(this.gpCurrentDevice);
			this.Controls.Add(this.btnApply);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "formDevicePicker";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormDevicePicker";
			this.gpCurrentDevice.ResumeLayout(false);
			this.gpCurrentDevice.PerformLayout();
			this.gpOtherDevices.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cmbUrl;
		private System.Windows.Forms.ComboBox cmbStreamType;
		private System.Windows.Forms.Label lblStreamType;
		private System.Windows.Forms.Label lblUrl;
		private System.Windows.Forms.Button btnDeviceProperties;
		private System.Windows.Forms.Label lblNoConf;
		private System.Windows.Forms.ComboBox cmbOtherDevices;
		private System.Windows.Forms.Button btnCamcorder;
		private System.Windows.Forms.GroupBox gpOtherDevices;
		private System.Windows.Forms.Label lblConfig;
		private System.Windows.Forms.ComboBox cmbCapabilities;
		private System.Windows.Forms.GroupBox gpCurrentDevice;
		private System.Windows.Forms.Label lblCurrentlySelected;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnApply;
	}
}
