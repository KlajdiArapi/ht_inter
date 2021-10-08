namespace ht_inter
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
            this.components = new System.ComponentModel.Container();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbPort2 = new System.Windows.Forms.ComboBox();
            this.cb_porta = new System.Windows.Forms.ComboBox();
            this.txtTesto = new System.Windows.Forms.TextBox();
            this.btnSimula = new System.Windows.Forms.Button();
            this.cognomeTxt = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.codiceFiscale = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStop.ForeColor = System.Drawing.Color.Firebrick;
            this.btnStop.Location = new System.Drawing.Point(258, 54);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 46);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // cbPort2
            // 
            this.cbPort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPort2.FormattingEnabled = true;
            this.cbPort2.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.cbPort2.Location = new System.Drawing.Point(578, 119);
            this.cbPort2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPort2.Name = "cbPort2";
            this.cbPort2.Size = new System.Drawing.Size(100, 24);
            this.cbPort2.TabIndex = 27;
            this.cbPort2.Text = "COM4";
            // 
            // cb_porta
            // 
            this.cb_porta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_porta.FormattingEnabled = true;
            this.cb_porta.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.cb_porta.Location = new System.Drawing.Point(24, 119);
            this.cb_porta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_porta.Name = "cb_porta";
            this.cb_porta.Size = new System.Drawing.Size(100, 24);
            this.cb_porta.TabIndex = 26;
            this.cb_porta.Text = "COM3";
            this.cb_porta.SelectedIndexChanged += new System.EventHandler(this.cb_porta_SelectedIndexChanged);
            // 
            // txtTesto
            // 
            this.txtTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTesto.Location = new System.Drawing.Point(132, 120);
            this.txtTesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTesto.Name = "txtTesto";
            this.txtTesto.ReadOnly = true;
            this.txtTesto.Size = new System.Drawing.Size(440, 23);
            this.txtTesto.TabIndex = 25;
            // 
            // btnSimula
            // 
            this.btnSimula.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSimula.FlatAppearance.BorderSize = 0;
            this.btnSimula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSimula.Location = new System.Drawing.Point(130, 54);
            this.btnSimula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimula.Name = "btnSimula";
            this.btnSimula.Size = new System.Drawing.Size(122, 46);
            this.btnSimula.TabIndex = 24;
            this.btnSimula.Text = "Simula";
            this.btnSimula.UseVisualStyleBackColor = false;
            // 
            // cognomeTxt
            // 
            this.cognomeTxt.AutoSize = true;
            this.cognomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cognomeTxt.Location = new System.Drawing.Point(153, 203);
            this.cognomeTxt.Name = "cognomeTxt";
            this.cognomeTxt.Size = new System.Drawing.Size(0, 20);
            this.cognomeTxt.TabIndex = 23;
            // 
            // nomeTxt
            // 
            this.nomeTxt.AutoSize = true;
            this.nomeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nomeTxt.Location = new System.Drawing.Point(153, 182);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.Size = new System.Drawing.Size(0, 20);
            this.nomeTxt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Codice fiscale";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(24, 53);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 47);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "LEGGI";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // codiceFiscale
            // 
            this.codiceFiscale.AutoSize = true;
            this.codiceFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codiceFiscale.Location = new System.Drawing.Point(153, 224);
            this.codiceFiscale.Name = "codiceFiscale";
            this.codiceFiscale.Size = new System.Drawing.Size(0, 20);
            this.codiceFiscale.TabIndex = 17;
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.ReceivedBytesThreshold = 55;
            this.serialPort1.RtsEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 333);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.cbPort2);
            this.Controls.Add(this.cb_porta);
            this.Controls.Add(this.txtTesto);
            this.Controls.Add(this.btnSimula);
            this.Controls.Add(this.cognomeTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.codiceFiscale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cbPort2;
        private System.Windows.Forms.ComboBox cb_porta;
        private System.Windows.Forms.TextBox txtTesto;
        private System.Windows.Forms.Button btnSimula;
        private System.Windows.Forms.Label cognomeTxt;
        private System.Windows.Forms.Label nomeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label codiceFiscale;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
    }
}

