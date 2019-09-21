namespace WindowsFormsApp1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.NumericUpDown();
            this.startHour = new System.Windows.Forms.NumericUpDown();
            this.startMinute = new System.Windows.Forms.NumericUpDown();
            this.endHour = new System.Windows.Forms.NumericUpDown();
            this.endMinute = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.BackColor = System.Drawing.SystemColors.Info;
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 5;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.table.Location = new System.Drawing.Point(34, 27);
            this.table.Name = "table";
            this.table.RowCount = 5;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table.Size = new System.Drawing.Size(506, 250);
            this.table.TabIndex = 0;
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(546, 27);
            this.day.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(73, 20);
            this.day.TabIndex = 3;
            this.day.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(546, 76);
            this.startHour.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(73, 20);
            this.startHour.TabIndex = 4;
            // 
            // startMinute
            // 
            this.startMinute.Location = new System.Drawing.Point(681, 76);
            this.startMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(73, 20);
            this.startMinute.TabIndex = 5;
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(546, 131);
            this.endHour.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(73, 20);
            this.endHour.TabIndex = 6;
            // 
            // endMinute
            // 
            this.endMinute.Location = new System.Drawing.Point(681, 131);
            this.endMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(73, 20);
            this.endMinute.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.endMinute);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.startMinute);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel table;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown day;
        private System.Windows.Forms.NumericUpDown startHour;
        private System.Windows.Forms.NumericUpDown startMinute;
        private System.Windows.Forms.NumericUpDown endHour;
        private System.Windows.Forms.NumericUpDown endMinute;

        private void add()
        {
            System.Windows.Forms.Button h = new System.Windows.Forms.Button();
            h.Name = "U";
            this.Controls.Add(h);
        }
    }
}

