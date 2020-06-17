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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSkin = new System.Windows.Forms.PictureBox();
            this.label_notice = new System.Windows.Forms.Label();
            this.btnSkinSelf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSkinSelf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "사진을 업로드하여 나의 피부색을 선택하세요";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(325, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "나의 피부색";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(315, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "* 햇빛을 받은 사진이면 좋아요";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(315, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "* 자동선택 인식이 안 되면 직접 선택해주세요";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(315, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "* 얼굴을 중심으로 한 사진이 좋아요";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(347, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "자동으로 선택";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("G마켓 산스 TTF Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(467, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "직접 선택";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.pictureBox2.Location = new System.Drawing.Point(335, 304);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 84);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnRe
            // 
            this.btnRe.BackColor = System.Drawing.Color.Transparent;
            this.btnRe.BackgroundImage = global::FindMyColor_m.Properties.Resources.버튼2;
            this.btnRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRe.FlatAppearance.BorderSize = 0;
            this.btnRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRe.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnRe.Location = new System.Drawing.Point(99, 463);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(136, 44);
            this.btnRe.TabIndex = 3;
            this.btnRe.Text = "다시하기";
            this.btnRe.UseVisualStyleBackColor = false;
            this.btnRe.Visible = false;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.White;
            this.btnPicture.BackgroundImage = global::FindMyColor_m.Properties.Resources.버튼2;
            this.btnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnPicture.Location = new System.Drawing.Point(99, 255);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(136, 44);
            this.btnPicture.TabIndex = 3;
            this.btnPicture.Text = "사진불러오기";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.BackgroundImage = global::FindMyColor_m.Properties.Resources.버튼3;
            this.btnResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResult.Enabled = false;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.btnResult.Location = new System.Drawing.Point(329, 394);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(238, 110);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과 보기";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(25, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSkin
            // 
            this.btnSkin.BackColor = System.Drawing.Color.Transparent;
            this.btnSkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkin.Enabled = false;
            this.btnSkin.Image = global::FindMyColor_m.Properties.Resources.자동;
            this.btnSkin.Location = new System.Drawing.Point(361, 173);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(67, 63);
            this.btnSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSkin.TabIndex = 5;
            this.btnSkin.TabStop = false;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // label_notice
            // 
            this.label_notice.AutoSize = true;
            this.label_notice.BackColor = System.Drawing.Color.Transparent;
            this.label_notice.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_notice.Location = new System.Drawing.Point(321, 134);
            this.label_notice.Name = "label_notice";
            this.label_notice.Size = new System.Drawing.Size(269, 19);
            this.label_notice.TabIndex = 1;
            this.label_notice.Text = "사진불러오기를 먼저 실행해주세요 !";
            // 
            // btnSkinSelf
            // 
            this.btnSkinSelf.BackColor = System.Drawing.Color.Transparent;
            this.btnSkinSelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkinSelf.Enabled = false;
            this.btnSkinSelf.Image = global::FindMyColor_m.Properties.Resources.수동;
            this.btnSkinSelf.Location = new System.Drawing.Point(459, 157);
            this.btnSkinSelf.Name = "btnSkinSelf";
            this.btnSkinSelf.Size = new System.Drawing.Size(86, 86);
            this.btnSkinSelf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSkinSelf.TabIndex = 5;
            this.btnSkinSelf.TabStop = false;
            this.btnSkinSelf.Click += new System.EventHandler(this.btnSkinSelf_Click);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.BackgroundImage = global::FindMyColor_m.Properties.Resources.셋;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 529);
            this.Controls.Add(this.btnSkinSelf);
            this.Controls.Add(this.btnSkin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_notice);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSkinSelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnSkin;
        private System.Windows.Forms.Label label_notice;
        private System.Windows.Forms.PictureBox btnSkinSelf;
    }
}