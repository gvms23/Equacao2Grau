namespace Equacao2Grau
{
    partial class frmEquacao2Grau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquacao2Grau));
            this.btnEfetuarCalc = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSintaxe = new System.Windows.Forms.Label();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.lblExplicacao8 = new System.Windows.Forms.Label();
            this.lblExplicacao12 = new System.Windows.Forms.Label();
            this.lblExplicacao10 = new System.Windows.Forms.Label();
            this.lblExplicacao11 = new System.Windows.Forms.Label();
            this.lblExplicacao9 = new System.Windows.Forms.Label();
            this.lblExplicacao15 = new System.Windows.Forms.Label();
            this.lblExplicacao13 = new System.Windows.Forms.Label();
            this.lblExplicacao14 = new System.Windows.Forms.Label();
            this.lblExplicacao22 = new System.Windows.Forms.Label();
            this.lblExplicacao20 = new System.Windows.Forms.Label();
            this.lblExplicacao21 = new System.Windows.Forms.Label();
            this.lblExplicacao19 = new System.Windows.Forms.Label();
            this.lblExplicacao17 = new System.Windows.Forms.Label();
            this.lblExplicacao18 = new System.Windows.Forms.Label();
            this.lblExplicacao16 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblExplicacao2 = new System.Windows.Forms.Label();
            this.lblFormula2 = new System.Windows.Forms.Label();
            this.lblFormula1 = new System.Windows.Forms.Label();
            this.lblFormula3 = new System.Windows.Forms.Label();
            this.lblExplicacao4 = new System.Windows.Forms.Label();
            this.lblExplicacao3 = new System.Windows.Forms.Label();
            this.lblExplicacao5 = new System.Windows.Forms.Label();
            this.lblExplicacao7 = new System.Windows.Forms.Label();
            this.lblExplicacao6 = new System.Windows.Forms.Label();
            this.lblSobre = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.pcbLinkedin = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEfetuarCalc
            // 
            this.btnEfetuarCalc.BackColor = System.Drawing.SystemColors.Control;
            this.btnEfetuarCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfetuarCalc.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarCalc.Location = new System.Drawing.Point(38, 248);
            this.btnEfetuarCalc.Name = "btnEfetuarCalc";
            this.btnEfetuarCalc.Size = new System.Drawing.Size(260, 34);
            this.btnEfetuarCalc.TabIndex = 4;
            this.btnEfetuarCalc.Text = "Efetuar Cálculo";
            this.btnEfetuarCalc.UseVisualStyleBackColor = false;
            this.btnEfetuarCalc.Click += new System.EventHandler(this.btnEfetuarCalc_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(69, 29);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(56, 30);
            this.txtA.TabIndex = 1;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(69, 65);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(56, 30);
            this.txtB.TabIndex = 2;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(69, 101);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(56, 30);
            this.txtC.TabIndex = 3;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sintaxe da Função:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSintaxe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 210);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores de Entrada";
            // 
            // lblSintaxe
            // 
            this.lblSintaxe.AutoSize = true;
            this.lblSintaxe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSintaxe.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lblSintaxe.Location = new System.Drawing.Point(6, 175);
            this.lblSintaxe.Name = "lblSintaxe";
            this.lblSintaxe.Size = new System.Drawing.Size(131, 18);
            this.lblSintaxe.TabIndex = 9;
            this.lblSintaxe.Text = "textoTemporario";
            this.lblSintaxe.Visible = false;
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao.Location = new System.Drawing.Point(421, 74);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(114, 108);
            this.lblExplicacao.TabIndex = 12;
            this.lblExplicacao.Text = "Passo 1 - Delta: \r\n\r\nΔ = b² –4 . a . c \r\nΔ = 3² –4 . 1 . -10\r\nΔ = 9 + 40\r\nΔ = 49";
            this.lblExplicacao.Visible = false;
            // 
            // lblExplicacao8
            // 
            this.lblExplicacao8.AutoSize = true;
            this.lblExplicacao8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao8.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao8.Location = new System.Drawing.Point(477, 356);
            this.lblExplicacao8.Name = "lblExplicacao8";
            this.lblExplicacao8.Size = new System.Drawing.Size(16, 18);
            this.lblExplicacao8.TabIndex = 21;
            this.lblExplicacao8.Text = "2";
            this.lblExplicacao8.Visible = false;
            // 
            // lblExplicacao12
            // 
            this.lblExplicacao12.AutoSize = true;
            this.lblExplicacao12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao12.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao12.Location = new System.Drawing.Point(725, 126);
            this.lblExplicacao12.Name = "lblExplicacao12";
            this.lblExplicacao12.Size = new System.Drawing.Size(16, 18);
            this.lblExplicacao12.TabIndex = 26;
            this.lblExplicacao12.Text = "2";
            this.lblExplicacao12.Visible = false;
            // 
            // lblExplicacao10
            // 
            this.lblExplicacao10.AutoSize = true;
            this.lblExplicacao10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao10.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao10.Location = new System.Drawing.Point(708, 101);
            this.lblExplicacao10.Name = "lblExplicacao10";
            this.lblExplicacao10.Size = new System.Drawing.Size(53, 18);
            this.lblExplicacao10.TabIndex = 24;
            this.lblExplicacao10.Text = "(-3 + 7)";
            this.lblExplicacao10.Visible = false;
            // 
            // lblExplicacao11
            // 
            this.lblExplicacao11.AutoSize = true;
            this.lblExplicacao11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao11.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao11.Location = new System.Drawing.Point(661, 108);
            this.lblExplicacao11.Name = "lblExplicacao11";
            this.lblExplicacao11.Size = new System.Drawing.Size(119, 18);
            this.lblExplicacao11.TabIndex = 25;
            this.lblExplicacao11.Text = "x¹ = __________";
            this.lblExplicacao11.Visible = false;
            // 
            // lblExplicacao9
            // 
            this.lblExplicacao9.AutoSize = true;
            this.lblExplicacao9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao9.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao9.Location = new System.Drawing.Point(660, 74);
            this.lblExplicacao9.Name = "lblExplicacao9";
            this.lblExplicacao9.Size = new System.Drawing.Size(163, 18);
            this.lblExplicacao9.TabIndex = 23;
            this.lblExplicacao9.Text = "Passo 3 - Encontrando X¹";
            this.lblExplicacao9.Visible = false;
            // 
            // lblExplicacao15
            // 
            this.lblExplicacao15.AutoSize = true;
            this.lblExplicacao15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao15.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao15.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao15.Location = new System.Drawing.Point(726, 171);
            this.lblExplicacao15.Name = "lblExplicacao15";
            this.lblExplicacao15.Size = new System.Drawing.Size(16, 18);
            this.lblExplicacao15.TabIndex = 29;
            this.lblExplicacao15.Text = "2";
            this.lblExplicacao15.Visible = false;
            // 
            // lblExplicacao13
            // 
            this.lblExplicacao13.AutoSize = true;
            this.lblExplicacao13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao13.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao13.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao13.Location = new System.Drawing.Point(725, 149);
            this.lblExplicacao13.Name = "lblExplicacao13";
            this.lblExplicacao13.Size = new System.Drawing.Size(16, 18);
            this.lblExplicacao13.TabIndex = 27;
            this.lblExplicacao13.Text = "4";
            this.lblExplicacao13.Visible = false;
            // 
            // lblExplicacao14
            // 
            this.lblExplicacao14.AutoSize = true;
            this.lblExplicacao14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao14.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao14.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao14.Location = new System.Drawing.Point(662, 154);
            this.lblExplicacao14.Name = "lblExplicacao14";
            this.lblExplicacao14.Size = new System.Drawing.Size(119, 18);
            this.lblExplicacao14.TabIndex = 28;
            this.lblExplicacao14.Text = "x¹ = __________";
            this.lblExplicacao14.Visible = false;
            // 
            // lblExplicacao22
            // 
            this.lblExplicacao22.AutoSize = true;
            this.lblExplicacao22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao22.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao22.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao22.Location = new System.Drawing.Point(726, 322);
            this.lblExplicacao22.Name = "lblExplicacao22";
            this.lblExplicacao22.Size = new System.Drawing.Size(16, 18);
            this.lblExplicacao22.TabIndex = 35;
            this.lblExplicacao22.Text = "2";
            this.lblExplicacao22.Visible = false;
            // 
            // lblExplicacao20
            // 
            this.lblExplicacao20.AutoSize = true;
            this.lblExplicacao20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao20.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao20.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao20.Location = new System.Drawing.Point(719, 299);
            this.lblExplicacao20.Name = "lblExplicacao20";
            this.lblExplicacao20.Size = new System.Drawing.Size(27, 18);
            this.lblExplicacao20.TabIndex = 33;
            this.lblExplicacao20.Text = "-10";
            this.lblExplicacao20.Visible = false;
            // 
            // lblExplicacao21
            // 
            this.lblExplicacao21.AutoSize = true;
            this.lblExplicacao21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao21.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao21.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao21.Location = new System.Drawing.Point(662, 305);
            this.lblExplicacao21.Name = "lblExplicacao21";
            this.lblExplicacao21.Size = new System.Drawing.Size(119, 18);
            this.lblExplicacao21.TabIndex = 34;
            this.lblExplicacao21.Text = "x² = __________";
            this.lblExplicacao21.Visible = false;
            // 
            // lblExplicacao19
            // 
            this.lblExplicacao19.AutoSize = true;
            this.lblExplicacao19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao19.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao19.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao19.Location = new System.Drawing.Point(725, 276);
            this.lblExplicacao19.Name = "lblExplicacao19";
            this.lblExplicacao19.Size = new System.Drawing.Size(16, 18);
            this.lblExplicacao19.TabIndex = 32;
            this.lblExplicacao19.Text = "2";
            this.lblExplicacao19.Visible = false;
            // 
            // lblExplicacao17
            // 
            this.lblExplicacao17.AutoSize = true;
            this.lblExplicacao17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao17.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao17.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao17.Location = new System.Drawing.Point(708, 251);
            this.lblExplicacao17.Name = "lblExplicacao17";
            this.lblExplicacao17.Size = new System.Drawing.Size(52, 18);
            this.lblExplicacao17.TabIndex = 30;
            this.lblExplicacao17.Text = "(-3 - 7)";
            this.lblExplicacao17.Visible = false;
            // 
            // lblExplicacao18
            // 
            this.lblExplicacao18.AutoSize = true;
            this.lblExplicacao18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao18.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao18.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao18.Location = new System.Drawing.Point(661, 258);
            this.lblExplicacao18.Name = "lblExplicacao18";
            this.lblExplicacao18.Size = new System.Drawing.Size(119, 18);
            this.lblExplicacao18.TabIndex = 31;
            this.lblExplicacao18.Text = "x² = __________";
            this.lblExplicacao18.Visible = false;
            // 
            // lblExplicacao16
            // 
            this.lblExplicacao16.AutoSize = true;
            this.lblExplicacao16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao16.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao16.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao16.Location = new System.Drawing.Point(660, 224);
            this.lblExplicacao16.Name = "lblExplicacao16";
            this.lblExplicacao16.Size = new System.Drawing.Size(163, 18);
            this.lblExplicacao16.TabIndex = 36;
            this.lblExplicacao16.Text = "Passo 4 - Encontrando X²";
            this.lblExplicacao16.Visible = false;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblX1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.ForeColor = System.Drawing.Color.White;
            this.lblX1.Location = new System.Drawing.Point(778, 154);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(27, 18);
            this.lblX1.TabIndex = 37;
            this.lblX1.Text = "= 2";
            this.lblX1.Visible = false;
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblX2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.ForeColor = System.Drawing.Color.White;
            this.lblX2.Location = new System.Drawing.Point(778, 305);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(32, 18);
            this.lblX2.TabIndex = 38;
            this.lblX2.Text = "= -5";
            this.lblX2.Visible = false;
            // 
            // lblExplicacao2
            // 
            this.lblExplicacao2.AutoSize = true;
            this.lblExplicacao2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao2.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao2.Location = new System.Drawing.Point(420, 199);
            this.lblExplicacao2.Name = "lblExplicacao2";
            this.lblExplicacao2.Size = new System.Drawing.Size(159, 18);
            this.lblExplicacao2.TabIndex = 13;
            this.lblExplicacao2.Text = "Passo 2 - Encontrando X:\r\n";
            this.lblExplicacao2.Visible = false;
            // 
            // lblFormula2
            // 
            this.lblFormula2.AutoSize = true;
            this.lblFormula2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblFormula2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula2.ForeColor = System.Drawing.Color.White;
            this.lblFormula2.Location = new System.Drawing.Point(420, 233);
            this.lblFormula2.Name = "lblFormula2";
            this.lblFormula2.Size = new System.Drawing.Size(111, 18);
            this.lblFormula2.TabIndex = 15;
            this.lblFormula2.Text = "x = __________";
            this.lblFormula2.Visible = false;
            // 
            // lblFormula1
            // 
            this.lblFormula1.AutoSize = true;
            this.lblFormula1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblFormula1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula1.ForeColor = System.Drawing.Color.White;
            this.lblFormula1.Location = new System.Drawing.Point(451, 226);
            this.lblFormula1.Name = "lblFormula1";
            this.lblFormula1.Size = new System.Drawing.Size(68, 18);
            this.lblFormula1.TabIndex = 14;
            this.lblFormula1.Text = "(-b +- √Δ)";
            this.lblFormula1.Visible = false;
            // 
            // lblFormula3
            // 
            this.lblFormula3.AutoSize = true;
            this.lblFormula3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblFormula3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula3.ForeColor = System.Drawing.Color.White;
            this.lblFormula3.Location = new System.Drawing.Point(467, 252);
            this.lblFormula3.Name = "lblFormula3";
            this.lblFormula3.Size = new System.Drawing.Size(34, 18);
            this.lblFormula3.TabIndex = 16;
            this.lblFormula3.Text = "2 . a";
            this.lblFormula3.Visible = false;
            // 
            // lblExplicacao4
            // 
            this.lblExplicacao4.AutoSize = true;
            this.lblExplicacao4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao4.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao4.Location = new System.Drawing.Point(420, 286);
            this.lblExplicacao4.Name = "lblExplicacao4";
            this.lblExplicacao4.Size = new System.Drawing.Size(111, 18);
            this.lblExplicacao4.TabIndex = 18;
            this.lblExplicacao4.Text = "x = __________";
            this.lblExplicacao4.Visible = false;
            // 
            // lblExplicacao3
            // 
            this.lblExplicacao3.AutoSize = true;
            this.lblExplicacao3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao3.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao3.Location = new System.Drawing.Point(451, 279);
            this.lblExplicacao3.Name = "lblExplicacao3";
            this.lblExplicacao3.Size = new System.Drawing.Size(74, 18);
            this.lblExplicacao3.TabIndex = 17;
            this.lblExplicacao3.Text = "(-3 +- √49)";
            this.lblExplicacao3.Visible = false;
            // 
            // lblExplicacao5
            // 
            this.lblExplicacao5.AutoSize = true;
            this.lblExplicacao5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao5.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao5.Location = new System.Drawing.Point(467, 305);
            this.lblExplicacao5.Name = "lblExplicacao5";
            this.lblExplicacao5.Size = new System.Drawing.Size(33, 18);
            this.lblExplicacao5.TabIndex = 19;
            this.lblExplicacao5.Text = "2 . 1";
            this.lblExplicacao5.Visible = false;
            // 
            // lblExplicacao7
            // 
            this.lblExplicacao7.AutoSize = true;
            this.lblExplicacao7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao7.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao7.Location = new System.Drawing.Point(421, 338);
            this.lblExplicacao7.Name = "lblExplicacao7";
            this.lblExplicacao7.Size = new System.Drawing.Size(111, 18);
            this.lblExplicacao7.TabIndex = 20;
            this.lblExplicacao7.Text = "x = __________";
            this.lblExplicacao7.Visible = false;
            // 
            // lblExplicacao6
            // 
            this.lblExplicacao6.AutoSize = true;
            this.lblExplicacao6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(123)))));
            this.lblExplicacao6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao6.ForeColor = System.Drawing.Color.White;
            this.lblExplicacao6.Location = new System.Drawing.Point(457, 331);
            this.lblExplicacao6.Name = "lblExplicacao6";
            this.lblExplicacao6.Size = new System.Drawing.Size(58, 18);
            this.lblExplicacao6.TabIndex = 22;
            this.lblExplicacao6.Text = "(-3 +- 7)";
            this.lblExplicacao6.Visible = false;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Humnst777 Cn BT", 10F);
            this.lblSobre.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblSobre.Location = new System.Drawing.Point(804, 446);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(181, 17);
            this.lblSobre.TabIndex = 39;
            this.lblSobre.Text = "Desenvolvido por Gabriel Vicente";
            // 
            // pcbProfessor
            // 
            this.pcbProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pcbProfessor.Image = global::Equacao2Grau.Properties.Resources.teacher;
            this.pcbProfessor.Location = new System.Drawing.Point(107, 286);
            this.pcbProfessor.Name = "pcbProfessor";
            this.pcbProfessor.Size = new System.Drawing.Size(130, 167);
            this.pcbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProfessor.TabIndex = 41;
            this.pcbProfessor.TabStop = false;
            // 
            // pcbLinkedin
            // 
            this.pcbLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLinkedin.Image = global::Equacao2Grau.Properties.Resources._in;
            this.pcbLinkedin.Location = new System.Drawing.Point(771, 441);
            this.pcbLinkedin.Name = "pcbLinkedin";
            this.pcbLinkedin.Size = new System.Drawing.Size(27, 27);
            this.pcbLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLinkedin.TabIndex = 40;
            this.pcbLinkedin.TabStop = false;
            this.pcbLinkedin.Click += new System.EventHandler(this.pcbLinkedin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = global::Equacao2Grau.Properties.Resources.lousa;
            this.pictureBox1.Location = new System.Drawing.Point(339, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 394);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmEquacao2Grau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1016, 487);
            this.Controls.Add(this.pcbProfessor);
            this.Controls.Add(this.pcbLinkedin);
            this.Controls.Add(this.lblSobre);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblExplicacao16);
            this.Controls.Add(this.lblExplicacao22);
            this.Controls.Add(this.lblExplicacao20);
            this.Controls.Add(this.lblExplicacao21);
            this.Controls.Add(this.lblExplicacao19);
            this.Controls.Add(this.lblExplicacao17);
            this.Controls.Add(this.lblExplicacao18);
            this.Controls.Add(this.lblExplicacao15);
            this.Controls.Add(this.lblExplicacao13);
            this.Controls.Add(this.lblExplicacao14);
            this.Controls.Add(this.lblExplicacao12);
            this.Controls.Add(this.lblExplicacao10);
            this.Controls.Add(this.lblExplicacao11);
            this.Controls.Add(this.lblExplicacao9);
            this.Controls.Add(this.lblExplicacao6);
            this.Controls.Add(this.lblExplicacao8);
            this.Controls.Add(this.lblExplicacao7);
            this.Controls.Add(this.lblExplicacao5);
            this.Controls.Add(this.lblExplicacao3);
            this.Controls.Add(this.lblExplicacao4);
            this.Controls.Add(this.lblFormula3);
            this.Controls.Add(this.lblFormula1);
            this.Controls.Add(this.lblFormula2);
            this.Controls.Add(this.lblExplicacao2);
            this.Controls.Add(this.lblExplicacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEfetuarCalc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmEquacao2Grau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explicação de Equação 2º Grau | Gabriel Vicente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEfetuarCalc;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSintaxe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblExplicacao;
        private System.Windows.Forms.Label lblExplicacao8;
        private System.Windows.Forms.Label lblExplicacao12;
        private System.Windows.Forms.Label lblExplicacao10;
        private System.Windows.Forms.Label lblExplicacao11;
        private System.Windows.Forms.Label lblExplicacao9;
        private System.Windows.Forms.Label lblExplicacao15;
        private System.Windows.Forms.Label lblExplicacao13;
        private System.Windows.Forms.Label lblExplicacao14;
        private System.Windows.Forms.Label lblExplicacao22;
        private System.Windows.Forms.Label lblExplicacao20;
        private System.Windows.Forms.Label lblExplicacao21;
        private System.Windows.Forms.Label lblExplicacao19;
        private System.Windows.Forms.Label lblExplicacao17;
        private System.Windows.Forms.Label lblExplicacao18;
        private System.Windows.Forms.Label lblExplicacao16;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblExplicacao2;
        private System.Windows.Forms.Label lblFormula2;
        private System.Windows.Forms.Label lblFormula1;
        private System.Windows.Forms.Label lblFormula3;
        private System.Windows.Forms.Label lblExplicacao4;
        private System.Windows.Forms.Label lblExplicacao3;
        private System.Windows.Forms.Label lblExplicacao5;
        private System.Windows.Forms.Label lblExplicacao7;
        private System.Windows.Forms.Label lblExplicacao6;
        private System.Windows.Forms.PictureBox pcbLinkedin;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.PictureBox pcbProfessor;
    }
}

