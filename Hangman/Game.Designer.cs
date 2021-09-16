namespace Hangman
{
    partial class HangmanGame
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
            this.lettersLabelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wordPanel = new System.Windows.Forms.Panel();
            this.wordRemoveButton = new System.Windows.Forms.Button();
            this.wordAddButton = new System.Windows.Forms.Button();
            this.wordAddTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lettersListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.retriesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countOfLetterComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.userNameTxtBx = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.wordPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lettersLabelPanel
            // 
            this.lettersLabelPanel.Location = new System.Drawing.Point(353, 297);
            this.lettersLabelPanel.Name = "lettersLabelPanel";
            this.lettersLabelPanel.Size = new System.Drawing.Size(301, 202);
            this.lettersLabelPanel.TabIndex = 11;
            // 
            // wordPanel
            // 
            this.wordPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wordPanel.Controls.Add(this.wordRemoveButton);
            this.wordPanel.Controls.Add(this.wordAddButton);
            this.wordPanel.Controls.Add(this.wordAddTxtBx);
            this.wordPanel.Controls.Add(this.label5);
            this.wordPanel.Location = new System.Drawing.Point(677, 56);
            this.wordPanel.Name = "wordPanel";
            this.wordPanel.Size = new System.Drawing.Size(243, 443);
            this.wordPanel.TabIndex = 10;
            this.wordPanel.Visible = false;
            // 
            // wordRemoveButton
            // 
            this.wordRemoveButton.BackColor = System.Drawing.Color.Peru;
            this.wordRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordRemoveButton.Location = new System.Drawing.Point(100, 261);
            this.wordRemoveButton.Name = "wordRemoveButton";
            this.wordRemoveButton.Size = new System.Drawing.Size(123, 34);
            this.wordRemoveButton.TabIndex = 13;
            this.wordRemoveButton.Text = "Kelime Sil";
            this.wordRemoveButton.UseVisualStyleBackColor = false;
            this.wordRemoveButton.Click += new System.EventHandler(this.wordRemoveButton_Click);
            // 
            // wordAddButton
            // 
            this.wordAddButton.BackColor = System.Drawing.Color.Peru;
            this.wordAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordAddButton.Location = new System.Drawing.Point(100, 129);
            this.wordAddButton.Name = "wordAddButton";
            this.wordAddButton.Size = new System.Drawing.Size(123, 34);
            this.wordAddButton.TabIndex = 12;
            this.wordAddButton.Text = "Kelimeyi Ekle";
            this.wordAddButton.UseVisualStyleBackColor = false;
            this.wordAddButton.Click += new System.EventHandler(this.wordAddButton_Click);
            // 
            // wordAddTxtBx
            // 
            this.wordAddTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordAddTxtBx.Location = new System.Drawing.Point(26, 71);
            this.wordAddTxtBx.MaxLength = 70;
            this.wordAddTxtBx.Name = "wordAddTxtBx";
            this.wordAddTxtBx.Size = new System.Drawing.Size(197, 26);
            this.wordAddTxtBx.TabIndex = 12;
            this.wordAddTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordAddTxtBx_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kelime Ekle ";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Peru;
            this.gamePanel.Controls.Add(this.label7);
            this.gamePanel.Controls.Add(this.lettersListview);
            this.gamePanel.Controls.Add(this.label4);
            this.gamePanel.Controls.Add(this.label3);
            this.gamePanel.Controls.Add(this.scoreLabel);
            this.gamePanel.Controls.Add(this.retriesLabel);
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.label1);
            this.gamePanel.Controls.Add(this.countOfLetterComboBox);
            this.gamePanel.Controls.Add(this.startButton);
            this.gamePanel.Controls.Add(this.userNameTxtBx);
            this.gamePanel.Location = new System.Drawing.Point(6, 56);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(341, 443);
            this.gamePanel.TabIndex = 9;
            this.gamePanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(7, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "İsminizde Türkçe karakter kullanmayınız!";
            // 
            // lettersListview
            // 
            this.lettersListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lettersListview.HideSelection = false;
            this.lettersListview.Location = new System.Drawing.Point(3, 220);
            this.lettersListview.Name = "lettersListview";
            this.lettersListview.Size = new System.Drawing.Size(335, 149);
            this.lettersListview.TabIndex = 12;
            this.lettersListview.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 32;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 31;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 32;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 32;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 31;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 31;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 32;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Width = 31;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Width = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Harf Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı Adınız :";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.Location = new System.Drawing.Point(154, 413);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(19, 20);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "0";
            // 
            // retriesLabel
            // 
            this.retriesLabel.AutoSize = true;
            this.retriesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.retriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.retriesLabel.Location = new System.Drawing.Point(154, 372);
            this.retriesLabel.Name = "retriesLabel";
            this.retriesLabel.Size = new System.Drawing.Size(19, 20);
            this.retriesLabel.TabIndex = 8;
            this.retriesLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Skorunuz :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalan Hakkınız :";
            // 
            // countOfLetterComboBox
            // 
            this.countOfLetterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countOfLetterComboBox.FormattingEnabled = true;
            this.countOfLetterComboBox.Location = new System.Drawing.Point(158, 113);
            this.countOfLetterComboBox.Name = "countOfLetterComboBox";
            this.countOfLetterComboBox.Size = new System.Drawing.Size(123, 28);
            this.countOfLetterComboBox.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.Location = new System.Drawing.Point(158, 180);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(123, 34);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Başla";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // userNameTxtBx
            // 
            this.userNameTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameTxtBx.Location = new System.Drawing.Point(158, 24);
            this.userNameTxtBx.MaxLength = 70;
            this.userNameTxtBx.Name = "userNameTxtBx";
            this.userNameTxtBx.Size = new System.Drawing.Size(180, 26);
            this.userNameTxtBx.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.scoreListToolStripMenuItem,
            this.addWordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.gameToolStripMenuItem.Text = "Oyun";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // scoreListToolStripMenuItem
            // 
            this.scoreListToolStripMenuItem.Name = "scoreListToolStripMenuItem";
            this.scoreListToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.scoreListToolStripMenuItem.Text = "Skor Tablosu";
            this.scoreListToolStripMenuItem.Click += new System.EventHandler(this.scoreListToolStripMenuItem_Click);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.addWordToolStripMenuItem.Text = "Kelime Ekle";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click_1);
            // 
            // lettersPanel
            // 
            this.lettersPanel.Location = new System.Drawing.Point(353, 56);
            this.lettersPanel.Name = "lettersPanel";
            this.lettersPanel.Size = new System.Drawing.Size(301, 235);
            this.lettersPanel.TabIndex = 9;
            // 
            // HangmanGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.lettersPanel);
            this.Controls.Add(this.lettersLabelPanel);
            this.Controls.Add(this.wordPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HangmanGame";
            this.Text = "Adam Asmaca";
            this.wordPanel.ResumeLayout(false);
            this.wordPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel lettersLabelPanel;
        private System.Windows.Forms.Panel wordPanel;
        private System.Windows.Forms.Button wordRemoveButton;
        private System.Windows.Forms.Button wordAddButton;
        private System.Windows.Forms.TextBox wordAddTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label retriesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countOfLetterComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox userNameTxtBx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel lettersPanel;
        private System.Windows.Forms.ListView lettersListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label7;
    }
}

