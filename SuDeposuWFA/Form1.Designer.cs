
namespace SuDeposuWFA
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
            this.pnlDepo = new System.Windows.Forms.Panel();
            this.pnlSu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSuMiktari = new System.Windows.Forms.NumericUpDown();
            this.btnSuEkle = new System.Windows.Forms.Button();
            this.lblDolulukOrani = new System.Windows.Forms.Label();
            this.pnlDepo.SuspendLayout();
            this.pnlSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDepo
            // 
            this.pnlDepo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDepo.Controls.Add(this.pnlSu);
            this.pnlDepo.Location = new System.Drawing.Point(541, 64);
            this.pnlDepo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDepo.Name = "pnlDepo";
            this.pnlDepo.Size = new System.Drawing.Size(321, 526);
            this.pnlDepo.TabIndex = 0;
            // 
            // pnlSu
            // 
            this.pnlSu.BackColor = System.Drawing.Color.Aqua;
            this.pnlSu.Controls.Add(this.lblDolulukOrani);
            this.pnlSu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSu.Location = new System.Drawing.Point(0, 368);
            this.pnlSu.Name = "pnlSu";
            this.pnlSu.Size = new System.Drawing.Size(319, 156);
            this.pnlSu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kapasite: ";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapasite.Location = new System.Drawing.Point(670, 617);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(39, 20);
            this.lblKapasite.TabIndex = 2;
            this.lblKapasite.Text = "0m³";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Su Miktarı(m³): ";
            // 
            // nudSuMiktari
            // 
            this.nudSuMiktari.DecimalPlaces = 2;
            this.nudSuMiktari.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSuMiktari.Location = new System.Drawing.Point(264, 109);
            this.nudSuMiktari.Name = "nudSuMiktari";
            this.nudSuMiktari.Size = new System.Drawing.Size(120, 26);
            this.nudSuMiktari.TabIndex = 3;
            // 
            // btnSuEkle
            // 
            this.btnSuEkle.Location = new System.Drawing.Point(157, 157);
            this.btnSuEkle.Name = "btnSuEkle";
            this.btnSuEkle.Size = new System.Drawing.Size(227, 39);
            this.btnSuEkle.TabIndex = 4;
            this.btnSuEkle.Text = "SU EKLE";
            this.btnSuEkle.UseVisualStyleBackColor = true;
            this.btnSuEkle.Click += new System.EventHandler(this.btnSuEkle_Click);
            // 
            // lblDolulukOrani
            // 
            this.lblDolulukOrani.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDolulukOrani.Location = new System.Drawing.Point(249, 124);
            this.lblDolulukOrani.Name = "lblDolulukOrani";
            this.lblDolulukOrani.Size = new System.Drawing.Size(67, 20);
            this.lblDolulukOrani.TabIndex = 1;
            this.lblDolulukOrani.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 665);
            this.Controls.Add(this.btnSuEkle);
            this.Controls.Add(this.nudSuMiktari);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDepo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Su Deposu";
            this.pnlDepo.ResumeLayout(false);
            this.pnlSu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDepo;
        private System.Windows.Forms.Panel pnlSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSuMiktari;
        private System.Windows.Forms.Button btnSuEkle;
        private System.Windows.Forms.Label lblDolulukOrani;
    }
}

