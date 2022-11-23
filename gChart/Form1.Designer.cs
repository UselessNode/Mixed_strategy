namespace gChart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label4 = new System.Windows.Forms.Label();
            this.tBMaxMin = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tBMinMax = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bExecute = new System.Windows.Forms.Button();
            this.GraphicsTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InfoTabPage = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.fillRandomMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.solveRandomMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.executeMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.графикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGraphicMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DrawGraphMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GraphicsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InfoTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.MainTabPage);
            this.tabControl1.Controls.Add(this.GraphicsTabPage);
            this.tabControl1.Controls.Add(this.InfoTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // MainTabPage
            // 
            this.MainTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTabPage.Controls.Add(this.label1);
            this.MainTabPage.Controls.Add(this.tableLayoutPanel1);
            this.MainTabPage.Controls.Add(this.dataGridView1);
            this.MainTabPage.Controls.Add(this.bExecute);
            this.MainTabPage.Location = new System.Drawing.Point(4, 30);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(689, 531);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Главная";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtbOutput, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 477);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(324, 64);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Label4);
            this.flowLayoutPanel1.Controls.Add(this.tBMaxMin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 26);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(3, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(105, 18);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "MaxMin (α):";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBMaxMin
            // 
            this.tBMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMaxMin.Location = new System.Drawing.Point(114, 3);
            this.tBMaxMin.Name = "tBMaxMin";
            this.tBMaxMin.ReadOnly = true;
            this.tBMaxMin.Size = new System.Drawing.Size(150, 20);
            this.tBMaxMin.TabIndex = 1;
            this.tBMaxMin.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.tBMinMax);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 26);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "MinMax (β):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBMinMax
            // 
            this.tBMinMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBMinMax.Location = new System.Drawing.Point(114, 3);
            this.tBMinMax.Name = "tBMinMax";
            this.tBMinMax.ReadOnly = true;
            this.tBMinMax.Size = new System.Drawing.Size(150, 20);
            this.tBMinMax.TabIndex = 1;
            this.tBMinMax.TabStop = false;
            // 
            // rtbOutput
            // 
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Location = new System.Drawing.Point(3, 73);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(324, 401);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(348, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(321, 222);
            this.dataGridView1.TabIndex = 3;
            // 
            // bExecute
            // 
            this.bExecute.AutoSize = true;
            this.bExecute.Location = new System.Drawing.Point(361, 276);
            this.bExecute.Name = "bExecute";
            this.bExecute.Size = new System.Drawing.Size(299, 28);
            this.bExecute.TabIndex = 2;
            this.bExecute.Text = "Решить";
            this.bExecute.UseVisualStyleBackColor = true;
            this.bExecute.Click += new System.EventHandler(this.bExecute_Click);
            // 
            // GraphicsTabPage
            // 
            this.GraphicsTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GraphicsTabPage.Controls.Add(this.pictureBox1);
            this.GraphicsTabPage.Location = new System.Drawing.Point(4, 30);
            this.GraphicsTabPage.Name = "GraphicsTabPage";
            this.GraphicsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GraphicsTabPage.Size = new System.Drawing.Size(689, 531);
            this.GraphicsTabPage.TabIndex = 1;
            this.GraphicsTabPage.Text = "Графики";
            this.GraphicsTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InfoTabPage
            // 
            this.InfoTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTabPage.Controls.Add(this.richTextBox1);
            this.InfoTabPage.Location = new System.Drawing.Point(4, 30);
            this.InfoTabPage.Name = "InfoTabPage";
            this.InfoTabPage.Size = new System.Drawing.Size(689, 531);
            this.InfoTabPage.TabIndex = 2;
            this.InfoTabPage.Text = "Справка";
            this.InfoTabPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(687, 529);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip,
            this.графикиToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 23);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "Панель меню";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillRandomMenuButton,
            this.solveRandomMenuButton,
            this.clearTableMenuButton,
            this.executeMenuButton});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(65, 19);
            this.menuStrip.Text = "Таблица";
            // 
            // fillRandomMenuButton
            // 
            this.fillRandomMenuButton.Name = "fillRandomMenuButton";
            this.fillRandomMenuButton.Size = new System.Drawing.Size(325, 22);
            this.fillRandomMenuButton.Text = "Заполнить таблицу случайными значениями";
            this.fillRandomMenuButton.Click += new System.EventHandler(this.fillRandomMenuButton_Click);
            // 
            // solveRandomMenuButton
            // 
            this.solveRandomMenuButton.Name = "solveRandomMenuButton";
            this.solveRandomMenuButton.Size = new System.Drawing.Size(325, 22);
            this.solveRandomMenuButton.Text = "Решить со случайными значениями";
            this.solveRandomMenuButton.Click += new System.EventHandler(this.fillTableRandomMenuButton_Click);
            // 
            // clearTableMenuButton
            // 
            this.clearTableMenuButton.Name = "clearTableMenuButton";
            this.clearTableMenuButton.Size = new System.Drawing.Size(325, 22);
            this.clearTableMenuButton.Text = "Очистить таблицу";
            this.clearTableMenuButton.Click += new System.EventHandler(this.clearTableMenuButton_Click);
            // 
            // executeMenuButton
            // 
            this.executeMenuButton.Name = "executeMenuButton";
            this.executeMenuButton.Size = new System.Drawing.Size(325, 22);
            this.executeMenuButton.Text = "Решить таблицу";
            this.executeMenuButton.Click += new System.EventHandler(this.bExecute_Click);
            // 
            // графикиToolStripMenuItem
            // 
            this.графикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveGraphicMenuButton,
            this.DrawGraphMenuButton});
            this.графикиToolStripMenuItem.Name = "графикиToolStripMenuItem";
            this.графикиToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.графикиToolStripMenuItem.Text = "График";
            // 
            // SaveGraphicMenuButton
            // 
            this.SaveGraphicMenuButton.Name = "SaveGraphicMenuButton";
            this.SaveGraphicMenuButton.Size = new System.Drawing.Size(180, 22);
            this.SaveGraphicMenuButton.Text = "Сохранить";
            this.SaveGraphicMenuButton.Click += new System.EventHandler(this.SaveGraphicMenuButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Диаграмма";
            this.saveFileDialog1.Filter = "Изображение (JPEG)|*.jpeg| Все файлы|*.*";
            this.saveFileDialog1.Title = "Сохранение изображения диаграммы";
            this.saveFileDialog1.ValidateNames = false;
            // 
            // DrawGraphMenuButton
            // 
            this.DrawGraphMenuButton.Name = "DrawGraphMenuButton";
            this.DrawGraphMenuButton.Size = new System.Drawing.Size(180, 22);
            this.DrawGraphMenuButton.Text = "Нарисовать";
            this.DrawGraphMenuButton.Click += new System.EventHandler(this.DrawGraphMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Матрица 2 х 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 588);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(299, 200);
            this.Name = "Form1";
            this.Text = "Решение игры в смешанных стратегиях геометрическим методом";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.MainTabPage.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GraphicsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InfoTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage GraphicsTabPage;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox tBMinMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBMaxMin;
        private System.Windows.Forms.Button bExecute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage InfoTabPage;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip;
        private System.Windows.Forms.ToolStripMenuItem solveRandomMenuButton;
        private System.Windows.Forms.ToolStripMenuItem clearTableMenuButton;
        private System.Windows.Forms.ToolStripMenuItem executeMenuButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem графикиToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem SaveGraphicMenuButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fillRandomMenuButton;
        private System.Windows.Forms.ToolStripMenuItem DrawGraphMenuButton;
        private System.Windows.Forms.Label label1;
    }
}

