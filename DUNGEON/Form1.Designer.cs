﻿namespace DUNGEON
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DungeonButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PlusAdditionalGold = new System.Windows.Forms.Button();
            this.PlusLuck = new System.Windows.Forms.Button();
            this.PlusAdditionalHP = new System.Windows.Forms.Button();
            this.PlusDefence = new System.Windows.Forms.Button();
            this.PlusPower = new System.Windows.Forms.Button();
            this.PlusAgility = new System.Windows.Forms.Button();
            this.PlusCritChance = new System.Windows.Forms.Button();
            this.PlusCritAdditionalDamage = new System.Windows.Forms.Button();
            this.AdditionalGoldLabel = new System.Windows.Forms.Label();
            this.LuckLabel = new System.Windows.Forms.Label();
            this.AdditionalHPLabel = new System.Windows.Forms.Label();
            this.DefenceLabel = new System.Windows.Forms.Label();
            this.BlockLabel = new System.Windows.Forms.Label();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.CritChanceLabel = new System.Windows.Forms.Label();
            this.CritAdditionalDamageLabel = new System.Windows.Forms.Label();
            this.AdditionalGoldLevel = new System.Windows.Forms.Label();
            this.LuckLevel = new System.Windows.Forms.Label();
            this.AdditionalHPLevel = new System.Windows.Forms.Label();
            this.DefenceLevel = new System.Windows.Forms.Label();
            this.BlockLevel = new System.Windows.Forms.Label();
            this.PowerLevel = new System.Windows.Forms.Label();
            this.AgilityLevel = new System.Windows.Forms.Label();
            this.CritChanceLevel = new System.Windows.Forms.Label();
            this.CritAdditionalDamageLevel = new System.Windows.Forms.Label();
            this.PlusBlock = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HealthLable = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.EXPLAbel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SkillPoints = new System.Windows.Forms.Label();
            this.PlusDungeonLevel = new System.Windows.Forms.Button();
            this.GoldNeedToUpgrateLabel = new System.Windows.Forms.Label();
            this.DungeonLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DungeonButton
            // 
            this.DungeonButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DungeonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DungeonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DungeonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DungeonButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.DungeonButton.FlatAppearance.BorderSize = 0;
            this.DungeonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DungeonButton.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DungeonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DungeonButton.Location = new System.Drawing.Point(522, 416);
            this.DungeonButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DungeonButton.Name = "DungeonButton";
            this.DungeonButton.Size = new System.Drawing.Size(136, 51);
            this.DungeonButton.TabIndex = 0;
            this.DungeonButton.Text = "Отправиться в подземелье";
            this.DungeonButton.UseVisualStyleBackColor = true;
            this.DungeonButton.Click += new System.EventHandler(this.DungeonButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(842, 26);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(18, 28);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "x";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Tan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(133, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "name";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.Color.Gold;
            this.LevelLabel.Location = new System.Drawing.Point(253, 88);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(49, 24);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "0";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LevelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GoldLabel
            // 
            this.GoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldLabel.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLabel.ForeColor = System.Drawing.Color.Gold;
            this.GoldLabel.Location = new System.Drawing.Point(364, 88);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(78, 24);
            this.GoldLabel.TabIndex = 4;
            this.GoldLabel.Text = "0";
            this.GoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GoldLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.inventoryBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // PlusAdditionalGold
            // 
            this.PlusAdditionalGold.BackColor = System.Drawing.Color.Transparent;
            this.PlusAdditionalGold.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusAdditionalGold.FlatAppearance.BorderSize = 0;
            this.PlusAdditionalGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusAdditionalGold.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusAdditionalGold.Location = new System.Drawing.Point(776, 112);
            this.PlusAdditionalGold.Name = "PlusAdditionalGold";
            this.PlusAdditionalGold.Size = new System.Drawing.Size(13, 14);
            this.PlusAdditionalGold.TabIndex = 6;
            this.PlusAdditionalGold.UseVisualStyleBackColor = false;
            this.PlusAdditionalGold.Click += new System.EventHandler(this.PlusAdditionalGold_Click);
            // 
            // PlusLuck
            // 
            this.PlusLuck.BackColor = System.Drawing.Color.Transparent;
            this.PlusLuck.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusLuck.FlatAppearance.BorderSize = 0;
            this.PlusLuck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusLuck.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusLuck.Location = new System.Drawing.Point(777, 140);
            this.PlusLuck.Name = "PlusLuck";
            this.PlusLuck.Size = new System.Drawing.Size(13, 14);
            this.PlusLuck.TabIndex = 7;
            this.PlusLuck.UseVisualStyleBackColor = false;
            this.PlusLuck.Click += new System.EventHandler(this.PlusLuck_Click);
            // 
            // PlusAdditionalHP
            // 
            this.PlusAdditionalHP.BackColor = System.Drawing.Color.Transparent;
            this.PlusAdditionalHP.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusAdditionalHP.FlatAppearance.BorderSize = 0;
            this.PlusAdditionalHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusAdditionalHP.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusAdditionalHP.Location = new System.Drawing.Point(777, 170);
            this.PlusAdditionalHP.Name = "PlusAdditionalHP";
            this.PlusAdditionalHP.Size = new System.Drawing.Size(13, 14);
            this.PlusAdditionalHP.TabIndex = 8;
            this.PlusAdditionalHP.UseVisualStyleBackColor = false;
            this.PlusAdditionalHP.Click += new System.EventHandler(this.PlusAdditionalHP_Click);
            // 
            // PlusDefence
            // 
            this.PlusDefence.BackColor = System.Drawing.Color.Transparent;
            this.PlusDefence.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusDefence.FlatAppearance.BorderSize = 0;
            this.PlusDefence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusDefence.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusDefence.Location = new System.Drawing.Point(776, 195);
            this.PlusDefence.Name = "PlusDefence";
            this.PlusDefence.Size = new System.Drawing.Size(13, 14);
            this.PlusDefence.TabIndex = 9;
            this.PlusDefence.UseVisualStyleBackColor = false;
            this.PlusDefence.Click += new System.EventHandler(this.PlusDefence_Click);
            // 
            // PlusPower
            // 
            this.PlusPower.BackColor = System.Drawing.Color.Transparent;
            this.PlusPower.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusPower.FlatAppearance.BorderSize = 0;
            this.PlusPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusPower.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusPower.Location = new System.Drawing.Point(777, 253);
            this.PlusPower.Name = "PlusPower";
            this.PlusPower.Size = new System.Drawing.Size(13, 14);
            this.PlusPower.TabIndex = 10;
            this.PlusPower.UseVisualStyleBackColor = false;
            this.PlusPower.Click += new System.EventHandler(this.PlusPower_Click);
            // 
            // PlusAgility
            // 
            this.PlusAgility.BackColor = System.Drawing.Color.Transparent;
            this.PlusAgility.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusAgility.FlatAppearance.BorderSize = 0;
            this.PlusAgility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusAgility.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusAgility.Location = new System.Drawing.Point(777, 283);
            this.PlusAgility.Name = "PlusAgility";
            this.PlusAgility.Size = new System.Drawing.Size(13, 14);
            this.PlusAgility.TabIndex = 11;
            this.PlusAgility.UseVisualStyleBackColor = false;
            this.PlusAgility.Click += new System.EventHandler(this.PlusAgility_Click);
            // 
            // PlusCritChance
            // 
            this.PlusCritChance.BackColor = System.Drawing.Color.Transparent;
            this.PlusCritChance.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusCritChance.FlatAppearance.BorderSize = 0;
            this.PlusCritChance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusCritChance.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusCritChance.Location = new System.Drawing.Point(776, 310);
            this.PlusCritChance.Name = "PlusCritChance";
            this.PlusCritChance.Size = new System.Drawing.Size(13, 14);
            this.PlusCritChance.TabIndex = 12;
            this.PlusCritChance.UseVisualStyleBackColor = false;
            this.PlusCritChance.Click += new System.EventHandler(this.PlusCritChance_Click);
            // 
            // PlusCritAdditionalDamage
            // 
            this.PlusCritAdditionalDamage.BackColor = System.Drawing.Color.Transparent;
            this.PlusCritAdditionalDamage.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusCritAdditionalDamage.FlatAppearance.BorderSize = 0;
            this.PlusCritAdditionalDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusCritAdditionalDamage.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusCritAdditionalDamage.Location = new System.Drawing.Point(776, 339);
            this.PlusCritAdditionalDamage.Name = "PlusCritAdditionalDamage";
            this.PlusCritAdditionalDamage.Size = new System.Drawing.Size(13, 14);
            this.PlusCritAdditionalDamage.TabIndex = 13;
            this.PlusCritAdditionalDamage.UseVisualStyleBackColor = false;
            this.PlusCritAdditionalDamage.Click += new System.EventHandler(this.PlusCritAdditionalDamage_Click);
            // 
            // AdditionalGoldLabel
            // 
            this.AdditionalGoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalGoldLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalGoldLabel.Location = new System.Drawing.Point(621, 111);
            this.AdditionalGoldLabel.Name = "AdditionalGoldLabel";
            this.AdditionalGoldLabel.Size = new System.Drawing.Size(85, 20);
            this.AdditionalGoldLabel.TabIndex = 14;
            this.AdditionalGoldLabel.Text = "+100%";
            // 
            // LuckLabel
            // 
            this.LuckLabel.BackColor = System.Drawing.Color.Transparent;
            this.LuckLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LuckLabel.Location = new System.Drawing.Point(621, 140);
            this.LuckLabel.Name = "LuckLabel";
            this.LuckLabel.Size = new System.Drawing.Size(85, 20);
            this.LuckLabel.TabIndex = 15;
            this.LuckLabel.Text = "0%";
            // 
            // AdditionalHPLabel
            // 
            this.AdditionalHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalHPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalHPLabel.Location = new System.Drawing.Point(621, 169);
            this.AdditionalHPLabel.Name = "AdditionalHPLabel";
            this.AdditionalHPLabel.Size = new System.Drawing.Size(85, 20);
            this.AdditionalHPLabel.TabIndex = 16;
            this.AdditionalHPLabel.Text = "+0";
            // 
            // DefenceLabel
            // 
            this.DefenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefenceLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefenceLabel.Location = new System.Drawing.Point(621, 195);
            this.DefenceLabel.Name = "DefenceLabel";
            this.DefenceLabel.Size = new System.Drawing.Size(85, 20);
            this.DefenceLabel.TabIndex = 17;
            this.DefenceLabel.Text = "0";
            // 
            // BlockLabel
            // 
            this.BlockLabel.BackColor = System.Drawing.Color.Transparent;
            this.BlockLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockLabel.Location = new System.Drawing.Point(621, 223);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(85, 20);
            this.BlockLabel.TabIndex = 18;
            this.BlockLabel.Text = "0%";
            // 
            // PowerLabel
            // 
            this.PowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PowerLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerLabel.Location = new System.Drawing.Point(621, 252);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(85, 20);
            this.PowerLabel.TabIndex = 19;
            this.PowerLabel.Text = "5";
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgilityLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgilityLabel.Location = new System.Drawing.Point(621, 281);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(85, 20);
            this.AgilityLabel.TabIndex = 20;
            this.AgilityLabel.Text = "10%";
            // 
            // CritChanceLabel
            // 
            this.CritChanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CritChanceLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritChanceLabel.Location = new System.Drawing.Point(621, 309);
            this.CritChanceLabel.Name = "CritChanceLabel";
            this.CritChanceLabel.Size = new System.Drawing.Size(85, 20);
            this.CritChanceLabel.TabIndex = 21;
            this.CritChanceLabel.Text = "10%";
            // 
            // CritAdditionalDamageLabel
            // 
            this.CritAdditionalDamageLabel.BackColor = System.Drawing.Color.Transparent;
            this.CritAdditionalDamageLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritAdditionalDamageLabel.Location = new System.Drawing.Point(621, 338);
            this.CritAdditionalDamageLabel.Name = "CritAdditionalDamageLabel";
            this.CritAdditionalDamageLabel.Size = new System.Drawing.Size(85, 20);
            this.CritAdditionalDamageLabel.TabIndex = 22;
            this.CritAdditionalDamageLabel.Text = "+150%";
            // 
            // AdditionalGoldLevel
            // 
            this.AdditionalGoldLevel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalGoldLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalGoldLevel.Location = new System.Drawing.Point(704, 111);
            this.AdditionalGoldLevel.Name = "AdditionalGoldLevel";
            this.AdditionalGoldLevel.Size = new System.Drawing.Size(35, 20);
            this.AdditionalGoldLevel.TabIndex = 23;
            this.AdditionalGoldLevel.Text = "0";
            // 
            // LuckLevel
            // 
            this.LuckLevel.BackColor = System.Drawing.Color.Transparent;
            this.LuckLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LuckLevel.Location = new System.Drawing.Point(704, 140);
            this.LuckLevel.Name = "LuckLevel";
            this.LuckLevel.Size = new System.Drawing.Size(35, 20);
            this.LuckLevel.TabIndex = 24;
            this.LuckLevel.Text = "0";
            // 
            // AdditionalHPLevel
            // 
            this.AdditionalHPLevel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalHPLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalHPLevel.Location = new System.Drawing.Point(704, 169);
            this.AdditionalHPLevel.Name = "AdditionalHPLevel";
            this.AdditionalHPLevel.Size = new System.Drawing.Size(35, 20);
            this.AdditionalHPLevel.TabIndex = 25;
            this.AdditionalHPLevel.Text = "0";
            // 
            // DefenceLevel
            // 
            this.DefenceLevel.BackColor = System.Drawing.Color.Transparent;
            this.DefenceLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefenceLevel.Location = new System.Drawing.Point(704, 195);
            this.DefenceLevel.Name = "DefenceLevel";
            this.DefenceLevel.Size = new System.Drawing.Size(35, 20);
            this.DefenceLevel.TabIndex = 26;
            this.DefenceLevel.Text = "0";
            // 
            // BlockLevel
            // 
            this.BlockLevel.BackColor = System.Drawing.Color.Transparent;
            this.BlockLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockLevel.Location = new System.Drawing.Point(704, 223);
            this.BlockLevel.Name = "BlockLevel";
            this.BlockLevel.Size = new System.Drawing.Size(35, 20);
            this.BlockLevel.TabIndex = 27;
            this.BlockLevel.Text = "0";
            // 
            // PowerLevel
            // 
            this.PowerLevel.BackColor = System.Drawing.Color.Transparent;
            this.PowerLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerLevel.Location = new System.Drawing.Point(704, 252);
            this.PowerLevel.Name = "PowerLevel";
            this.PowerLevel.Size = new System.Drawing.Size(35, 20);
            this.PowerLevel.TabIndex = 28;
            this.PowerLevel.Text = "0";
            // 
            // AgilityLevel
            // 
            this.AgilityLevel.BackColor = System.Drawing.Color.Transparent;
            this.AgilityLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgilityLevel.Location = new System.Drawing.Point(704, 281);
            this.AgilityLevel.Name = "AgilityLevel";
            this.AgilityLevel.Size = new System.Drawing.Size(35, 20);
            this.AgilityLevel.TabIndex = 29;
            this.AgilityLevel.Text = "0";
            // 
            // CritChanceLevel
            // 
            this.CritChanceLevel.BackColor = System.Drawing.Color.Transparent;
            this.CritChanceLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritChanceLevel.Location = new System.Drawing.Point(704, 309);
            this.CritChanceLevel.Name = "CritChanceLevel";
            this.CritChanceLevel.Size = new System.Drawing.Size(35, 20);
            this.CritChanceLevel.TabIndex = 30;
            this.CritChanceLevel.Text = "0";
            // 
            // CritAdditionalDamageLevel
            // 
            this.CritAdditionalDamageLevel.BackColor = System.Drawing.Color.Transparent;
            this.CritAdditionalDamageLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritAdditionalDamageLevel.Location = new System.Drawing.Point(704, 338);
            this.CritAdditionalDamageLevel.Name = "CritAdditionalDamageLevel";
            this.CritAdditionalDamageLevel.Size = new System.Drawing.Size(35, 20);
            this.CritAdditionalDamageLevel.TabIndex = 31;
            this.CritAdditionalDamageLevel.Text = "0";
            // 
            // PlusBlock
            // 
            this.PlusBlock.BackColor = System.Drawing.Color.Transparent;
            this.PlusBlock.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusBlock.FlatAppearance.BorderSize = 0;
            this.PlusBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBlock.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBlock.Location = new System.Drawing.Point(776, 225);
            this.PlusBlock.Name = "PlusBlock";
            this.PlusBlock.Size = new System.Drawing.Size(13, 14);
            this.PlusBlock.TabIndex = 32;
            this.PlusBlock.UseVisualStyleBackColor = false;
            this.PlusBlock.Click += new System.EventHandler(this.PlusBlock_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.inventoryBindingSource;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(304, 273);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 33;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.inventoryBindingSource;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(304, 331);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 34;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.inventoryBindingSource;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(304, 387);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 35;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.inventoryBindingSource;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(304, 443);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 36;
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(145, 512);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(280, 32);
            this.HealthBar.Step = 1;
            this.HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthBar.TabIndex = 37;
            this.HealthBar.Value = 100;
            // 
            // HealthLable
            // 
            this.HealthLable.BackColor = System.Drawing.Color.Transparent;
            this.HealthLable.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLable.ForeColor = System.Drawing.Color.White;
            this.HealthLable.Location = new System.Drawing.Point(145, 493);
            this.HealthLable.Name = "HealthLable";
            this.HealthLable.Size = new System.Drawing.Size(280, 26);
            this.HealthLable.TabIndex = 38;
            this.HealthLable.Text = "100/100";
            this.HealthLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(304, 135);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(106, 23);
            this.progressBar1.TabIndex = 39;
            // 
            // EXPLAbel
            // 
            this.EXPLAbel.BackColor = System.Drawing.Color.Transparent;
            this.EXPLAbel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXPLAbel.ForeColor = System.Drawing.Color.Gold;
            this.EXPLAbel.Location = new System.Drawing.Point(304, 156);
            this.EXPLAbel.Name = "EXPLAbel";
            this.EXPLAbel.Size = new System.Drawing.Size(106, 22);
            this.EXPLAbel.TabIndex = 40;
            this.EXPLAbel.Text = "0/100";
            this.EXPLAbel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(300, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "EXP";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(649, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Очки навыков:";
            // 
            // SkillPoints
            // 
            this.SkillPoints.BackColor = System.Drawing.Color.Transparent;
            this.SkillPoints.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SkillPoints.Location = new System.Drawing.Point(774, 359);
            this.SkillPoints.Name = "SkillPoints";
            this.SkillPoints.Size = new System.Drawing.Size(73, 26);
            this.SkillPoints.TabIndex = 43;
            this.SkillPoints.Text = "0";
            // 
            // PlusDungeonLevel
            // 
            this.PlusDungeonLevel.BackColor = System.Drawing.Color.Transparent;
            this.PlusDungeonLevel.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusDungeonLevel.FlatAppearance.BorderSize = 0;
            this.PlusDungeonLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusDungeonLevel.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusDungeonLevel.Location = new System.Drawing.Point(747, 491);
            this.PlusDungeonLevel.Name = "PlusDungeonLevel";
            this.PlusDungeonLevel.Size = new System.Drawing.Size(13, 14);
            this.PlusDungeonLevel.TabIndex = 44;
            this.PlusDungeonLevel.UseVisualStyleBackColor = false;
            this.PlusDungeonLevel.Click += new System.EventHandler(this.PlusDungeonLevel_Click);
            // 
            // GoldNeedToUpgrateLabel
            // 
            this.GoldNeedToUpgrateLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldNeedToUpgrateLabel.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldNeedToUpgrateLabel.ForeColor = System.Drawing.Color.Gold;
            this.GoldNeedToUpgrateLabel.Location = new System.Drawing.Point(801, 487);
            this.GoldNeedToUpgrateLabel.Name = "GoldNeedToUpgrateLabel";
            this.GoldNeedToUpgrateLabel.Size = new System.Drawing.Size(46, 24);
            this.GoldNeedToUpgrateLabel.TabIndex = 45;
            this.GoldNeedToUpgrateLabel.Text = "500";
            this.GoldNeedToUpgrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DungeonLevelLabel
            // 
            this.DungeonLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DungeonLevelLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DungeonLevelLabel.Location = new System.Drawing.Point(744, 397);
            this.DungeonLevelLabel.Name = "DungeonLevelLabel";
            this.DungeonLevelLabel.Size = new System.Drawing.Size(35, 20);
            this.DungeonLevelLabel.TabIndex = 46;
            this.DungeonLevelLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 684);
            this.Controls.Add(this.DungeonLevelLabel);
            this.Controls.Add(this.GoldNeedToUpgrateLabel);
            this.Controls.Add(this.PlusDungeonLevel);
            this.Controls.Add(this.SkillPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EXPLAbel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.HealthLable);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.PlusBlock);
            this.Controls.Add(this.CritAdditionalDamageLevel);
            this.Controls.Add(this.CritChanceLevel);
            this.Controls.Add(this.AgilityLevel);
            this.Controls.Add(this.PowerLevel);
            this.Controls.Add(this.BlockLevel);
            this.Controls.Add(this.DefenceLevel);
            this.Controls.Add(this.AdditionalHPLevel);
            this.Controls.Add(this.LuckLevel);
            this.Controls.Add(this.AdditionalGoldLevel);
            this.Controls.Add(this.CritAdditionalDamageLabel);
            this.Controls.Add(this.CritChanceLabel);
            this.Controls.Add(this.AgilityLabel);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.BlockLabel);
            this.Controls.Add(this.DefenceLabel);
            this.Controls.Add(this.AdditionalHPLabel);
            this.Controls.Add(this.LuckLabel);
            this.Controls.Add(this.AdditionalGoldLabel);
            this.Controls.Add(this.PlusCritAdditionalDamage);
            this.Controls.Add(this.PlusCritChance);
            this.Controls.Add(this.PlusAgility);
            this.Controls.Add(this.PlusPower);
            this.Controls.Add(this.PlusDefence);
            this.Controls.Add(this.PlusAdditionalHP);
            this.Controls.Add(this.PlusLuck);
            this.Controls.Add(this.PlusAdditionalGold);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DungeonButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DungeonButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.Button PlusAdditionalGold;
        private System.Windows.Forms.Button PlusLuck;
        private System.Windows.Forms.Button PlusAdditionalHP;
        private System.Windows.Forms.Button PlusDefence;
        private System.Windows.Forms.Button PlusPower;
        private System.Windows.Forms.Button PlusAgility;
        private System.Windows.Forms.Button PlusCritChance;
        private System.Windows.Forms.Button PlusCritAdditionalDamage;
        private System.Windows.Forms.Label AdditionalGoldLabel;
        private System.Windows.Forms.Label LuckLabel;
        private System.Windows.Forms.Label AdditionalHPLabel;
        private System.Windows.Forms.Label DefenceLabel;
        private System.Windows.Forms.Label BlockLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label AgilityLabel;
        private System.Windows.Forms.Label CritChanceLabel;
        private System.Windows.Forms.Label CritAdditionalDamageLabel;
        private System.Windows.Forms.Label AdditionalGoldLevel;
        private System.Windows.Forms.Label LuckLevel;
        private System.Windows.Forms.Label AdditionalHPLevel;
        private System.Windows.Forms.Label DefenceLevel;
        private System.Windows.Forms.Label BlockLevel;
        private System.Windows.Forms.Label PowerLevel;
        private System.Windows.Forms.Label AgilityLevel;
        private System.Windows.Forms.Label CritChanceLevel;
        private System.Windows.Forms.Label CritAdditionalDamageLevel;
        private System.Windows.Forms.Button PlusBlock;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Label HealthLable;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label EXPLAbel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SkillPoints;
        private System.Windows.Forms.Button PlusDungeonLevel;
        private System.Windows.Forms.Label GoldNeedToUpgrateLabel;
        private System.Windows.Forms.Label DungeonLevelLabel;
    }
}

