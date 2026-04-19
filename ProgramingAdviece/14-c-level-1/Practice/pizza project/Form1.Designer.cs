namespace pizza_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkChees = new System.Windows.Forms.CheckBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbCurstType = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetFrom = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "make your pizza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbSize
            // 
            this.gbSize.AutoSize = true;
            this.gbSize.BackColor = System.Drawing.Color.Crimson;
            this.gbSize.Controls.Add(this.rbLarg);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Yellow;
            this.gbSize.Location = new System.Drawing.Point(30, 97);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(205, 180);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(42, 113);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(64, 28);
            this.rbLarg.TabIndex = 2;
            this.rbLarg.Tag = "40";
            this.rbLarg.Text = "larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Checked = true;
            this.rbMeduim.Location = new System.Drawing.Point(42, 79);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(102, 28);
            this.rbMeduim.TabIndex = 0;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "30";
            this.rbMeduim.Text = "meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbSmall.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.rbSmall.Location = new System.Drawing.Point(42, 41);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(76, 28);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.AutoSize = true;
            this.gbToppings.BackColor = System.Drawing.Color.Crimson;
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkChees);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.Yellow;
            this.gbToppings.Location = new System.Drawing.Point(267, 97);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(373, 180);
            this.gbToppings.TabIndex = 2;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(211, 123);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(156, 28);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(38, 123);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(113, 28);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(211, 84);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(84, 28);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(38, 84);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(133, 28);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(211, 45);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(84, 28);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkChees
            // 
            this.chkChees.AutoSize = true;
            this.chkChees.Location = new System.Drawing.Point(38, 45);
            this.chkChees.Name = "chkChees";
            this.chkChees.Size = new System.Drawing.Size(131, 28);
            this.chkChees.TabIndex = 0;
            this.chkChees.Tag = "5";
            this.chkChees.Text = "Extra Chees";
            this.chkChees.UseVisualStyleBackColor = true;
            this.chkChees.CheckedChanged += new System.EventHandler(this.chkChees_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.AutoSize = true;
            this.gbCrustType.BackColor = System.Drawing.Color.Crimson;
            this.gbCrustType.Controls.Add(this.rbThink);
            this.gbCrustType.Controls.Add(this.rbThin);
            this.gbCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCrustType.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustType.ForeColor = System.Drawing.Color.Yellow;
            this.gbCrustType.Location = new System.Drawing.Point(30, 309);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Size = new System.Drawing.Size(205, 136);
            this.gbCrustType.TabIndex = 3;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.Location = new System.Drawing.Point(42, 79);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(126, 28);
            this.rbThink.TabIndex = 1;
            this.rbThink.TabStop = true;
            this.rbThink.Tag = "10";
            this.rbThink.Text = "Think crust";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Location = new System.Drawing.Point(42, 41);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(114, 28);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.AutoSize = true;
            this.gbWhereToEat.BackColor = System.Drawing.Color.Crimson;
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.Yellow;
            this.gbWhereToEat.Location = new System.Drawing.Point(288, 309);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(205, 136);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(42, 79);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(109, 28);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(42, 41);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(80, 28);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.AutoSize = true;
            this.gbOrderSummary.BackColor = System.Drawing.Color.Crimson;
            this.gbOrderSummary.Controls.Add(this.lbTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lbToppings);
            this.gbOrderSummary.Controls.Add(this.lbWhereToEat);
            this.gbOrderSummary.Controls.Add(this.lbCurstType);
            this.gbOrderSummary.Controls.Add(this.lbSize);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.Yellow;
            this.gbOrderSummary.Location = new System.Drawing.Point(646, 97);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(394, 476);
            this.gbOrderSummary.TabIndex = 4;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(151, 396);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(186, 54);
            this.lbTotalPrice.TabIndex = 9;
            this.lbTotalPrice.Text = "no Chooice";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoEllipsis = true;
            this.lbToppings.AutoSize = true;
            this.lbToppings.Location = new System.Drawing.Point(11, 181);
            this.lbToppings.MaximumSize = new System.Drawing.Size(330, 0);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(105, 24);
            this.lbToppings.TabIndex = 8;
            this.lbToppings.Text = "no Chooice";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Location = new System.Drawing.Point(147, 372);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(105, 24);
            this.lbWhereToEat.TabIndex = 7;
            this.lbWhereToEat.Text = "no Chooice";
            // 
            // lbCurstType
            // 
            this.lbCurstType.AutoSize = true;
            this.lbCurstType.Location = new System.Drawing.Point(123, 306);
            this.lbCurstType.Name = "lbCurstType";
            this.lbCurstType.Size = new System.Drawing.Size(105, 24);
            this.lbCurstType.TabIndex = 6;
            this.lbCurstType.Text = "no Chooice";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(27, 88);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(105, 24);
            this.lbSize.TabIndex = 5;
            this.lbSize.Text = "no Chooice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Toppings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(11, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Curst Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(6, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Where to Eat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(6, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size:";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOrderPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnOrderPizza.Location = new System.Drawing.Point(67, 493);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(131, 46);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = false;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetFrom
            // 
            this.btnResetFrom.BackColor = System.Drawing.Color.Crimson;
            this.btnResetFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetFrom.Location = new System.Drawing.Point(326, 493);
            this.btnResetFrom.Name = "btnResetFrom";
            this.btnResetFrom.Size = new System.Drawing.Size(131, 46);
            this.btnResetFrom.TabIndex = 6;
            this.btnResetFrom.Text = "Reset Form";
            this.btnResetFrom.UseVisualStyleBackColor = false;
            this.btnResetFrom.Click += new System.EventHandler(this.btnResetFrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1052, 566);
            this.Controls.Add(this.btnResetFrom);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkChees;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbCurstType;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbWhereToEat;
    }
}

