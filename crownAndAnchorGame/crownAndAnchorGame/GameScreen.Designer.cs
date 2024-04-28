namespace crownAndAnchorGame
{
    partial class GameScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBanksButton = new System.Windows.Forms.Button();
            this.textChangeBets = new System.Windows.Forms.Label();
            this.crownValue = new System.Windows.Forms.NumericUpDown();
            this.anchorValue = new System.Windows.Forms.NumericUpDown();
            this.spadesValue = new System.Windows.Forms.NumericUpDown();
            this.heartsValue = new System.Windows.Forms.NumericUpDown();
            this.crossesValue = new System.Windows.Forms.NumericUpDown();
            this.boobyValue = new System.Windows.Forms.NumericUpDown();
            this.startRound = new System.Windows.Forms.Button();
            this.saveBets = new System.Windows.Forms.Button();
            this.betsValues = new System.Windows.Forms.GroupBox();
            this.boobyBox = new System.Windows.Forms.PictureBox();
            this.crossesBox = new System.Windows.Forms.PictureBox();
            this.heartsBox = new System.Windows.Forms.PictureBox();
            this.spadesBox = new System.Windows.Forms.PictureBox();
            this.anchorBox = new System.Windows.Forms.PictureBox();
            this.crownBox = new System.Windows.Forms.PictureBox();
            this.rollDicesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.diceValues = new System.Windows.Forms.GroupBox();
            this.endButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchorValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossesValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boobyValue)).BeginInit();
            this.betsValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boobyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.diceValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerName,
            this.playerBank});
            this.dataGridView1.Location = new System.Drawing.Point(22, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(364, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // playerName
            // 
            this.playerName.HeaderText = "Имя";
            this.playerName.MinimumWidth = 8;
            this.playerName.Name = "playerName";
            this.playerName.ReadOnly = true;
            this.playerName.Width = 150;
            // 
            // playerBank
            // 
            this.playerBank.HeaderText = "Банк";
            this.playerBank.MinimumWidth = 8;
            this.playerBank.Name = "playerBank";
            this.playerBank.Width = 150;
            // 
            // saveBanksButton
            // 
            this.saveBanksButton.BackColor = System.Drawing.Color.Crimson;
            this.saveBanksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBanksButton.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBanksButton.Location = new System.Drawing.Point(22, 374);
            this.saveBanksButton.Name = "saveBanksButton";
            this.saveBanksButton.Size = new System.Drawing.Size(355, 41);
            this.saveBanksButton.TabIndex = 1;
            this.saveBanksButton.Text = "Сохранить";
            this.saveBanksButton.UseVisualStyleBackColor = false;
            this.saveBanksButton.Click += new System.EventHandler(this.SaveBanksButton_Click);
            // 
            // textChangeBets
            // 
            this.textChangeBets.AutoSize = true;
            this.textChangeBets.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textChangeBets.Location = new System.Drawing.Point(22, 19);
            this.textChangeBets.Name = "textChangeBets";
            this.textChangeBets.Size = new System.Drawing.Size(349, 32);
            this.textChangeBets.TabIndex = 2;
            this.textChangeBets.Text = "Вы можете изменить банк:";
            // 
            // crownValue
            // 
            this.crownValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.crownValue.Location = new System.Drawing.Point(19, 44);
            this.crownValue.Name = "crownValue";
            this.crownValue.Size = new System.Drawing.Size(76, 39);
            this.crownValue.TabIndex = 3;
            // 
            // anchorValue
            // 
            this.anchorValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.anchorValue.Location = new System.Drawing.Point(19, 138);
            this.anchorValue.Name = "anchorValue";
            this.anchorValue.Size = new System.Drawing.Size(76, 39);
            this.anchorValue.TabIndex = 4;
            // 
            // spadesValue
            // 
            this.spadesValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spadesValue.Location = new System.Drawing.Point(19, 230);
            this.spadesValue.Name = "spadesValue";
            this.spadesValue.Size = new System.Drawing.Size(76, 39);
            this.spadesValue.TabIndex = 5;
            // 
            // heartsValue
            // 
            this.heartsValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.heartsValue.Location = new System.Drawing.Point(228, 44);
            this.heartsValue.Name = "heartsValue";
            this.heartsValue.Size = new System.Drawing.Size(76, 39);
            this.heartsValue.TabIndex = 6;
            // 
            // crossesValue
            // 
            this.crossesValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.crossesValue.Location = new System.Drawing.Point(228, 138);
            this.crossesValue.Name = "crossesValue";
            this.crossesValue.Size = new System.Drawing.Size(76, 39);
            this.crossesValue.TabIndex = 7;
            // 
            // boobyValue
            // 
            this.boobyValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.boobyValue.Location = new System.Drawing.Point(228, 230);
            this.boobyValue.Name = "boobyValue";
            this.boobyValue.Size = new System.Drawing.Size(76, 39);
            this.boobyValue.TabIndex = 8;
            // 
            // startRound
            // 
            this.startRound.BackColor = System.Drawing.Color.Crimson;
            this.startRound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startRound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startRound.Location = new System.Drawing.Point(22, 374);
            this.startRound.Name = "startRound";
            this.startRound.Size = new System.Drawing.Size(364, 41);
            this.startRound.TabIndex = 9;
            this.startRound.Text = "Начать раунд";
            this.startRound.UseVisualStyleBackColor = false;
            this.startRound.Click += new System.EventHandler(this.StartRound_Click);
            // 
            // saveBets
            // 
            this.saveBets.BackColor = System.Drawing.Color.Crimson;
            this.saveBets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveBets.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBets.Location = new System.Drawing.Point(552, 374);
            this.saveBets.Name = "saveBets";
            this.saveBets.Size = new System.Drawing.Size(257, 41);
            this.saveBets.TabIndex = 10;
            this.saveBets.Text = "Сохранить ставки";
            this.saveBets.UseVisualStyleBackColor = false;
            this.saveBets.Click += new System.EventHandler(this.SaveBets_Click);
            // 
            // betsValues
            // 
            this.betsValues.Controls.Add(this.boobyBox);
            this.betsValues.Controls.Add(this.crossesBox);
            this.betsValues.Controls.Add(this.heartsBox);
            this.betsValues.Controls.Add(this.spadesBox);
            this.betsValues.Controls.Add(this.anchorBox);
            this.betsValues.Controls.Add(this.crownBox);
            this.betsValues.Controls.Add(this.crownValue);
            this.betsValues.Controls.Add(this.anchorValue);
            this.betsValues.Controls.Add(this.spadesValue);
            this.betsValues.Controls.Add(this.boobyValue);
            this.betsValues.Controls.Add(this.heartsValue);
            this.betsValues.Controls.Add(this.crossesValue);
            this.betsValues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.betsValues.Location = new System.Drawing.Point(474, 58);
            this.betsValues.Name = "betsValues";
            this.betsValues.Size = new System.Drawing.Size(447, 298);
            this.betsValues.TabIndex = 11;
            this.betsValues.TabStop = false;
            this.betsValues.Text = "groupBox1";
            // 
            // boobyBox
            // 
            this.boobyBox.Location = new System.Drawing.Point(320, 208);
            this.boobyBox.Name = "boobyBox";
            this.boobyBox.Size = new System.Drawing.Size(74, 74);
            this.boobyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boobyBox.TabIndex = 21;
            this.boobyBox.TabStop = false;
            // 
            // crossesBox
            // 
            this.crossesBox.Location = new System.Drawing.Point(320, 119);
            this.crossesBox.Name = "crossesBox";
            this.crossesBox.Size = new System.Drawing.Size(74, 74);
            this.crossesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crossesBox.TabIndex = 20;
            this.crossesBox.TabStop = false;
            // 
            // heartsBox
            // 
            this.heartsBox.Location = new System.Drawing.Point(320, 30);
            this.heartsBox.Name = "heartsBox";
            this.heartsBox.Size = new System.Drawing.Size(74, 74);
            this.heartsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heartsBox.TabIndex = 19;
            this.heartsBox.TabStop = false;
            // 
            // spadesBox
            // 
            this.spadesBox.Location = new System.Drawing.Point(112, 208);
            this.spadesBox.Name = "spadesBox";
            this.spadesBox.Size = new System.Drawing.Size(74, 74);
            this.spadesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spadesBox.TabIndex = 18;
            this.spadesBox.TabStop = false;
            // 
            // anchorBox
            // 
            this.anchorBox.Location = new System.Drawing.Point(112, 119);
            this.anchorBox.Name = "anchorBox";
            this.anchorBox.Size = new System.Drawing.Size(74, 74);
            this.anchorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anchorBox.TabIndex = 17;
            this.anchorBox.TabStop = false;
            // 
            // crownBox
            // 
            this.crownBox.Location = new System.Drawing.Point(112, 30);
            this.crownBox.Name = "crownBox";
            this.crownBox.Size = new System.Drawing.Size(74, 74);
            this.crownBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crownBox.TabIndex = 16;
            this.crownBox.TabStop = false;
            // 
            // rollDicesButton
            // 
            this.rollDicesButton.BackColor = System.Drawing.Color.Crimson;
            this.rollDicesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rollDicesButton.ForeColor = System.Drawing.SystemColors.Control;
            this.rollDicesButton.Location = new System.Drawing.Point(552, 374);
            this.rollDicesButton.Name = "rollDicesButton";
            this.rollDicesButton.Size = new System.Drawing.Size(257, 41);
            this.rollDicesButton.TabIndex = 12;
            this.rollDicesButton.Text = "Бросить кубики";
            this.rollDicesButton.UseVisualStyleBackColor = false;
            this.rollDicesButton.Click += new System.EventHandler(this.RollDicesButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(15, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(15, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // diceValues
            // 
            this.diceValues.Controls.Add(this.pictureBox1);
            this.diceValues.Controls.Add(this.pictureBox3);
            this.diceValues.Controls.Add(this.pictureBox2);
            this.diceValues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diceValues.Location = new System.Drawing.Point(967, 58);
            this.diceValues.Name = "diceValues";
            this.diceValues.Size = new System.Drawing.Size(237, 298);
            this.diceValues.TabIndex = 16;
            this.diceValues.TabStop = false;
            this.diceValues.Text = "Результат броска";
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.Color.Crimson;
            this.endButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endButton.ForeColor = System.Drawing.SystemColors.Control;
            this.endButton.Location = new System.Drawing.Point(967, 374);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(237, 41);
            this.endButton.TabIndex = 17;
            this.endButton.Text = "Завершить игру";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1236, 453);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.diceValues);
            this.Controls.Add(this.rollDicesButton);
            this.Controls.Add(this.betsValues);
            this.Controls.Add(this.saveBets);
            this.Controls.Add(this.startRound);
            this.Controls.Add(this.textChangeBets);
            this.Controls.Add(this.saveBanksButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchorValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossesValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boobyValue)).EndInit();
            this.betsValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boobyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.diceValues.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn playerName;
        private DataGridViewTextBoxColumn playerBank;
        private Button saveBanksButton;
        private Label textChangeBets;
        private NumericUpDown crownValue;
        private NumericUpDown anchorValue;
        private NumericUpDown spadesValue;
        private NumericUpDown heartsValue;
        private NumericUpDown crossesValue;
        private NumericUpDown boobyValue;
        private Button startRound;
        private Button saveBets;
        private GroupBox betsValues;
        private Button rollDicesButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox boobyBox;
        private PictureBox crossesBox;
        private PictureBox heartsBox;
        private PictureBox spadesBox;
        private PictureBox anchorBox;
        private PictureBox crownBox;
        private GroupBox diceValues;
        private Button endButton;
    }
}