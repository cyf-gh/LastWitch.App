
namespace LastWitch.App {
    partial class Util {
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
            this.u_btn_getSpotModelJson = new System.Windows.Forms.Button();
            this.btn_getIngredientInfoJson = new System.Windows.Forms.Button();
            this.u_tb_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // u_btn_getSpotModelJson
            // 
            this.u_btn_getSpotModelJson.Location = new System.Drawing.Point(12, 12);
            this.u_btn_getSpotModelJson.Name = "u_btn_getSpotModelJson";
            this.u_btn_getSpotModelJson.Size = new System.Drawing.Size(167, 23);
            this.u_btn_getSpotModelJson.TabIndex = 0;
            this.u_btn_getSpotModelJson.Text = "getSpotModelJson";
            this.u_btn_getSpotModelJson.UseVisualStyleBackColor = true;
            this.u_btn_getSpotModelJson.Click += new System.EventHandler(this.u_btn_getSpotModelJson_Click);
            // 
            // btn_getIngredientInfoJson
            // 
            this.btn_getIngredientInfoJson.Location = new System.Drawing.Point(12, 41);
            this.btn_getIngredientInfoJson.Name = "btn_getIngredientInfoJson";
            this.btn_getIngredientInfoJson.Size = new System.Drawing.Size(167, 23);
            this.btn_getIngredientInfoJson.TabIndex = 1;
            this.btn_getIngredientInfoJson.Text = "getIngredientInfosJson";
            this.btn_getIngredientInfoJson.UseVisualStyleBackColor = true;
            this.btn_getIngredientInfoJson.Click += new System.EventHandler(this.btn_getIngredientInfoJson_Click);
            // 
            // u_tb_output
            // 
            this.u_tb_output.Location = new System.Drawing.Point(185, 10);
            this.u_tb_output.Multiline = true;
            this.u_tb_output.Name = "u_tb_output";
            this.u_tb_output.Size = new System.Drawing.Size(603, 428);
            this.u_tb_output.TabIndex = 2;
            // 
            // Util
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.u_tb_output);
            this.Controls.Add(this.btn_getIngredientInfoJson);
            this.Controls.Add(this.u_btn_getSpotModelJson);
            this.Name = "Util";
            this.Text = "Util";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button u_btn_getSpotModelJson;
        private System.Windows.Forms.Button btn_getIngredientInfoJson;
        private System.Windows.Forms.TextBox u_tb_output;
    }
}