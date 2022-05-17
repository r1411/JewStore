namespace JewStoreFront
{
    partial class FrontForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxSorting = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.chooseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самоеДорогоеКольцоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самаяТолстаяЦепочкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыеКороткиеСерьгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.часыССамымМаленькимДисплеемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 526F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.listBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSorting, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 518);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 28;
            this.listBox.Location = new System.Drawing.Point(4, 78);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(250, 436);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Все украшения",
            "Кольца",
            "Сережки",
            "Цепочки",
            "Часы"});
            this.comboBoxType.Location = new System.Drawing.Point(4, 4);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(250, 24);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxSorting
            // 
            this.comboBoxSorting.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSorting.FormattingEnabled = true;
            this.comboBoxSorting.Items.AddRange(new object[] {
            "По названию [▲]",
            "По названию [▼]",
            "По цене [▲]",
            "По цене [▼]"});
            this.comboBoxSorting.Location = new System.Drawing.Point(4, 41);
            this.comboBoxSorting.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSorting.Name = "comboBoxSorting";
            this.comboBoxSorting.Size = new System.Drawing.Size(250, 24);
            this.comboBoxSorting.TabIndex = 2;
            this.comboBoxSorting.SelectedIndexChanged += new System.EventHandler(this.comboBoxSorting_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(270, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 518F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(793, 518);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(479, 4);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(310, 510);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox_LoadCompleted);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.labelItemDescription, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelItemName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(467, 510);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelItemDescription.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItemDescription.Location = new System.Drawing.Point(4, 74);
            this.labelItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(459, 436);
            this.labelItemDescription.TabIndex = 2;
            // 
            // labelItemName
            // 
            this.labelItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelItemName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItemName.Location = new System.Drawing.Point(4, 0);
            this.labelItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(459, 74);
            this.labelItemName.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // chooseToolStripMenuItem
            // 
            this.chooseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.самоеДорогоеКольцоToolStripMenuItem,
            this.самаяТолстаяЦепочкаToolStripMenuItem,
            this.самыеКороткиеСерьгиToolStripMenuItem,
            this.часыССамымМаленькимДисплеемToolStripMenuItem,
            this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem});
            this.chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            this.chooseToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.chooseToolStripMenuItem.Text = "Выбрать";
            // 
            // самоеДорогоеКольцоToolStripMenuItem
            // 
            this.самоеДорогоеКольцоToolStripMenuItem.Name = "самоеДорогоеКольцоToolStripMenuItem";
            this.самоеДорогоеКольцоToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.самоеДорогоеКольцоToolStripMenuItem.Text = "Самое дорогое кольцо";
            this.самоеДорогоеКольцоToolStripMenuItem.Click += new System.EventHandler(this.самоеДорогоеКольцоToolStripMenuItem_Click);
            // 
            // самаяТолстаяЦепочкаToolStripMenuItem
            // 
            this.самаяТолстаяЦепочкаToolStripMenuItem.Name = "самаяТолстаяЦепочкаToolStripMenuItem";
            this.самаяТолстаяЦепочкаToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.самаяТолстаяЦепочкаToolStripMenuItem.Text = "Самая толстая цепочка";
            this.самаяТолстаяЦепочкаToolStripMenuItem.Click += new System.EventHandler(this.самаяТолстаяЦепочкаToolStripMenuItem_Click);
            // 
            // самыеКороткиеСерьгиToolStripMenuItem
            // 
            this.самыеКороткиеСерьгиToolStripMenuItem.Name = "самыеКороткиеСерьгиToolStripMenuItem";
            this.самыеКороткиеСерьгиToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.самыеКороткиеСерьгиToolStripMenuItem.Text = "Самые короткие серьги";
            this.самыеКороткиеСерьгиToolStripMenuItem.Click += new System.EventHandler(this.самыеКороткиеСерьгиToolStripMenuItem_Click);
            // 
            // часыССамымМаленькимДисплеемToolStripMenuItem
            // 
            this.часыССамымМаленькимДисплеемToolStripMenuItem.Name = "часыССамымМаленькимДисплеемToolStripMenuItem";
            this.часыССамымМаленькимДисплеемToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.часыССамымМаленькимДисплеемToolStripMenuItem.Text = "Часы с самым маленьким дисплеем";
            this.часыССамымМаленькимДисплеемToolStripMenuItem.Click += new System.EventHandler(this.часыССамымМаленькимДисплеемToolStripMenuItem_Click);
            // 
            // украшениеСНаибольшимЧисломКамнейToolStripMenuItem
            // 
            this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem.Name = "украшениеСНаибольшимЧисломКамнейToolStripMenuItem";
            this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem.Size = new System.Drawing.Size(390, 26);
            this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem.Text = "Украшение с наибольшим числом камней";
            this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem.Click += new System.EventHandler(this.украшениеСНаибольшимЧисломКамнейToolStripMenuItem_Click);
            // 
            // FrontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "FrontForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxSorting;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem chooseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.ToolStripMenuItem самоеДорогоеКольцоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самаяТолстаяЦепочкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыеКороткиеСерьгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem часыССамымМаленькимДисплеемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem украшениеСНаибольшимЧисломКамнейToolStripMenuItem;
    }
}

