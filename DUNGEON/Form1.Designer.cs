namespace DUNGEON
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.DungeonButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.HeadInventory = new System.Windows.Forms.ComboBox();
            this.PlusAdditionalGold = new System.Windows.Forms.Button();
            this.PlusLuck = new System.Windows.Forms.Button();
            this.PlusAdditionalHP = new System.Windows.Forms.Button();
            this.PlusDefence = new System.Windows.Forms.Button();
            this.PlusPower = new System.Windows.Forms.Button();
            this.PlusAgility = new System.Windows.Forms.Button();
            this.PlusCritChance = new System.Windows.Forms.Button();
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
            this.ArmorInventory = new System.Windows.Forms.ComboBox();
            this.LegsInventory = new System.Windows.Forms.ComboBox();
            this.SwordsInventory = new System.Windows.Forms.ComboBox();
            this.ShieldsInventory = new System.Windows.Forms.ComboBox();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.HealthLable = new System.Windows.Forms.Label();
            this.EXPBar = new System.Windows.Forms.ProgressBar();
            this.EXPLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SkillPoints = new System.Windows.Forms.Label();
            this.PlusDungeonLevel = new System.Windows.Forms.Button();
            this.GoldNeedToUpgradeLabel = new System.Windows.Forms.Label();
            this.PlusCritAdditionalDamage = new System.Windows.Forms.Button();
            this.DangeonLevelLabel = new System.Windows.Forms.Label();
            this.webVochila = new System.Windows.Forms.WebBrowser();
            this.EnemyStatsButton = new System.Windows.Forms.Button();
            this.NewShieldLabel = new System.Windows.Forms.Label();
            this.NewSwordLabel = new System.Windows.Forms.Label();
            this.NewLegsLabel = new System.Windows.Forms.Label();
            this.NewArmorLabel = new System.Windows.Forms.Label();
            this.NewHeadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DungeonButton
            // 
            this.DungeonButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DungeonButton.BackColor = System.Drawing.Color.Maroon;
            this.DungeonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DungeonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DungeonButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.DungeonButton.FlatAppearance.BorderSize = 2;
            this.DungeonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DungeonButton.Font = new System.Drawing.Font("Castellar", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DungeonButton.ForeColor = System.Drawing.Color.Gold;
            this.DungeonButton.Location = new System.Drawing.Point(541, 602);
            this.DungeonButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DungeonButton.Name = "DungeonButton";
            this.DungeonButton.Size = new System.Drawing.Size(269, 40);
            this.DungeonButton.TabIndex = 0;
            this.DungeonButton.Text = "Отправиться в подземелье";
            this.DungeonButton.UseVisualStyleBackColor = false;
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
            this.ExitButton.Location = new System.Drawing.Point(840, 21);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 44);
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
            this.textBox1.Location = new System.Drawing.Point(132, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "name";
            // 
            // LevelLabel
            // 
            this.LevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.LevelLabel.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LevelLabel.Location = new System.Drawing.Point(252, 88);
            this.LevelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(49, 24);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "0";
            this.LevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoldLabel
            // 
            this.GoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldLabel.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GoldLabel.Location = new System.Drawing.Point(364, 88);
            this.GoldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(78, 24);
            this.GoldLabel.TabIndex = 4;
            this.GoldLabel.Text = "0";
            this.GoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeadInventory
            // 
            this.HeadInventory.BackColor = System.Drawing.Color.Gold;
            this.HeadInventory.DisplayMember = "name";
            this.HeadInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HeadInventory.Font = new System.Drawing.Font("Castellar", 9.75F);
            this.HeadInventory.FormattingEnabled = true;
            this.HeadInventory.Location = new System.Drawing.Point(304, 215);
            this.HeadInventory.Margin = new System.Windows.Forms.Padding(2);
            this.HeadInventory.Name = "HeadInventory";
            this.HeadInventory.Size = new System.Drawing.Size(133, 27);
            this.HeadInventory.Sorted = true;
            this.HeadInventory.TabIndex = 5;
            this.HeadInventory.ValueMember = "name";
            this.HeadInventory.DropDown += new System.EventHandler(this.HeadInventory_DropDown);
            this.HeadInventory.SelectedIndexChanged += new System.EventHandler(this.HeadInventory_SelectedIndexChanged);
            this.HeadInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadInventory_MouseDown);
            // 
            // PlusAdditionalGold
            // 
            this.PlusAdditionalGold.BackColor = System.Drawing.Color.Transparent;
            this.PlusAdditionalGold.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusAdditionalGold.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusAdditionalGold.FlatAppearance.BorderSize = 2;
            this.PlusAdditionalGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusAdditionalGold.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusAdditionalGold.Location = new System.Drawing.Point(776, 112);
            this.PlusAdditionalGold.Margin = new System.Windows.Forms.Padding(2);
            this.PlusAdditionalGold.Name = "PlusAdditionalGold";
            this.PlusAdditionalGold.Size = new System.Drawing.Size(12, 14);
            this.PlusAdditionalGold.TabIndex = 6;
            this.PlusAdditionalGold.UseVisualStyleBackColor = false;
            this.PlusAdditionalGold.Click += new System.EventHandler(this.PlusAdditionalGold_Click);
            // 
            // PlusLuck
            // 
            this.PlusLuck.BackColor = System.Drawing.Color.Transparent;
            this.PlusLuck.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusLuck.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusLuck.FlatAppearance.BorderSize = 2;
            this.PlusLuck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusLuck.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusLuck.Location = new System.Drawing.Point(776, 140);
            this.PlusLuck.Margin = new System.Windows.Forms.Padding(2);
            this.PlusLuck.Name = "PlusLuck";
            this.PlusLuck.Size = new System.Drawing.Size(12, 14);
            this.PlusLuck.TabIndex = 7;
            this.PlusLuck.UseVisualStyleBackColor = false;
            this.PlusLuck.Click += new System.EventHandler(this.PlusLuck_Click);
            // 
            // PlusAdditionalHP
            // 
            this.PlusAdditionalHP.BackColor = System.Drawing.Color.Transparent;
            this.PlusAdditionalHP.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusAdditionalHP.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusAdditionalHP.FlatAppearance.BorderSize = 2;
            this.PlusAdditionalHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusAdditionalHP.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusAdditionalHP.Location = new System.Drawing.Point(776, 169);
            this.PlusAdditionalHP.Margin = new System.Windows.Forms.Padding(2);
            this.PlusAdditionalHP.Name = "PlusAdditionalHP";
            this.PlusAdditionalHP.Size = new System.Drawing.Size(12, 14);
            this.PlusAdditionalHP.TabIndex = 8;
            this.PlusAdditionalHP.UseVisualStyleBackColor = false;
            this.PlusAdditionalHP.Click += new System.EventHandler(this.PlusAdditionalHP_Click);
            // 
            // PlusDefence
            // 
            this.PlusDefence.BackColor = System.Drawing.Color.Transparent;
            this.PlusDefence.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusDefence.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusDefence.FlatAppearance.BorderSize = 2;
            this.PlusDefence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusDefence.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusDefence.Location = new System.Drawing.Point(776, 195);
            this.PlusDefence.Margin = new System.Windows.Forms.Padding(2);
            this.PlusDefence.Name = "PlusDefence";
            this.PlusDefence.Size = new System.Drawing.Size(12, 14);
            this.PlusDefence.TabIndex = 9;
            this.PlusDefence.UseVisualStyleBackColor = false;
            this.PlusDefence.Click += new System.EventHandler(this.PlusDefence_Click);
            // 
            // PlusPower
            // 
            this.PlusPower.BackColor = System.Drawing.Color.Transparent;
            this.PlusPower.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusPower.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusPower.FlatAppearance.BorderSize = 2;
            this.PlusPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusPower.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusPower.Location = new System.Drawing.Point(776, 252);
            this.PlusPower.Margin = new System.Windows.Forms.Padding(2);
            this.PlusPower.Name = "PlusPower";
            this.PlusPower.Size = new System.Drawing.Size(12, 14);
            this.PlusPower.TabIndex = 10;
            this.PlusPower.UseVisualStyleBackColor = false;
            this.PlusPower.Click += new System.EventHandler(this.PlusPower_Click);
            // 
            // PlusAgility
            // 
            this.PlusAgility.BackColor = System.Drawing.Color.Transparent;
            this.PlusAgility.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusAgility.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusAgility.FlatAppearance.BorderSize = 2;
            this.PlusAgility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusAgility.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusAgility.Location = new System.Drawing.Point(776, 281);
            this.PlusAgility.Margin = new System.Windows.Forms.Padding(2);
            this.PlusAgility.Name = "PlusAgility";
            this.PlusAgility.Size = new System.Drawing.Size(12, 14);
            this.PlusAgility.TabIndex = 11;
            this.PlusAgility.UseVisualStyleBackColor = false;
            this.PlusAgility.Click += new System.EventHandler(this.PlusAgility_Click);
            // 
            // PlusCritChance
            // 
            this.PlusCritChance.BackColor = System.Drawing.Color.Transparent;
            this.PlusCritChance.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusCritChance.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusCritChance.FlatAppearance.BorderSize = 2;
            this.PlusCritChance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusCritChance.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusCritChance.Location = new System.Drawing.Point(776, 310);
            this.PlusCritChance.Margin = new System.Windows.Forms.Padding(2);
            this.PlusCritChance.Name = "PlusCritChance";
            this.PlusCritChance.Size = new System.Drawing.Size(12, 14);
            this.PlusCritChance.TabIndex = 12;
            this.PlusCritChance.UseVisualStyleBackColor = false;
            this.PlusCritChance.Click += new System.EventHandler(this.PlusCritChance_Click);
            // 
            // AdditionalGoldLabel
            // 
            this.AdditionalGoldLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalGoldLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalGoldLabel.ForeColor = System.Drawing.Color.Black;
            this.AdditionalGoldLabel.Location = new System.Drawing.Point(621, 111);
            this.AdditionalGoldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdditionalGoldLabel.Name = "AdditionalGoldLabel";
            this.AdditionalGoldLabel.Size = new System.Drawing.Size(85, 20);
            this.AdditionalGoldLabel.TabIndex = 14;
            this.AdditionalGoldLabel.Text = "+0%";
            // 
            // LuckLabel
            // 
            this.LuckLabel.BackColor = System.Drawing.Color.Transparent;
            this.LuckLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LuckLabel.ForeColor = System.Drawing.Color.Black;
            this.LuckLabel.Location = new System.Drawing.Point(621, 140);
            this.LuckLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LuckLabel.Name = "LuckLabel";
            this.LuckLabel.Size = new System.Drawing.Size(85, 20);
            this.LuckLabel.TabIndex = 15;
            this.LuckLabel.Text = "0%";
            // 
            // AdditionalHPLabel
            // 
            this.AdditionalHPLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalHPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalHPLabel.ForeColor = System.Drawing.Color.Black;
            this.AdditionalHPLabel.Location = new System.Drawing.Point(621, 169);
            this.AdditionalHPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdditionalHPLabel.Name = "AdditionalHPLabel";
            this.AdditionalHPLabel.Size = new System.Drawing.Size(85, 20);
            this.AdditionalHPLabel.TabIndex = 16;
            this.AdditionalHPLabel.Text = "+0";
            // 
            // DefenceLabel
            // 
            this.DefenceLabel.BackColor = System.Drawing.Color.Transparent;
            this.DefenceLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefenceLabel.ForeColor = System.Drawing.Color.Black;
            this.DefenceLabel.Location = new System.Drawing.Point(621, 195);
            this.DefenceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DefenceLabel.Name = "DefenceLabel";
            this.DefenceLabel.Size = new System.Drawing.Size(85, 20);
            this.DefenceLabel.TabIndex = 17;
            this.DefenceLabel.Text = "2";
            // 
            // BlockLabel
            // 
            this.BlockLabel.BackColor = System.Drawing.Color.Transparent;
            this.BlockLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockLabel.ForeColor = System.Drawing.Color.Black;
            this.BlockLabel.Location = new System.Drawing.Point(621, 222);
            this.BlockLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlockLabel.Name = "BlockLabel";
            this.BlockLabel.Size = new System.Drawing.Size(85, 20);
            this.BlockLabel.TabIndex = 18;
            this.BlockLabel.Text = "0%";
            // 
            // PowerLabel
            // 
            this.PowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PowerLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerLabel.ForeColor = System.Drawing.Color.Black;
            this.PowerLabel.Location = new System.Drawing.Point(621, 252);
            this.PowerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(85, 20);
            this.PowerLabel.TabIndex = 19;
            this.PowerLabel.Text = "10";
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgilityLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgilityLabel.ForeColor = System.Drawing.Color.Black;
            this.AgilityLabel.Location = new System.Drawing.Point(621, 281);
            this.AgilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(85, 20);
            this.AgilityLabel.TabIndex = 20;
            this.AgilityLabel.Text = "10%";
            // 
            // CritChanceLabel
            // 
            this.CritChanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.CritChanceLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritChanceLabel.ForeColor = System.Drawing.Color.Black;
            this.CritChanceLabel.Location = new System.Drawing.Point(621, 309);
            this.CritChanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CritChanceLabel.Name = "CritChanceLabel";
            this.CritChanceLabel.Size = new System.Drawing.Size(85, 20);
            this.CritChanceLabel.TabIndex = 21;
            this.CritChanceLabel.Text = "10%";
            // 
            // CritAdditionalDamageLabel
            // 
            this.CritAdditionalDamageLabel.BackColor = System.Drawing.Color.Transparent;
            this.CritAdditionalDamageLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritAdditionalDamageLabel.ForeColor = System.Drawing.Color.Black;
            this.CritAdditionalDamageLabel.Location = new System.Drawing.Point(621, 338);
            this.CritAdditionalDamageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CritAdditionalDamageLabel.Name = "CritAdditionalDamageLabel";
            this.CritAdditionalDamageLabel.Size = new System.Drawing.Size(85, 20);
            this.CritAdditionalDamageLabel.TabIndex = 22;
            this.CritAdditionalDamageLabel.Text = "150%";
            // 
            // AdditionalGoldLevel
            // 
            this.AdditionalGoldLevel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalGoldLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalGoldLevel.ForeColor = System.Drawing.Color.Black;
            this.AdditionalGoldLevel.Location = new System.Drawing.Point(704, 111);
            this.AdditionalGoldLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdditionalGoldLevel.Name = "AdditionalGoldLevel";
            this.AdditionalGoldLevel.Size = new System.Drawing.Size(35, 20);
            this.AdditionalGoldLevel.TabIndex = 23;
            this.AdditionalGoldLevel.Text = "0";
            // 
            // LuckLevel
            // 
            this.LuckLevel.BackColor = System.Drawing.Color.Transparent;
            this.LuckLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LuckLevel.ForeColor = System.Drawing.Color.Black;
            this.LuckLevel.Location = new System.Drawing.Point(704, 140);
            this.LuckLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LuckLevel.Name = "LuckLevel";
            this.LuckLevel.Size = new System.Drawing.Size(35, 20);
            this.LuckLevel.TabIndex = 24;
            this.LuckLevel.Text = "0";
            // 
            // AdditionalHPLevel
            // 
            this.AdditionalHPLevel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalHPLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionalHPLevel.ForeColor = System.Drawing.Color.Black;
            this.AdditionalHPLevel.Location = new System.Drawing.Point(704, 169);
            this.AdditionalHPLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdditionalHPLevel.Name = "AdditionalHPLevel";
            this.AdditionalHPLevel.Size = new System.Drawing.Size(35, 20);
            this.AdditionalHPLevel.TabIndex = 25;
            this.AdditionalHPLevel.Text = "0";
            // 
            // DefenceLevel
            // 
            this.DefenceLevel.BackColor = System.Drawing.Color.Transparent;
            this.DefenceLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefenceLevel.ForeColor = System.Drawing.Color.Black;
            this.DefenceLevel.Location = new System.Drawing.Point(704, 195);
            this.DefenceLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DefenceLevel.Name = "DefenceLevel";
            this.DefenceLevel.Size = new System.Drawing.Size(35, 20);
            this.DefenceLevel.TabIndex = 26;
            this.DefenceLevel.Text = "0";
            // 
            // BlockLevel
            // 
            this.BlockLevel.BackColor = System.Drawing.Color.Transparent;
            this.BlockLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BlockLevel.ForeColor = System.Drawing.Color.Black;
            this.BlockLevel.Location = new System.Drawing.Point(704, 222);
            this.BlockLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BlockLevel.Name = "BlockLevel";
            this.BlockLevel.Size = new System.Drawing.Size(35, 20);
            this.BlockLevel.TabIndex = 27;
            this.BlockLevel.Text = "0";
            // 
            // PowerLevel
            // 
            this.PowerLevel.BackColor = System.Drawing.Color.Transparent;
            this.PowerLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerLevel.ForeColor = System.Drawing.Color.Black;
            this.PowerLevel.Location = new System.Drawing.Point(704, 252);
            this.PowerLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PowerLevel.Name = "PowerLevel";
            this.PowerLevel.Size = new System.Drawing.Size(35, 20);
            this.PowerLevel.TabIndex = 28;
            this.PowerLevel.Text = "0";
            // 
            // AgilityLevel
            // 
            this.AgilityLevel.BackColor = System.Drawing.Color.Transparent;
            this.AgilityLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgilityLevel.ForeColor = System.Drawing.Color.Black;
            this.AgilityLevel.Location = new System.Drawing.Point(704, 281);
            this.AgilityLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgilityLevel.Name = "AgilityLevel";
            this.AgilityLevel.Size = new System.Drawing.Size(35, 20);
            this.AgilityLevel.TabIndex = 29;
            this.AgilityLevel.Text = "0";
            // 
            // CritChanceLevel
            // 
            this.CritChanceLevel.BackColor = System.Drawing.Color.Transparent;
            this.CritChanceLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritChanceLevel.ForeColor = System.Drawing.Color.Black;
            this.CritChanceLevel.Location = new System.Drawing.Point(704, 309);
            this.CritChanceLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CritChanceLevel.Name = "CritChanceLevel";
            this.CritChanceLevel.Size = new System.Drawing.Size(35, 20);
            this.CritChanceLevel.TabIndex = 30;
            this.CritChanceLevel.Text = "0";
            // 
            // CritAdditionalDamageLevel
            // 
            this.CritAdditionalDamageLevel.BackColor = System.Drawing.Color.Transparent;
            this.CritAdditionalDamageLevel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CritAdditionalDamageLevel.ForeColor = System.Drawing.Color.Black;
            this.CritAdditionalDamageLevel.Location = new System.Drawing.Point(704, 338);
            this.CritAdditionalDamageLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CritAdditionalDamageLevel.Name = "CritAdditionalDamageLevel";
            this.CritAdditionalDamageLevel.Size = new System.Drawing.Size(35, 20);
            this.CritAdditionalDamageLevel.TabIndex = 31;
            this.CritAdditionalDamageLevel.Text = "0";
            // 
            // PlusBlock
            // 
            this.PlusBlock.BackColor = System.Drawing.Color.Transparent;
            this.PlusBlock.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusBlock.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusBlock.FlatAppearance.BorderSize = 2;
            this.PlusBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBlock.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBlock.Location = new System.Drawing.Point(776, 225);
            this.PlusBlock.Margin = new System.Windows.Forms.Padding(2);
            this.PlusBlock.Name = "PlusBlock";
            this.PlusBlock.Size = new System.Drawing.Size(12, 14);
            this.PlusBlock.TabIndex = 32;
            this.PlusBlock.UseVisualStyleBackColor = false;
            this.PlusBlock.Click += new System.EventHandler(this.PlusBlock_Click);
            // 
            // ArmorInventory
            // 
            this.ArmorInventory.BackColor = System.Drawing.Color.Gold;
            this.ArmorInventory.DisplayMember = "name";
            this.ArmorInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArmorInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ArmorInventory.FormattingEnabled = true;
            this.ArmorInventory.Location = new System.Drawing.Point(304, 272);
            this.ArmorInventory.Margin = new System.Windows.Forms.Padding(2);
            this.ArmorInventory.Name = "ArmorInventory";
            this.ArmorInventory.Size = new System.Drawing.Size(133, 27);
            this.ArmorInventory.Sorted = true;
            this.ArmorInventory.TabIndex = 33;
            this.ArmorInventory.ValueMember = "name";
            this.ArmorInventory.DropDown += new System.EventHandler(this.ArmorInventory_DropDown);
            this.ArmorInventory.SelectedIndexChanged += new System.EventHandler(this.ArmorInventory_SelectedIndexChanged);
            this.ArmorInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArmorInventory_MouseDown);
            // 
            // LegsInventory
            // 
            this.LegsInventory.BackColor = System.Drawing.Color.Gold;
            this.LegsInventory.DisplayMember = "name";
            this.LegsInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LegsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LegsInventory.FormattingEnabled = true;
            this.LegsInventory.Location = new System.Drawing.Point(304, 331);
            this.LegsInventory.Margin = new System.Windows.Forms.Padding(2);
            this.LegsInventory.Name = "LegsInventory";
            this.LegsInventory.Size = new System.Drawing.Size(133, 27);
            this.LegsInventory.Sorted = true;
            this.LegsInventory.TabIndex = 34;
            this.LegsInventory.ValueMember = "name";
            this.LegsInventory.DropDown += new System.EventHandler(this.LegsInventory_DropDown);
            this.LegsInventory.SelectedIndexChanged += new System.EventHandler(this.LegsInventory_SelectedIndexChanged);
            this.LegsInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LegsInventory_MouseDown);
            // 
            // SwordsInventory
            // 
            this.SwordsInventory.BackColor = System.Drawing.Color.Gold;
            this.SwordsInventory.DisplayMember = "name";
            this.SwordsInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SwordsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SwordsInventory.FormattingEnabled = true;
            this.SwordsInventory.Location = new System.Drawing.Point(304, 388);
            this.SwordsInventory.Margin = new System.Windows.Forms.Padding(2);
            this.SwordsInventory.Name = "SwordsInventory";
            this.SwordsInventory.Size = new System.Drawing.Size(133, 27);
            this.SwordsInventory.Sorted = true;
            this.SwordsInventory.TabIndex = 35;
            this.SwordsInventory.ValueMember = "name";
            this.SwordsInventory.DropDown += new System.EventHandler(this.SwordsInventory_DropDown);
            this.SwordsInventory.SelectedIndexChanged += new System.EventHandler(this.SwordsInventory_SelectedIndexChanged);
            this.SwordsInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwordsInventory_MouseDown);
            // 
            // ShieldsInventory
            // 
            this.ShieldsInventory.BackColor = System.Drawing.Color.Gold;
            this.ShieldsInventory.DisplayMember = "name";
            this.ShieldsInventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShieldsInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShieldsInventory.FormattingEnabled = true;
            this.ShieldsInventory.Location = new System.Drawing.Point(304, 442);
            this.ShieldsInventory.Margin = new System.Windows.Forms.Padding(2);
            this.ShieldsInventory.Name = "ShieldsInventory";
            this.ShieldsInventory.Size = new System.Drawing.Size(133, 27);
            this.ShieldsInventory.Sorted = true;
            this.ShieldsInventory.TabIndex = 36;
            this.ShieldsInventory.ValueMember = "name";
            this.ShieldsInventory.DropDown += new System.EventHandler(this.ShieldsInventory_DropDown);
            this.ShieldsInventory.SelectedIndexChanged += new System.EventHandler(this.ShieldsInventory_SelectedIndexChanged);
            this.ShieldsInventory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShieldsInventory_MouseDown);
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(145, 512);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(275, 32);
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
            this.HealthLable.Location = new System.Drawing.Point(145, 492);
            this.HealthLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthLable.Name = "HealthLable";
            this.HealthLable.Size = new System.Drawing.Size(280, 26);
            this.HealthLable.TabIndex = 38;
            this.HealthLable.Text = "100/100";
            this.HealthLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EXPBar
            // 
            this.EXPBar.Location = new System.Drawing.Point(304, 135);
            this.EXPBar.Margin = new System.Windows.Forms.Padding(2);
            this.EXPBar.Name = "EXPBar";
            this.EXPBar.Size = new System.Drawing.Size(106, 22);
            this.EXPBar.TabIndex = 39;
            // 
            // EXPLabel
            // 
            this.EXPLabel.BackColor = System.Drawing.Color.Transparent;
            this.EXPLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EXPLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.EXPLabel.Location = new System.Drawing.Point(304, 156);
            this.EXPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EXPLabel.Name = "EXPLabel";
            this.EXPLabel.Size = new System.Drawing.Size(106, 22);
            this.EXPLabel.TabIndex = 40;
            this.EXPLabel.Text = "0/50";
            this.EXPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(304, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "EXP";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(649, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.SkillPoints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SkillPoints.Name = "SkillPoints";
            this.SkillPoints.Size = new System.Drawing.Size(72, 26);
            this.SkillPoints.TabIndex = 43;
            this.SkillPoints.Text = "0";
            // 
            // PlusDungeonLevel
            // 
            this.PlusDungeonLevel.BackColor = System.Drawing.Color.Transparent;
            this.PlusDungeonLevel.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusDungeonLevel.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusDungeonLevel.FlatAppearance.BorderSize = 2;
            this.PlusDungeonLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusDungeonLevel.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusDungeonLevel.Location = new System.Drawing.Point(522, 486);
            this.PlusDungeonLevel.Margin = new System.Windows.Forms.Padding(2);
            this.PlusDungeonLevel.Name = "PlusDungeonLevel";
            this.PlusDungeonLevel.Size = new System.Drawing.Size(241, 24);
            this.PlusDungeonLevel.TabIndex = 44;
            this.PlusDungeonLevel.UseVisualStyleBackColor = false;
            this.PlusDungeonLevel.Click += new System.EventHandler(this.PlusDungeonLevel_Click);
            // 
            // GoldNeedToUpgradeLabel
            // 
            this.GoldNeedToUpgradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GoldNeedToUpgradeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoldNeedToUpgradeLabel.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldNeedToUpgradeLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.GoldNeedToUpgradeLabel.Location = new System.Drawing.Point(765, 486);
            this.GoldNeedToUpgradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoldNeedToUpgradeLabel.Name = "GoldNeedToUpgradeLabel";
            this.GoldNeedToUpgradeLabel.Size = new System.Drawing.Size(65, 24);
            this.GoldNeedToUpgradeLabel.TabIndex = 45;
            this.GoldNeedToUpgradeLabel.Text = "500";
            this.GoldNeedToUpgradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlusCritAdditionalDamage
            // 
            this.PlusCritAdditionalDamage.BackColor = System.Drawing.Color.Transparent;
            this.PlusCritAdditionalDamage.Cursor = System.Windows.Forms.Cursors.No;
            this.PlusCritAdditionalDamage.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.PlusCritAdditionalDamage.FlatAppearance.BorderSize = 2;
            this.PlusCritAdditionalDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusCritAdditionalDamage.Font = new System.Drawing.Font("", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusCritAdditionalDamage.Location = new System.Drawing.Point(776, 339);
            this.PlusCritAdditionalDamage.Margin = new System.Windows.Forms.Padding(2);
            this.PlusCritAdditionalDamage.Name = "PlusCritAdditionalDamage";
            this.PlusCritAdditionalDamage.Size = new System.Drawing.Size(12, 14);
            this.PlusCritAdditionalDamage.TabIndex = 46;
            this.PlusCritAdditionalDamage.UseVisualStyleBackColor = false;
            this.PlusCritAdditionalDamage.Click += new System.EventHandler(this.PlusCritAdditionalDamage_Click);
            // 
            // DangeonLevelLabel
            // 
            this.DangeonLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.DangeonLevelLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DangeonLevelLabel.Location = new System.Drawing.Point(749, 397);
            this.DangeonLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DangeonLevelLabel.Name = "DangeonLevelLabel";
            this.DangeonLevelLabel.Size = new System.Drawing.Size(40, 26);
            this.DangeonLevelLabel.TabIndex = 47;
            this.DangeonLevelLabel.Text = "0";
            // 
            // webVochila
            // 
            this.webVochila.IsWebBrowserContextMenuEnabled = false;
            this.webVochila.Location = new System.Drawing.Point(942, 664);
            this.webVochila.Margin = new System.Windows.Forms.Padding(2);
            this.webVochila.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVochila.Name = "webVochila";
            this.webVochila.ScrollBarsEnabled = false;
            this.webVochila.Size = new System.Drawing.Size(20, 20);
            this.webVochila.TabIndex = 48;
            this.webVochila.Url = new System.Uri("", System.UriKind.Relative);
            this.webVochila.Visible = false;
            // 
            // EnemyStatsButton
            // 
            this.EnemyStatsButton.BackColor = System.Drawing.Color.Transparent;
            this.EnemyStatsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnemyStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnemyStatsButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyStatsButton.Location = new System.Drawing.Point(499, 605);
            this.EnemyStatsButton.Name = "EnemyStatsButton";
            this.EnemyStatsButton.Size = new System.Drawing.Size(34, 34);
            this.EnemyStatsButton.TabIndex = 49;
            this.EnemyStatsButton.Text = "?";
            this.EnemyStatsButton.UseVisualStyleBackColor = false;
            this.EnemyStatsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewShieldLabel
            // 
            this.NewShieldLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.NewShieldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewShieldLabel.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewShieldLabel.ForeColor = System.Drawing.Color.White;
            this.NewShieldLabel.Location = new System.Drawing.Point(443, 442);
            this.NewShieldLabel.Name = "NewShieldLabel";
            this.NewShieldLabel.Size = new System.Drawing.Size(19, 26);
            this.NewShieldLabel.TabIndex = 50;
            this.NewShieldLabel.Text = "!";
            this.NewShieldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewShieldLabel.Visible = false;
            // 
            // NewSwordLabel
            // 
            this.NewSwordLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.NewSwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewSwordLabel.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSwordLabel.ForeColor = System.Drawing.Color.White;
            this.NewSwordLabel.Location = new System.Drawing.Point(443, 389);
            this.NewSwordLabel.Name = "NewSwordLabel";
            this.NewSwordLabel.Size = new System.Drawing.Size(19, 26);
            this.NewSwordLabel.TabIndex = 51;
            this.NewSwordLabel.Text = "!";
            this.NewSwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewSwordLabel.Visible = false;
            // 
            // NewLegsLabel
            // 
            this.NewLegsLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.NewLegsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewLegsLabel.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLegsLabel.ForeColor = System.Drawing.Color.White;
            this.NewLegsLabel.Location = new System.Drawing.Point(443, 332);
            this.NewLegsLabel.Name = "NewLegsLabel";
            this.NewLegsLabel.Size = new System.Drawing.Size(19, 26);
            this.NewLegsLabel.TabIndex = 52;
            this.NewLegsLabel.Text = "!";
            this.NewLegsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewLegsLabel.Visible = false;
            // 
            // NewArmorLabel
            // 
            this.NewArmorLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.NewArmorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewArmorLabel.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewArmorLabel.ForeColor = System.Drawing.Color.White;
            this.NewArmorLabel.Location = new System.Drawing.Point(443, 273);
            this.NewArmorLabel.Name = "NewArmorLabel";
            this.NewArmorLabel.Size = new System.Drawing.Size(19, 26);
            this.NewArmorLabel.TabIndex = 53;
            this.NewArmorLabel.Text = "!";
            this.NewArmorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewArmorLabel.Visible = false;
            // 
            // NewHeadLabel
            // 
            this.NewHeadLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.NewHeadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewHeadLabel.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHeadLabel.ForeColor = System.Drawing.Color.White;
            this.NewHeadLabel.Location = new System.Drawing.Point(442, 216);
            this.NewHeadLabel.Name = "NewHeadLabel";
            this.NewHeadLabel.Size = new System.Drawing.Size(19, 26);
            this.NewHeadLabel.TabIndex = 54;
            this.NewHeadLabel.Text = "!";
            this.NewHeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewHeadLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 684);
            this.ControlBox = false;
            this.Controls.Add(this.NewHeadLabel);
            this.Controls.Add(this.NewArmorLabel);
            this.Controls.Add(this.NewLegsLabel);
            this.Controls.Add(this.NewSwordLabel);
            this.Controls.Add(this.NewShieldLabel);
            this.Controls.Add(this.EnemyStatsButton);
            this.Controls.Add(this.webVochila);
            this.Controls.Add(this.DangeonLevelLabel);
            this.Controls.Add(this.PlusCritAdditionalDamage);
            this.Controls.Add(this.GoldNeedToUpgradeLabel);
            this.Controls.Add(this.PlusDungeonLevel);
            this.Controls.Add(this.SkillPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EXPLabel);
            this.Controls.Add(this.EXPBar);
            this.Controls.Add(this.HealthLable);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.ShieldsInventory);
            this.Controls.Add(this.SwordsInventory);
            this.Controls.Add(this.LegsInventory);
            this.Controls.Add(this.ArmorInventory);
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
            this.Controls.Add(this.PlusCritChance);
            this.Controls.Add(this.PlusAgility);
            this.Controls.Add(this.PlusPower);
            this.Controls.Add(this.PlusDefence);
            this.Controls.Add(this.PlusAdditionalHP);
            this.Controls.Add(this.PlusLuck);
            this.Controls.Add(this.PlusAdditionalGold);
            this.Controls.Add(this.HeadInventory);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DungeonButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dangeon & Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DungeonButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label GoldLabel;
        private System.Windows.Forms.ComboBox HeadInventory;
        private System.Windows.Forms.Button PlusAdditionalGold;
        private System.Windows.Forms.Button PlusLuck;
        private System.Windows.Forms.Button PlusAdditionalHP;
        private System.Windows.Forms.Button PlusDefence;
        private System.Windows.Forms.Button PlusPower;
        private System.Windows.Forms.Button PlusAgility;
        private System.Windows.Forms.Button PlusCritChance;
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
        private System.Windows.Forms.ComboBox ArmorInventory;
        private System.Windows.Forms.ComboBox LegsInventory;
        private System.Windows.Forms.ComboBox SwordsInventory;
        private System.Windows.Forms.ComboBox ShieldsInventory;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Label HealthLable;
        private System.Windows.Forms.ProgressBar EXPBar;
        private System.Windows.Forms.Label EXPLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SkillPoints;
        private System.Windows.Forms.Button PlusDungeonLevel;
        private System.Windows.Forms.Label GoldNeedToUpgradeLabel;
        private System.Windows.Forms.Button PlusCritAdditionalDamage;
        private System.Windows.Forms.Label DangeonLevelLabel;
        private System.Windows.Forms.WebBrowser webVochila;
        private System.Windows.Forms.Button EnemyStatsButton;
        private System.Windows.Forms.Label NewShieldLabel;
        private System.Windows.Forms.Label NewSwordLabel;
        private System.Windows.Forms.Label NewLegsLabel;
        private System.Windows.Forms.Label NewArmorLabel;
        private System.Windows.Forms.Label NewHeadLabel;
    }
}

