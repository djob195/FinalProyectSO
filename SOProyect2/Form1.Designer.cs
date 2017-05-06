namespace SOProyect2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnBalanced = new System.Windows.Forms.Panel();
            this.lbCantConsumidores = new System.Windows.Forms.Label();
            this.lbCantProductores = new System.Windows.Forms.Label();
            this.lbBalanceado = new System.Windows.Forms.Label();
            this.btnBalancear = new System.Windows.Forms.Button();
            this.dgvInfoConsumidores = new System.Windows.Forms.DataGridView();
            this.dgvcAliasConsumidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdgvPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTDProductores = new System.Windows.Forms.Label();
            this.NUDConsumidores = new System.Windows.Forms.NumericUpDown();
            this.NUDProductores = new System.Windows.Forms.NumericUpDown();
            this.lbTDConsumers = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerActualizar = new System.Windows.Forms.Timer(this.components);
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.btnTitleEmpezar = new System.Windows.Forms.Button();
            this.NUDTitleTransations = new System.Windows.Forms.NumericUpDown();
            this.lbTitleInst = new System.Windows.Forms.Label();
            this.tbProduccionOrigen = new System.Windows.Forms.MaskedTextBox();
            this.lbProduccionOrigen = new System.Windows.Forms.Label();
            this.lbProduccionDestino = new System.Windows.Forms.Label();
            this.tbProduccionDestino = new System.Windows.Forms.MaskedTextBox();
            this.lbProduccionRegistros = new System.Windows.Forms.Label();
            this.NUDProduccionRegistros = new System.Windows.Forms.NumericUpDown();
            this.btnInsertarRegistros = new System.Windows.Forms.Button();
            this.btnEliminarRegistros = new System.Windows.Forms.Button();
            this.lbColaProduccio = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnBalanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoConsumidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDConsumidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProductores)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTitleTransations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProduccionRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(358, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnBalanced);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(350, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thread Driver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnBalanced
            // 
            this.pnBalanced.Controls.Add(this.lbCantConsumidores);
            this.pnBalanced.Controls.Add(this.lbCantProductores);
            this.pnBalanced.Controls.Add(this.lbBalanceado);
            this.pnBalanced.Controls.Add(this.btnBalancear);
            this.pnBalanced.Controls.Add(this.dgvInfoConsumidores);
            this.pnBalanced.Controls.Add(this.lbTDProductores);
            this.pnBalanced.Controls.Add(this.NUDConsumidores);
            this.pnBalanced.Controls.Add(this.NUDProductores);
            this.pnBalanced.Controls.Add(this.lbTDConsumers);
            this.pnBalanced.Location = new System.Drawing.Point(6, 6);
            this.pnBalanced.Name = "pnBalanced";
            this.pnBalanced.Size = new System.Drawing.Size(326, 271);
            this.pnBalanced.TabIndex = 1;
            // 
            // lbCantConsumidores
            // 
            this.lbCantConsumidores.AutoSize = true;
            this.lbCantConsumidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantConsumidores.Location = new System.Drawing.Point(196, 79);
            this.lbCantConsumidores.Name = "lbCantConsumidores";
            this.lbCantConsumidores.Size = new System.Drawing.Size(82, 13);
            this.lbCantConsumidores.TabIndex = 8;
            this.lbCantConsumidores.Text = "3 Consumidores";
            // 
            // lbCantProductores
            // 
            this.lbCantProductores.AutoSize = true;
            this.lbCantProductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantProductores.Location = new System.Drawing.Point(196, 40);
            this.lbCantProductores.Name = "lbCantProductores";
            this.lbCantProductores.Size = new System.Drawing.Size(73, 13);
            this.lbCantProductores.TabIndex = 7;
            this.lbCantProductores.Text = "3 Productores";
            // 
            // lbBalanceado
            // 
            this.lbBalanceado.AutoSize = true;
            this.lbBalanceado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceado.Location = new System.Drawing.Point(167, 230);
            this.lbBalanceado.Name = "lbBalanceado";
            this.lbBalanceado.Size = new System.Drawing.Size(120, 24);
            this.lbBalanceado.TabIndex = 6;
            this.lbBalanceado.Text = "Balanceado";
            // 
            // btnBalancear
            // 
            this.btnBalancear.Location = new System.Drawing.Point(25, 233);
            this.btnBalancear.Name = "btnBalancear";
            this.btnBalancear.Size = new System.Drawing.Size(75, 23);
            this.btnBalancear.TabIndex = 5;
            this.btnBalancear.Text = "Balancear";
            this.btnBalancear.UseVisualStyleBackColor = true;
            this.btnBalancear.Click += new System.EventHandler(this.btnBalancear_Click);
            // 
            // dgvInfoConsumidores
            // 
            this.dgvInfoConsumidores.AllowUserToAddRows = false;
            this.dgvInfoConsumidores.AllowUserToDeleteRows = false;
            this.dgvInfoConsumidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoConsumidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcAliasConsumidor,
            this.cdgvPrioridad});
            this.dgvInfoConsumidores.Location = new System.Drawing.Point(25, 111);
            this.dgvInfoConsumidores.Name = "dgvInfoConsumidores";
            this.dgvInfoConsumidores.Size = new System.Drawing.Size(244, 89);
            this.dgvInfoConsumidores.TabIndex = 4;
            // 
            // dgvcAliasConsumidor
            // 
            this.dgvcAliasConsumidor.HeaderText = "# Consumidor";
            this.dgvcAliasConsumidor.Name = "dgvcAliasConsumidor";
            this.dgvcAliasConsumidor.ReadOnly = true;
            // 
            // cdgvPrioridad
            // 
            this.cdgvPrioridad.HeaderText = "Prioridad";
            this.cdgvPrioridad.Name = "cdgvPrioridad";
            // 
            // lbTDProductores
            // 
            this.lbTDProductores.AutoSize = true;
            this.lbTDProductores.Location = new System.Drawing.Point(22, 40);
            this.lbTDProductores.Name = "lbTDProductores";
            this.lbTDProductores.Size = new System.Drawing.Size(64, 13);
            this.lbTDProductores.TabIndex = 0;
            this.lbTDProductores.Text = "Productores";
            // 
            // NUDConsumidores
            // 
            this.NUDConsumidores.Location = new System.Drawing.Point(101, 72);
            this.NUDConsumidores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDConsumidores.Name = "NUDConsumidores";
            this.NUDConsumidores.Size = new System.Drawing.Size(55, 20);
            this.NUDConsumidores.TabIndex = 3;
            this.NUDConsumidores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDConsumidores.ValueChanged += new System.EventHandler(this.NUDConsumidores_ValueChanged);
            // 
            // NUDProductores
            // 
            this.NUDProductores.Location = new System.Drawing.Point(101, 38);
            this.NUDProductores.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDProductores.Name = "NUDProductores";
            this.NUDProductores.Size = new System.Drawing.Size(55, 20);
            this.NUDProductores.TabIndex = 1;
            this.NUDProductores.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbTDConsumers
            // 
            this.lbTDConsumers.AutoSize = true;
            this.lbTDConsumers.Location = new System.Drawing.Point(13, 79);
            this.lbTDConsumers.Name = "lbTDConsumers";
            this.lbTDConsumers.Size = new System.Drawing.Size(73, 13);
            this.lbTDConsumers.TabIndex = 2;
            this.lbTDConsumers.Text = "Consumidores";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbColaProduccio);
            this.tabPage2.Controls.Add(this.btnEliminarRegistros);
            this.tabPage2.Controls.Add(this.btnInsertarRegistros);
            this.tabPage2.Controls.Add(this.NUDProduccionRegistros);
            this.tabPage2.Controls.Add(this.lbProduccionRegistros);
            this.tabPage2.Controls.Add(this.tbProduccionDestino);
            this.tabPage2.Controls.Add(this.lbProduccionDestino);
            this.tabPage2.Controls.Add(this.lbProduccionOrigen);
            this.tabPage2.Controls.Add(this.tbProduccionOrigen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(350, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Producción";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timerActualizar
            // 
            this.timerActualizar.Interval = 1000;
            this.timerActualizar.Tick += new System.EventHandler(this.timerActualizar_Tick);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(35, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(247, 148);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "MODELO DE \r\nCONSUMIDOR\r\n Y \r\nPRODUCTOR";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.lbTitleInst);
            this.pnTitle.Controls.Add(this.NUDTitleTransations);
            this.pnTitle.Controls.Add(this.btnTitleEmpezar);
            this.pnTitle.Controls.Add(this.lbTitle);
            this.pnTitle.Location = new System.Drawing.Point(388, 34);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(318, 297);
            this.pnTitle.TabIndex = 1;
            // 
            // btnTitleEmpezar
            // 
            this.btnTitleEmpezar.Location = new System.Drawing.Point(106, 266);
            this.btnTitleEmpezar.Name = "btnTitleEmpezar";
            this.btnTitleEmpezar.Size = new System.Drawing.Size(87, 23);
            this.btnTitleEmpezar.TabIndex = 2;
            this.btnTitleEmpezar.Text = "Empezar";
            this.btnTitleEmpezar.UseVisualStyleBackColor = true;
            this.btnTitleEmpezar.Click += new System.EventHandler(this.btnTitleEmpezar_Click);
            // 
            // NUDTitleTransations
            // 
            this.NUDTitleTransations.Location = new System.Drawing.Point(115, 226);
            this.NUDTitleTransations.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDTitleTransations.Name = "NUDTitleTransations";
            this.NUDTitleTransations.Size = new System.Drawing.Size(66, 20);
            this.NUDTitleTransations.TabIndex = 3;
            this.NUDTitleTransations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbTitleInst
            // 
            this.lbTitleInst.AutoSize = true;
            this.lbTitleInst.Location = new System.Drawing.Point(59, 195);
            this.lbTitleInst.Name = "lbTitleInst";
            this.lbTitleInst.Size = new System.Drawing.Size(199, 13);
            this.lbTitleInst.TabIndex = 4;
            this.lbTitleInst.Text = "Selecciona la cantidad de transacciones";
            // 
            // tbProduccionOrigen
            // 
            this.tbProduccionOrigen.Location = new System.Drawing.Point(195, 73);
            this.tbProduccionOrigen.Mask = "AAAAA";
            this.tbProduccionOrigen.Name = "tbProduccionOrigen";
            this.tbProduccionOrigen.Size = new System.Drawing.Size(38, 20);
            this.tbProduccionOrigen.TabIndex = 0;
            // 
            // lbProduccionOrigen
            // 
            this.lbProduccionOrigen.AutoSize = true;
            this.lbProduccionOrigen.Location = new System.Drawing.Point(125, 76);
            this.lbProduccionOrigen.Name = "lbProduccionOrigen";
            this.lbProduccionOrigen.Size = new System.Drawing.Size(38, 13);
            this.lbProduccionOrigen.TabIndex = 1;
            this.lbProduccionOrigen.Text = "Origen";
            // 
            // lbProduccionDestino
            // 
            this.lbProduccionDestino.AutoSize = true;
            this.lbProduccionDestino.Location = new System.Drawing.Point(120, 121);
            this.lbProduccionDestino.Name = "lbProduccionDestino";
            this.lbProduccionDestino.Size = new System.Drawing.Size(43, 13);
            this.lbProduccionDestino.TabIndex = 2;
            this.lbProduccionDestino.Text = "Destino";
            // 
            // tbProduccionDestino
            // 
            this.tbProduccionDestino.Location = new System.Drawing.Point(195, 118);
            this.tbProduccionDestino.Mask = "AAAAA";
            this.tbProduccionDestino.Name = "tbProduccionDestino";
            this.tbProduccionDestino.Size = new System.Drawing.Size(38, 20);
            this.tbProduccionDestino.TabIndex = 3;
            // 
            // lbProduccionRegistros
            // 
            this.lbProduccionRegistros.AutoSize = true;
            this.lbProduccionRegistros.Location = new System.Drawing.Point(57, 163);
            this.lbProduccionRegistros.Name = "lbProduccionRegistros";
            this.lbProduccionRegistros.Size = new System.Drawing.Size(106, 13);
            this.lbProduccionRegistros.TabIndex = 4;
            this.lbProduccionRegistros.Text = "Cantidad de registros";
            // 
            // NUDProduccionRegistros
            // 
            this.NUDProduccionRegistros.Location = new System.Drawing.Point(195, 161);
            this.NUDProduccionRegistros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDProduccionRegistros.Name = "NUDProduccionRegistros";
            this.NUDProduccionRegistros.Size = new System.Drawing.Size(38, 20);
            this.NUDProduccionRegistros.TabIndex = 5;
            this.NUDProduccionRegistros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnInsertarRegistros
            // 
            this.btnInsertarRegistros.Location = new System.Drawing.Point(52, 211);
            this.btnInsertarRegistros.Name = "btnInsertarRegistros";
            this.btnInsertarRegistros.Size = new System.Drawing.Size(75, 47);
            this.btnInsertarRegistros.TabIndex = 6;
            this.btnInsertarRegistros.Text = "Insertar\r\nRegistros";
            this.btnInsertarRegistros.UseVisualStyleBackColor = true;
            this.btnInsertarRegistros.Click += new System.EventHandler(this.btnInsertarRegistros_Click);
            // 
            // btnEliminarRegistros
            // 
            this.btnEliminarRegistros.Location = new System.Drawing.Point(206, 211);
            this.btnEliminarRegistros.Name = "btnEliminarRegistros";
            this.btnEliminarRegistros.Size = new System.Drawing.Size(75, 47);
            this.btnEliminarRegistros.TabIndex = 7;
            this.btnEliminarRegistros.Text = "Eliminar \nRegistros";
            this.btnEliminarRegistros.UseVisualStyleBackColor = true;
            this.btnEliminarRegistros.Click += new System.EventHandler(this.btnEliminarRegistros_Click);
            // 
            // lbColaProduccio
            // 
            this.lbColaProduccio.AutoSize = true;
            this.lbColaProduccio.Location = new System.Drawing.Point(32, 28);
            this.lbColaProduccio.Name = "lbColaProduccio";
            this.lbColaProduccio.Size = new System.Drawing.Size(249, 13);
            this.lbColaProduccio.TabIndex = 8;
            this.lbColaProduccio.Text = "Hay 0 instrucciones en espera para los productores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 337);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnBalanced.ResumeLayout(false);
            this.pnBalanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoConsumidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDConsumidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProductores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTitleTransations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDProduccionRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvInfoConsumidores;
        private System.Windows.Forms.NumericUpDown NUDConsumidores;
        private System.Windows.Forms.Label lbTDConsumers;
        private System.Windows.Forms.NumericUpDown NUDProductores;
        private System.Windows.Forms.Label lbTDProductores;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBalancear;
        private System.Windows.Forms.Panel pnBalanced;
        private System.Windows.Forms.Label lbBalanceado;
        private System.Windows.Forms.Label lbCantConsumidores;
        private System.Windows.Forms.Label lbCantProductores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAliasConsumidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdgvPrioridad;
        private System.Windows.Forms.Timer timerActualizar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lbTitleInst;
        private System.Windows.Forms.NumericUpDown NUDTitleTransations;
        private System.Windows.Forms.Button btnTitleEmpezar;
        private System.Windows.Forms.Label lbColaProduccio;
        private System.Windows.Forms.Button btnEliminarRegistros;
        private System.Windows.Forms.Button btnInsertarRegistros;
        private System.Windows.Forms.NumericUpDown NUDProduccionRegistros;
        private System.Windows.Forms.Label lbProduccionRegistros;
        private System.Windows.Forms.MaskedTextBox tbProduccionDestino;
        private System.Windows.Forms.Label lbProduccionDestino;
        private System.Windows.Forms.Label lbProduccionOrigen;
        private System.Windows.Forms.MaskedTextBox tbProduccionOrigen;
    }
}

