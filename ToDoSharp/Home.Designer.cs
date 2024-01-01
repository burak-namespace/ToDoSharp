namespace ToDoSharp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.task_textbox = new System.Windows.Forms.TextBox();
            this.task_date = new System.Windows.Forms.DateTimePicker();
            this.task_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.task_data = new System.Windows.Forms.DataGridView();
            this.task_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.task_data)).BeginInit();
            this.SuspendLayout();
            // 
            // task_textbox
            // 
            this.task_textbox.Location = new System.Drawing.Point(8, 464);
            this.task_textbox.Name = "task_textbox";
            this.task_textbox.Size = new System.Drawing.Size(253, 27);
            this.task_textbox.TabIndex = 0;
            // 
            // task_date
            // 
            this.task_date.Location = new System.Drawing.Point(271, 464);
            this.task_date.Name = "task_date";
            this.task_date.Size = new System.Drawing.Size(266, 27);
            this.task_date.TabIndex = 1;
            // 
            // task_button
            // 
            this.task_button.Location = new System.Drawing.Point(545, 462);
            this.task_button.Name = "task_button";
            this.task_button.Size = new System.Drawing.Size(147, 29);
            this.task_button.TabIndex = 2;
            this.task_button.Text = "Add";
            this.task_button.UseVisualStyleBackColor = true;
            this.task_button.Click += new System.EventHandler(this.task_button_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Show All Done Tasks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(361, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(331, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show To Do";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // task_data
            // 
            this.task_data.AllowUserToAddRows = false;
            this.task_data.AllowUserToDeleteRows = false;
            this.task_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.task_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.task_name,
            this.date,
            this.status,
            this.id});
            this.task_data.Location = new System.Drawing.Point(16, 41);
            this.task_data.Name = "task_data";
            this.task_data.Size = new System.Drawing.Size(666, 413);
            this.task_data.TabIndex = 5;
            this.task_data.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.task_data_CellValueChanged_1);
            // 
            // task_name
            // 
            this.task_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.task_name.HeaderText = "Task Name";
            this.task_name.Name = "task_name";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Items.AddRange(new object[] {
            "done",
            "not done"});
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(698, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task_data);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.task_button);
            this.Controls.Add(this.task_date);
            this.Controls.Add(this.task_textbox);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.task_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox task_textbox;
        private System.Windows.Forms.DateTimePicker task_date;
        private System.Windows.Forms.Button task_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView task_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label1;
    }
}