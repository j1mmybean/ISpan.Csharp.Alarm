namespace Alarm.win
{
    partial class Alarm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerInstantTime = new System.Windows.Forms.Timer(this.components);
            this.labInstantTime = new System.Windows.Forms.Label();
            this.labAlarmTIme = new System.Windows.Forms.Label();
            this.gbSelectTime = new System.Windows.Forms.GroupBox();
            this.cbSetAlarm = new System.Windows.Forms.CheckBox();
            this.mtxtAlarmTime = new System.Windows.Forms.MaskedTextBox();
            this.gbSelectTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerInstantTime
            // 
            this.timerInstantTime.Tick += new System.EventHandler(this.timerInstantTime_Tick);
            // 
            // labInstantTime
            // 
            this.labInstantTime.AutoSize = true;
            this.labInstantTime.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstantTime.Location = new System.Drawing.Point(27, 59);
            this.labInstantTime.Name = "labInstantTime";
            this.labInstantTime.Size = new System.Drawing.Size(158, 30);
            this.labInstantTime.TabIndex = 0;
            this.labInstantTime.Text = "Instant Time";
            // 
            // labAlarmTIme
            // 
            this.labAlarmTIme.AutoSize = true;
            this.labAlarmTIme.Location = new System.Drawing.Point(63, 121);
            this.labAlarmTIme.Name = "labAlarmTIme";
            this.labAlarmTIme.Size = new System.Drawing.Size(130, 23);
            this.labAlarmTIme.TabIndex = 1;
            this.labAlarmTIme.Text = "Alarm Time :";
            // 
            // gbSelectTime
            // 
            this.gbSelectTime.Controls.Add(this.mtxtAlarmTime);
            this.gbSelectTime.Controls.Add(this.cbSetAlarm);
            this.gbSelectTime.Controls.Add(this.labAlarmTIme);
            this.gbSelectTime.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbSelectTime.Location = new System.Drawing.Point(150, 124);
            this.gbSelectTime.Name = "gbSelectTime";
            this.gbSelectTime.Size = new System.Drawing.Size(475, 265);
            this.gbSelectTime.TabIndex = 2;
            this.gbSelectTime.TabStop = false;
            this.gbSelectTime.Text = "Select Time";
            // 
            // cbSetAlarm
            // 
            this.cbSetAlarm.AutoSize = true;
            this.cbSetAlarm.Location = new System.Drawing.Point(205, 174);
            this.cbSetAlarm.Name = "cbSetAlarm";
            this.cbSetAlarm.Size = new System.Drawing.Size(122, 27);
            this.cbSetAlarm.TabIndex = 3;
            this.cbSetAlarm.Text = "Set Alarm";
            this.cbSetAlarm.UseVisualStyleBackColor = true;
            // 
            // mtxtAlarmTime
            // 
            this.mtxtAlarmTime.Location = new System.Drawing.Point(205, 118);
            this.mtxtAlarmTime.Mask = "00時00分00秒";
            this.mtxtAlarmTime.Name = "mtxtAlarmTime";
            this.mtxtAlarmTime.RejectInputOnFirstFailure = true;
            this.mtxtAlarmTime.ResetOnPrompt = false;
            this.mtxtAlarmTime.Size = new System.Drawing.Size(142, 35);
            this.mtxtAlarmTime.TabIndex = 3;
            this.mtxtAlarmTime.ValidatingType = typeof(System.DateTime);
            this.mtxtAlarmTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtAlarmTime_MaskInputRejected);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSelectTime);
            this.Controls.Add(this.labInstantTime);
            this.Name = "Alarm";
            this.Text = "Alarm";
            this.gbSelectTime.ResumeLayout(false);
            this.gbSelectTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerInstantTime;
        private System.Windows.Forms.Label labInstantTime;
        private System.Windows.Forms.Label labAlarmTIme;
        private System.Windows.Forms.GroupBox gbSelectTime;
        private System.Windows.Forms.CheckBox cbSetAlarm;
        private System.Windows.Forms.MaskedTextBox mtxtAlarmTime;
    }
}

