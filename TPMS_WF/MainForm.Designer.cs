namespace TPMS_WF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFrontLeftPressure = new System.Windows.Forms.Label();
            this.lblFrontRightPressure = new System.Windows.Forms.Label();
            this.lblBackLeftPressure = new System.Windows.Forms.Label();
            this.lblBackRightPressure = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.lblFrontLeftTemperature = new System.Windows.Forms.Label();
            this.lblBackLeftTemperature = new System.Windows.Forms.Label();
            this.lblFrontRightTemperature = new System.Windows.Forms.Label();
            this.lblBackRightTemperature = new System.Windows.Forms.Label();
            this.btnFrontLeftTireHistory = new System.Windows.Forms.Button();
            this.btnBackLeftTireHistory = new System.Windows.Forms.Button();
            this.btnFrontRightTireHistory = new System.Windows.Forms.Button();
            this.btnBackRightTireHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrontLeftPressure
            // 
            this.lblFrontLeftPressure.AutoSize = true;
            this.lblFrontLeftPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrontLeftPressure.Location = new System.Drawing.Point(23, 109);
            this.lblFrontLeftPressure.Name = "lblFrontLeftPressure";
            this.lblFrontLeftPressure.Size = new System.Drawing.Size(77, 25);
            this.lblFrontLeftPressure.TabIndex = 1;
            this.lblFrontLeftPressure.Text = "--- кПа";
            // 
            // lblFrontRightPressure
            // 
            this.lblFrontRightPressure.AutoSize = true;
            this.lblFrontRightPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrontRightPressure.Location = new System.Drawing.Point(660, 109);
            this.lblFrontRightPressure.Name = "lblFrontRightPressure";
            this.lblFrontRightPressure.Size = new System.Drawing.Size(77, 25);
            this.lblFrontRightPressure.TabIndex = 2;
            this.lblFrontRightPressure.Text = "--- кПа";
            // 
            // lblBackLeftPressure
            // 
            this.lblBackLeftPressure.AutoSize = true;
            this.lblBackLeftPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackLeftPressure.Location = new System.Drawing.Point(23, 368);
            this.lblBackLeftPressure.Name = "lblBackLeftPressure";
            this.lblBackLeftPressure.Size = new System.Drawing.Size(77, 25);
            this.lblBackLeftPressure.TabIndex = 3;
            this.lblBackLeftPressure.Text = "--- кПа";
            // 
            // lblBackRightPressure
            // 
            this.lblBackRightPressure.AutoSize = true;
            this.lblBackRightPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackRightPressure.Location = new System.Drawing.Point(660, 368);
            this.lblBackRightPressure.Name = "lblBackRightPressure";
            this.lblBackRightPressure.Size = new System.Drawing.Size(77, 25);
            this.lblBackRightPressure.TabIndex = 4;
            this.lblBackRightPressure.Text = "--- кПа";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = global::TPMS_WF.Properties.Resources.carWithTire;
            this.pictureBoxMain.Location = new System.Drawing.Point(135, 13);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(495, 498);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // lblFrontLeftTemperature
            // 
            this.lblFrontLeftTemperature.AutoSize = true;
            this.lblFrontLeftTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrontLeftTemperature.Location = new System.Drawing.Point(23, 134);
            this.lblFrontLeftTemperature.Name = "lblFrontLeftTemperature";
            this.lblFrontLeftTemperature.Size = new System.Drawing.Size(55, 25);
            this.lblFrontLeftTemperature.TabIndex = 5;
            this.lblFrontLeftTemperature.Text = "-- °С";
            // 
            // lblBackLeftTemperature
            // 
            this.lblBackLeftTemperature.AutoSize = true;
            this.lblBackLeftTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackLeftTemperature.Location = new System.Drawing.Point(23, 393);
            this.lblBackLeftTemperature.Name = "lblBackLeftTemperature";
            this.lblBackLeftTemperature.Size = new System.Drawing.Size(55, 25);
            this.lblBackLeftTemperature.TabIndex = 6;
            this.lblBackLeftTemperature.Text = "-- °С";
            // 
            // lblFrontRightTemperature
            // 
            this.lblFrontRightTemperature.AutoSize = true;
            this.lblFrontRightTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrontRightTemperature.Location = new System.Drawing.Point(660, 134);
            this.lblFrontRightTemperature.Name = "lblFrontRightTemperature";
            this.lblFrontRightTemperature.Size = new System.Drawing.Size(55, 25);
            this.lblFrontRightTemperature.TabIndex = 7;
            this.lblFrontRightTemperature.Text = "-- °С";
            // 
            // lblBackRightTemperature
            // 
            this.lblBackRightTemperature.AutoSize = true;
            this.lblBackRightTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackRightTemperature.Location = new System.Drawing.Point(660, 393);
            this.lblBackRightTemperature.Name = "lblBackRightTemperature";
            this.lblBackRightTemperature.Size = new System.Drawing.Size(55, 25);
            this.lblBackRightTemperature.TabIndex = 8;
            this.lblBackRightTemperature.Text = "-- °С";
            // 
            // btnFrontLeftTireHistory
            // 
            this.btnFrontLeftTireHistory.Location = new System.Drawing.Point(12, 162);
            this.btnFrontLeftTireHistory.Name = "btnFrontLeftTireHistory";
            this.btnFrontLeftTireHistory.Size = new System.Drawing.Size(88, 23);
            this.btnFrontLeftTireHistory.TabIndex = 9;
            this.btnFrontLeftTireHistory.Text = "История";
            this.btnFrontLeftTireHistory.UseVisualStyleBackColor = true;
            this.btnFrontLeftTireHistory.Click += new System.EventHandler(this.btnFrontLeftTireHistory_Click);
            // 
            // btnBackLeftTireHistory
            // 
            this.btnBackLeftTireHistory.Location = new System.Drawing.Point(12, 421);
            this.btnBackLeftTireHistory.Name = "btnBackLeftTireHistory";
            this.btnBackLeftTireHistory.Size = new System.Drawing.Size(88, 23);
            this.btnBackLeftTireHistory.TabIndex = 10;
            this.btnBackLeftTireHistory.Text = "История";
            this.btnBackLeftTireHistory.UseVisualStyleBackColor = true;
            this.btnBackLeftTireHistory.Click += new System.EventHandler(this.btnBackLeftTireHistory_Click);
            // 
            // btnFrontRightTireHistory
            // 
            this.btnFrontRightTireHistory.Location = new System.Drawing.Point(665, 162);
            this.btnFrontRightTireHistory.Name = "btnFrontRightTireHistory";
            this.btnFrontRightTireHistory.Size = new System.Drawing.Size(88, 23);
            this.btnFrontRightTireHistory.TabIndex = 11;
            this.btnFrontRightTireHistory.Text = "История";
            this.btnFrontRightTireHistory.UseVisualStyleBackColor = true;
            this.btnFrontRightTireHistory.Click += new System.EventHandler(this.btnFrontRightTireHistory_Click);
            // 
            // btnBackRightTireHistory
            // 
            this.btnBackRightTireHistory.Location = new System.Drawing.Point(660, 421);
            this.btnBackRightTireHistory.Name = "btnBackRightTireHistory";
            this.btnBackRightTireHistory.Size = new System.Drawing.Size(88, 23);
            this.btnBackRightTireHistory.TabIndex = 12;
            this.btnBackRightTireHistory.Text = "История";
            this.btnBackRightTireHistory.UseVisualStyleBackColor = true;
            this.btnBackRightTireHistory.Click += new System.EventHandler(this.btnBackRightTireHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 523);
            this.Controls.Add(this.btnBackRightTireHistory);
            this.Controls.Add(this.btnFrontRightTireHistory);
            this.Controls.Add(this.btnBackLeftTireHistory);
            this.Controls.Add(this.btnFrontLeftTireHistory);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.lblBackRightTemperature);
            this.Controls.Add(this.lblFrontLeftPressure);
            this.Controls.Add(this.lblBackRightPressure);
            this.Controls.Add(this.lblFrontRightTemperature);
            this.Controls.Add(this.lblFrontLeftTemperature);
            this.Controls.Add(this.lblFrontRightPressure);
            this.Controls.Add(this.lblBackLeftPressure);
            this.Controls.Add(this.lblBackLeftTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "TPMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label lblFrontLeftPressure;
        private System.Windows.Forms.Label lblFrontRightPressure;
        private System.Windows.Forms.Label lblBackLeftPressure;
        private System.Windows.Forms.Label lblBackRightPressure;
        private System.Windows.Forms.Label lblFrontLeftTemperature;
        private System.Windows.Forms.Label lblBackLeftTemperature;
        private System.Windows.Forms.Label lblFrontRightTemperature;
        private System.Windows.Forms.Label lblBackRightTemperature;
        private System.Windows.Forms.Button btnFrontLeftTireHistory;
        private System.Windows.Forms.Button btnBackLeftTireHistory;
        private System.Windows.Forms.Button btnFrontRightTireHistory;
        private System.Windows.Forms.Button btnBackRightTireHistory;
    }
}

