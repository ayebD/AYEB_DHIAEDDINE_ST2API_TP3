
namespace OpenWeahterAPI_TP
{
    partial class AirQual
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.Label();
            this.CO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Air Quality index:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbone in the air:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(185, 18);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(59, 25);
            this.Index.TabIndex = 2;
            this.Index.Text = "label3";
            this.Index.Click += new System.EventHandler(this.label3_Click);
            // 
            // CO
            // 
            this.CO.AutoSize = true;
            this.CO.Location = new System.Drawing.Point(185, 74);
            this.CO.Name = "CO";
            this.CO.Size = new System.Drawing.Size(59, 25);
            this.CO.TabIndex = 3;
            this.CO.Text = "label4";
            // 
            // AirQual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CO);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AirQual";
            this.Size = new System.Drawing.Size(285, 111);
            this.Load += new System.EventHandler(this.AirQual_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Index;
        public System.Windows.Forms.Label CO;
    }
}
