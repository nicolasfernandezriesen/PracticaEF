namespace WindowsAppPubs
{
    partial class frmAuthor
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
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdAuthor = new System.Windows.Forms.TextBox();
            this.lblIdStore = new System.Windows.Forms.Label();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(1290, 545);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(273, 26);
            this.txtZip.TabIndex = 39;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(1290, 478);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(273, 26);
            this.txtState.TabIndex = 38;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(1290, 412);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(273, 26);
            this.txtCity.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1290, 364);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 26);
            this.txtAddress.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1290, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 26);
            this.txtName.TabIndex = 35;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1290, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(273, 26);
            this.txtId.TabIndex = 34;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(1111, 545);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(96, 20);
            this.lblZip.TabIndex = 33;
            this.lblZip.Text = "Author Zip =";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(1111, 478);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(125, 20);
            this.lblState.TabIndex = 32;
            this.lblState.Text = "Author Estado =";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(1111, 412);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(124, 20);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "Author Ciudad =";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(1111, 364);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(140, 20);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Author Direccion =";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1111, 177);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 20);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Author Nombre =";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1111, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(91, 20);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "Author ID =";
            // 
            // txtIdAuthor
            // 
            this.txtIdAuthor.Location = new System.Drawing.Point(421, 41);
            this.txtIdAuthor.Name = "txtIdAuthor";
            this.txtIdAuthor.Size = new System.Drawing.Size(100, 26);
            this.txtIdAuthor.TabIndex = 27;
            // 
            // lblIdStore
            // 
            this.lblIdStore.AutoSize = true;
            this.lblIdStore.Location = new System.Drawing.Point(372, 44);
            this.lblIdStore.Name = "lblIdStore";
            this.lblIdStore.Size = new System.Drawing.Size(43, 20);
            this.lblIdStore.TabIndex = 26;
            this.lblIdStore.Text = "ID = ";
            // 
            // gridAuthor
            // 
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(23, 93);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.RowHeadersWidth = 62;
            this.gridAuthor.RowTemplate.Height = 28;
            this.gridAuthor.Size = new System.Drawing.Size(950, 561);
            this.gridAuthor.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(543, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 59);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1196, 607);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 59);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1424, 607);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(103, 59);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(245, 15);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(121, 59);
            this.btnGet.TabIndex = 21;
            this.btnGet.Text = "Traer Uno";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(23, 15);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(182, 59);
            this.btnGetAll.TabIndex = 20;
            this.btnGetAll.Text = "Listar";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1111, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Author Apellido =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Author Telefono =";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(1290, 238);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(273, 26);
            this.txtLname.TabIndex = 42;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1290, 295);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(273, 26);
            this.txtPhone.TabIndex = 43;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 690);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.txtIdAuthor);
            this.Controls.Add(this.lblIdStore);
            this.Controls.Add(this.gridAuthor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGetAll);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdAuthor;
        private System.Windows.Forms.Label lblIdStore;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPhone;
    }
}