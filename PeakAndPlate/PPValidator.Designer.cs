namespace PicoPlaca
{
    partial class PPValidator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorPPProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipPP = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorPPProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPlate
            // 
            this.tbPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPlate.Location = new System.Drawing.Point(90, 53);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(200, 20);
            this.tbPlate.TabIndex = 0;
            this.tbPlate.Enter += new System.EventHandler(this.tbPlate_Enter);
            this.tbPlate.Leave += new System.EventHandler(this.tbPlate_Leave);
            this.tbPlate.Validating += new System.ComponentModel.CancelEventHandler(this.tbPlate_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLATE:";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(90, 79);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTime.TabIndex = 1;
            // 
            // tbHour
            // 
            this.tbHour.Location = new System.Drawing.Point(90, 105);
            this.tbHour.Name = "tbHour";
            this.tbHour.Size = new System.Drawing.Size(200, 20);
            this.tbHour.TabIndex = 2;
            this.tbHour.Enter += new System.EventHandler(this.tbHour_Enter);
            this.tbHour.Leave += new System.EventHandler(this.tbHour_Leave);
            this.tbHour.Validating += new System.ComponentModel.CancelEventHandler(this.tbHour_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HOUR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "RESULTADO";
            // 
            // errorPPProvider
            // 
            this.errorPPProvider.ContainerControl = this;
            // 
            // PPValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHour);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPlate);
            this.Name = "PPValidator";
            this.Text = "PEAK AND PLATE VALIDATOR";
            ((System.ComponentModel.ISupportInitialize)(this.errorPPProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorPPProvider;
        private System.Windows.Forms.ToolTip toolTipPP;
    }
}

