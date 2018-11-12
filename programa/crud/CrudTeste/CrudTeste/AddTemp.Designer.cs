namespace CrudTeste
{
    partial class AddTemp
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
            this.txtContato1 = new System.Windows.Forms.TextBox();
            this.txtContato2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmbiente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObjeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contato1";
            // 
            // txtContato1
            // 
            this.txtContato1.Location = new System.Drawing.Point(108, 69);
            this.txtContato1.Name = "txtContato1";
            this.txtContato1.Size = new System.Drawing.Size(146, 20);
            this.txtContato1.TabIndex = 1;
            // 
            // txtContato2
            // 
            this.txtContato2.Location = new System.Drawing.Point(108, 106);
            this.txtContato2.Name = "txtContato2";
            this.txtContato2.Size = new System.Drawing.Size(146, 20);
            this.txtContato2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contato 2";
            // 
            // txtAmbiente
            // 
            this.txtAmbiente.Location = new System.Drawing.Point(108, 143);
            this.txtAmbiente.Name = "txtAmbiente";
            this.txtAmbiente.Size = new System.Drawing.Size(146, 20);
            this.txtAmbiente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ambiente";
            // 
            // txtObjeto
            // 
            this.txtObjeto.Location = new System.Drawing.Point(108, 182);
            this.txtObjeto.Name = "txtObjeto";
            this.txtObjeto.Size = new System.Drawing.Size(146, 20);
            this.txtObjeto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Objeto";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(108, 224);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(69, 20);
            this.txtData.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data";
            // 
            // AddTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtObjeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmbiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContato2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContato1);
            this.Controls.Add(this.label1);
            this.Name = "AddTemp";
            this.Text = "AddTemp";
            this.Load += new System.EventHandler(this.AddTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContato1;
        private System.Windows.Forms.TextBox txtContato2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmbiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObjeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label5;
    }
}