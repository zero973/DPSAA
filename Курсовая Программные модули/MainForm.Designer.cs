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
            this.lbMyPrograms = new System.Windows.Forms.Label();
            this.btnProgramEdit = new System.Windows.Forms.Button();
            this.btnProgramLoad = new System.Windows.Forms.Button();
            this.btnProgramDelete = new System.Windows.Forms.Button();
            this.btnProgramAdd = new System.Windows.Forms.Button();
            this.nudSmallProgramsId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProgramName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImportData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEditSmallProg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmallProgramRowsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModuleId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSmallProgramsId)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSmallProgrammsClear
            // 
            this.btnSmallProgrammsClear.Location = new System.Drawing.Point(206, 148);
            this.btnSmallProgrammsClear.Name = "btnSmallProgrammsClear";
            this.btnSmallProgrammsClear.Size = new System.Drawing.Size(75, 23);
            this.btnSmallProgrammsClear.TabIndex = 42;
            this.btnSmallProgrammsClear.Text = "Очистить";
            this.btnSmallProgrammsClear.UseVisualStyleBackColor = true;
            this.btnSmallProgrammsClear.Click += new System.EventHandler(this.btnSmallProgrammsClear_Click);
            // 
            // btnModuleEdit
            // 
            this.btnModuleEdit.Location = new System.Drawing.Point(734, 119);
            this.btnModuleEdit.Name = "btnModuleEdit";
            this.btnModuleEdit.Size = new System.Drawing.Size(75, 23);
            this.btnModuleEdit.TabIndex = 41;
            this.btnModuleEdit.Text = "Изменить";
            this.btnModuleEdit.UseVisualStyleBackColor = true;
            this.btnModuleEdit.Click += new System.EventHandler(this.btnModuleEdit_Click);
            // 
            // btnLoadModule
            // 
            this.btnLoadModule.Location = new System.Drawing.Point(653, 157);
            this.btnLoadModule.Name = "btnLoadModule";
            this.btnLoadModule.Size = new System.Drawing.Size(156, 23);
            this.btnLoadModule.TabIndex = 40;
            this.btnLoadModule.Text = "Загрузить подпрограммы";
            this.btnLoadModule.UseVisualStyleBackColor = true;
            this.btnLoadModule.Click += new System.EventHandler(this.btnLoadModule_Click);
            // 
            // btnSmallProgramDelete
            // 
            this.btnSmallProgramDelete.Location = new System.Drawing.Point(366, 119);
            this.btnSmallProgramDelete.Name = "btnSmallProgramDelete";
            this.btnSmallProgramDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSmallProgramDelete.TabIndex = 39;
            this.btnSmallProgramDelete.Text = "Удалить";
            this.btnSmallProgramDelete.UseVisualStyleBackColor = true;
            this.btnSmallProgramDelete.Click += new System.EventHandler(this.btnSmallProgramDelete_Click);
            // 
            // btnSmallProgramAdd
            // 
            this.btnSmallProgramAdd.Location = new System.Drawing.Point(206, 119);
            this.btnSmallProgramAdd.Name = "btnSmallProgramAdd";
            this.btnSmallProgramAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSmallProgramAdd.TabIndex = 38;
            this.btnSmallProgramAdd.Text = "Добавить";
            this.btnSmallProgramAdd.UseVisualStyleBackColor = true;
            this.btnSmallProgramAdd.Click += new System.EventHandler(this.btnSmallProgramAdd_Click);
            // 
            // nudSmallProgramRowsCount
            // 
            this.nudSmallProgramRowsCount.Location = new System.Drawing.Point(285, 68);
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
            this.label2.Location = new System.Drawing.Point(203, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Кол-во строк:";
            // 
            // tbSmallProgramName
            // 
            this.tbSmallProgramName.Location = new System.Drawing.Point(287, 40);
            this.tbSmallProgramName.Name = "tbSmallProgramName";
            this.tbSmallProgramName.Size = new System.Drawing.Size(144, 20);
            this.tbSmallProgramName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 43);
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
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(653, 119);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(75, 23);
            this.btnAddModule.TabIndex = 31;
            this.btnAddModule.Text = "Добавить";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // nudModuleId
            // 
            this.nudModuleId.Location = new System.Drawing.Point(716, 19);
            this.nudModuleId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudModuleId.Name = "nudModuleId";
            this.nudModuleId.Size = new System.Drawing.Size(163, 20);
            this.nudModuleId.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Id модуля:";
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
            // lbMyPrograms
            // 
            this.lbMyPrograms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMyPrograms.Location = new System.Drawing.Point(12, 261);
            this.lbMyPrograms.Name = "lbMyPrograms";
            this.lbMyPrograms.Size = new System.Drawing.Size(350, 287);
            this.lbMyPrograms.TabIndex = 43;
            this.lbMyPrograms.Text = "Программы:";
            this.lbMyPrograms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnProgramLoad.Size = new System.Drawing.Size(122, 23);
            this.btnProgramLoad.TabIndex = 46;
            this.btnProgramLoad.Text = "Загрузить модули";
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
            // nudSmallProgramsId
            // 
            this.nudSmallProgramsId.Location = new System.Drawing.Point(287, 14);
            this.nudSmallProgramsId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSmallProgramsId.Name = "nudSmallProgramsId";
            this.nudSmallProgramsId.Size = new System.Drawing.Size(145, 20);
            this.nudSmallProgramsId.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Id программы:";
            // 
            // tbProgramName
            // 
            this.tbProgramName.Location = new System.Drawing.Point(434, 278);
            this.tbProgramName.Name = "tbProgramName";
            this.tbProgramName.Size = new System.Drawing.Size(162, 20);
            this.tbProgramName.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Название:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportData);
            this.groupBox1.Controls.Add(this.btnChooseFile);
            this.groupBox1.Controls.Add(this.tbFilePath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnImportData);
            this.groupBox1.Location = new System.Drawing.Point(653, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 240);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка и выгрузка";
            // 
            // btnExportData
            // 
            this.btnExportData.Location = new System.Drawing.Point(90, 52);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(75, 51);
            this.btnExportData.TabIndex = 51;
            this.btnExportData.Text = "Выгрузить данные в файл";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(201, 18);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(25, 23);
            this.btnChooseFile.TabIndex = 50;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(48, 19);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(147, 20);
            this.tbFilePath.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Файл:";
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(9, 52);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(75, 51);
            this.btnImportData.TabIndex = 47;
            this.btnImportData.Text = "Загрузить данные из файла";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEditSmallProg
            // 
            this.btnEditSmallProg.Location = new System.Drawing.Point(285, 119);
            this.btnEditSmallProg.Name = "btnEditSmallProg";
            this.btnEditSmallProg.Size = new System.Drawing.Size(75, 23);
            this.btnEditSmallProg.TabIndex = 53;
            this.btnEditSmallProg.Text = "Изменить";
            this.btnEditSmallProg.UseVisualStyleBackColor = true;
            this.btnEditSmallProg.Click += new System.EventHandler(this.btnEditSmallProg_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 573);
            this.Controls.Add(this.btnEditSmallProg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudSmallProgramsId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbProgramName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnProgramEdit);
            this.Controls.Add(this.btnProgramLoad);
            this.Controls.Add(this.btnProgramDelete);
            this.Controls.Add(this.btnProgramAdd);
            this.Controls.Add(this.lbMyPrograms);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSmallProgramsId)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbMyPrograms;
        private System.Windows.Forms.Button btnProgramEdit;
        private System.Windows.Forms.Button btnProgramLoad;
        private System.Windows.Forms.Button btnProgramDelete;
        private System.Windows.Forms.Button btnProgramAdd;
        private System.Windows.Forms.NumericUpDown nudSmallProgramsId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbProgramName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEditSmallProg;
    }
}

