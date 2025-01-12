﻿/*  GRBL-Plotter. Another GCode sender for GRBL.
    This file is part of the GRBL-Plotter application.
   
    Copyright (C) 2015-2016 Sven Hasemann contact: svenhb@web.de

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace GrblPlotter
{
    partial class ControlCameraForm
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
                pen1.Dispose();
                penDown.Dispose();
                penMarker.Dispose();
                penRuler.Dispose();
                penTool.Dispose();
                penUp.Dispose();
                brushText.Dispose();
                penTeach.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCameraForm));
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.cmsPictureBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveMarkerToCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compensateAngleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showOverlayGraphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUDCameraZoom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStripCamera = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRotationAngleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.teachScalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachRadiusTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.lowerPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachRadiusBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.teachOffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossHairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setZeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachZeroPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachMarkerPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnApplyAngle = new System.Windows.Forms.Button();
            this.btnCamCoordTool = new System.Windows.Forms.Button();
            this.cBCamCoordMove = new System.Windows.Forms.CheckBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnCamCoordCam = new System.Windows.Forms.Button();
            this.lblOffset = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCenterPos = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBShapeDetection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAutoCenter = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.resetOffsetG921ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBRotateArround0 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            this.cmsPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCameraZoom)).BeginInit();
            this.menuStripCamera.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxVideo
            // 
            resources.ApplyResources(this.pictureBoxVideo, "pictureBoxVideo");
            this.pictureBoxVideo.ContextMenuStrip = this.cmsPictureBox;
            this.pictureBoxVideo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.TabStop = false;
            this.pictureBoxVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxVideo_Paint);
            this.pictureBoxVideo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxVideo_Click);
            this.pictureBoxVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxVideo_MouseDown);
            this.pictureBoxVideo.MouseEnter += new System.EventHandler(this.PictureBoxVideo_MouseEnter);
            this.pictureBoxVideo.MouseLeave += new System.EventHandler(this.PictureBoxVideo_MouseLeave);
            this.pictureBoxVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBoxVideo_MouseUp);
            this.pictureBoxVideo.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PictureBoxVideo_MouseWheel);
            // 
            // cmsPictureBox
            // 
            this.cmsPictureBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetOffsetG921ToolStripMenuItem,
            this.moveMarkerToCenterToolStripMenuItem,
            this.compensateAngleToolStripMenuItem,
            this.toolStripSeparator1,
            this.showOverlayGraphicsToolStripMenuItem});
            this.cmsPictureBox.Name = "cmsPictureBox";
            resources.ApplyResources(this.cmsPictureBox, "cmsPictureBox");
            // 
            // moveMarkerToCenterToolStripMenuItem
            // 
            this.moveMarkerToCenterToolStripMenuItem.Name = "moveMarkerToCenterToolStripMenuItem";
            resources.ApplyResources(this.moveMarkerToCenterToolStripMenuItem, "moveMarkerToCenterToolStripMenuItem");
            this.moveMarkerToCenterToolStripMenuItem.Click += new System.EventHandler(this.Teachpoint1_process_Click);
            // 
            // compensateAngleToolStripMenuItem
            // 
            this.compensateAngleToolStripMenuItem.Name = "compensateAngleToolStripMenuItem";
            resources.ApplyResources(this.compensateAngleToolStripMenuItem, "compensateAngleToolStripMenuItem");
            this.compensateAngleToolStripMenuItem.Click += new System.EventHandler(this.Teachpoint2_process_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // showOverlayGraphicsToolStripMenuItem
            // 
            this.showOverlayGraphicsToolStripMenuItem.Checked = true;
            this.showOverlayGraphicsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOverlayGraphicsToolStripMenuItem.Name = "showOverlayGraphicsToolStripMenuItem";
            resources.ApplyResources(this.showOverlayGraphicsToolStripMenuItem, "showOverlayGraphicsToolStripMenuItem");
            this.showOverlayGraphicsToolStripMenuItem.Click += new System.EventHandler(this.ShowOverlayGraphicsToolStripMenuItem_Click);
            // 
            // nUDCameraZoom
            // 
            resources.ApplyResources(this.nUDCameraZoom, "nUDCameraZoom");
            this.nUDCameraZoom.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDCameraZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCameraZoom.Name = "nUDCameraZoom";
            this.nUDCameraZoom.ReadOnly = true;
            this.nUDCameraZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDCameraZoom.ValueChanged += new System.EventHandler(this.NudCameraZoom_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // menuStripCamera
            // 
            this.menuStripCamera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.setZeroToolStripMenuItem});
            resources.ApplyResources(this.menuStripCamera, "menuStripCamera");
            this.menuStripCamera.Name = "menuStripCamera";
            this.menuStripCamera.ShowItemToolTips = true;
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camSourceToolStripMenuItem,
            this.setRotationAngleToolStripMenuItem,
            this.teachScalingToolStripMenuItem,
            this.teachOffsetToolStripMenuItem,
            this.colorsToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            resources.ApplyResources(this.setupToolStripMenuItem, "setupToolStripMenuItem");
            // 
            // camSourceToolStripMenuItem
            // 
            this.camSourceToolStripMenuItem.AutoToolTip = true;
            this.camSourceToolStripMenuItem.Name = "camSourceToolStripMenuItem";
            resources.ApplyResources(this.camSourceToolStripMenuItem, "camSourceToolStripMenuItem");
            // 
            // setRotationAngleToolStripMenuItem
            // 
            this.setRotationAngleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.setRotationAngleToolStripMenuItem.Name = "setRotationAngleToolStripMenuItem";
            resources.ApplyResources(this.setRotationAngleToolStripMenuItem, "setRotationAngleToolStripMenuItem");
            // 
            // toolStripTextBox1
            // 
            resources.ApplyResources(this.toolStripTextBox1, "toolStripTextBox1");
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyUp);
            // 
            // teachScalingToolStripMenuItem
            // 
            this.teachScalingToolStripMenuItem.AutoToolTip = true;
            this.teachScalingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upperPositionToolStripMenuItem,
            this.teachRadiusTopToolStripMenuItem,
            this.lowerPositionToolStripMenuItem,
            this.teachRadiusBottomToolStripMenuItem});
            this.teachScalingToolStripMenuItem.Name = "teachScalingToolStripMenuItem";
            resources.ApplyResources(this.teachScalingToolStripMenuItem, "teachScalingToolStripMenuItem");
            // 
            // upperPositionToolStripMenuItem
            // 
            this.upperPositionToolStripMenuItem.Name = "upperPositionToolStripMenuItem";
            resources.ApplyResources(this.upperPositionToolStripMenuItem, "upperPositionToolStripMenuItem");
            this.upperPositionToolStripMenuItem.Click += new System.EventHandler(this.UpperPositionToolStripMenuItem_Click);
            // 
            // teachRadiusTopToolStripMenuItem
            // 
            this.teachRadiusTopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.teachRadiusTopToolStripMenuItem.Name = "teachRadiusTopToolStripMenuItem";
            resources.ApplyResources(this.teachRadiusTopToolStripMenuItem, "teachRadiusTopToolStripMenuItem");
            // 
            // toolStripTextBox2
            // 
            resources.ApplyResources(this.toolStripTextBox2, "toolStripTextBox2");
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.ToolStripTextBox2_TextChanged);
            // 
            // lowerPositionToolStripMenuItem
            // 
            this.lowerPositionToolStripMenuItem.Name = "lowerPositionToolStripMenuItem";
            resources.ApplyResources(this.lowerPositionToolStripMenuItem, "lowerPositionToolStripMenuItem");
            this.lowerPositionToolStripMenuItem.Click += new System.EventHandler(this.LowerPositionToolStripMenuItem_Click);
            // 
            // teachRadiusBottomToolStripMenuItem
            // 
            this.teachRadiusBottomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.teachRadiusBottomToolStripMenuItem.Name = "teachRadiusBottomToolStripMenuItem";
            resources.ApplyResources(this.teachRadiusBottomToolStripMenuItem, "teachRadiusBottomToolStripMenuItem");
            // 
            // toolStripTextBox3
            // 
            resources.ApplyResources(this.toolStripTextBox3, "toolStripTextBox3");
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Leave += new System.EventHandler(this.ToolStripTextBox3_Leave);
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.ToolStripTextBox3_TextChanged);
            // 
            // teachOffsetToolStripMenuItem
            // 
            this.teachOffsetToolStripMenuItem.AutoToolTip = true;
            this.teachOffsetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachToolStripMenuItem});
            this.teachOffsetToolStripMenuItem.Name = "teachOffsetToolStripMenuItem";
            resources.ApplyResources(this.teachOffsetToolStripMenuItem, "teachOffsetToolStripMenuItem");
            // 
            // teachToolStripMenuItem
            // 
            this.teachToolStripMenuItem.Name = "teachToolStripMenuItem";
            resources.ApplyResources(this.teachToolStripMenuItem, "teachToolStripMenuItem");
            this.teachToolStripMenuItem.Click += new System.EventHandler(this.TeachToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.crossHairsToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            resources.ApplyResources(this.colorsToolStripMenuItem, "colorsToolStripMenuItem");
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            resources.ApplyResources(this.textToolStripMenuItem, "textToolStripMenuItem");
            this.textToolStripMenuItem.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // crossHairsToolStripMenuItem
            // 
            this.crossHairsToolStripMenuItem.Name = "crossHairsToolStripMenuItem";
            resources.ApplyResources(this.crossHairsToolStripMenuItem, "crossHairsToolStripMenuItem");
            this.crossHairsToolStripMenuItem.Click += new System.EventHandler(this.CrossHairsToolStripMenuItem_Click);
            // 
            // setZeroToolStripMenuItem
            // 
            this.setZeroToolStripMenuItem.AutoToolTip = true;
            this.setZeroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teachZeroPositionToolStripMenuItem,
            this.teachMarkerPositionToolStripMenuItem});
            this.setZeroToolStripMenuItem.Name = "setZeroToolStripMenuItem";
            resources.ApplyResources(this.setZeroToolStripMenuItem, "setZeroToolStripMenuItem");
            // 
            // teachZeroPositionToolStripMenuItem
            // 
            this.teachZeroPositionToolStripMenuItem.Name = "teachZeroPositionToolStripMenuItem";
            resources.ApplyResources(this.teachZeroPositionToolStripMenuItem, "teachZeroPositionToolStripMenuItem");
            this.teachZeroPositionToolStripMenuItem.Click += new System.EventHandler(this.BtnSetOffsetZero_Click);
            // 
            // teachMarkerPositionToolStripMenuItem
            // 
            this.teachMarkerPositionToolStripMenuItem.Name = "teachMarkerPositionToolStripMenuItem";
            resources.ApplyResources(this.teachMarkerPositionToolStripMenuItem, "teachMarkerPositionToolStripMenuItem");
            this.teachMarkerPositionToolStripMenuItem.Click += new System.EventHandler(this.BtnSetOffsetMarker_Click);
            // 
            // btnApplyAngle
            // 
            resources.ApplyResources(this.btnApplyAngle, "btnApplyAngle");
            this.btnApplyAngle.Name = "btnApplyAngle";
            this.toolTip1.SetToolTip(this.btnApplyAngle, resources.GetString("btnApplyAngle.ToolTip"));
            this.btnApplyAngle.UseVisualStyleBackColor = true;
            this.btnApplyAngle.Click += new System.EventHandler(this.BtnApplyAngle_Click);
            // 
            // btnCamCoordTool
            // 
            this.btnCamCoordTool.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnCamCoordTool, "btnCamCoordTool");
            this.btnCamCoordTool.Name = "btnCamCoordTool";
            this.toolTip1.SetToolTip(this.btnCamCoordTool, resources.GetString("btnCamCoordTool.ToolTip"));
            this.btnCamCoordTool.UseVisualStyleBackColor = false;
            this.btnCamCoordTool.Click += new System.EventHandler(this.BtnCamCoordTool_Click);
            // 
            // cBCamCoordMove
            // 
            resources.ApplyResources(this.cBCamCoordMove, "cBCamCoordMove");
            this.cBCamCoordMove.Name = "cBCamCoordMove";
            this.toolTip1.SetToolTip(this.cBCamCoordMove, resources.GetString("cBCamCoordMove.ToolTip"));
            this.cBCamCoordMove.UseVisualStyleBackColor = true;
            // 
            // lblAngle
            // 
            resources.ApplyResources(this.lblAngle, "lblAngle");
            this.lblAngle.Name = "lblAngle";
            this.toolTip1.SetToolTip(this.lblAngle, resources.GetString("lblAngle.ToolTip"));
            // 
            // btnCamCoordCam
            // 
            resources.ApplyResources(this.btnCamCoordCam, "btnCamCoordCam");
            this.btnCamCoordCam.Name = "btnCamCoordCam";
            this.toolTip1.SetToolTip(this.btnCamCoordCam, resources.GetString("btnCamCoordCam.ToolTip"));
            this.btnCamCoordCam.UseVisualStyleBackColor = true;
            this.btnCamCoordCam.Click += new System.EventHandler(this.BtnCamCoordCam_Click);
            // 
            // lblOffset
            // 
            resources.ApplyResources(this.lblOffset, "lblOffset");
            this.lblOffset.Name = "lblOffset";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nUDCameraZoom);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCamCoordTool);
            this.groupBox2.Controls.Add(this.btnCamCoordCam);
            this.groupBox2.Controls.Add(this.cBCamCoordMove);
            this.groupBox2.Controls.Add(this.lblOffset);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblCenterPos
            // 
            resources.ApplyResources(this.lblCenterPos, "lblCenterPos");
            this.lblCenterPos.Name = "lblCenterPos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBRotateArround0);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblAngle);
            this.groupBox3.Controls.Add(this.btnApplyAngle);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cBShapeDetection
            // 
            resources.ApplyResources(this.cBShapeDetection, "cBShapeDetection");
            this.cBShapeDetection.Name = "cBShapeDetection";
            this.cBShapeDetection.UseVisualStyleBackColor = true;
            this.cBShapeDetection.CheckedChanged += new System.EventHandler(this.CbShapeDetection_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblCenterPos);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.btnAutoCenter);
            this.groupBox4.Controls.Add(this.cBShapeDetection);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnAutoCenter
            // 
            resources.ApplyResources(this.btnAutoCenter, "btnAutoCenter");
            this.btnAutoCenter.Name = "btnAutoCenter";
            this.btnAutoCenter.UseVisualStyleBackColor = true;
            this.btnAutoCenter.Click += new System.EventHandler(this.BtnAutoCenter_Click);
            // 
            // resetOffsetG921ToolStripMenuItem
            // 
            this.resetOffsetG921ToolStripMenuItem.Name = "resetOffsetG921ToolStripMenuItem";
            resources.ApplyResources(this.resetOffsetG921ToolStripMenuItem, "resetOffsetG921ToolStripMenuItem");
            this.resetOffsetG921ToolStripMenuItem.Click += new System.EventHandler(this.ResetOffsetG921ToolStripMenuItem_Click);
            // 
            // cBRotateArround0
            // 
            resources.ApplyResources(this.cBRotateArround0, "cBRotateArround0");
            this.cBRotateArround0.Checked = global::GrblPlotter.Properties.Settings.Default.cameraRotateArround0;
            this.cBRotateArround0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBRotateArround0.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPlotter.Properties.Settings.Default, "cameraRotateArround0", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cBRotateArround0.Name = "cBRotateArround0";
            this.cBRotateArround0.UseVisualStyleBackColor = true;
            // 
            // ControlCameraForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxVideo);
            this.Controls.Add(this.menuStripCamera);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripCamera;
            this.MaximizeBox = false;
            this.Name = "ControlCameraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camera_form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Camera_form_FormClosed);
            this.Load += new System.EventHandler(this.Camera_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlCameraForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControlCameraForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            this.cmsPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCameraZoom)).EndInit();
            this.menuStripCamera.ResumeLayout(false);
            this.menuStripCamera.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.NumericUpDown nUDCameraZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStripCamera;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCamCoordTool;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.ToolStripMenuItem setZeroToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBCamCoordMove;
        private System.Windows.Forms.Button btnApplyAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button btnCamCoordCam;
        private System.Windows.Forms.ToolStripMenuItem teachZeroPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachMarkerPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachScalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachRadiusTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem lowerPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachRadiusBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripMenuItem teachOffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRotationAngleToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossHairsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cBShapeDetection;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAutoCenter;
        private System.Windows.Forms.Label lblCenterPos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip cmsPictureBox;
        private System.Windows.Forms.ToolStripMenuItem moveMarkerToCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compensateAngleToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showOverlayGraphicsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBRotateArround0;
        private System.Windows.Forms.ToolStripMenuItem resetOffsetG921ToolStripMenuItem;
    }
}