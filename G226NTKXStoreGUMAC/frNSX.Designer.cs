namespace G226NTKXStoreGUMAC
{
    partial class frNSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frNSX));
            this.dataGridViewNSX = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quocgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMNSXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMNSX = new G226NTKXStoreGUMAC.Data.DMNSX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dMNSXTableAdapter = new G226NTKXStoreGUMAC.Data.DMNSXTableAdapters.DMNSXTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNSX
            // 
            this.dataGridViewNSX.AutoGenerateColumns = false;
            this.dataGridViewNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tennsx,
            this.quocgia,
            this.mota});
            this.dataGridViewNSX.DataSource = this.dMNSXBindingSource;
            this.dataGridViewNSX.Location = new System.Drawing.Point(345, 94);
            this.dataGridViewNSX.Name = "dataGridViewNSX";
            this.dataGridViewNSX.Size = new System.Drawing.Size(443, 150);
            this.dataGridViewNSX.TabIndex = 0;
            this.dataGridViewNSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // tennsx
            // 
            this.tennsx.DataPropertyName = "tennsx";
            this.tennsx.HeaderText = "tennsx";
            this.tennsx.Name = "tennsx";
            // 
            // quocgia
            // 
            this.quocgia.DataPropertyName = "quocgia";
            this.quocgia.HeaderText = "quocgia";
            this.quocgia.Name = "quocgia";
            // 
            // mota
            // 
            this.mota.DataPropertyName = "mota";
            this.mota.HeaderText = "mota";
            this.mota.Name = "mota";
            // 
            // dMNSXBindingSource
            // 
            this.dMNSXBindingSource.DataMember = "DMNSX";
            this.dMNSXBindingSource.DataSource = this.dMNSX;
            // 
            // dMNSX
            // 
            this.dMNSX.DataSetName = "DMNSX";
            this.dMNSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên nsx";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(83, 94);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(239, 20);
            this.txtTen.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quốc gia";
            // 
            // txtQuocGia
            // 
            this.txtQuocGia.Location = new System.Drawing.Point(83, 131);
            this.txtQuocGia.Name = "txtQuocGia";
            this.txtQuocGia.Size = new System.Drawing.Size(239, 20);
            this.txtQuocGia.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mô tả";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(83, 184);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(239, 20);
            this.txtMota.TabIndex = 29;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(617, 261);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "Thoát chương trình";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(453, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Về màn hình chính";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(297, 261);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(178, 261);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(61, 261);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dMNSXTableAdapter
            // 
            this.dMNSXTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(265, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Danh sách nhà sản xuất";
            // 
            // frNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 302);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuocGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dataGridViewNSX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frNSX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frNSX";
            this.Load += new System.EventHandler(this.frNSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNSX;
        private Data.DMNSX dMNSX;
        private System.Windows.Forms.BindingSource dMNSXBindingSource;
        private Data.DMNSXTableAdapters.DMNSXTableAdapter dMNSXTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn quocgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn mota;
        private System.Windows.Forms.Label label6;
    }
}