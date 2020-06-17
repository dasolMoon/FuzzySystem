namespace FindMyColor_m
{
    partial class SetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnSkin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSkinSelf = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "사진을 업로드하여 나의 피부색을 알아보세요";
            // 
            // btnResult
            // 
            this.btnResult.Enabled = false;
            this.btnResult.Location = new System.Drawing.Point(382, 363);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(212, 100);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과 보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.BackgroundImage = global::FindMyColor_m.Properties.Resources.버튼;
            this.btnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnPicture.Location = new System.Drawing.Point(95, 233);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(136, 44);
            this.btnPicture.TabIndex = 3;
            this.btnPicture.Text = "사진불러오기";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.Color.Transparent;
            this.btnRe.BackgroundImage = global::FindMyColor_m.Properties.Resources.버튼;
            this.btnRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRe.FlatAppearance.BorderSize = 0;
            this.btnRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRe.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnRe.Location = new System.Drawing.Point(95, 469);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(136, 44);
            this.btnRe.TabIndex = 3;
            this.btnRe.Text = "다시하기";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Visible = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnSkin
            // 
            this.btnSkin.Enabled = false;
            this.btnSkin.Location = new System.Drawing.Point(329, 122);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(67, 63);
            this.btnSkin.TabIndex = 3;
            this.btnSkin.Text = "자동\r\n피부색\r\n선택";
            this.btnSkin.UseVisualStyleBackColor = true;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "나의 피부색";
            // 
            // btnSkinSelf
            // 
            this.btnSkinSelf.Enabled = false;
            this.btnSkinSelf.Location = new System.Drawing.Point(478, 122);
            this.btnSkinSelf.Name = "btnSkinSelf";
            this.btnSkinSelf.Size = new System.Drawing.Size(67, 63);
            this.btnSkinSelf.TabIndex = 3;
            this.btnSkinSelf.Text = "직접 피부색 선택";
            this.btnSkinSelf.UseVisualStyleBackColor = true;
            this.btnSkinSelf.Click += new System.EventHandler(this.btnSkinSelf_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(382, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 115);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 411);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(315, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "* 햇빛을 받은 사진이면 좋아요";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(315, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "* 자동선택 인식이 안 되면 직접 선택해주세요";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(315, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "* 얼굴을 중심으로 한 사진이 좋아요";
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(617, 559);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSkinSelf);
            this.Controls.Add(this.btnSkin);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SetForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnSkin;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSkinSelf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}