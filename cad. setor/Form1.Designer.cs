namespace cad._setor
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSetor = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            btnGravar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(243, 28);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome do setor: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(355, 333);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 333);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 269);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 3;
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(265, 35);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(428, 31);
            txtSetor.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(447, 333);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(289, 31);
            txtNome.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new Point(62, 333);
            txtId.Name = "txtId";
            txtId.Size = new Size(289, 31);
            txtId.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(53, 390);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(112, 34);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(333, 390);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(614, 390);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 34);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(757, 255);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(txtNome);
            Controls.Add(txtSetor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSetor;
        private TextBox txtNome;
        private TextBox txtId;
        private Button btnGravar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dataGridView1;
    }
}
