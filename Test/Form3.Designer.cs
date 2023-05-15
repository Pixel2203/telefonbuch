namespace Test
{
    partial class Form3
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
            this.create = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eintragErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eintragBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eintragSuchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eintragLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(50, 77);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(200, 68);
            this.create.TabIndex = 0;
            this.create.Text = "Eintrag erstellen";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(50, 382);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(200, 68);
            this.search.TabIndex = 1;
            this.search.Text = "Eintrag suchen";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button2_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(50, 180);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(200, 68);
            this.edit.TabIndex = 2;
            this.edit.Text = "Eintrag bearbeiten ";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(50, 284);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(200, 68);
            this.delete.TabIndex = 3;
            this.delete.Text = "Eintrag löschen";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(859, 33);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eintragErstellenToolStripMenuItem,
            this.eintragBearbeitenToolStripMenuItem,
            this.eintragSuchenToolStripMenuItem,
            this.eintragLöschenToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 29);
            this.toolStripMenuItem1.Text = "Menü";
            // 
            // eintragErstellenToolStripMenuItem
            // 
            this.eintragErstellenToolStripMenuItem.Name = "eintragErstellenToolStripMenuItem";
            this.eintragErstellenToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.eintragErstellenToolStripMenuItem.Text = "Eintrag erstellen";
            // 
            // eintragBearbeitenToolStripMenuItem
            // 
            this.eintragBearbeitenToolStripMenuItem.Name = "eintragBearbeitenToolStripMenuItem";
            this.eintragBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.eintragBearbeitenToolStripMenuItem.Text = "Eintrag bearbeiten";
            // 
            // eintragSuchenToolStripMenuItem
            // 
            this.eintragSuchenToolStripMenuItem.Name = "eintragSuchenToolStripMenuItem";
            this.eintragSuchenToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.eintragSuchenToolStripMenuItem.Text = "Eintrag suchen";
            // 
            // eintragLöschenToolStripMenuItem
            // 
            this.eintragLöschenToolStripMenuItem.Name = "eintragLöschenToolStripMenuItem";
            this.eintragLöschenToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.eintragLöschenToolStripMenuItem.Text = "Eintrag löschen ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 522);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.search);
            this.Controls.Add(this.create);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eintragErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eintragBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eintragSuchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eintragLöschenToolStripMenuItem;
    }
}