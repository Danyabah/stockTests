using System.Windows.Forms;

namespace stockhouse
{
    partial class infoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoForm));
            this.nameTB = new System.Windows.Forms.TextBox();
            this.sizeUD = new System.Windows.Forms.NumericUpDown();
            this.minUD = new System.Windows.Forms.NumericUpDown();
            this.priceUD = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialCB = new System.Windows.Forms.ComboBox();
            this.countUD = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(230, 109);
            this.nameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(268, 23);
            this.nameTB.TabIndex = 1;
            this.nameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // sizeUD
            // 
            this.sizeUD.DecimalPlaces = 2;
            this.sizeUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.sizeUD.Location = new System.Drawing.Point(230, 159);
            this.sizeUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeUD.Name = "sizeUD";
            this.sizeUD.Size = new System.Drawing.Size(268, 23);
            this.sizeUD.TabIndex = 3;
            this.sizeUD.ValueChanged += new System.EventHandler(this.SizeUD_ValueChanged);
            // 
            // minUD
            // 
            this.minUD.Location = new System.Drawing.Point(230, 245);
            this.minUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minUD.Name = "minUD";
            this.minUD.Size = new System.Drawing.Size(268, 23);
            this.minUD.TabIndex = 5;
            this.minUD.ValueChanged += new System.EventHandler(this.MinUD_ValueChanged);
            // 
            // priceUD
            // 
            this.priceUD.DecimalPlaces = 2;
            this.priceUD.Location = new System.Drawing.Point(230, 329);
            this.priceUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceUD.Name = "priceUD";
            this.priceUD.Size = new System.Drawing.Size(268, 23);
            this.priceUD.TabIndex = 6;
            this.priceUD.ValueChanged += new System.EventHandler(this.PriceUD_ValueChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SlateBlue;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Enabled = false;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(189, 19);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(153, 34);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Firebrick;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Cancel_Button.Location = new System.Drawing.Point(370, 19);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(158, 34);
            this.Cancel_Button.TabIndex = 9;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер (см)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Материал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Минимальный предел количества";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Цена (без НДС)";
            // 
            // materialCB
            // 
            this.materialCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialCB.FormattingEnabled = true;
            this.materialCB.Location = new System.Drawing.Point(230, 203);
            this.materialCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialCB.Name = "materialCB";
            this.materialCB.Size = new System.Drawing.Size(268, 23);
            this.materialCB.TabIndex = 19;
            this.materialCB.SelectedIndexChanged += new System.EventHandler(this.MaterialCB_SelectedIndexChanged);
            // 
            // countUD
            // 
            this.countUD.Location = new System.Drawing.Point(230, 286);
            this.countUD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.countUD.Name = "countUD";
            this.countUD.Size = new System.Drawing.Size(268, 23);
            this.countUD.TabIndex = 20;
            this.countUD.ValueChanged += new System.EventHandler(this.CountUD_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.Cancel_Button);
            this.panel1.Location = new System.Drawing.Point(-6, 394);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 75);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-6, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 83);
            this.panel2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(22, 13);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(235, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Информация о товаре";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.countUD);
            this.Controls.Add(this.materialCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceUD);
            this.Controls.Add(this.minUD);
            this.Controls.Add(this.sizeUD);
            this.Controls.Add(this.nameTB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "infoForm";
            this.Text = "Информация о товаре";
            ((System.ComponentModel.ISupportInitialize)(this.sizeUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox nameTB;
        private NumericUpDown sizeUD;
        private NumericUpDown minUD;
        private NumericUpDown priceUD;
        private Button SaveButton;
        private Button Cancel_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox materialCB;
        private NumericUpDown countUD;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox1;
    }
}