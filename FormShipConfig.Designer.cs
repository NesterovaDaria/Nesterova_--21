namespace WindowsFormsAppCruiser
{
    partial class FormShipConfig
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCruiser = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            
            this.paneldeeppink = new System.Windows.Forms.Panel();
            this.panelpurple = new System.Windows.Forms.Panel();
            this.paneldarkblue = new System.Windows.Forms.Panel();
            this.panellightgreen = new System.Windows.Forms.Panel();
            this.panelturquoise = new System.Windows.Forms.Panel();
            this.panellime = new System.Windows.Forms.Panel();
            this.panelyellow = new System.Windows.Forms.Panel();
            this.panelred = new System.Windows.Forms.Panel();
            this.panelgray = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(33, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(190, 109);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCruiser);
            this.groupBox1.Controls.Add(this.labelShip);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип корабля";
            // 
            // labelCruiser
            // 
            this.labelCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCruiser.Location = new System.Drawing.Point(32, 107);
            this.labelCruiser.Name = "labelCruiser";
            this.labelCruiser.Size = new System.Drawing.Size(170, 47);
            this.labelCruiser.TabIndex = 1;
            this.labelCruiser.Text = "Крейсер";
            this.labelCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCruiser.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.labelCruiser.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            this.labelCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCruiser_MouseDown);
            // 
            // labelship
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(32, 41);
            this.labelShip.Name = "labelship";
            this.labelShip.Size = new System.Drawing.Size(170, 50);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.labelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lablelShip_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShip.Controls.Add(this.labelDopColor);
            this.panelShip.Controls.Add(this.labelBaseColor);
            this.panelShip.Controls.Add(this.pictureBox);
            this.panelShip.Location = new System.Drawing.Point(276, 26);
            this.panelShip.Name = "panelCar";
            this.panelShip.Size = new System.Drawing.Size(257, 329);
            this.panelShip.TabIndex = 2;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(46, 253);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(155, 50);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(43, 174);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(158, 53);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            
            this.groupBox2.Controls.Add(this.paneldeeppink);
            this.groupBox2.Controls.Add(this.panelpurple);
            this.groupBox2.Controls.Add(this.paneldarkblue);
            this.groupBox2.Controls.Add(this.panellightgreen);
            this.groupBox2.Controls.Add(this.panelturquoise);
            this.groupBox2.Controls.Add(this.panellime);
            this.groupBox2.Controls.Add(this.panelyellow);
            this.groupBox2.Controls.Add(this.panelred);
            this.groupBox2.Controls.Add(this.panelgray);
            this.groupBox2.Location = new System.Drawing.Point(565, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 412);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";

            // 
            // paneldeeppink
            // 
            this.paneldeeppink.BackColor = System.Drawing.Color.DeepPink;
            this.paneldeeppink.Location = new System.Drawing.Point(156, 181);
            this.paneldeeppink.Name = "panel18";
            this.paneldeeppink.Size = new System.Drawing.Size(51, 46);
            this.paneldeeppink.TabIndex = 17;
            this.paneldeeppink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelpurple
            // 
            this.panelpurple.BackColor = System.Drawing.Color.Purple;
            this.panelpurple.Location = new System.Drawing.Point(156, 131);
            this.panelpurple.Name = "panel17";
            this.panelpurple.Size = new System.Drawing.Size(51, 44);
            this.panelpurple.TabIndex = 16;
            this.panelpurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            // 
            // paneldarkblue
            // 
            this.paneldarkblue.BackColor = System.Drawing.Color.DarkBlue;
            this.paneldarkblue.Location = new System.Drawing.Point(156, 79);
            this.paneldarkblue.Name = "panel14";
            this.paneldarkblue.Size = new System.Drawing.Size(47, 50);
            this.paneldarkblue.TabIndex = 13;
            this.paneldarkblue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            // 
            // panellightgreen
            // 
            this.panellightgreen.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panellightgreen.Location = new System.Drawing.Point(89, 181);
            this.panellightgreen.Name = "panel11";
            this.panellightgreen.Size = new System.Drawing.Size(47, 46);
            this.panellightgreen.TabIndex = 10;
            this.panellightgreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelturquoise
            // 
            this.panelturquoise.BackColor = System.Drawing.Color.Turquoise;
            this.panelturquoise.Location = new System.Drawing.Point(89, 132);
            this.panelturquoise.Name = "panel10";
            this.panelturquoise.Size = new System.Drawing.Size(47, 43);
            this.panelturquoise.TabIndex = 9;
            this.panelturquoise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panellime
            // 
            this.panellime.BackColor = System.Drawing.Color.Lime;
            this.panellime.Location = new System.Drawing.Point(89, 83);
            this.panellime.Name = "panel9";
            this.panellime.Size = new System.Drawing.Size(46, 42);
            this.panellime.TabIndex = 8;
            this.panellime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            // 
            // panelyellow
            // 
            this.panelyellow.BackColor = System.Drawing.Color.Yellow;
            this.panelyellow.Location = new System.Drawing.Point(17, 132);
            this.panelyellow.Name = "panel6";
            this.panelyellow.Size = new System.Drawing.Size(47, 43);
            this.panelyellow.TabIndex = 5;
            this.panelyellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            
            // 
            // panelred
            // 
            this.panelred.BackColor = System.Drawing.Color.Red;
            this.panelred.Location = new System.Drawing.Point(17, 181);
            this.panelred.Name = "panelred";
            this.panelred.Size = new System.Drawing.Size(47, 46);
            this.panelred.TabIndex = 3;
            this.panelred.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);

            // 
            // panelGray
            // 
            this.panelgray.BackColor = System.Drawing.Color.Gray;
            this.panelgray.Location = new System.Drawing.Point(17, 83);
            this.panelgray.Name = "panelgray";
            this.panelgray.Size = new System.Drawing.Size(47, 42);
            this.panelgray.TabIndex = 1;
            this.panelgray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 230);
            this.buttonAdd.Name = "button1";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonnCancel
            // 
            this.buttonnCancel.Location = new System.Drawing.Point(111, 283);
            this.buttonnCancel.Name = "buttonnCancel";
            this.buttonnCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonnCancel.TabIndex = 5;
            this.buttonnCancel.Text = "Отмена";
            this.buttonnCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "Выбор коробля";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelCar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCruiser;
        private System.Windows.Forms.Label labelShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        
        private System.Windows.Forms.Panel paneldeeppink;
        private System.Windows.Forms.Panel panelpurple;
        private System.Windows.Forms.Panel paneldarkblue;
        private System.Windows.Forms.Panel panellightgreen;
        private System.Windows.Forms.Panel panelturquoise;
        private System.Windows.Forms.Panel panellime;
        private System.Windows.Forms.Panel panelyellow;
        private System.Windows.Forms.Panel panelred;
        private System.Windows.Forms.Panel panelgray;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonnCancel;
        private System.Windows.Forms.Label labelDopColor;
        #region Windows Form Designer generated code


 
        #endregion
    }
}
