namespace GQ_Serial_flash_Test
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.combo_Serialport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Port = new System.Windows.Forms.Button();
            this.btn_oneshot = new System.Windows.Forms.Button();
            this.box_Delay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_Count = new System.Windows.Forms.TextBox();
            this.btn_Loop = new System.Windows.Forms.Button();
            this.Serial_Console = new System.Windows.Forms.RichTextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.remain = new System.Windows.Forms.Label();
            this.MAC_CHECK_FIELD = new System.Windows.Forms.RichTextBox();
            this.box_MAC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_Serialport
            // 
            this.combo_Serialport.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combo_Serialport.FormattingEnabled = true;
            this.combo_Serialport.Location = new System.Drawing.Point(56, 23);
            this.combo_Serialport.Name = "combo_Serialport";
            this.combo_Serialport.Size = new System.Drawing.Size(121, 23);
            this.combo_Serialport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // btn_Port
            // 
            this.btn_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Port.Location = new System.Drawing.Point(211, 21);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Size = new System.Drawing.Size(75, 23);
            this.btn_Port.TabIndex = 2;
            this.btn_Port.Text = "OPEN";
            this.btn_Port.UseVisualStyleBackColor = true;
            this.btn_Port.Click += new System.EventHandler(this.btn_Port_Click);
            // 
            // btn_oneshot
            // 
            this.btn_oneshot.Enabled = false;
            this.btn_oneshot.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_oneshot.Location = new System.Drawing.Point(191, 86);
            this.btn_oneshot.Name = "btn_oneshot";
            this.btn_oneshot.Size = new System.Drawing.Size(121, 23);
            this.btn_oneshot.TabIndex = 3;
            this.btn_oneshot.Text = "Reset(oneshot)";
            this.btn_oneshot.UseVisualStyleBackColor = true;
            this.btn_oneshot.Click += new System.EventHandler(this.btn_oneshot_Click);
            // 
            // box_Delay
            // 
            this.box_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Delay.Enabled = false;
            this.box_Delay.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.box_Delay.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.box_Delay.Location = new System.Drawing.Point(52, 128);
            this.box_Delay.Name = "box_Delay";
            this.box_Delay.Size = new System.Drawing.Size(85, 23);
            this.box_Delay.TabIndex = 4;
            this.box_Delay.Text = "10";
            this.box_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // box_Count
            // 
            this.box_Count.Enabled = false;
            this.box_Count.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.box_Count.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.box_Count.Location = new System.Drawing.Point(52, 165);
            this.box_Count.Name = "box_Count";
            this.box_Count.Size = new System.Drawing.Size(85, 23);
            this.box_Count.TabIndex = 7;
            this.box_Count.Text = "10";
            this.box_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Loop
            // 
            this.btn_Loop.Enabled = false;
            this.btn_Loop.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Loop.Location = new System.Drawing.Point(191, 145);
            this.btn_Loop.Name = "btn_Loop";
            this.btn_Loop.Size = new System.Drawing.Size(121, 23);
            this.btn_Loop.TabIndex = 8;
            this.btn_Loop.Text = "Reset(Loop)";
            this.btn_Loop.UseVisualStyleBackColor = true;
            this.btn_Loop.Click += new System.EventHandler(this.btn_Loop_Click);
            // 
            // Serial_Console
            // 
            this.Serial_Console.BackColor = System.Drawing.SystemColors.InfoText;
            this.Serial_Console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serial_Console.ForeColor = System.Drawing.Color.White;
            this.Serial_Console.Location = new System.Drawing.Point(349, 21);
            this.Serial_Console.Name = "Serial_Console";
            this.Serial_Console.Size = new System.Drawing.Size(349, 757);
            this.Serial_Console.TabIndex = 9;
            this.Serial_Console.Text = "Serial Flash Booting Test";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Clear.Location = new System.Drawing.Point(623, 784);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sec";
            // 
            // remain
            // 
            this.remain.AutoSize = true;
            this.remain.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.remain.Location = new System.Drawing.Point(12, 741);
            this.remain.Name = "remain";
            this.remain.Size = new System.Drawing.Size(132, 37);
            this.remain.TabIndex = 12;
            this.remain.Text = "Remain : ";
            this.remain.Visible = false;
            // 
            // MAC_CHECK_FIELD
            // 
            this.MAC_CHECK_FIELD.BackColor = System.Drawing.Color.Black;
            this.MAC_CHECK_FIELD.Cursor = System.Windows.Forms.Cursors.Default;
            this.MAC_CHECK_FIELD.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAC_CHECK_FIELD.ForeColor = System.Drawing.Color.Lime;
            this.MAC_CHECK_FIELD.Location = new System.Drawing.Point(12, 241);
            this.MAC_CHECK_FIELD.Name = "MAC_CHECK_FIELD";
            this.MAC_CHECK_FIELD.Size = new System.Drawing.Size(321, 497);
            this.MAC_CHECK_FIELD.TabIndex = 13;
            this.MAC_CHECK_FIELD.Text = "ERROR CHECK FIELD";
            // 
            // box_MAC
            // 
            this.box_MAC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.box_MAC.Location = new System.Drawing.Point(56, 214);
            this.box_MAC.Name = "box_MAC";
            this.box_MAC.Size = new System.Drawing.Size(277, 23);
            this.box_MAC.TabIndex = 14;
            this.box_MAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "MAC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 819);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.box_MAC);
            this.Controls.Add(this.MAC_CHECK_FIELD);
            this.Controls.Add(this.remain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.Serial_Console);
            this.Controls.Add(this.btn_Loop);
            this.Controls.Add(this.box_Count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_Delay);
            this.Controls.Add(this.btn_oneshot);
            this.Controls.Add(this.btn_Port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Serialport);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_Serialport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Port;
        private System.Windows.Forms.Button btn_oneshot;
        private System.Windows.Forms.TextBox box_Delay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_Count;
        private System.Windows.Forms.Button btn_Loop;
        private System.Windows.Forms.RichTextBox Serial_Console;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label remain;
        private System.Windows.Forms.RichTextBox MAC_CHECK_FIELD;
        private System.Windows.Forms.TextBox box_MAC;
        private System.Windows.Forms.Label label5;
    }
}

