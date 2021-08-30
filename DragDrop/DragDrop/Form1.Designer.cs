
namespace DragDrop
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbImg1 = new System.Windows.Forms.PictureBox();
            this.pbImg2 = new System.Windows.Forms.PictureBox();
            this.pbImg3 = new System.Windows.Forms.PictureBox();
            this.pbImg4 = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg1
            // 
            this.pbImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg1.Image = ((System.Drawing.Image)(resources.GetObject("pbImg1.Image")));
            this.pbImg1.Location = new System.Drawing.Point(30, 33);
            this.pbImg1.Name = "pbImg1";
            this.pbImg1.Size = new System.Drawing.Size(115, 86);
            this.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg1.TabIndex = 0;
            this.pbImg1.TabStop = false;
            this.pbImg1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImg1_MouseClick);
            this.pbImg1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg1_MouseDown);
            // 
            // pbImg2
            // 
            this.pbImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg2.Image = ((System.Drawing.Image)(resources.GetObject("pbImg2.Image")));
            this.pbImg2.Location = new System.Drawing.Point(186, 33);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(115, 86);
            this.pbImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg2.TabIndex = 0;
            this.pbImg2.TabStop = false;
            this.pbImg2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImg2_MouseClick);
            this.pbImg2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg2_MouseDown);
            // 
            // pbImg3
            // 
            this.pbImg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg3.Image = ((System.Drawing.Image)(resources.GetObject("pbImg3.Image")));
            this.pbImg3.Location = new System.Drawing.Point(351, 33);
            this.pbImg3.Name = "pbImg3";
            this.pbImg3.Size = new System.Drawing.Size(115, 86);
            this.pbImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg3.TabIndex = 0;
            this.pbImg3.TabStop = false;
            this.pbImg3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImg3_MouseClick);
            this.pbImg3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg3_MouseDown);
            // 
            // pbImg4
            // 
            this.pbImg4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg4.Image = ((System.Drawing.Image)(resources.GetObject("pbImg4.Image")));
            this.pbImg4.Location = new System.Drawing.Point(514, 33);
            this.pbImg4.Name = "pbImg4";
            this.pbImg4.Size = new System.Drawing.Size(115, 86);
            this.pbImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg4.TabIndex = 0;
            this.pbImg4.TabStop = false;
            this.pbImg4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImg4_MouseClick);
            this.pbImg4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg4_MouseDown);
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMain.Location = new System.Drawing.Point(186, 161);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(280, 205);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbMain_DragDrop);
            this.pbMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbMain_DragEnter);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.pbImg4);
            this.Controls.Add(this.pbImg3);
            this.Controls.Add(this.pbImg2);
            this.Controls.Add(this.pbImg1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg1;
        private System.Windows.Forms.PictureBox pbImg2;
        private System.Windows.Forms.PictureBox pbImg3;
        private System.Windows.Forms.PictureBox pbImg4;
        private System.Windows.Forms.PictureBox pbMain;
    }
}

