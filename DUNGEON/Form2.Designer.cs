﻿namespace DUNGEON
{
    partial class EnemyStatsWindow
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
            this.close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EnemyHPLabel = new System.Windows.Forms.Label();
            this.EnemyDefenceLabel = new System.Windows.Forms.Label();
            this.EnemyPowerLabel = new System.Windows.Forms.Label();
            this.EnemyAgilityLabel = new System.Windows.Forms.Label();
            this.EnemyCritChanceLabel = new System.Windows.Forms.Label();
            this.EnemyCritAdditionalDamageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Brown;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(85, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 35);
            this.close.TabIndex = 50;
            this.close.Text = "Х";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(11, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Защита:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(11, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 52;
            this.label1.Text = "Урон:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(11, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 53;
            this.label2.Text = "Ловкость:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 54;
            this.label3.Text = "Шанс крита:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(11, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 55;
            this.label5.Text = "Урон крита:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 56;
            this.label6.Text = "Здоровье:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 28);
            this.label7.TabIndex = 57;
            this.label7.Text = "Характеристики врагов:";
            // 
            // EnemyHPLabel
            // 
            this.EnemyHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyHPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyHPLabel.Location = new System.Drawing.Point(124, 68);
            this.EnemyHPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyHPLabel.Name = "EnemyHPLabel";
            this.EnemyHPLabel.Size = new System.Drawing.Size(77, 20);
            this.EnemyHPLabel.TabIndex = 58;
            this.EnemyHPLabel.Text = "0";
            // 
            // EnemyDefenceLabel
            // 
            this.EnemyDefenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyDefenceLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyDefenceLabel.Location = new System.Drawing.Point(124, 96);
            this.EnemyDefenceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyDefenceLabel.Name = "EnemyDefenceLabel";
            this.EnemyDefenceLabel.Size = new System.Drawing.Size(77, 20);
            this.EnemyDefenceLabel.TabIndex = 59;
            this.EnemyDefenceLabel.Text = "0";
            // 
            // EnemyPowerLabel
            // 
            this.EnemyPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyPowerLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyPowerLabel.Location = new System.Drawing.Point(124, 122);
            this.EnemyPowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyPowerLabel.Name = "EnemyPowerLabel";
            this.EnemyPowerLabel.Size = new System.Drawing.Size(77, 20);
            this.EnemyPowerLabel.TabIndex = 60;
            this.EnemyPowerLabel.Text = "0";
            // 
            // EnemyAgilityLabel
            // 
            this.EnemyAgilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyAgilityLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyAgilityLabel.Location = new System.Drawing.Point(124, 148);
            this.EnemyAgilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyAgilityLabel.Name = "EnemyAgilityLabel";
            this.EnemyAgilityLabel.Size = new System.Drawing.Size(77, 20);
            this.EnemyAgilityLabel.TabIndex = 61;
            this.EnemyAgilityLabel.Text = "0";
            // 
            // EnemyCritChanceLabel
            // 
            this.EnemyCritChanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCritChanceLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyCritChanceLabel.Location = new System.Drawing.Point(124, 174);
            this.EnemyCritChanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyCritChanceLabel.Name = "EnemyCritChanceLabel";
            this.EnemyCritChanceLabel.Size = new System.Drawing.Size(77, 20);
            this.EnemyCritChanceLabel.TabIndex = 62;
            this.EnemyCritChanceLabel.Text = "0";
            // 
            // EnemyCritAdditionalDamageLabel
            // 
            this.EnemyCritAdditionalDamageLabel.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCritAdditionalDamageLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyCritAdditionalDamageLabel.Location = new System.Drawing.Point(124, 200);
            this.EnemyCritAdditionalDamageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyCritAdditionalDamageLabel.Name = "EnemyCritAdditionalDamageLabel";
            this.EnemyCritAdditionalDamageLabel.Size = new System.Drawing.Size(77, 20);
            this.EnemyCritAdditionalDamageLabel.TabIndex = 63;
            this.EnemyCritAdditionalDamageLabel.Text = "0";
            // 
            // EnemyStatsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(203, 226);
            this.ControlBox = false;
            this.Controls.Add(this.EnemyCritAdditionalDamageLabel);
            this.Controls.Add(this.EnemyCritChanceLabel);
            this.Controls.Add(this.EnemyAgilityLabel);
            this.Controls.Add(this.EnemyPowerLabel);
            this.Controls.Add(this.EnemyDefenceLabel);
            this.Controls.Add(this.EnemyHPLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnemyStatsWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Enemy Stats";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label EnemyHPLabel;
        private System.Windows.Forms.Label EnemyDefenceLabel;
        private System.Windows.Forms.Label EnemyPowerLabel;
        private System.Windows.Forms.Label EnemyAgilityLabel;
        private System.Windows.Forms.Label EnemyCritChanceLabel;
        private System.Windows.Forms.Label EnemyCritAdditionalDamageLabel;
    }
}