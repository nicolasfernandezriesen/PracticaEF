namespace WindowsAppPubs
{
    partial class frmStore
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
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridStore = new System.Windows.Forms.DataGridView();
            this.lblIdStore = new System.Windows.Forms.Label();
            this.txtIdStore = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(12, 14);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(182, 59);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Listar";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(234, 14);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(121, 59);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Traer Uno";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1413, 490);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 59);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1185, 490);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 59);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(532, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 59);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridStore
            // 
            this.gridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStore.Location = new System.Drawing.Point(12, 92);
            this.gridStore.Name = "gridStore";
            this.gridStore.RowHeadersWidth = 62;
            this.gridStore.RowTemplate.Height = 28;
            this.gridStore.Size = new System.Drawing.Size(950, 561);
            this.gridStore.TabIndex = 5;
            // 
            // lblIdStore
            // 
            this.lblIdStore.AutoSize = true;
            this.lblIdStore.Location = new System.Drawing.Point(361, 43);
            this.lblIdStore.Name = "lblIdStore";
            this.lblIdStore.Size = new System.Drawing.Size(43, 20);
            this.lblIdStore.TabIndex = 6;
            this.lblIdStore.Text = "ID = ";
            // 
            // txtIdStore
            // 
            this.txtIdStore.Location = new System.Drawing.Point(410, 40);
            this.txtIdStore.Name = "txtIdStore";
            this.txtIdStore.Size = new System.Drawing.Size(100, 26);
            this.txtIdStore.TabIndex = 7;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1100, 105);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Store ID =";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1100, 176);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Store Nombre =";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(1100, 247);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(131, 20);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Store Direccion =";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(1100, 295);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(115, 20);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "Store Ciudad =";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(1100, 361);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(116, 20);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "Store Estado =";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(1100, 428);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(87, 20);
            this.lblZip.TabIndex = 13;
            this.lblZip.Text = "Store Zip =";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1279, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(273, 26);
            this.txtId.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1279, 176);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 26);
            this.txtName.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1279, 247);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 26);
            this.txtAddress.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(1279, 295);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(273, 26);
            this.txtCity.TabIndex = 17;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(1279, 361);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(273, 26);
            this.txtState.TabIndex = 18;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(1279, 428);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(273, 26);
            this.txtZip.TabIndex = 19;
            // 
            // frmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 679);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdStore);
            this.Controls.Add(this.lblIdStore);
            this.Controls.Add(this.gridStore);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGetAll);
            this.Name = "frmStore";
            this.Text = "frmStore";
            ((System.ComponentModel.ISupportInitialize)(this.gridStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridStore;
        private System.Windows.Forms.Label lblIdStore;
        private System.Windows.Forms.TextBox txtIdStore;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
    }
}