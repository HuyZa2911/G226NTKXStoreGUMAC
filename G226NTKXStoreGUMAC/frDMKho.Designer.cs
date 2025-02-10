namespace G226NTKXStoreGUMAC
{
    partial class frDMKho
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
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConTrong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.succhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dMKho = new G226NTKXStoreGUMAC.Data.DMKho();
            this.dMKhoTableAdapter = new G226NTKXStoreGUMAC.Data.DMKhoTableAdapters.DMKhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.AutoGenerateColumns = false;
            this.dataGridViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tenkho,
            this.dc,
            this.sdt,
            this.succhua,
            this.controng});
            this.dataGridViewKho.DataSource = this.dMKhoBindingSource;
            this.dataGridViewKho.Location = new System.Drawing.Point(408, 88);
            this.dataGridViewKho.Name = "dataGridViewKho";
            this.dataGridViewKho.Size = new System.Drawing.Size(355, 196);
            this.dataGridViewKho.TabIndex = 0;
            this.dataGridViewKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên kho";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(96, 88);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(239, 20);
            this.txtTen.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(96, 129);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 20);
            this.txtDiaChi.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sdt";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(96, 178);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(239, 20);
            this.txtSDT.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sức chứa";
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(96, 227);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(239, 20);
            this.txtSucChua.TabIndex = 29;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(155, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(274, 318);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(594, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "Thoát chương trình";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(430, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Về màn hình chính";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Còn trống";
            // 
            // txtConTrong
            // 
            this.txtConTrong.Location = new System.Drawing.Point(96, 270);
            this.txtConTrong.Name = "txtConTrong";
            this.txtConTrong.Size = new System.Drawing.Size(239, 20);
            this.txtConTrong.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(261, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "Danh sách danh mục kho";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // tenkho
            // 
            this.tenkho.DataPropertyName = "tenkho";
            this.tenkho.HeaderText = "tenkho";
            this.tenkho.Name = "tenkho";
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
            // succhua
            // 
            this.succhua.DataPropertyName = "succhua";
            this.succhua.HeaderText = "succhua";
            this.succhua.Name = "succhua";
            // 
            // controng
            // 
            this.controng.DataPropertyName = "controng";
            this.controng.HeaderText = "controng";
            this.controng.Name = "controng";
            // 
            // dMKhoBindingSource
            // 
            this.dMKhoBindingSource.DataMember = "DMKho";
            this.dMKhoBindingSource.DataSource = this.dMKho;
            // 
            // dMKho
            // 
            this.dMKho.DataSetName = "DMKho";
            this.dMKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMKhoTableAdapter
            // 
            this.dMKhoTableAdapter.ClearBeforeFill = true;
            // 
            // frDMKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConTrong);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSucChua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dataGridViewKho);
            this.Name = "frDMKho";
            this.Text = "frDMKho";
            this.Load += new System.EventHandler(this.frDMKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKho;
        private Data.DMKho dMKho;
        private System.Windows.Forms.BindingSource dMKhoBindingSource;
        private Data.DMKhoTableAdapters.DMKhoTableAdapter dMKhoTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConTrong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn succhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn controng;
    }
}