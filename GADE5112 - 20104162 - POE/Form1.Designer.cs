namespace GADE5112___20104162___Task_1
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
            this.map_LB = new System.Windows.Forms.Label();
            this.heroStats_LB = new System.Windows.Forms.Label();
            this.heroName_TB = new System.Windows.Forms.TextBox();
            this.heroName_LB = new System.Windows.Forms.Label();
            this.heroAttack_ListBox = new System.Windows.Forms.ListBox();
            this.enemyStats_LB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attack_BTN = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map_LB
            // 
            this.map_LB.AutoSize = true;
            this.map_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_LB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map_LB.Location = new System.Drawing.Point(122, 203);
            this.map_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.map_LB.Name = "map_LB";
            this.map_LB.Size = new System.Drawing.Size(84, 24);
            this.map_LB.TabIndex = 0;
            this.map_LB.Text = "label1";
            // 
            // heroStats_LB
            // 
            this.heroStats_LB.AutoSize = true;
            this.heroStats_LB.Location = new System.Drawing.Point(382, 141);
            this.heroStats_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heroStats_LB.Name = "heroStats_LB";
            this.heroStats_LB.Size = new System.Drawing.Size(19, 17);
            this.heroStats_LB.TabIndex = 1;
            this.heroStats_LB.Text = "lb";
            // 
            // heroName_TB
            // 
            this.heroName_TB.Location = new System.Drawing.Point(182, 40);
            this.heroName_TB.Margin = new System.Windows.Forms.Padding(4);
            this.heroName_TB.Name = "heroName_TB";
            this.heroName_TB.Size = new System.Drawing.Size(186, 22);
            this.heroName_TB.TabIndex = 2;
            // 
            // heroName_LB
            // 
            this.heroName_LB.AutoSize = true;
            this.heroName_LB.Location = new System.Drawing.Point(381, 109);
            this.heroName_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heroName_LB.Name = "heroName_LB";
            this.heroName_LB.Size = new System.Drawing.Size(46, 17);
            this.heroName_LB.TabIndex = 3;
            this.heroName_LB.Text = "label1";
            this.heroName_LB.Click += new System.EventHandler(this.heroName_LB_Click);
            // 
            // heroAttack_ListBox
            // 
            this.heroAttack_ListBox.FormattingEnabled = true;
            this.heroAttack_ListBox.ItemHeight = 16;
            this.heroAttack_ListBox.Location = new System.Drawing.Point(384, 186);
            this.heroAttack_ListBox.Name = "heroAttack_ListBox";
            this.heroAttack_ListBox.Size = new System.Drawing.Size(134, 100);
            this.heroAttack_ListBox.TabIndex = 4;
            this.heroAttack_ListBox.SelectedIndexChanged += new System.EventHandler(this.heroAttack_ListBox_SelectedIndexChanged);
            // 
            // enemyStats_LB
            // 
            this.enemyStats_LB.AutoSize = true;
            this.enemyStats_LB.Location = new System.Drawing.Point(382, 352);
            this.enemyStats_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyStats_LB.Name = "enemyStats_LB";
            this.enemyStats_LB.Size = new System.Drawing.Size(19, 17);
            this.enemyStats_LB.TabIndex = 5;
            this.enemyStats_LB.Text = "lb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type in your Hero\'s Name";
            // 
            // attack_BTN
            // 
            this.attack_BTN.Location = new System.Drawing.Point(385, 292);
            this.attack_BTN.Name = "attack_BTN";
            this.attack_BTN.Size = new System.Drawing.Size(133, 28);
            this.attack_BTN.TabIndex = 7;
            this.attack_BTN.Text = "Attack";
            this.attack_BTN.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(182, 417);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(186, 46);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(536, 475);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.attack_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemyStats_LB);
            this.Controls.Add(this.heroAttack_ListBox);
            this.Controls.Add(this.heroName_LB);
            this.Controls.Add(this.heroName_TB);
            this.Controls.Add(this.heroStats_LB);
            this.Controls.Add(this.map_LB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Rogue Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label map_LB;
        private System.Windows.Forms.Label heroStats_LB;
        private System.Windows.Forms.TextBox heroName_TB;
        private System.Windows.Forms.Label heroName_LB;
        private System.Windows.Forms.ListBox heroAttack_ListBox;
        private System.Windows.Forms.Label enemyStats_LB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attack_BTN;
        private System.Windows.Forms.Button save_btn;
    }
}

