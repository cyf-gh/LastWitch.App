
namespace LastWitch.App {
    partial class Game {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tp_GameMenu = new System.Windows.Forms.TabPage();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.tp_World = new System.Windows.Forms.TabPage();
            this.tp_Pot = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uTILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tp_GameMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tp_GameMenu);
            this.tabControl.Controls.Add(this.tp_World);
            this.tabControl.Controls.Add(this.tp_Pot);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(756, 413);
            this.tabControl.TabIndex = 0;
            // 
            // tp_GameMenu
            // 
            this.tp_GameMenu.Controls.Add(this.btn_Exit);
            this.tp_GameMenu.Controls.Add(this.btn_Continue);
            this.tp_GameMenu.Controls.Add(this.btn_NewGame);
            this.tp_GameMenu.Location = new System.Drawing.Point(4, 25);
            this.tp_GameMenu.Name = "tp_GameMenu";
            this.tp_GameMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_GameMenu.Size = new System.Drawing.Size(748, 384);
            this.tp_GameMenu.TabIndex = 0;
            this.tp_GameMenu.Text = "GameMenu";
            this.tp_GameMenu.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(206, 247);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(340, 98);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(206, 143);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(340, 98);
            this.btn_Continue.TabIndex = 0;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(206, 39);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(340, 98);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // tp_World
            // 
            this.tp_World.Location = new System.Drawing.Point(4, 25);
            this.tp_World.Name = "tp_World";
            this.tp_World.Padding = new System.Windows.Forms.Padding(3);
            this.tp_World.Size = new System.Drawing.Size(748, 412);
            this.tp_World.TabIndex = 1;
            this.tp_World.Text = "World";
            this.tp_World.UseVisualStyleBackColor = true;
            this.tp_World.Click += new System.EventHandler(this.tp_World_Click);
            // 
            // tp_Pot
            // 
            this.tp_Pot.Location = new System.Drawing.Point(4, 25);
            this.tp_Pot.Name = "tp_Pot";
            this.tp_Pot.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Pot.Size = new System.Drawing.Size(748, 384);
            this.tp_Pot.TabIndex = 2;
            this.tp_Pot.Text = "Pot";
            this.tp_Pot.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uTILToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uTILToolStripMenuItem
            // 
            this.uTILToolStripMenuItem.Name = "uTILToolStripMenuItem";
            this.uTILToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.uTILToolStripMenuItem.Text = "UTIL";
            this.uTILToolStripMenuItem.Click += new System.EventHandler(this.uTILToolStripMenuItem_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 441);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.tabControl.ResumeLayout(false);
            this.tp_GameMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tp_GameMenu;
        private System.Windows.Forms.TabPage tp_World;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.TabPage tp_Pot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uTILToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}