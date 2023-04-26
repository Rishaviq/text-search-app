namespace text_search_app
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_number_search = new System.Windows.Forms.Button();
            this.box_specific_word_search = new System.Windows.Forms.TextBox();
            this.btn_specific_word_search = new System.Windows.Forms.Button();
            this.btn_longest_word = new System.Windows.Forms.Button();
            this.box_number_search = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.box_number_search)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 258);
            this.textBox1.TabIndex = 0;
            // 
            // btn_number_search
            // 
            this.btn_number_search.Location = new System.Drawing.Point(12, 121);
            this.btn_number_search.Name = "btn_number_search";
            this.btn_number_search.Size = new System.Drawing.Size(100, 23);
            this.btn_number_search.TabIndex = 1;
            this.btn_number_search.Text = "търсене";
            this.btn_number_search.UseVisualStyleBackColor = true;
            // 
            // box_specific_word_search
            // 
            this.box_specific_word_search.Location = new System.Drawing.Point(396, 91);
            this.box_specific_word_search.Name = "box_specific_word_search";
            this.box_specific_word_search.Size = new System.Drawing.Size(100, 23);
            this.box_specific_word_search.TabIndex = 2;
            // 
            // btn_specific_word_search
            // 
            this.btn_specific_word_search.Location = new System.Drawing.Point(396, 121);
            this.btn_specific_word_search.Name = "btn_specific_word_search";
            this.btn_specific_word_search.Size = new System.Drawing.Size(100, 23);
            this.btn_specific_word_search.TabIndex = 3;
            this.btn_specific_word_search.Text = "търсене";
            this.btn_specific_word_search.UseVisualStyleBackColor = true;
            // 
            // btn_longest_word
            // 
            this.btn_longest_word.Location = new System.Drawing.Point(209, 81);
            this.btn_longest_word.Name = "btn_longest_word";
            this.btn_longest_word.Size = new System.Drawing.Size(92, 40);
            this.btn_longest_word.TabIndex = 5;
            this.btn_longest_word.Text = "най-голяма дума";
            this.btn_longest_word.UseVisualStyleBackColor = true;
            // 
            // box_number_search
            // 
            this.box_number_search.Location = new System.Drawing.Point(12, 92);
            this.box_number_search.Name = "box_number_search";
            this.box_number_search.Size = new System.Drawing.Size(100, 23);
            this.box_number_search.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.box_number_search);
            this.Controls.Add(this.btn_longest_word);
            this.Controls.Add(this.btn_specific_word_search);
            this.Controls.Add(this.box_specific_word_search);
            this.Controls.Add(this.btn_number_search);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.box_number_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btn_number_search;
        private TextBox box_specific_word_search;
        private Button btn_specific_word_search;
        private Button btn_longest_word;
        private NumericUpDown box_number_search;
    }
}