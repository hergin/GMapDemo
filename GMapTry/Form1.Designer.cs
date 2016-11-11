namespace GMapTry
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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_location1 = new System.Windows.Forms.TextBox();
            this.textbox_location2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_distance = new System.Windows.Forms.Label();
            this.radioButton_fastest = new System.Windows.Forms.RadioButton();
            this.radioButton_shortest = new System.Windows.Forms.RadioButton();
            this.radioButton_google = new System.Windows.Forms.RadioButton();
            this.radioButton_openMap = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(624, 467);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 10D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location1";
            // 
            // textbox_location1
            // 
            this.textbox_location1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_location1.Location = new System.Drawing.Point(646, 30);
            this.textbox_location1.Name = "textbox_location1";
            this.textbox_location1.Size = new System.Drawing.Size(158, 20);
            this.textbox_location1.TabIndex = 2;
            // 
            // textbox_location2
            // 
            this.textbox_location2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_location2.Location = new System.Drawing.Point(646, 79);
            this.textbox_location2.Name = "textbox_location2";
            this.textbox_location2.Size = new System.Drawing.Size(158, 20);
            this.textbox_location2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location2";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(646, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Find Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distance";
            // 
            // label_distance
            // 
            this.label_distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_distance.AutoSize = true;
            this.label_distance.Location = new System.Drawing.Point(701, 264);
            this.label_distance.Name = "label_distance";
            this.label_distance.Size = new System.Drawing.Size(30, 13);
            this.label_distance.TabIndex = 7;
            this.label_distance.Text = "0 km";
            // 
            // radioButton_fastest
            // 
            this.radioButton_fastest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_fastest.AutoSize = true;
            this.radioButton_fastest.Checked = true;
            this.radioButton_fastest.Location = new System.Drawing.Point(11, 20);
            this.radioButton_fastest.Name = "radioButton_fastest";
            this.radioButton_fastest.Size = new System.Drawing.Size(59, 17);
            this.radioButton_fastest.TabIndex = 8;
            this.radioButton_fastest.TabStop = true;
            this.radioButton_fastest.Text = "Fastest";
            this.radioButton_fastest.UseVisualStyleBackColor = true;
            // 
            // radioButton_shortest
            // 
            this.radioButton_shortest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_shortest.AutoSize = true;
            this.radioButton_shortest.Location = new System.Drawing.Point(76, 20);
            this.radioButton_shortest.Name = "radioButton_shortest";
            this.radioButton_shortest.Size = new System.Drawing.Size(64, 17);
            this.radioButton_shortest.TabIndex = 9;
            this.radioButton_shortest.Text = "Shortest";
            this.radioButton_shortest.UseVisualStyleBackColor = true;
            // 
            // radioButton_google
            // 
            this.radioButton_google.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_google.AutoSize = true;
            this.radioButton_google.Checked = true;
            this.radioButton_google.Location = new System.Drawing.Point(10, 23);
            this.radioButton_google.Name = "radioButton_google";
            this.radioButton_google.Size = new System.Drawing.Size(59, 17);
            this.radioButton_google.TabIndex = 10;
            this.radioButton_google.TabStop = true;
            this.radioButton_google.Text = "Google";
            this.radioButton_google.UseVisualStyleBackColor = true;
            // 
            // radioButton_openMap
            // 
            this.radioButton_openMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_openMap.AutoSize = true;
            this.radioButton_openMap.Location = new System.Drawing.Point(75, 23);
            this.radioButton_openMap.Name = "radioButton_openMap";
            this.radioButton_openMap.Size = new System.Drawing.Size(72, 17);
            this.radioButton_openMap.TabIndex = 11;
            this.radioButton_openMap.Text = "OpenMap";
            this.radioButton_openMap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButton_shortest);
            this.groupBox1.Controls.Add(this.radioButton_fastest);
            this.groupBox1.Location = new System.Drawing.Point(649, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Speed";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton_google);
            this.groupBox2.Controls.Add(this.radioButton_openMap);
            this.groupBox2.Location = new System.Drawing.Point(649, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 50);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Provider";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_distance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox_location2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_location1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_location1;
        private System.Windows.Forms.TextBox textbox_location2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_distance;
        private System.Windows.Forms.RadioButton radioButton_fastest;
        private System.Windows.Forms.RadioButton radioButton_shortest;
        private System.Windows.Forms.RadioButton radioButton_google;
        private System.Windows.Forms.RadioButton radioButton_openMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

