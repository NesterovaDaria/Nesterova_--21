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
            this.pictureBoxCruiser = new System.Windows.Forms.PictureBox();
            this.Shep = new System.Windows.Forms.Button();
            this.Cruiser = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTake = new System.Windows.Forms.Label();
            this.labelMesto = new System.Windows.Forms.Label();
            this.TakeOut = new System.Windows.Forms.Button();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvianos
            // 
            this.pictureBoxCruiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCruiser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCruiser.Name = "pictureBoxCruiser";
            this.pictureBoxCruiser.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxCruiser.TabIndex = 5;
            this.pictureBoxCruiser.TabStop = false;
            // 
            // Shep
            // 
            this.Shep.Location = new System.Drawing.Point(809, 0);
            this.Shep.Name = "Shep";
            this.Shep.Size = new System.Drawing.Size(75, 23);
            this.Shep.TabIndex = 6;
            this.Shep.Text = "Shep";
            this.Shep.UseVisualStyleBackColor = true;
            this.Shep.Click += new System.EventHandler(this.buttonSetShip_Click);
            // 
            // Cruiser
            // 
            this.Cruiser.Location = new System.Drawing.Point(809, 29);
            this.Cruiser.Name = "Cruiser";
            this.Cruiser.Size = new System.Drawing.Size(75, 23);
            this.Cruiser.TabIndex = 11;
            this.Cruiser.Text = "Cruiser";
            this.Cruiser.UseVisualStyleBackColor = true;
            this.Cruiser.Click += new System.EventHandler(this.buttonSetCruiser_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(753, 290);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(96, 20);
            this.maskedTextBox.TabIndex = 12;
            // 
            // labelTake
            // 
            this.labelTake.AutoSize = true;
            this.labelTake.Location = new System.Drawing.Point(750, 261);
            this.labelTake.Name = "labelTake";
            this.labelTake.Size = new System.Drawing.Size(87, 13);
            this.labelTake.TabIndex = 13;
            this.labelTake.Text = "Заберите судно";
            // 
            // labelMesto
            // 
            this.labelMesto.AutoSize = true;
            this.labelMesto.Location = new System.Drawing.Point(750, 274);
            this.labelMesto.Name = "labelMesto";
            this.labelMesto.Size = new System.Drawing.Size(39, 13);
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
            // pictureBoxTakeShep
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(746, 358);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShep";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(126, 91);
            this.pictureBoxTakeShip.TabIndex = 16;
            this.pictureBoxTakeShip.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.TakeOut);
            this.Controls.Add(this.labelMesto);
            this.Controls.Add(this.labelTake);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.Cruiser);
            this.Controls.Add(this.Shep);
            this.Controls.Add(this.pictureBoxCruiser);
            this.Name = "FormParking";
            this.Text = "Cruiser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCruiser;
        private System.Windows.Forms.Button Shep;
        private System.Windows.Forms.Button Cruiser;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelTake;
        private System.Windows.Forms.Label labelMesto;
        private System.Windows.Forms.Button TakeOut;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.PictureBox pictureBoxParking;
    }
}