namespace dataBases
{
    partial class addPhone
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
            this.name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.ram = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.descrptionLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.gamma = new System.Windows.Forms.ComboBox();
            this.pictureLeaveImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeaveImage)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(199, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 20);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(199, 96);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(197, 113);
            this.description.TabIndex = 1;
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(199, 235);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(197, 20);
            this.ram.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(146, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Nombre";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date
            // 
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.Location = new System.Drawing.Point(199, 283);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(197, 20);
            this.date.TabIndex = 3;
            // 
            // descrptionLabel
            // 
            this.descrptionLabel.AutoSize = true;
            this.descrptionLabel.Location = new System.Drawing.Point(127, 96);
            this.descrptionLabel.Name = "descrptionLabel";
            this.descrptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descrptionLabel.TabIndex = 8;
            this.descrptionLabel.Text = "Descrpicion";
            this.descrptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(116, 235);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(74, 13);
            this.ramLabel.TabIndex = 9;
            this.ramLabel.Text = "Memoria RAM";
            this.ramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(75, 283);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(115, 13);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Fecha de Lanzamiento";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(152, 333);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(38, 13);
            this.gammaLabel.TabIndex = 11;
            this.gammaLabel.Text = "Gama ";
            this.gammaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(321, 491);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "CANCELAR";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(199, 491);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 6;
            this.acceptButton.Text = "ACEPTAR";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(199, 393);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(197, 20);
            this.image.TabIndex = 5;
            this.image.Leave += new System.EventHandler(this.image_Leave);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(117, 393);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(73, 13);
            this.imageLabel.TabIndex = 15;
            this.imageLabel.Text = "Imagen (URL)";
            this.imageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gamma
            // 
            this.gamma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamma.FormattingEnabled = true;
            this.gamma.Location = new System.Drawing.Point(199, 333);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(197, 21);
            this.gamma.TabIndex = 4;
            // 
            // pictureLeaveImage
            // 
            this.pictureLeaveImage.Location = new System.Drawing.Point(466, 75);
            this.pictureLeaveImage.Name = "pictureLeaveImage";
            this.pictureLeaveImage.Size = new System.Drawing.Size(372, 367);
            this.pictureLeaveImage.TabIndex = 17;
            this.pictureLeaveImage.TabStop = false;
            // 
            // addPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(885, 560);
            this.Controls.Add(this.pictureLeaveImage);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.image);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.gammaLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.descrptionLabel);
            this.Controls.Add(this.date);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.description);
            this.Controls.Add(this.name);
            this.Name = "addPhone";
            this.Text = "Nuevo Dispositivo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addPhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeaveImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox ram;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label descrptionLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.ComboBox gamma;
        private System.Windows.Forms.PictureBox pictureLeaveImage;
    }
}