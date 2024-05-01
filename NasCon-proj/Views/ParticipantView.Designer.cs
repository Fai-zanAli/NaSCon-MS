namespace NasCon_proj.Views
{
    partial class ParticipantView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantView));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registerevent1 = new System.Windows.Forms.Button();
            this.bookedevents1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categories1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registereventbox1 = new System.Windows.Forms.ComboBox();
            this.signout1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(236, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 637);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // registerevent1
            // 
            this.registerevent1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.registerevent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerevent1.Location = new System.Drawing.Point(22, 408);
            this.registerevent1.Name = "registerevent1";
            this.registerevent1.Size = new System.Drawing.Size(186, 51);
            this.registerevent1.TabIndex = 1;
            this.registerevent1.Text = "Register New Event";
            this.registerevent1.UseVisualStyleBackColor = true;
            this.registerevent1.Click += new System.EventHandler(this.registerevent1_Click);
            // 
            // bookedevents1
            // 
            this.bookedevents1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bookedevents1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookedevents1.Location = new System.Drawing.Point(22, 553);
            this.bookedevents1.Name = "bookedevents1";
            this.bookedevents1.Size = new System.Drawing.Size(186, 49);
            this.bookedevents1.TabIndex = 2;
            this.bookedevents1.Text = "Booked Events";
            this.bookedevents1.UseVisualStyleBackColor = true;
            this.bookedevents1.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 647);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Food Deals";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Events By Categories";
            // 
            // categories1
            // 
            this.categories1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories1.FormattingEnabled = true;
            this.categories1.Location = new System.Drawing.Point(7, 256);
            this.categories1.Name = "categories1";
            this.categories1.Size = new System.Drawing.Size(223, 33);
            this.categories1.TabIndex = 5;
            this.categories1.SelectedIndexChanged += new System.EventHandler(this.categories1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Available Events";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "NaSCon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select Event To Register";
            // 
            // registereventbox1
            // 
            this.registereventbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registereventbox1.FormattingEnabled = true;
            this.registereventbox1.Location = new System.Drawing.Point(7, 356);
            this.registereventbox1.Name = "registereventbox1";
            this.registereventbox1.Size = new System.Drawing.Size(223, 33);
            this.registereventbox1.TabIndex = 19;
            this.registereventbox1.SelectedIndexChanged += new System.EventHandler(this.registereventbox1_SelectedIndexChanged);
            // 
            // signout1
            // 
            this.signout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout1.Location = new System.Drawing.Point(660, 718);
            this.signout1.Name = "signout1";
            this.signout1.Size = new System.Drawing.Size(143, 45);
            this.signout1.TabIndex = 20;
            this.signout1.Text = "Signout";
            this.signout1.UseVisualStyleBackColor = true;
            this.signout1.Click += new System.EventHandler(this.signout1_Click);
            // 
            // ParticipantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 776);
            this.Controls.Add(this.signout1);
            this.Controls.Add(this.registereventbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categories1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bookedevents1);
            this.Controls.Add(this.registerevent1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ParticipantView";
            this.Text = "ParticipantView";
            this.Load += new System.EventHandler(this.ParticipantView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button registerevent1;
        private System.Windows.Forms.Button bookedevents1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categories1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox registereventbox1;
        private System.Windows.Forms.Button signout1;
    }
}