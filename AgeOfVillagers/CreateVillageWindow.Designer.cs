namespace AgeOfVillagers
{
    partial class CreateVillageWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.select_nation = new System.Windows.Forms.ComboBox();
            this.open_village = new System.Windows.Forms.Button();
            this.new_village = new System.Windows.Forms.Button();
            this.save_village = new System.Windows.Forms.Button();
            this.water_resource = new System.Windows.Forms.RadioButton();
            this.house = new System.Windows.Forms.RadioButton();
            this.tree = new System.Windows.Forms.RadioButton();
            this.village_name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawing_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.select_nation);
            this.panel1.Controls.Add(this.open_village);
            this.panel1.Controls.Add(this.new_village);
            this.panel1.Controls.Add(this.save_village);
            this.panel1.Controls.Add(this.water_resource);
            this.panel1.Controls.Add(this.house);
            this.panel1.Controls.Add(this.tree);
            this.panel1.Controls.Add(this.village_name);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(789, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 560);
            this.panel1.TabIndex = 0;
            // 
            // select_nation
            // 
            this.select_nation.AccessibleDescription = "";
            this.select_nation.BackColor = System.Drawing.Color.Teal;
            this.select_nation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.select_nation.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.select_nation.ForeColor = System.Drawing.Color.Snow;
            this.select_nation.Items.AddRange(new object[] {
            "Egyptian Kings",
            "Bangladeshi Farmers",
            "Arab Bedouin",
            "Inuit Hunters"});
            this.select_nation.Location = new System.Drawing.Point(28, 171);
            this.select_nation.Name = "select_nation";
            this.select_nation.Size = new System.Drawing.Size(244, 37);
            this.select_nation.TabIndex = 9;
            this.select_nation.Text = "     Select Nations";
            this.select_nation.TextChanged += new System.EventHandler(this.selectNation_TextChanged);
            // 
            // open_village
            // 
            this.open_village.BackColor = System.Drawing.Color.DarkCyan;
            this.open_village.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.open_village.ForeColor = System.Drawing.Color.Snow;
            this.open_village.Location = new System.Drawing.Point(155, 488);
            this.open_village.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.open_village.Name = "open_village";
            this.open_village.Size = new System.Drawing.Size(133, 38);
            this.open_village.TabIndex = 8;
            this.open_village.Text = "Open Village";
            this.open_village.UseVisualStyleBackColor = false;
            this.open_village.Click += new System.EventHandler(this.open_village_Click);
            // 
            // new_village
            // 
            this.new_village.BackColor = System.Drawing.Color.DarkCyan;
            this.new_village.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_village.ForeColor = System.Drawing.Color.Snow;
            this.new_village.Location = new System.Drawing.Point(17, 488);
            this.new_village.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_village.Name = "new_village";
            this.new_village.Size = new System.Drawing.Size(133, 38);
            this.new_village.TabIndex = 7;
            this.new_village.Text = "New Village";
            this.new_village.UseVisualStyleBackColor = false;
            this.new_village.Click += new System.EventHandler(this.new_village_Click);
            // 
            // save_village
            // 
            this.save_village.BackColor = System.Drawing.Color.DarkCyan;
            this.save_village.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_village.ForeColor = System.Drawing.Color.Snow;
            this.save_village.Location = new System.Drawing.Point(87, 443);
            this.save_village.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_village.Name = "save_village";
            this.save_village.Size = new System.Drawing.Size(133, 38);
            this.save_village.TabIndex = 6;
            this.save_village.Text = "Save Village";
            this.save_village.UseVisualStyleBackColor = false;
            this.save_village.Click += new System.EventHandler(this.save_village_Click);
            // 
            // water_resource
            // 
            this.water_resource.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.water_resource.ForeColor = System.Drawing.Color.Snow;
            this.water_resource.Location = new System.Drawing.Point(69, 331);
            this.water_resource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.water_resource.Name = "water_resource";
            this.water_resource.Size = new System.Drawing.Size(203, 33);
            this.water_resource.TabIndex = 5;
            this.water_resource.TabStop = true;
            this.water_resource.Text = "Water Source";
            this.water_resource.UseVisualStyleBackColor = true;
            // 
            // house
            // 
            this.house.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.house.ForeColor = System.Drawing.Color.Snow;
            this.house.Location = new System.Drawing.Point(69, 295);
            this.house.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(163, 31);
            this.house.TabIndex = 4;
            this.house.TabStop = true;
            this.house.Text = "House";
            this.house.UseVisualStyleBackColor = true;
            // 
            // tree
            // 
            this.tree.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tree.ForeColor = System.Drawing.Color.Snow;
            this.tree.Location = new System.Drawing.Point(69, 260);
            this.tree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(163, 31);
            this.tree.TabIndex = 3;
            this.tree.TabStop = true;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.CheckedChanged += new System.EventHandler(this.tree_CheckedChanged);
            // 
            // village_name
            // 
            this.village_name.BackColor = System.Drawing.Color.Teal;
            this.village_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.village_name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.village_name.ForeColor = System.Drawing.Color.Snow;
            this.village_name.Location = new System.Drawing.Point(28, 119);
            this.village_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.village_name.Name = "village_name";
            this.village_name.Size = new System.Drawing.Size(248, 28);
            this.village_name.TabIndex = 1;
            this.village_name.Text = "Edit Village Name";
            this.village_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.village_name.TextChanged += new System.EventHandler(this.village_name_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Snow;
            this.textBox1.Location = new System.Drawing.Point(24, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(248, 42);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Age of Villagers";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawing_panel
            // 
            this.drawing_panel.BackColor = System.Drawing.Color.Azure;
            this.drawing_panel.Location = new System.Drawing.Point(71, 56);
            this.drawing_panel.Name = "drawing_panel";
            this.drawing_panel.Size = new System.Drawing.Size(600, 400);
            this.drawing_panel.TabIndex = 1;
            this.drawing_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawing_panel_MouseClick);
            // 
            // CreateVillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1085, 555);
            this.Controls.Add(this.drawing_panel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateVillageWindow";
            this.Text = "Age of Villagers";
            this.Load += new System.EventHandler(this.CreateVillageWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox village_name;
        private System.Windows.Forms.RadioButton water_resource;
        private System.Windows.Forms.RadioButton house;
        private System.Windows.Forms.RadioButton tree;
        private System.Windows.Forms.Button open_village;
        private System.Windows.Forms.Button new_village;
        private System.Windows.Forms.Button save_village;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel drawing_panel;
        private System.Windows.Forms.ComboBox select_nation;
    }
}