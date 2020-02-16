namespace FileSearcher
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFileTemplate = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSymbols = new System.Windows.Forms.TextBox();
            this.labelCurrentData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewData = new FileSearcher.BufferedTreeView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPath.Location = new System.Drawing.Point(119, 0);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(135, 20);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSelectPath.Location = new System.Drawing.Point(254, 0);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(26, 20);
            this.buttonSelectPath.TabIndex = 2;
            this.buttonSelectPath.Text = "...";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаблон имени файла:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFileTemplate
            // 
            this.textBoxFileTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileTemplate.Location = new System.Drawing.Point(119, 0);
            this.textBoxFileTemplate.Name = "textBoxFileTemplate";
            this.textBoxFileTemplate.Size = new System.Drawing.Size(161, 20);
            this.textBoxFileTemplate.TabIndex = 4;
            this.textBoxFileTemplate.Text = "*.*";
            this.textBoxFileTemplate.TextChanged += new System.EventHandler(this.textBoxFileTemplate_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 25);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Набор символов:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSymbols
            // 
            this.textBoxSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSymbols.Location = new System.Drawing.Point(119, 0);
            this.textBoxSymbols.Name = "textBoxSymbols";
            this.textBoxSymbols.Size = new System.Drawing.Size(161, 20);
            this.textBoxSymbols.TabIndex = 7;
            this.textBoxSymbols.TextChanged += new System.EventHandler(this.textBoxSymbols_TextChanged);
            // 
            // labelCurrentData
            // 
            this.labelCurrentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrentData.Location = new System.Drawing.Point(0, 85);
            this.labelCurrentData.Name = "labelCurrentData";
            this.labelCurrentData.Size = new System.Drawing.Size(280, 78);
            this.labelCurrentData.TabIndex = 8;
            this.labelCurrentData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCurrentData);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 163);
            this.panel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonSearch);
            this.panel5.Controls.Add(this.buttonStop);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 25);
            this.panel5.TabIndex = 13;
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(173, 0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(107, 25);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Остановить";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBoxSymbols);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 20);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxFileTemplate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 20);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxPath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonSelectPath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 20);
            this.panel2.TabIndex = 10;
            // 
            // treeViewData
            // 
            this.treeViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewData.Location = new System.Drawing.Point(0, 163);
            this.treeViewData.Name = "treeViewData";
            this.treeViewData.Size = new System.Drawing.Size(280, 115);
            this.treeViewData.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(280, 278);
            this.Controls.Add(this.treeViewData);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Searcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFileTemplate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSymbols;
        private System.Windows.Forms.Label labelCurrentData;
        private BufferedTreeView treeViewData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

