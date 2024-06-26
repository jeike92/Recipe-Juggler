﻿namespace Recipe_Juggler
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblName = new Label();
            pbThumb = new PictureBox();
            lblArea = new Label();
            btnLucky = new Button();
            lblCategory = new Label();
            lblTags = new Label();
            rtbInstructions = new RichTextBox();
            rootBindingSource = new BindingSource(components);
            btnFavorite = new Button();
            btnBack = new Button();
            btnNext = new Button();
            btnShowFavorites = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            lblYouTube = new Label();
            ((System.ComponentModel.ISupportInitialize)pbThumb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rootBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(51, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(130, 31);
            lblName.TabIndex = 1;
            lblName.Text = "MealName";
            // 
            // pbThumb
            // 
            pbThumb.Location = new Point(707, 42);
            pbThumb.Name = "pbThumb";
            pbThumb.Size = new Size(773, 706);
            pbThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            pbThumb.TabIndex = 2;
            pbThumb.TabStop = false;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(51, 88);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 4;
            lblArea.Text = "Area";
            // 
            // btnLucky
            // 
            btnLucky.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLucky.Location = new Point(51, 676);
            btnLucky.Name = "btnLucky";
            btnLucky.Size = new Size(282, 72);
            btnLucky.TabIndex = 5;
            btnLucky.Text = "I am feeling lucky";
            btnLucky.UseVisualStyleBackColor = true;
            btnLucky.Click += BtnLucky_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(51, 129);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Location = new Point(51, 167);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(38, 20);
            lblTags.TabIndex = 8;
            lblTags.Text = "Tags";
            // 
            // rtbInstructions
            // 
            rtbInstructions.Location = new Point(51, 455);
            rtbInstructions.Name = "rtbInstructions";
            rtbInstructions.Size = new Size(625, 201);
            rtbInstructions.TabIndex = 9;
            rtbInstructions.Text = "";
            // 
            // rootBindingSource
            // 
            rootBindingSource.DataSource = typeof(Root);
            // 
            // btnFavorite
            // 
            btnFavorite.Location = new Point(321, 393);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(148, 29);
            btnFavorite.TabIndex = 13;
            btnFavorite.Text = "Add to favorites!";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(388, 704);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(527, 704);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 15;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnShowFavorites
            // 
            btnShowFavorites.Location = new Point(527, 393);
            btnShowFavorites.Name = "btnShowFavorites";
            btnShowFavorites.Size = new Size(149, 29);
            btnShowFavorites.TabIndex = 18;
            btnShowFavorites.Text = "Show favorites";
            btnShowFavorites.UseVisualStyleBackColor = true;
            btnShowFavorites.Click += btnShowFavorites_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(321, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(355, 308);
            dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(51, 234);
            button1.Name = "button1";
            button1.Size = new Size(70, 48);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblYouTube
            // 
            lblYouTube.AutoSize = true;
            lblYouTube.Location = new Point(51, 198);
            lblYouTube.Name = "lblYouTube";
            lblYouTube.Size = new Size(143, 20);
            lblYouTube.TabIndex = 22;
            lblYouTube.Text = "YouTube  Instruction";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1534, 787);
            Controls.Add(lblYouTube);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnShowFavorites);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnFavorite);
            Controls.Add(rtbInstructions);
            Controls.Add(lblTags);
            Controls.Add(lblCategory);
            Controls.Add(btnLucky);
            Controls.Add(lblArea);
            Controls.Add(pbThumb);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Random Recipe Juggler for lazy chefs";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbThumb).EndInit();
            ((System.ComponentModel.ISupportInitialize)rootBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private PictureBox pbThumb;
        private Label lblArea;
        private Button btnLucky;
        private Label lblCategory;
        private Label lblTags;
        private RichTextBox rtbInstructions;
        private BindingSource rootBindingSource;
        private Button btnFavorite;
        private Button btnBack;
        private Button btnNext;
        private Button btnShowFavorites;
        private FileSystemWatcher fileSystemWatcher1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label lblYouTube;
    }
}