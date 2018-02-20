namespace SheppardTAS
{
    partial class sheppardtas
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
            this.reset_btn = new System.Windows.Forms.Button();
            this.run_btn = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delaytext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clickcounter = new System.Windows.Forms.Label();
            this.default_check_state = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.total_moves = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(12, 253);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Clear";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_Click);
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(100, 253);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(75, 23);
            this.run_btn.TabIndex = 4;
            this.run_btn.Text = "Run";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_Click);
            // 
            // listbox
            // 
            this.listbox.CheckOnClick = true;
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(15, 62);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(163, 139);
            this.listbox.TabIndex = 9999;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press F7 to add a new position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Checked positions will be clicked";
            // 
            // delaytext
            // 
            this.delaytext.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.delaytext.Location = new System.Drawing.Point(55, 208);
            this.delaytext.MaxLength = 20;
            this.delaytext.Name = "delaytext";
            this.delaytext.Size = new System.Drawing.Size(32, 20);
            this.delaytext.TabIndex = 2;
            this.delaytext.Text = "0";
            this.delaytext.WordWrap = false;
            this.delaytext.TextChanged += new System.EventHandler(this.delaytext_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delay:";
            // 
            // clickcounter
            // 
            this.clickcounter.AutoSize = true;
            this.clickcounter.Location = new System.Drawing.Point(12, 230);
            this.clickcounter.Name = "clickcounter";
            this.clickcounter.Size = new System.Drawing.Size(78, 13);
            this.clickcounter.TabIndex = 10;
            this.clickcounter.Text = "Clicked 0 times";
            // 
            // default_check_state
            // 
            this.default_check_state.AutoSize = true;
            this.default_check_state.Location = new System.Drawing.Point(163, 42);
            this.default_check_state.Name = "default_check_state";
            this.default_check_state.Size = new System.Drawing.Size(15, 14);
            this.default_check_state.TabIndex = 1;
            this.default_check_state.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Default:";
            // 
            // total_moves
            // 
            this.total_moves.AutoSize = true;
            this.total_moves.Location = new System.Drawing.Point(14, 46);
            this.total_moves.Name = "total_moves";
            this.total_moves.Size = new System.Drawing.Size(43, 13);
            this.total_moves.TabIndex = 10000;
            this.total_moves.Text = "Total: 0";
            // 
            // sheppardtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 288);
            this.Controls.Add(this.total_moves);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.default_check_state);
            this.Controls.Add(this.clickcounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delaytext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.reset_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sheppardtas";
            this.ShowIcon = false;
            this.Text = "Sheppard TAS";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.CheckedListBox listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delaytext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label clickcounter;
        private System.Windows.Forms.CheckBox default_check_state;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_moves;
    }
}

