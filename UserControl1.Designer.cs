
namespace OpenWeahterAPI_TP
{
    partial class la
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
            this.WeatherIcon = new System.Windows.Forms.PictureBox();
            this.DayT = new System.Windows.Forms.Label();
            this.WeatherCondi = new System.Windows.Forms.Label();
            this.WeatherDescri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // WeatherIcon
            // 
            this.WeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.WeatherIcon.Name = "WeatherIcon";
            this.WeatherIcon.Size = new System.Drawing.Size(107, 116);
            this.WeatherIcon.TabIndex = 0;
            this.WeatherIcon.TabStop = false;
            // 
            // DayT
            // 
            this.DayT.AutoSize = true;
            this.DayT.Location = new System.Drawing.Point(116, 3);
            this.DayT.Name = "DayT";
            this.DayT.Size = new System.Drawing.Size(43, 25);
            this.DayT.TabIndex = 1;
            this.DayT.Text = "Day";
            // 
            // WeatherCondi
            // 
            this.WeatherCondi.AutoSize = true;
            this.WeatherCondi.Location = new System.Drawing.Point(116, 45);
            this.WeatherCondi.Name = "WeatherCondi";
            this.WeatherCondi.Size = new System.Drawing.Size(59, 25);
            this.WeatherCondi.TabIndex = 2;
            this.WeatherCondi.Text = "label2";
            // 
            // WeatherDescri
            // 
            this.WeatherDescri.AutoSize = true;
            this.WeatherDescri.Location = new System.Drawing.Point(116, 85);
            this.WeatherDescri.Name = "WeatherDescri";
            this.WeatherDescri.Size = new System.Drawing.Size(59, 25);
            this.WeatherDescri.TabIndex = 3;
            this.WeatherDescri.Text = "label1";
            // 
            // la
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeatherDescri);
            this.Controls.Add(this.WeatherCondi);
            this.Controls.Add(this.DayT);
            this.Controls.Add(this.WeatherIcon);
            this.Name = "la";
            this.Size = new System.Drawing.Size(249, 122);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox WeatherIcon;
        public System.Windows.Forms.Label WeatherCondi;
        public System.Windows.Forms.Label WeatherDescri;
        public System.Windows.Forms.Label DayT;
    }
}
