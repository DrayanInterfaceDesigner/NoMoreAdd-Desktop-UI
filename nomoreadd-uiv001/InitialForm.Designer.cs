namespace nomoreadd_uiv001
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.imageInputField1 = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.min_window_btn = new System.Windows.Forms.Button();
            this.contactsBtn = new System.Windows.Forms.Button();
            this.closeWindowBtn = new System.Windows.Forms.Button();
            this.logo_small = new System.Windows.Forms.PictureBox();
            this.imageInputField2 = new System.Windows.Forms.PictureBox();
            this.labelDDI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageInputField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInputField2)).BeginInit();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputName.Font = new System.Drawing.Font("Montserrat", 12.75F);
            this.inputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.inputName.Location = new System.Drawing.Point(108, 338);
            this.inputName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.inputName.MaxLength = 85;
            this.inputName.MinimumSize = this.inputName.Size;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(243, 21);
            this.inputName.TabIndex = 3;
            this.inputName.Text = "name";
            this.inputName.Enter += new System.EventHandler(this.inputName_Enter);
            this.inputName.Leave += new System.EventHandler(this.inputName_Leave);
            // 
            // inputNumber
            // 
            this.inputNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.inputNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.inputNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNumber.Font = new System.Drawing.Font("Montserrat", 12.75F);
            this.inputNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(69)))), ((int)(((byte)(79)))));
            this.inputNumber.Location = new System.Drawing.Point(168, 390);
            this.inputNumber.Margin = new System.Windows.Forms.Padding(0);
            this.inputNumber.MaxLength = 14;
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(183, 21);
            this.inputNumber.TabIndex = 3;
            this.inputNumber.Text = "number";
            this.inputNumber.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            this.inputNumber.Enter += new System.EventHandler(this.inputNumber_Enter);
            this.inputNumber.Leave += new System.EventHandler(this.inputNumber_Leave);
            // 
            // imageInputField1
            // 
            this.imageInputField1.Image = global::nomoreadd_uiv001.Properties.Resources.input_field;
            this.imageInputField1.Location = new System.Drawing.Point(74, 328);
            this.imageInputField1.Margin = new System.Windows.Forms.Padding(0);
            this.imageInputField1.Name = "imageInputField1";
            this.imageInputField1.Size = new System.Drawing.Size(297, 48);
            this.imageInputField1.TabIndex = 5;
            this.imageInputField1.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Questrial", 14.32F);
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.Image = global::nomoreadd_uiv001.Properties.Resources.btn_gen;
            this.btnGenerate.Location = new System.Drawing.Point(74, 432);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(290, 48);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "generate link";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // min_window_btn
            // 
            this.min_window_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.min_window_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.min_window_btn.FlatAppearance.BorderSize = 0;
            this.min_window_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.min_window_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.min_window_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.min_window_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_window_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.min_window_btn.Image = global::nomoreadd_uiv001.Properties.Resources.min_ico;
            this.min_window_btn.Location = new System.Drawing.Point(327, 28);
            this.min_window_btn.Name = "min_window_btn";
            this.min_window_btn.Size = new System.Drawing.Size(37, 36);
            this.min_window_btn.TabIndex = 2;
            this.min_window_btn.UseVisualStyleBackColor = false;
            this.min_window_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // contactsBtn
            // 
            this.contactsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.contactsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contactsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactsBtn.FlatAppearance.BorderSize = 0;
            this.contactsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contactsBtn.Image = ((System.Drawing.Image)(resources.GetObject("contactsBtn.Image")));
            this.contactsBtn.Location = new System.Drawing.Point(336, 584);
            this.contactsBtn.Name = "contactsBtn";
            this.contactsBtn.Size = new System.Drawing.Size(70, 70);
            this.contactsBtn.TabIndex = 1;
            this.contactsBtn.UseVisualStyleBackColor = false;
            this.contactsBtn.MouseEnter += new System.EventHandler(this.contactsBtn_MouseEnter);
            this.contactsBtn.MouseLeave += new System.EventHandler(this.contactsBtn_MouseLeave);
            // 
            // closeWindowBtn
            // 
            this.closeWindowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.closeWindowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeWindowBtn.FlatAppearance.BorderSize = 0;
            this.closeWindowBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeWindowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeWindowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeWindowBtn.Image = global::nomoreadd_uiv001.Properties.Resources.close_ico;
            this.closeWindowBtn.Location = new System.Drawing.Point(370, 28);
            this.closeWindowBtn.Name = "closeWindowBtn";
            this.closeWindowBtn.Size = new System.Drawing.Size(36, 36);
            this.closeWindowBtn.TabIndex = 1;
            this.closeWindowBtn.UseVisualStyleBackColor = false;
            this.closeWindowBtn.Click += new System.EventHandler(this.closeWindowBtn_Click);
            this.closeWindowBtn.MouseEnter += new System.EventHandler(this.closeWindowBtn_MouseEnter);
            this.closeWindowBtn.MouseLeave += new System.EventHandler(this.closeWindowBtn_MouseLeave);
            // 
            // logo_small
            // 
            this.logo_small.Image = global::nomoreadd_uiv001.Properties.Resources.logo_66;
            this.logo_small.Location = new System.Drawing.Point(119, 160);
            this.logo_small.Name = "logo_small";
            this.logo_small.Size = new System.Drawing.Size(202, 140);
            this.logo_small.TabIndex = 0;
            this.logo_small.TabStop = false;
            // 
            // imageInputField2
            // 
            this.imageInputField2.Image = global::nomoreadd_uiv001.Properties.Resources.input_field;
            this.imageInputField2.Location = new System.Drawing.Point(74, 378);
            this.imageInputField2.Margin = new System.Windows.Forms.Padding(0);
            this.imageInputField2.Name = "imageInputField2";
            this.imageInputField2.Size = new System.Drawing.Size(297, 48);
            this.imageInputField2.TabIndex = 5;
            this.imageInputField2.TabStop = false;
            // 
            // labelDDI
            // 
            this.labelDDI.AutoSize = true;
            this.labelDDI.Font = new System.Drawing.Font("Nexa Light", 12.75F);
            this.labelDDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.labelDDI.Location = new System.Drawing.Point(104, 393);
            this.labelDDI.Name = "labelDDI";
            this.labelDDI.Size = new System.Drawing.Size(41, 21);
            this.labelDDI.TabIndex = 6;
            this.labelDDI.Text = "+55";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(440, 684);
            this.ControlBox = false;
            this.Controls.Add(this.labelDDI);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.min_window_btn);
            this.Controls.Add(this.contactsBtn);
            this.Controls.Add(this.closeWindowBtn);
            this.Controls.Add(this.logo_small);
            this.Controls.Add(this.imageInputField2);
            this.Controls.Add(this.imageInputField1);
            this.Font = new System.Drawing.Font("Nexa Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageInputField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageInputField2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_small;
        private System.Windows.Forms.Button closeWindowBtn;
        private System.Windows.Forms.Button min_window_btn;
        private System.Windows.Forms.Button contactsBtn;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox imageInputField1;
        private System.Windows.Forms.PictureBox imageInputField2;
        private System.Windows.Forms.Label labelDDI;
    }
}

