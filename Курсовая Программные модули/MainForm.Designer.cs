namespace Курсовая_Программные_модули
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSmallProgrammsClear = new System.Windows.Forms.Button();
            this.btnModuleEdit = new System.Windows.Forms.Button();
            this.btnLoadModule = new System.Windows.Forms.Button();
            this.btnSmallProgramDelete = new System.Windows.Forms.Button();
            this.btnSmallProgramAdd = new System.Windows.Forms.Button();
            this.nudSmallProgramRowsCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSmallProgramName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSmallPrograms = new System.Windows.Forms.Label();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.nudModuleId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModuleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbModules = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProgramEdit = new System.Windows.Forms.Button();
            this.btnProgramLoad = new System.Windows.Forms.Button();
            this.btnProgramDelete = new System.Windows.Forms.Button();
            this.btnProgramAdd = new System.Windows.Forms.Button();
            this.nudProgramId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProgramName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmallProgramRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModuleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSmallProgrammsClear
            // 
            this.btnSmallProgrammsClear.Location = new System.Drawing.Point(368, 119);
            this.btnSmallProgrammsClear.Name = "btnSmallProgrammsClear";
            this.btnSmallProgrammsClear.Size = new System.Drawing.Size(75, 23);
            this.btnSmallProgrammsClear.TabIndex = 42;
            this.btnSmallProgrammsClear.Text = "Очистить";
            this.btnSmallProgrammsClear.UseVisualStyleBackColor = true;
            // 
            // btnModuleEdit
            // 
            this.btnModuleEdit.Location = new System.Drawing.Point(734, 119);
            this.btnModuleEdit.Name = "btnModuleEdit";
            this.btnModuleEdit.Size = new System.Drawing.Size(75, 23);
            this.btnModuleEdit.TabIndex = 41;
            this.btnModuleEdit.Text = "Изменить";
            this.btnModuleEdit.UseVisualStyleBackColor = true;
            // 
            // btnLoadModule
            // 
            this.btnLoadModule.Location = new System.Drawing.Point(653, 157);
            this.btnLoadModule.Name = "btnLoadModule";
            this.btnLoadModule.Size = new System.Drawing.Size(75, 23);
            this.btnLoadModule.TabIndex = 40;
            this.btnLoadModule.Text = "Загрузить";
            this.btnLoadModule.UseVisualStyleBackColor = true;
            // 
            // btnSmallProgramDelete
            // 
            this.btnSmallProgramDelete.Location = new System.Drawing.Point(287, 119);
            this.btnSmallProgramDelete.Name = "btnSmallProgramDelete";
            this.btnSmallProgramDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSmallProgramDelete.TabIndex = 39;
            this.btnSmallProgramDelete.Text = "Удалить";
            this.btnSmallProgramDelete.UseVisualStyleBackColor = true;
            // 
            // btnSmallProgramAdd
            // 
            this.btnSmallProgramAdd.Location = new System.Drawing.Point(206, 119);
            this.btnSmallProgramAdd.Name = "btnSmallProgramAdd";
            this.btnSmallProgramAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSmallProgramAdd.TabIndex = 38;
            this.btnSmallProgramAdd.Text = "Добавить";
            this.btnSmallProgramAdd.UseVisualStyleBackColor = true;
            // 
            // nudSmallProgramRowsCount
            // 
            this.nudSmallProgramRowsCount.Location = new System.Drawing.Point(285, 46);
            this.nudSmallProgramRowsCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSmallProgramRowsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSmallProgramRowsCount.Name = "nudSmallProgramRowsCount";
            this.nudSmallProgramRowsCount.Size = new System.Drawing.Size(145, 20);
            this.nudSmallProgramRowsCount.TabIndex = 37;
            this.nudSmallProgramRowsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Кол-во строк:";
            // 
            // tbSmallProgramName
            // 
            this.tbSmallProgramName.Location = new System.Drawing.Point(269, 18);
            this.tbSmallProgramName.Name = "tbSmallProgramName";
            this.tbSmallProgramName.Size = new System.Drawing.Size(162, 20);
            this.tbSmallProgramName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Название:";
            // 
            // lbSmallPrograms
            // 
            this.lbSmallPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSmallPrograms.Location = new System.Drawing.Point(12, 9);
            this.lbSmallPrograms.Name = "lbSmallPrograms";
            this.lbSmallPrograms.Size = new System.Drawing.Size(185, 215);
            this.lbSmallPrograms.TabIndex = 33;
            this.lbSmallPrograms.Text = "Подпрограммы:";
            this.lbSmallPrograms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Location = new System.Drawing.Point(816, 119);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModule.TabIndex = 32;
            this.btnDeleteModule.Text = "Удалить";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(653, 119);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(75, 23);
            this.btnAddModule.TabIndex = 31;
            this.btnAddModule.Text = "Добавить";
            this.btnAddModule.UseVisualStyleBackColor = true;
            // 
            // nudModuleId
            // 
            this.nudModuleId.Location = new System.Drawing.Point(732, 19);
            this.nudModuleId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudModuleId.Name = "nudModuleId";
            this.nudModuleId.Size = new System.Drawing.Size(145, 20);
            this.nudModuleId.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Id:";
            // 
            // tbModuleName
            // 
            this.tbModuleName.Location = new System.Drawing.Point(716, 48);
            this.tbModuleName.Name = "tbModuleName";
            this.tbModuleName.Size = new System.Drawing.Size(162, 20);
            this.tbModuleName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Название:";
            // 
            // lbModules
            // 
            this.lbModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbModules.Location = new System.Drawing.Point(459, 9);
            this.lbModules.Name = "lbModules";
            this.lbModules.Size = new System.Drawing.Size(185, 215);
            this.lbModules.TabIndex = 26;
            this.lbModules.Text = "Модули:";
            this.lbModules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 287);
            this.label5.TabIndex = 43;
            this.label5.Text = "Программы:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnProgramEdit
            // 
            this.btnProgramEdit.Location = new System.Drawing.Point(452, 345);
            this.btnProgramEdit.Name = "btnProgramEdit";
            this.btnProgramEdit.Size = new System.Drawing.Size(75, 23);
            this.btnProgramEdit.TabIndex = 47;
            this.btnProgramEdit.Text = "Изменить";
            this.btnProgramEdit.UseVisualStyleBackColor = true;
            this.btnProgramEdit.Click += new System.EventHandler(this.btnProgramEdit_Click);
            // 
            // btnProgramLoad
            // 
            this.btnProgramLoad.Location = new System.Drawing.Point(371, 383);
            this.btnProgramLoad.Name = "btnProgramLoad";
            this.btnProgramLoad.Size = new System.Drawing.Size(75, 23);
            this.btnProgramLoad.TabIndex = 46;
            this.btnProgramLoad.Text = "Загрузить";
            this.btnProgramLoad.UseVisualStyleBackColor = true;
            this.btnProgramLoad.Click += new System.EventHandler(this.btnProgramLoad_Click);
            // 
            // btnProgramDelete
            // 
            this.btnProgramDelete.Location = new System.Drawing.Point(534, 345);
            this.btnProgramDelete.Name = "btnProgramDelete";
            this.btnProgramDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProgramDelete.TabIndex = 45;
            this.btnProgramDelete.Text = "Удалить";
            this.btnProgramDelete.UseVisualStyleBackColor = true;
            this.btnProgramDelete.Click += new System.EventHandler(this.btnProgramDelete_Click);
            // 
            // btnProgramAdd
            // 
            this.btnProgramAdd.Location = new System.Drawing.Point(371, 345);
            this.btnProgramAdd.Name = "btnProgramAdd";
            this.btnProgramAdd.Size = new System.Drawing.Size(75, 23);
            this.btnProgramAdd.TabIndex = 44;
            this.btnProgramAdd.Text = "Добавить";
            this.btnProgramAdd.UseVisualStyleBackColor = true;
            this.btnProgramAdd.Click += new System.EventHandler(this.btnProgramAdd_Click);
            // 
            // nudProgramId
            // 
            this.nudProgramId.Location = new System.Drawing.Point(450, 275);
            this.nudProgramId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudProgramId.Name = "nudProgramId";
            this.nudProgramId.Size = new System.Drawing.Size(145, 20);
            this.nudProgramId.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Id:";
            // 
            // tbProgramName
            // 
            this.tbProgramName.Location = new System.Drawing.Point(434, 304);
            this.tbProgramName.Name = "tbProgramName";
            this.tbProgramName.Size = new System.Drawing.Size(162, 20);
            this.tbProgramName.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Название:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 573);
            this.Controls.Add(this.nudProgramId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbProgramName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProgramEdit);
            this.Controls.Add(this.btnProgramLoad);
            this.Controls.Add(this.btnProgramDelete);
            this.Controls.Add(this.btnProgramAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSmallProgrammsClear);
            this.Controls.Add(this.btnModuleEdit);
            this.Controls.Add(this.btnLoadModule);
            this.Controls.Add(this.btnSmallProgramDelete);
            this.Controls.Add(this.btnSmallProgramAdd);
            this.Controls.Add(this.nudSmallProgramRowsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSmallProgramName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSmallPrograms);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.nudModuleId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbModuleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbModules);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программные модули";
            ((System.ComponentModel.ISupportInitialize)(this.nudSmallProgramRowsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModuleId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProgramId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmallProgrammsClear;
        private System.Windows.Forms.Button btnModuleEdit;
        private System.Windows.Forms.Button btnLoadModule;
        private System.Windows.Forms.Button btnSmallProgramDelete;
        private System.Windows.Forms.Button btnSmallProgramAdd;
        private System.Windows.Forms.NumericUpDown nudSmallProgramRowsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSmallProgramName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSmallPrograms;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.NumericUpDown nudModuleId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModuleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbModules;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProgramEdit;
        private System.Windows.Forms.Button btnProgramLoad;
        private System.Windows.Forms.Button btnProgramDelete;
        private System.Windows.Forms.Button btnProgramAdd;
        private System.Windows.Forms.NumericUpDown nudProgramId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProgramName;
        private System.Windows.Forms.Label label7;
    }
}

