namespace sdwEncDec
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAESEnc = new System.Windows.Forms.Button();
            this.btnAESDec = new System.Windows.Forms.Button();
            this.btnDESEnc = new System.Windows.Forms.Button();
            this.btnDESDec = new System.Windows.Forms.Button();
            this.btnRC2Enc = new System.Windows.Forms.Button();
            this.btnRC2Dec = new System.Windows.Forms.Button();
            this.btnTriDesEnc = new System.Windows.Forms.Button();
            this.btnTriDESDec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 656);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1017, 302);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 350);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(1017, 303);
            this.textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnAESEnc, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAESDec, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDESEnc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDESDec, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRC2Enc, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRC2Dec, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTriDesEnc, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTriDESDec, 10, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 308);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1023, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAESEnc
            // 
            this.btnAESEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAESEnc.Location = new System.Drawing.Point(3, 3);
            this.btnAESEnc.Name = "btnAESEnc";
            this.btnAESEnc.Size = new System.Drawing.Size(94, 33);
            this.btnAESEnc.TabIndex = 0;
            this.btnAESEnc.Text = "AED Enc";
            this.btnAESEnc.UseVisualStyleBackColor = true;
            this.btnAESEnc.Click += new System.EventHandler(this.btnAESEnc_Click);
            // 
            // btnAESDec
            // 
            this.btnAESDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAESDec.Location = new System.Drawing.Point(103, 3);
            this.btnAESDec.Name = "btnAESDec";
            this.btnAESDec.Size = new System.Drawing.Size(94, 33);
            this.btnAESDec.TabIndex = 1;
            this.btnAESDec.Text = "AES Dec";
            this.btnAESDec.UseVisualStyleBackColor = true;
            this.btnAESDec.Click += new System.EventHandler(this.btnAESDec_Click);
            // 
            // btnDESEnc
            // 
            this.btnDESEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDESEnc.Location = new System.Drawing.Point(233, 3);
            this.btnDESEnc.Name = "btnDESEnc";
            this.btnDESEnc.Size = new System.Drawing.Size(94, 33);
            this.btnDESEnc.TabIndex = 2;
            this.btnDESEnc.Text = "DES Enc";
            this.btnDESEnc.UseVisualStyleBackColor = true;
            this.btnDESEnc.Click += new System.EventHandler(this.btnDESEnc_Click);
            // 
            // btnDESDec
            // 
            this.btnDESDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDESDec.Location = new System.Drawing.Point(333, 3);
            this.btnDESDec.Name = "btnDESDec";
            this.btnDESDec.Size = new System.Drawing.Size(94, 33);
            this.btnDESDec.TabIndex = 3;
            this.btnDESDec.Text = "DES Dec";
            this.btnDESDec.UseVisualStyleBackColor = true;
            this.btnDESDec.Click += new System.EventHandler(this.btnDESDec_Click);
            // 
            // btnRC2Enc
            // 
            this.btnRC2Enc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRC2Enc.Location = new System.Drawing.Point(463, 3);
            this.btnRC2Enc.Name = "btnRC2Enc";
            this.btnRC2Enc.Size = new System.Drawing.Size(94, 33);
            this.btnRC2Enc.TabIndex = 4;
            this.btnRC2Enc.Text = "RC2 Enc";
            this.btnRC2Enc.UseVisualStyleBackColor = true;
            this.btnRC2Enc.Click += new System.EventHandler(this.btnRC2Enc_Click);
            // 
            // btnRC2Dec
            // 
            this.btnRC2Dec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRC2Dec.Location = new System.Drawing.Point(563, 3);
            this.btnRC2Dec.Name = "btnRC2Dec";
            this.btnRC2Dec.Size = new System.Drawing.Size(94, 33);
            this.btnRC2Dec.TabIndex = 5;
            this.btnRC2Dec.Text = "RC2 Dec";
            this.btnRC2Dec.UseVisualStyleBackColor = true;
            this.btnRC2Dec.Click += new System.EventHandler(this.btnRC2Dec_Click);
            // 
            // btnTriDesEnc
            // 
            this.btnTriDesEnc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTriDesEnc.Location = new System.Drawing.Point(693, 3);
            this.btnTriDesEnc.Name = "btnTriDesEnc";
            this.btnTriDesEnc.Size = new System.Drawing.Size(94, 33);
            this.btnTriDesEnc.TabIndex = 6;
            this.btnTriDesEnc.Text = "TriDES Enc";
            this.btnTriDesEnc.UseVisualStyleBackColor = true;
            this.btnTriDesEnc.Click += new System.EventHandler(this.btnTriDesEnc_Click);
            // 
            // btnTriDESDec
            // 
            this.btnTriDESDec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTriDESDec.Location = new System.Drawing.Point(793, 3);
            this.btnTriDESDec.Name = "btnTriDESDec";
            this.btnTriDESDec.Size = new System.Drawing.Size(94, 33);
            this.btnTriDESDec.TabIndex = 7;
            this.btnTriDESDec.Text = "TriDES Dec";
            this.btnTriDESDec.UseVisualStyleBackColor = true;
            this.btnTriDESDec.Click += new System.EventHandler(this.btnTriDESDec_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 681);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAESEnc;
        private System.Windows.Forms.Button btnAESDec;
        private System.Windows.Forms.Button btnDESEnc;
        private System.Windows.Forms.Button btnDESDec;
        private System.Windows.Forms.Button btnRC2Enc;
        private System.Windows.Forms.Button btnRC2Dec;
        private System.Windows.Forms.Button btnTriDesEnc;
        private System.Windows.Forms.Button btnTriDESDec;
    }
}

