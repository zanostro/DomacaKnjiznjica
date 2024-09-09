namespace DomačaKnjižnjica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NovaKnjigaTab = new System.Windows.Forms.TabPage();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.getData = new System.Windows.Forms.Button();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.opombeTextBox = new System.Windows.Forms.TextBox();
            this.avtorTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.EditSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FileStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.NovaKnjigaTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 104);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(18, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1210, 70);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domači knjižnji register";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(12, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1240, 504);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NovaKnjigaTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 491);
            this.tabControl1.TabIndex = 4;
            // 
            // NovaKnjigaTab
            // 
            this.NovaKnjigaTab.Controls.Add(this.naslovTextBox);
            this.NovaKnjigaTab.Controls.Add(this.opombeTextBox);
            this.NovaKnjigaTab.Controls.Add(this.avtorTextBox);
            this.NovaKnjigaTab.Controls.Add(this.submitButton);
            this.NovaKnjigaTab.Controls.Add(this.label2);
            this.NovaKnjigaTab.Controls.Add(this.label4);
            this.NovaKnjigaTab.Controls.Add(this.label3);
            this.NovaKnjigaTab.Location = new System.Drawing.Point(4, 22);
            this.NovaKnjigaTab.Name = "NovaKnjigaTab";
            this.NovaKnjigaTab.Padding = new System.Windows.Forms.Padding(3);
            this.NovaKnjigaTab.Size = new System.Drawing.Size(626, 465);
            this.NovaKnjigaTab.TabIndex = 0;
            this.NovaKnjigaTab.Text = "Nova knjiga";
            this.NovaKnjigaTab.UseVisualStyleBackColor = true;
            // 
            // undoButton
            // 
            this.undoButton.Image = global::DomačaKnjižnjica.Properties.Resources.undoGray;
            this.undoButton.Location = new System.Drawing.Point(12, 138);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(23, 23);
            this.undoButton.TabIndex = 12;
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click_1);
            // 
            // redoButton
            // 
            this.redoButton.Image = global::DomačaKnjižnjica.Properties.Resources.redoGray;
            this.redoButton.Location = new System.Drawing.Point(39, 138);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(23, 23);
            this.redoButton.TabIndex = 11;
            this.redoButton.UseVisualStyleBackColor = true;
            this.redoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(68, 138);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(75, 23);
            this.getData.TabIndex = 10;
            this.getData.Text = "Refresh";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovTextBox.Location = new System.Drawing.Point(107, 25);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(489, 29);
            this.naslovTextBox.TabIndex = 9;
            this.naslovTextBox.TextChanged += new System.EventHandler(this.NaslovTextBox_TextChanged);
            this.naslovTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NaslovTextBox_Validating);
            // 
            // opombeTextBox
            // 
            this.opombeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opombeTextBox.Location = new System.Drawing.Point(107, 118);
            this.opombeTextBox.Name = "opombeTextBox";
            this.opombeTextBox.Size = new System.Drawing.Size(489, 29);
            this.opombeTextBox.TabIndex = 8;
            this.opombeTextBox.TextChanged += new System.EventHandler(this.OpombeTextBox_TextChanged);
            // 
            // avtorTextBox
            // 
            this.avtorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtorTextBox.Location = new System.Drawing.Point(107, 71);
            this.avtorTextBox.Name = "avtorTextBox";
            this.avtorTextBox.Size = new System.Drawing.Size(489, 29);
            this.avtorTextBox.TabIndex = 7;
            this.avtorTextBox.TextChanged += new System.EventHandler(this.AvtorTextBox_TextChanged);
            this.avtorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AvtorTextBox_Validating);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(521, 169);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Oddaj";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.submitButton.Validating += new System.ComponentModel.CancelEventHandler(this.SubmitButton_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opombe";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Avtor";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naslov";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputBox);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(626, 465);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Konzola";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(3, 442);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(623, 20);
            this.inputBox.TabIndex = 3;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.consoleBox);
            this.panel7.Location = new System.Drawing.Point(-4, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(638, 436);
            this.panel7.TabIndex = 1;
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.consoleBox.ForeColor = System.Drawing.Color.White;
            this.consoleBox.Location = new System.Drawing.Point(4, 0);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(634, 436);
            this.consoleBox.TabIndex = 2;
            this.consoleBox.TextChanged += new System.EventHandler(this.ConsoleBox_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.dataGridView);
            this.panel6.Controls.Add(this.searchButton);
            this.panel6.Controls.Add(this.searchBox);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(648, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 488);
            this.panel6.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.AccessibleDescription = "dataGridView";
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(576, 444);
            this.dataGridView.TabIndex = 14;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(499, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Išči";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(4, 9);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(489, 29);
            this.searchBox.TabIndex = 13;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(18, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 488);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStripDropDownButton,
            this.EditSplitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // EditSplitButton
            // 
            this.EditSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.EditSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("EditSplitButton.Image")));
            this.EditSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSplitButton.Name = "EditSplitButton";
            this.EditSplitButton.Size = new System.Drawing.Size(43, 22);
            this.EditSplitButton.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FileStripDropDownButton
            // 
            this.FileStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.changeUserToolStripMenuItem});
            this.FileStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FileStripDropDownButton.Image")));
            this.FileStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileStripDropDownButton.Name = "FileStripDropDownButton";
            this.FileStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.FileStripDropDownButton.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsCSVToolStripMenuItem,
            this.exportAsExcelFileToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportAsCSVToolStripMenuItem
            // 
            this.exportAsCSVToolStripMenuItem.Name = "exportAsCSVToolStripMenuItem";
            this.exportAsCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsCSVToolStripMenuItem.Text = "Export as CSV";
            // 
            // exportAsExcelFileToolStripMenuItem
            // 
            this.exportAsExcelFileToolStripMenuItem.Name = "exportAsExcelFileToolStripMenuItem";
            this.exportAsExcelFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportAsExcelFileToolStripMenuItem.Text = "Export as Excel file";
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeUserToolStripMenuItem.Text = "Change User";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.redoButton);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.NovaKnjigaTab.ResumeLayout(false);
            this.NovaKnjigaTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NovaKnjigaTab;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.TextBox opombeTextBox;
        private System.Windows.Forms.TextBox avtorTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox inputBox;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton EditSplitButton;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton FileStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsExcelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

