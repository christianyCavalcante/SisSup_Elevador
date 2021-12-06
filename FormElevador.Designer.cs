
namespace SisSup_Elevador
{
    partial class frmElevador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElevador));
            this.cbModoOperacaoManual = new System.Windows.Forms.CheckBox();
            this.cbModoOperacaoAutomatico = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btTerreoSubir = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt4AndarDescer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt3AndarDescer = new System.Windows.Forms.Button();
            this.bt3AndarSubir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt2AndarDescer = new System.Windows.Forms.Button();
            this.bt2AndarSubir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt1AndarDescer = new System.Windows.Forms.Button();
            this.bt1AndarSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelAndarAtual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbModoOperacaoManual
            // 
            this.cbModoOperacaoManual.AutoSize = true;
            this.cbModoOperacaoManual.Location = new System.Drawing.Point(24, 40);
            this.cbModoOperacaoManual.Name = "cbModoOperacaoManual";
            this.cbModoOperacaoManual.Size = new System.Drawing.Size(81, 25);
            this.cbModoOperacaoManual.TabIndex = 0;
            this.cbModoOperacaoManual.Text = "Manual";
            this.cbModoOperacaoManual.UseVisualStyleBackColor = true;
            this.cbModoOperacaoManual.CheckedChanged += new System.EventHandler(this.cbModoOperacaoManual_CheckedChanged);
            // 
            // cbModoOperacaoAutomatico
            // 
            this.cbModoOperacaoAutomatico.AutoSize = true;
            this.cbModoOperacaoAutomatico.Location = new System.Drawing.Point(127, 40);
            this.cbModoOperacaoAutomatico.Name = "cbModoOperacaoAutomatico";
            this.cbModoOperacaoAutomatico.Size = new System.Drawing.Size(109, 25);
            this.cbModoOperacaoAutomatico.TabIndex = 1;
            this.cbModoOperacaoAutomatico.Text = "Automático";
            this.cbModoOperacaoAutomatico.UseVisualStyleBackColor = true;
            this.cbModoOperacaoAutomatico.CheckedChanged += new System.EventHandler(this.cbModoOperacaoAutomatico_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbModoOperacaoManual);
            this.groupBox1.Controls.Add(this.cbModoOperacaoAutomatico);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(478, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de Operação";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 119);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(890, 278);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(146, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 45);
            this.button5.TabIndex = 8;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.click4Andar);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(14, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 7;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.click3Andar);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(14, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 6;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.click1Andar);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(146, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.click2Andar);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(72, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "T";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickTerreo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Painel de Navegação Interno";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.btTerreoSubir);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(13, 53);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 108);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Térreo";
            // 
            // btTerreoSubir
            // 
            this.btTerreoSubir.Image = ((System.Drawing.Image)(resources.GetObject("btTerreoSubir.Image")));
            this.btTerreoSubir.Location = new System.Drawing.Point(17, 17);
            this.btTerreoSubir.Name = "btTerreoSubir";
            this.btTerreoSubir.Size = new System.Drawing.Size(81, 80);
            this.btTerreoSubir.TabIndex = 0;
            this.btTerreoSubir.UseVisualStyleBackColor = true;
            this.btTerreoSubir.Click += new System.EventHandler(this.clickTerreoSubir);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.bt4AndarDescer);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(494, 53);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(114, 108);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4° Andar";
            // 
            // bt4AndarDescer
            // 
            this.bt4AndarDescer.Image = ((System.Drawing.Image)(resources.GetObject("bt4AndarDescer.Image")));
            this.bt4AndarDescer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt4AndarDescer.Location = new System.Drawing.Point(17, 17);
            this.bt4AndarDescer.Name = "bt4AndarDescer";
            this.bt4AndarDescer.Size = new System.Drawing.Size(81, 80);
            this.bt4AndarDescer.TabIndex = 1;
            this.bt4AndarDescer.UseVisualStyleBackColor = true;
            this.bt4AndarDescer.Click += new System.EventHandler(this.click4AndarDescer);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.bt3AndarDescer);
            this.groupBox4.Controls.Add(this.bt3AndarSubir);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(374, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 206);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3° Andar";
            // 
            // bt3AndarDescer
            // 
            this.bt3AndarDescer.Image = ((System.Drawing.Image)(resources.GetObject("bt3AndarDescer.Image")));
            this.bt3AndarDescer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt3AndarDescer.Location = new System.Drawing.Point(17, 107);
            this.bt3AndarDescer.Name = "bt3AndarDescer";
            this.bt3AndarDescer.Size = new System.Drawing.Size(81, 80);
            this.bt3AndarDescer.TabIndex = 1;
            this.bt3AndarDescer.UseVisualStyleBackColor = true;
            this.bt3AndarDescer.Click += new System.EventHandler(this.click3AndarDescer);
            // 
            // bt3AndarSubir
            // 
            this.bt3AndarSubir.Image = ((System.Drawing.Image)(resources.GetObject("bt3AndarSubir.Image")));
            this.bt3AndarSubir.Location = new System.Drawing.Point(17, 17);
            this.bt3AndarSubir.Name = "bt3AndarSubir";
            this.bt3AndarSubir.Size = new System.Drawing.Size(81, 80);
            this.bt3AndarSubir.TabIndex = 0;
            this.bt3AndarSubir.UseVisualStyleBackColor = true;
            this.bt3AndarSubir.Click += new System.EventHandler(this.click3AndarSubir);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.bt2AndarDescer);
            this.groupBox3.Controls.Add(this.bt2AndarSubir);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(254, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2° Andar";
            // 
            // bt2AndarDescer
            // 
            this.bt2AndarDescer.Image = ((System.Drawing.Image)(resources.GetObject("bt2AndarDescer.Image")));
            this.bt2AndarDescer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt2AndarDescer.Location = new System.Drawing.Point(17, 107);
            this.bt2AndarDescer.Name = "bt2AndarDescer";
            this.bt2AndarDescer.Size = new System.Drawing.Size(81, 80);
            this.bt2AndarDescer.TabIndex = 1;
            this.bt2AndarDescer.UseVisualStyleBackColor = true;
            this.bt2AndarDescer.Click += new System.EventHandler(this.click2AndarDescer);
            // 
            // bt2AndarSubir
            // 
            this.bt2AndarSubir.Image = ((System.Drawing.Image)(resources.GetObject("bt2AndarSubir.Image")));
            this.bt2AndarSubir.Location = new System.Drawing.Point(17, 17);
            this.bt2AndarSubir.Name = "bt2AndarSubir";
            this.bt2AndarSubir.Size = new System.Drawing.Size(81, 80);
            this.bt2AndarSubir.TabIndex = 0;
            this.bt2AndarSubir.UseVisualStyleBackColor = true;
            this.bt2AndarSubir.Click += new System.EventHandler(this.click2AndarSubir);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.bt1AndarDescer);
            this.groupBox2.Controls.Add(this.bt1AndarSubir);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(132, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1° Andar";
            // 
            // bt1AndarDescer
            // 
            this.bt1AndarDescer.Image = ((System.Drawing.Image)(resources.GetObject("bt1AndarDescer.Image")));
            this.bt1AndarDescer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt1AndarDescer.Location = new System.Drawing.Point(17, 107);
            this.bt1AndarDescer.Name = "bt1AndarDescer";
            this.bt1AndarDescer.Size = new System.Drawing.Size(81, 80);
            this.bt1AndarDescer.TabIndex = 1;
            this.bt1AndarDescer.UseVisualStyleBackColor = true;
            this.bt1AndarDescer.Click += new System.EventHandler(this.click1AndarDescer);
            // 
            // bt1AndarSubir
            // 
            this.bt1AndarSubir.Image = ((System.Drawing.Image)(resources.GetObject("bt1AndarSubir.Image")));
            this.bt1AndarSubir.Location = new System.Drawing.Point(17, 17);
            this.bt1AndarSubir.Name = "bt1AndarSubir";
            this.bt1AndarSubir.Size = new System.Drawing.Size(81, 80);
            this.bt1AndarSubir.TabIndex = 0;
            this.bt1AndarSubir.UseVisualStyleBackColor = true;
            this.bt1AndarSubir.Click += new System.EventHandler(this.click1AndarSubir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(122, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Painéis de Navegação Externo";
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStatus.Location = new System.Drawing.Point(74, 9);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(100, 21);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAndarAtual
            // 
            this.labelAndarAtual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAndarAtual.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAndarAtual.ForeColor = System.Drawing.SystemColors.Info;
            this.labelAndarAtual.Location = new System.Drawing.Point(74, 31);
            this.labelAndarAtual.Name = "labelAndarAtual";
            this.labelAndarAtual.Size = new System.Drawing.Size(100, 65);
            this.labelAndarAtual.TabIndex = 6;
            this.labelAndarAtual.Text = "-";
            this.labelAndarAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmElevador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 435);
            this.Controls.Add(this.labelAndarAtual);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmElevador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbModoOperacaoManual;
        private System.Windows.Forms.CheckBox cbModoOperacaoAutomatico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt4AndarDescer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt3AndarDescer;
        private System.Windows.Forms.Button bt3AndarSubir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt2AndarDescer;
        private System.Windows.Forms.Button bt2AndarSubir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt1AndarDescer;
        private System.Windows.Forms.Button bt1AndarSubir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btTerreoSubir;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelAndarAtual;
    }
}

