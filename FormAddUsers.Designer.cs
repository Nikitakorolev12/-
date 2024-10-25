namespace LB1
{
    partial class FormAddUsers
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
            this.components = new System.ComponentModel.Container();
            this.buttonback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonback.Location = new System.Drawing.Point(22, 52);
            this.buttonback.Margin = new System.Windows.Forms.Padding(5);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(125, 37);
            this.buttonback.TabIndex = 0;
            this.buttonback.Text = "Назад";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(304, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление нового пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Повтор пароля:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(29, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Эл. почта:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Телефон:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(456, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(456, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Фамилия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(456, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Роль:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(456, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Пол:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(184, 147);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(164, 29);
            this.loginTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(184, 186);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(164, 29);
            this.passwordTextBox.TabIndex = 12;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox2.Location = new System.Drawing.Point(184, 225);
            this.passwordTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(164, 29);
            this.passwordTextBox2.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(184, 264);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(164, 29);
            this.emailTextBox.TabIndex = 14;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(583, 147);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(164, 29);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameTextBox.Location = new System.Drawing.Point(583, 189);
            this.secondNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(164, 29);
            this.secondNameTextBox.TabIndex = 17;
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataSource = this.bindingSource1;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(583, 225);
            this.roleIDComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(164, 29);
            this.roleIDComboBox.TabIndex = 18;
            this.roleIDComboBox.ValueMember = "ID";
            this.roleIDComboBox.SelectedIndexChanged += new System.EventHandler(this.roleIDComboBox_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LB1.DBContext.Roles);
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Checked = true;
            this.radioButtonMen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMen.Location = new System.Drawing.Point(547, 268);
            this.radioButtonMen.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(103, 25);
            this.radioButtonMen.TabIndex = 19;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Мужской";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWomen.Location = new System.Drawing.Point(671, 268);
            this.radioButtonWomen.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(100, 25);
            this.radioButtonWomen.TabIndex = 20;
            this.radioButtonWomen.Text = "Женский";
            this.radioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(556, 326);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 37);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(184, 303);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.Mask = "+7 (000) 000-00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(164, 29);
            this.phoneTextBox.TabIndex = 22;
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 414);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.radioButtonWomen);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonback);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
    }
}