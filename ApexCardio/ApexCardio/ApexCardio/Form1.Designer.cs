﻿namespace ApexCardio
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.butPumpsStop = new System.Windows.Forms.Button();
            this.butPumpsStart = new System.Windows.Forms.Button();
            this.labBP2 = new System.Windows.Forms.Label();
            this.labBP1 = new System.Windows.Forms.Label();
            this.butBPabort2 = new System.Windows.Forms.Button();
            this.butBPmeas2 = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.butBPabort1 = new System.Windows.Forms.Button();
            this.butBPMeas1 = new System.Windows.Forms.Button();
            this.butNewRecord = new System.Windows.Forms.Button();
            this.pbRecordProgress = new System.Windows.Forms.ProgressBar();
            this.butPump2stop = new System.Windows.Forms.Button();
            this.butPump2start = new System.Windows.Forms.Button();
            this.butPump1stop = new System.Windows.Forms.Button();
            this.butPump1start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numUDplevel2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDplevel1 = new System.Windows.Forms.NumericUpDown();
            this.labP3 = new System.Windows.Forms.Label();
            this.labP2 = new System.Windows.Forms.Label();
            this.labP1 = new System.Windows.Forms.Label();
            this.butEditRecInfo = new System.Windows.Forms.Button();
            this.butFlow = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.textBoxRecInfo = new System.Windows.Forms.TextBox();
            this.labRecordSize = new System.Windows.Forms.Label();
            this.butSaveRecord = new System.Windows.Forms.Button();
            this.butStartRecord = new System.Windows.Forms.Button();
            this.butSettings = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.labConnected = new System.Windows.Forms.Label();
            this.panelAmp = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerPaint = new System.Windows.Forms.Timer(this.components);
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDplevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDplevel1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRead
            // 
            this.timerRead.Enabled = true;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelGraph, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hScrollBar1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labConnected, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelAmp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 502);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelGraph
            // 
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(343, 3);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(498, 431);
            this.panelGraph.TabIndex = 0;
            this.panelGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BufPanel_MouseDown);
            this.panelGraph.Resize += new System.EventHandler(this.panelGraph_Resize);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.label1);
            this.panelButtons.Controls.Add(this.butPumpsStop);
            this.panelButtons.Controls.Add(this.butPumpsStart);
            this.panelButtons.Controls.Add(this.labBP2);
            this.panelButtons.Controls.Add(this.labBP1);
            this.panelButtons.Controls.Add(this.butBPabort2);
            this.panelButtons.Controls.Add(this.butBPmeas2);
            this.panelButtons.Controls.Add(this.labStatus);
            this.panelButtons.Controls.Add(this.butBPabort1);
            this.panelButtons.Controls.Add(this.butBPMeas1);
            this.panelButtons.Controls.Add(this.butNewRecord);
            this.panelButtons.Controls.Add(this.pbRecordProgress);
            this.panelButtons.Controls.Add(this.butPump2stop);
            this.panelButtons.Controls.Add(this.butPump2start);
            this.panelButtons.Controls.Add(this.butPump1stop);
            this.panelButtons.Controls.Add(this.butPump1start);
            this.panelButtons.Controls.Add(this.label3);
            this.panelButtons.Controls.Add(this.numUDplevel2);
            this.panelButtons.Controls.Add(this.label2);
            this.panelButtons.Controls.Add(this.numUDplevel1);
            this.panelButtons.Controls.Add(this.labP3);
            this.panelButtons.Controls.Add(this.labP2);
            this.panelButtons.Controls.Add(this.labP1);
            this.panelButtons.Controls.Add(this.butEditRecInfo);
            this.panelButtons.Controls.Add(this.butFlow);
            this.panelButtons.Controls.Add(this.butOpenFile);
            this.panelButtons.Controls.Add(this.textBoxRecInfo);
            this.panelButtons.Controls.Add(this.labRecordSize);
            this.panelButtons.Controls.Add(this.butSaveRecord);
            this.panelButtons.Controls.Add(this.butStartRecord);
            this.panelButtons.Controls.Add(this.butSettings);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(294, 431);
            this.panelButtons.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // butPumpsStop
            // 
            this.butPumpsStop.Location = new System.Drawing.Point(220, 182);
            this.butPumpsStop.Name = "butPumpsStop";
            this.butPumpsStop.Size = new System.Drawing.Size(20, 52);
            this.butPumpsStop.TabIndex = 31;
            this.butPumpsStop.Text = "X";
            this.butPumpsStop.UseVisualStyleBackColor = true;
            this.butPumpsStop.Click += new System.EventHandler(this.butPumpsStop_Click);
            // 
            // butPumpsStart
            // 
            this.butPumpsStart.Location = new System.Drawing.Point(157, 182);
            this.butPumpsStart.Name = "butPumpsStart";
            this.butPumpsStart.Size = new System.Drawing.Size(20, 52);
            this.butPumpsStart.TabIndex = 30;
            this.butPumpsStart.Text = ">";
            this.butPumpsStart.UseVisualStyleBackColor = true;
            this.butPumpsStart.Click += new System.EventHandler(this.butPumpsStart_Click);
            // 
            // labBP2
            // 
            this.labBP2.AutoSize = true;
            this.labBP2.Location = new System.Drawing.Point(192, 101);
            this.labBP2.Name = "labBP2";
            this.labBP2.Size = new System.Drawing.Size(37, 13);
            this.labBP2.TabIndex = 29;
            this.labBP2.Text = "ABP 2";
            // 
            // labBP1
            // 
            this.labBP1.AutoSize = true;
            this.labBP1.Location = new System.Drawing.Point(192, 72);
            this.labBP1.Name = "labBP1";
            this.labBP1.Size = new System.Drawing.Size(37, 13);
            this.labBP1.TabIndex = 28;
            this.labBP1.Text = "ABP 1";
            // 
            // butBPabort2
            // 
            this.butBPabort2.Location = new System.Drawing.Point(99, 96);
            this.butBPabort2.Name = "butBPabort2";
            this.butBPabort2.Size = new System.Drawing.Size(75, 23);
            this.butBPabort2.TabIndex = 27;
            this.butBPabort2.Text = "Abort ABP";
            this.butBPabort2.UseVisualStyleBackColor = true;
            this.butBPabort2.Click += new System.EventHandler(this.butBPabort2_Click);
            // 
            // butBPmeas2
            // 
            this.butBPmeas2.Location = new System.Drawing.Point(13, 96);
            this.butBPmeas2.Name = "butBPmeas2";
            this.butBPmeas2.Size = new System.Drawing.Size(75, 23);
            this.butBPmeas2.TabIndex = 26;
            this.butBPmeas2.Text = "Start ABP 2";
            this.butBPmeas2.UseVisualStyleBackColor = true;
            this.butBPmeas2.Click += new System.EventHandler(this.butBPmeas2_Click);
            // 
            // labStatus
            // 
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(116, 426);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(35, 13);
            this.labStatus.TabIndex = 25;
            this.labStatus.Text = "label1";
            // 
            // butBPabort1
            // 
            this.butBPabort1.Location = new System.Drawing.Point(99, 67);
            this.butBPabort1.Name = "butBPabort1";
            this.butBPabort1.Size = new System.Drawing.Size(75, 23);
            this.butBPabort1.TabIndex = 24;
            this.butBPabort1.Text = "Abort ABP";
            this.butBPabort1.UseVisualStyleBackColor = true;
            this.butBPabort1.Click += new System.EventHandler(this.butBPabort_Click);
            // 
            // butBPMeas1
            // 
            this.butBPMeas1.Location = new System.Drawing.Point(13, 67);
            this.butBPMeas1.Name = "butBPMeas1";
            this.butBPMeas1.Size = new System.Drawing.Size(75, 23);
            this.butBPMeas1.TabIndex = 23;
            this.butBPMeas1.Text = "Start ABP 1";
            this.butBPMeas1.UseVisualStyleBackColor = true;
            this.butBPMeas1.Click += new System.EventHandler(this.butBPMeas_Click);
            // 
            // butNewRecord
            // 
            this.butNewRecord.Location = new System.Drawing.Point(13, 38);
            this.butNewRecord.Name = "butNewRecord";
            this.butNewRecord.Size = new System.Drawing.Size(75, 23);
            this.butNewRecord.TabIndex = 22;
            this.butNewRecord.Text = "New record";
            this.butNewRecord.UseVisualStyleBackColor = true;
            this.butNewRecord.Click += new System.EventHandler(this.butNewRecord_Click);
            // 
            // pbRecordProgress
            // 
            this.pbRecordProgress.Location = new System.Drawing.Point(99, 125);
            this.pbRecordProgress.Name = "pbRecordProgress";
            this.pbRecordProgress.Size = new System.Drawing.Size(180, 23);
            this.pbRecordProgress.TabIndex = 21;
            this.pbRecordProgress.Visible = false;
            // 
            // butPump2stop
            // 
            this.butPump2stop.Location = new System.Drawing.Point(242, 211);
            this.butPump2stop.Name = "butPump2stop";
            this.butPump2stop.Size = new System.Drawing.Size(37, 23);
            this.butPump2stop.TabIndex = 20;
            this.butPump2stop.Text = "Stop";
            this.butPump2stop.UseVisualStyleBackColor = true;
            this.butPump2stop.Click += new System.EventHandler(this.butPump2stop_Click);
            // 
            // butPump2start
            // 
            this.butPump2start.Location = new System.Drawing.Point(177, 211);
            this.butPump2start.Name = "butPump2start";
            this.butPump2start.Size = new System.Drawing.Size(37, 23);
            this.butPump2start.TabIndex = 19;
            this.butPump2start.Text = "Start";
            this.butPump2start.UseVisualStyleBackColor = true;
            this.butPump2start.Click += new System.EventHandler(this.butPump2start_Click);
            // 
            // butPump1stop
            // 
            this.butPump1stop.Location = new System.Drawing.Point(242, 182);
            this.butPump1stop.Name = "butPump1stop";
            this.butPump1stop.Size = new System.Drawing.Size(37, 23);
            this.butPump1stop.TabIndex = 18;
            this.butPump1stop.Text = "Stop";
            this.butPump1stop.UseVisualStyleBackColor = true;
            this.butPump1stop.Click += new System.EventHandler(this.butPump1stop_Click);
            // 
            // butPump1start
            // 
            this.butPump1start.Location = new System.Drawing.Point(177, 182);
            this.butPump1start.Name = "butPump1start";
            this.butPump1start.Size = new System.Drawing.Size(37, 23);
            this.butPump1start.TabIndex = 17;
            this.butPump1start.Text = "Start";
            this.butPump1start.UseVisualStyleBackColor = true;
            this.butPump1start.Click += new System.EventHandler(this.butPump1start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pressure level 2";
            // 
            // numUDplevel2
            // 
            this.numUDplevel2.Location = new System.Drawing.Point(103, 214);
            this.numUDplevel2.Name = "numUDplevel2";
            this.numUDplevel2.Size = new System.Drawing.Size(48, 20);
            this.numUDplevel2.TabIndex = 15;
            this.numUDplevel2.ValueChanged += new System.EventHandler(this.numUDplevel2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pressure level 1";
            // 
            // numUDplevel1
            // 
            this.numUDplevel1.Location = new System.Drawing.Point(103, 185);
            this.numUDplevel1.Name = "numUDplevel1";
            this.numUDplevel1.Size = new System.Drawing.Size(48, 20);
            this.numUDplevel1.TabIndex = 13;
            this.numUDplevel1.ValueChanged += new System.EventHandler(this.numUDplevel1_ValueChanged);
            // 
            // labP3
            // 
            this.labP3.AutoSize = true;
            this.labP3.Location = new System.Drawing.Point(230, 449);
            this.labP3.Name = "labP3";
            this.labP3.Size = new System.Drawing.Size(20, 13);
            this.labP3.TabIndex = 12;
            this.labP3.Text = "P3";
            this.labP3.Visible = false;
            // 
            // labP2
            // 
            this.labP2.AutoSize = true;
            this.labP2.Location = new System.Drawing.Point(230, 436);
            this.labP2.Name = "labP2";
            this.labP2.Size = new System.Drawing.Size(20, 13);
            this.labP2.TabIndex = 11;
            this.labP2.Text = "P2";
            this.labP2.Visible = false;
            // 
            // labP1
            // 
            this.labP1.AutoSize = true;
            this.labP1.Location = new System.Drawing.Point(230, 423);
            this.labP1.Name = "labP1";
            this.labP1.Size = new System.Drawing.Size(20, 13);
            this.labP1.TabIndex = 10;
            this.labP1.Text = "P1";
            this.labP1.Visible = false;
            // 
            // butEditRecInfo
            // 
            this.butEditRecInfo.Location = new System.Drawing.Point(17, 426);
            this.butEditRecInfo.Name = "butEditRecInfo";
            this.butEditRecInfo.Size = new System.Drawing.Size(75, 23);
            this.butEditRecInfo.TabIndex = 2;
            this.butEditRecInfo.Text = "Edit";
            this.butEditRecInfo.UseVisualStyleBackColor = true;
            this.butEditRecInfo.Click += new System.EventHandler(this.butEditRecInfo_Click);
            // 
            // butFlow
            // 
            this.butFlow.Location = new System.Drawing.Point(13, 9);
            this.butFlow.Name = "butFlow";
            this.butFlow.Size = new System.Drawing.Size(75, 23);
            this.butFlow.TabIndex = 9;
            this.butFlow.Text = "Stop flow";
            this.butFlow.UseVisualStyleBackColor = true;
            this.butFlow.Click += new System.EventHandler(this.butFlow_Click);
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(204, 38);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(75, 23);
            this.butOpenFile.TabIndex = 8;
            this.butOpenFile.Text = "OpenFile";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.butOpenFile_Click);
            // 
            // textBoxRecInfo
            // 
            this.textBoxRecInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRecInfo.Location = new System.Drawing.Point(17, 251);
            this.textBoxRecInfo.Multiline = true;
            this.textBoxRecInfo.Name = "textBoxRecInfo";
            this.textBoxRecInfo.ReadOnly = true;
            this.textBoxRecInfo.Size = new System.Drawing.Size(266, 169);
            this.textBoxRecInfo.TabIndex = 7;
            // 
            // labRecordSize
            // 
            this.labRecordSize.AutoSize = true;
            this.labRecordSize.Location = new System.Drawing.Point(96, 154);
            this.labRecordSize.Name = "labRecordSize";
            this.labRecordSize.Size = new System.Drawing.Size(35, 13);
            this.labRecordSize.TabIndex = 6;
            this.labRecordSize.Text = "label2";
            this.labRecordSize.Visible = false;
            // 
            // butSaveRecord
            // 
            this.butSaveRecord.Location = new System.Drawing.Point(13, 154);
            this.butSaveRecord.Name = "butSaveRecord";
            this.butSaveRecord.Size = new System.Drawing.Size(75, 23);
            this.butSaveRecord.TabIndex = 5;
            this.butSaveRecord.Text = "Save record";
            this.butSaveRecord.UseVisualStyleBackColor = true;
            this.butSaveRecord.Click += new System.EventHandler(this.butSaveRecord_Click);
            // 
            // butStartRecord
            // 
            this.butStartRecord.Location = new System.Drawing.Point(13, 125);
            this.butStartRecord.Name = "butStartRecord";
            this.butStartRecord.Size = new System.Drawing.Size(75, 23);
            this.butStartRecord.TabIndex = 4;
            this.butStartRecord.Text = "Start record";
            this.butStartRecord.UseVisualStyleBackColor = true;
            this.butStartRecord.Click += new System.EventHandler(this.butStartRecord_Click);
            // 
            // butSettings
            // 
            this.butSettings.Location = new System.Drawing.Point(204, 9);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(75, 23);
            this.butSettings.TabIndex = 0;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.butSettings_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(340, 442);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(504, 20);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Visible = false;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // labConnected
            // 
            this.labConnected.AutoSize = true;
            this.labConnected.Dock = System.Windows.Forms.DockStyle.Left;
            this.labConnected.Location = new System.Drawing.Point(3, 437);
            this.labConnected.Name = "labConnected";
            this.labConnected.Size = new System.Drawing.Size(73, 25);
            this.labConnected.TabIndex = 3;
            this.labConnected.Text = "Disconnected";
            // 
            // panelAmp
            // 
            this.panelAmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAmp.Location = new System.Drawing.Point(303, 3);
            this.panelAmp.Name = "panelAmp";
            this.panelAmp.Size = new System.Drawing.Size(34, 431);
            this.panelAmp.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(343, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 34);
            this.panel1.TabIndex = 5;
            // 
            // timerPaint
            // 
            this.timerPaint.Enabled = true;
            this.timerPaint.Interval = 110;
            this.timerPaint.Tick += new System.EventHandler(this.timerPaint_Tick);
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 500;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.ValidateNames = false;
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 1000;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(860, 540);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDplevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDplevel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.Timer timerPaint;
        private System.Windows.Forms.Label labConnected;
        private System.Windows.Forms.Button butSaveRecord;
        private System.Windows.Forms.Button butStartRecord;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Label labRecordSize;
        private System.Windows.Forms.TextBox textBoxRecInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Panel panelAmp;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Button butFlow;
        private System.Windows.Forms.Button butEditRecInfo;
        private System.Windows.Forms.Label labP3;
        private System.Windows.Forms.Label labP2;
        private System.Windows.Forms.Label labP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUDplevel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDplevel1;
        private System.Windows.Forms.Button butPump2stop;
        private System.Windows.Forms.Button butPump2start;
        private System.Windows.Forms.Button butPump1stop;
        private System.Windows.Forms.Button butPump1start;
        private System.Windows.Forms.ProgressBar pbRecordProgress;
        private System.Windows.Forms.Button butNewRecord;
        private System.Windows.Forms.Button butBPMeas1;
        private System.Windows.Forms.Button butBPabort1;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.Button butBPabort2;
        private System.Windows.Forms.Button butBPmeas2;
        private System.Windows.Forms.Label labBP2;
        private System.Windows.Forms.Label labBP1;
        private System.Windows.Forms.Button butPumpsStop;
        private System.Windows.Forms.Button butPumpsStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

