namespace WindowsFormsAppCruiser
{
    partial class FormParking
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
            this.buttonSet = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelMesto = new System.Windows.Forms.Label();
            this.TakeOut = new System.Windows.Forms.Button();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.groupBoxLevels = new System.Windows.Forms.GroupBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.groupBoxLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(23, 188);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 6;
            this.buttonSet.Text = "Поставить";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(753, 290);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(96, 22);
            this.maskedTextBox.TabIndex = 12;
            // 
            // labelMesto
            // 
            this.labelMesto.AutoSize = true;
            this.labelMesto.Location = new System.Drawing.Point(750, 274);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(49, 17);
            this.labelMesto.TabIndex = 14;
            this.labelMesto.Text = "Место";
            // 
            // TakeOut
            // 
            this.TakeOut.Location = new System.Drawing.Point(753, 316);
            this.TakeOut.Name = "TakeOut";
            this.TakeOut.Size = new System.Drawing.Size(75, 23);
            this.TakeOut.TabIndex = 15;
            this.TakeOut.Text = "Забрать";
            this.TakeOut.UseVisualStyleBackColor = true;
            this.TakeOut.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(746, 358);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(126, 91);
            this.pictureBoxTakeShip.TabIndex = 16;
            this.pictureBoxTakeShip.TabStop = false;
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Location = new System.Drawing.Point(740, 255);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(144, 194);
            this.groupBoxTake.TabIndex = 23;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать";
            // 
            // groupBoxLevels
            // 
            this.groupBoxLevels.Controls.Add(this.listBoxLevels);
            this.groupBoxLevels.Controls.Add(this.buttonSet);
            this.groupBoxLevels.Location = new System.Drawing.Point(740, 2);
            this.groupBoxLevels.Name = "groupBoxLevels";
            this.groupBoxLevels.Size = new System.Drawing.Size(144, 237);
            this.groupBoxLevels.TabIndex = 22;
            this.groupBoxLevels.TabStop = false;
            this.groupBoxLevels.Text = "Уровни";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(12, 21);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 116);
            this.listBoxLevels.TabIndex = 0;
            this.listBoxLevels.Click += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(734, 459);
            this.pictureBoxParking.TabIndex = 17;
            this.pictureBoxParking.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(886, 461);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.TakeOut);
            this.Controls.Add(this.labelMesto);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.groupBoxLevels);
            this.Name = "FormParking";
            this.Text = "Cruiser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.groupBoxLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.Button TakeOut;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.GroupBox groupBoxLevels;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}