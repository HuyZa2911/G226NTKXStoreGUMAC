namespace G226NTKXStoreGUMAC
{
    partial class frDMNCC
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
            this.dataGridViewNCC = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dMNCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMNCC = new G226NTKXStoreGUMAC.Data.DMNCC();
            this.dMNCCTableAdapter = new G226NTKXStoreGUMAC.Data.DMNCCTableAdapters.DMNCCTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNCC
            // 
            this.dataGridViewNCC.AutoGenerateColumns = false;
            this.dataGridViewNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenncc,
            this.dc,
            this.sdt});
            this.dataGridViewNCC.DataSource = this.dMNCCBindingSource;
            this.dataGridViewNCC.Location = new System.Drawing.Point(351, 55);
            this.dataGridViewNCC.Name = "dataGridViewNCC";
            this.dataGridViewNCC.Size = new System.Drawing.Size(447, 171);
            this.dataGridViewNCC.TabIndex = 0;
            this.dataGridViewNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(610, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 42;
            this.button5.Text = "Thoát chương trình";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "Về màn hình chính";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(290, 269);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(171, 269);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(54, 269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên NCC";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(92, 66);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(239, 20);
            this.txtTen.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(92, 119);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 20);
            this.txtDiaChi.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Sdt";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(92, 181);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(239, 20);
            this.txtSDT.TabIndex = 45;
            // 
            // dMNCCBindingSource
            // 
            this.dMNCCBindingSource.DataMember = "DMNCC";
            this.dMNCCBindingSource.DataSource = this.dMNCC;
            // 
            // dMNCC
            // 
            this.dMNCC.DataSetName = "DMNCC";
            this.dMNCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMNCCTableAdapter
            // 
            this.dMNCCTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(213, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Danh sách danh mục nhà cung cấp";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "tenncc";
            this.tenncc.HeaderText = "tenncc";
            this.tenncc.Name = "tenncc";
            // 
            // dc
            // 
            this.dc.DataPropertyName = "dc";
            this.dc.HeaderText = "dc";
            this.dc.Name = "dc";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sodt";
            this.sdt.HeaderText = "sodt";
            this.sdt.Name = "sdt";
            // 
            // frDMNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dataGridViewNCC);
            this.Name = "frDMNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frDMNCC";
            this.Load += new System.EventHandler(this.frDMNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNCC;
        private Data.DMNCC dMNCC;
        private System.Windows.Forms.BindingSource dMNCCBindingSource;
        private Data.DMNCCTableAdapters.DMNCCTableAdapter dMNCCTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}