namespace ClinicDesctop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            btnUpdate = new Button();
            document = new TextBox();
            surName = new TextBox();
            firstName = new TextBox();
            patronymic = new TextBox();
            birthDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(776, 223);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.Width = 200;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 200;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(668, 241);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 52);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // document
            // 
            document.Location = new Point(125, 260);
            document.Name = "document";
            document.Size = new Size(200, 23);
            document.TabIndex = 3;
            // 
            // surName
            // 
            surName.Location = new Point(125, 289);
            surName.Name = "surName";
            surName.Size = new Size(200, 23);
            surName.TabIndex = 4;
            // 
            // firstName
            // 
            firstName.Location = new Point(125, 318);
            firstName.Name = "firstName";
            firstName.Size = new Size(200, 23);
            firstName.TabIndex = 5;
            // 
            // patronymic
            // 
            patronymic.Location = new Point(125, 347);
            patronymic.Name = "patronymic";
            patronymic.Size = new Size(200, 23);
            patronymic.TabIndex = 6;
            // 
            // birthDate
            // 
            birthDate.Location = new Point(125, 376);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(200, 23);
            birthDate.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 268);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Документ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 297);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 326);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 355);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 384);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата рождения";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(348, 307);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(120, 53);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(btnCreate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(birthDate);
            Controls.Add(patronymic);
            Controls.Add(firstName);
            Controls.Add(surName);
            Controls.Add(document);
            Controls.Add(btnUpdate);
            Controls.Add(listViewClients);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя клиника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewClients;
        private Button btnUpdate;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private TextBox document;
        private TextBox surName;
        private TextBox firstName;
        private TextBox patronymic;
        private TextBox birthDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCreate;
    }
}