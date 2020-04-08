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
            this.panelCar = new System.Windows.Forms.Panel();
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.pictureBox.Location = new System.Drawing.Point(44, 38);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(253, 134);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCruiser);
            this.groupBox1.Controls.Add(this.labelShip);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(316, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип корабля";
            // 
            // labelCruiser
            // 
            this.labelCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCruiser.Location = new System.Drawing.Point(43, 132);
            this.labelCruiser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCruiser.Name = "labelCruiser";
            this.labelCruiser.Size = new System.Drawing.Size(226, 57);
            this.labelCruiser.TabIndex = 1;
            this.labelCruiser.Text = "Крейсер";
            this.labelCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCruiser.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.labelCruiser.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            this.labelCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCruiser_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(43, 50);
            this.labelShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(226, 61);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Корабль";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.labelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lablelShip_MouseDown);
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCar.Controls.Add(this.labelDopColor);
            this.panelCar.Controls.Add(this.labelBaseColor);
            this.panelCar.Controls.Add(this.pictureBox);
            this.panelCar.Location = new System.Drawing.Point(368, 32);
            this.panelCar.Margin = new System.Windows.Forms.Padding(4);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(342, 404);
            this.panelCar.TabIndex = 2;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(61, 311);
            this.labelDopColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(206, 61);
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
            this.labelBaseColor.Location = new System.Drawing.Point(57, 214);
            this.labelBaseColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(210, 65);
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
            this.groupBox2.Location = new System.Drawing.Point(753, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(297, 507);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // paneldeeppink
            // 
            this.paneldeeppink.BackColor = System.Drawing.Color.DeepPink;
            this.paneldeeppink.Location = new System.Drawing.Point(208, 223);
            this.paneldeeppink.Margin = new System.Windows.Forms.Padding(4);
            this.paneldeeppink.Name = "paneldeeppink";
            this.paneldeeppink.Size = new System.Drawing.Size(68, 57);
            this.paneldeeppink.TabIndex = 17;
            this.paneldeeppink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelpurple
            // 
            this.panelpurple.BackColor = System.Drawing.Color.Purple;
            this.panelpurple.Location = new System.Drawing.Point(208, 161);
            this.panelpurple.Margin = new System.Windows.Forms.Padding(4);
            this.panelpurple.Name = "panelpurple";
            this.panelpurple.Size = new System.Drawing.Size(68, 54);
            this.panelpurple.TabIndex = 16;
            this.panelpurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // paneldarkblue
            // 
            this.paneldarkblue.BackColor = System.Drawing.Color.DarkBlue;
            this.paneldarkblue.Location = new System.Drawing.Point(208, 97);
            this.paneldarkblue.Margin = new System.Windows.Forms.Padding(4);
            this.paneldarkblue.Name = "paneldarkblue";
            this.paneldarkblue.Size = new System.Drawing.Size(68, 57);
            this.paneldarkblue.TabIndex = 13;
            this.paneldarkblue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panellightgreen
            // 
            this.panellightgreen.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panellightgreen.Location = new System.Drawing.Point(119, 223);
            this.panellightgreen.Margin = new System.Windows.Forms.Padding(4);
            this.panellightgreen.Name = "panellightgreen";
            this.panellightgreen.Size = new System.Drawing.Size(63, 57);
            this.panellightgreen.TabIndex = 10;
            this.panellightgreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelturquoise
            // 
            this.panelturquoise.BackColor = System.Drawing.Color.Turquoise;
            this.panelturquoise.Location = new System.Drawing.Point(119, 162);
            this.panelturquoise.Margin = new System.Windows.Forms.Padding(4);
            this.panelturquoise.Name = "panelturquoise";
            this.panelturquoise.Size = new System.Drawing.Size(63, 53);
            this.panelturquoise.TabIndex = 9;
            this.panelturquoise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panellime
            // 
            this.panellime.BackColor = System.Drawing.Color.Lime;
            this.panellime.Location = new System.Drawing.Point(119, 102);
            this.panellime.Margin = new System.Windows.Forms.Padding(4);
            this.panellime.Name = "panellime";
            this.panellime.Size = new System.Drawing.Size(61, 52);
            this.panellime.TabIndex = 8;
            this.panellime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelyellow
            // 
            this.panelyellow.BackColor = System.Drawing.Color.Yellow;
            this.panelyellow.Location = new System.Drawing.Point(23, 162);
            this.panelyellow.Margin = new System.Windows.Forms.Padding(4);
            this.panelyellow.Name = "panelyellow";
            this.panelyellow.Size = new System.Drawing.Size(63, 53);
            this.panelyellow.TabIndex = 5;
            this.panelyellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelred
            // 
            this.panelred.BackColor = System.Drawing.Color.Red;
            this.panelred.Location = new System.Drawing.Point(23, 223);
            this.panelred.Margin = new System.Windows.Forms.Padding(4);
            this.panelred.Name = "panelred";
            this.panelred.Size = new System.Drawing.Size(63, 57);
            this.panelred.TabIndex = 3;
            this.panelred.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelgray
            // 
            this.panelgray.BackColor = System.Drawing.Color.Gray;
            this.panelgray.Location = new System.Drawing.Point(23, 102);
            this.panelgray.Margin = new System.Windows.Forms.Padding(4);
            this.panelgray.Name = "panelgray";
            this.panelgray.Size = new System.Drawing.Size(63, 52);
            this.panelgray.TabIndex = 1;
            this.panelgray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonnCancel
            // 
            this.buttonnCancel.Location = new System.Drawing.Point(194, 283);
            this.buttonnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonnCancel.Name = "buttonnCancel";
            this.buttonnCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonnCancel.TabIndex = 5;
            this.buttonnCancel.Text = "Отмена";
            this.buttonnCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormShipConfig";
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
        private System.Windows.Forms.Panel panelCar;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonnCancel;
        private System.Windows.Forms.Label labelDopColor;
        #region Windows Form Designer generated code


 
        #endregion
    }
}