
namespace AddressBook {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.cbFamily = new System.Windows.Forms.CheckBox();
            this.cbFriends = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "メールアドレス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(134, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(134, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(103, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "グループ";
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(12, 288);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowTemplate.Height = 21;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(776, 150);
            this.dgvPersons.TabIndex = 1;
            this.dgvPersons.Click += new System.EventHandler(this.dgvPersons_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(254, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(354, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(254, 123);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(354, 60);
            this.tbAddress.TabIndex = 2;
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMailAddress.Location = new System.Drawing.Point(254, 62);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(354, 31);
            this.tbMailAddress.TabIndex = 2;
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbCompany.Location = new System.Drawing.Point(254, 190);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(354, 31);
            this.tbCompany.TabIndex = 2;
            // 
            // cbFamily
            // 
            this.cbFamily.AutoSize = true;
            this.cbFamily.Location = new System.Drawing.Point(254, 247);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(48, 16);
            this.cbFamily.TabIndex = 3;
            this.cbFamily.Text = "家族";
            this.cbFamily.UseVisualStyleBackColor = true;
            // 
            // cbFriends
            // 
            this.cbFriends.AutoSize = true;
            this.cbFriends.Location = new System.Drawing.Point(308, 247);
            this.cbFriends.Name = "cbFriends";
            this.cbFriends.Size = new System.Drawing.Size(48, 16);
            this.cbFriends.TabIndex = 3;
            this.cbFriends.Text = "友人";
            this.cbFriends.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(416, 247);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(55, 16);
            this.cbOther.TabIndex = 3;
            this.cbOther.Text = "その他";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(362, 247);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(48, 16);
            this.cbWork.TabIndex = 3;
            this.cbWork.Text = "仕事";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddPerson.Location = new System.Drawing.Point(576, 233);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(66, 41);
            this.btAddPerson.TabIndex = 4;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbPicture.Location = new System.Drawing.Point(633, 42);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(91, 120);
            this.pbPicture.TabIndex = 5;
            this.pbPicture.TabStop = false;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(614, 190);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureClear
            // 
            this.btPictureClear.Location = new System.Drawing.Point(695, 190);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(75, 23);
            this.btPictureClear.TabIndex = 6;
            this.btPictureClear.Text = "クリア";
            this.btPictureClear.UseVisualStyleBackColor = true;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(650, 233);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(66, 41);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(722, 233);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(66, 41);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbFriends);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbMailAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "住所録アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPersons;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbMailAddress;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.CheckBox cbFamily;
        private System.Windows.Forms.CheckBox cbFriends;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}

