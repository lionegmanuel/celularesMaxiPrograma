namespace bussines
{
    partial class principalForm
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
            this.phoneDataBase = new System.Windows.Forms.DataGridView();
            this.picturePhone = new System.Windows.Forms.PictureBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.llstButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhone)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneDataBase
            // 
            this.phoneDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneDataBase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.phoneDataBase.Location = new System.Drawing.Point(31, 32);
            this.phoneDataBase.Name = "phoneDataBase";
            this.phoneDataBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phoneDataBase.Size = new System.Drawing.Size(676, 523);
            this.phoneDataBase.TabIndex = 0;
            this.phoneDataBase.SelectionChanged += new System.EventHandler(this.phoneDataBase_SelectionChanged);
            // 
            // picturePhone
            // 
            this.picturePhone.Location = new System.Drawing.Point(801, 128);
            this.picturePhone.Name = "picturePhone";
            this.picturePhone.Size = new System.Drawing.Size(345, 360);
            this.picturePhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePhone.TabIndex = 1;
            this.picturePhone.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(31, 597);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(192, 42);
            this.registerButton.TabIndex = 2;
            this.registerButton.Text = "REGISTRAR NUEVO DISPOSITIVO";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(801, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(130, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "BUSCAR UN DISPOSITIVO";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(428, 597);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(140, 42);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "ELIMINAR DISPOSITIVO";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(256, 597);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(146, 42);
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "MODIFICAR DISPOSITIVO";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // llstButton
            // 
            this.llstButton.Location = new System.Drawing.Point(1016, 56);
            this.llstButton.Name = "llstButton";
            this.llstButton.Size = new System.Drawing.Size(130, 42);
            this.llstButton.TabIndex = 6;
            this.llstButton.Text = "LISTADO DE DISPOSITIVOS";
            this.llstButton.UseVisualStyleBackColor = true;
            this.llstButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 651);
            this.Controls.Add(this.llstButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.picturePhone);
            this.Controls.Add(this.phoneDataBase);
            this.Name = "principalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.principalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView phoneDataBase;
        private System.Windows.Forms.PictureBox picturePhone;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button llstButton;
    }
}

