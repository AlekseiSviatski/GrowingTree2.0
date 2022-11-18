﻿
namespace GrowingTree2._0
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
            this.cbTreeName = new System.Windows.Forms.ComboBox();
            this.dgvTreeInfo = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrunkLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCrownVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbArtuhov = new System.Windows.Forms.RadioButton();
            this.rbSviatski = new System.Windows.Forms.RadioButton();
            this.rbKoshel = new System.Windows.Forms.RadioButton();
            this.gbWaterers = new System.Windows.Forms.GroupBox();
            this.bGrow = new System.Windows.Forms.Button();
            this.gbAddNewTree = new System.Windows.Forms.GroupBox();
            this.bRefresh = new System.Windows.Forms.Button();
            this.bAddNewTree = new System.Windows.Forms.Button();
            this.lbCrownVolume = new System.Windows.Forms.Label();
            this.lbTrunkLength = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbCrownVolume = new System.Windows.Forms.TextBox();
            this.tbTrunkLength = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbChoice = new System.Windows.Forms.Label();
            this.dgvPersonsInfo = new System.Windows.Forms.DataGridView();
            this.dgvPersonsInfoArtuhov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPersonsInfoKoshel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPersonsInfoSviatski = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeInfo)).BeginInit();
            this.gbWaterers.SuspendLayout();
            this.gbAddNewTree.SuspendLayout();
            this.gbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTreeName
            // 
            this.cbTreeName.DisplayMember = "ID";
            this.cbTreeName.FormattingEnabled = true;
            this.cbTreeName.Location = new System.Drawing.Point(121, 122);
            this.cbTreeName.Name = "cbTreeName";
            this.cbTreeName.Size = new System.Drawing.Size(198, 21);
            this.cbTreeName.TabIndex = 1;
            this.cbTreeName.ValueMember = "ID";
            this.cbTreeName.SelectedIndexChanged += new System.EventHandler(this.cbTreeName_SelectedIndexChanged);
            // 
            // dgvTreeInfo
            // 
            this.dgvTreeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTreeInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvTreeInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTreeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName,
            this.dgvAge,
            this.dgvTrunkLength,
            this.dgvCrownVolume});
            this.dgvTreeInfo.Location = new System.Drawing.Point(12, 157);
            this.dgvTreeInfo.Name = "dgvTreeInfo";
            this.dgvTreeInfo.Size = new System.Drawing.Size(482, 43);
            this.dgvTreeInfo.TabIndex = 2;
            // 
            // dgvName
            // 
            this.dgvName.HeaderText = "Название";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvName.Width = 82;
            // 
            // dgvAge
            // 
            this.dgvAge.HeaderText = "Возраст (лет)";
            this.dgvAge.Name = "dgvAge";
            this.dgvAge.ReadOnly = true;
            this.dgvAge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvTrunkLength
            // 
            this.dgvTrunkLength.HeaderText = "Длинна ствола (м)";
            this.dgvTrunkLength.Name = "dgvTrunkLength";
            this.dgvTrunkLength.ReadOnly = true;
            this.dgvTrunkLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrunkLength.Width = 126;
            // 
            // dgvCrownVolume
            // 
            this.dgvCrownVolume.HeaderText = "Объем кроны (м3)";
            this.dgvCrownVolume.Name = "dgvCrownVolume";
            this.dgvCrownVolume.ReadOnly = true;
            this.dgvCrownVolume.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCrownVolume.Width = 125;
            // 
            // rbArtuhov
            // 
            this.rbArtuhov.AutoSize = true;
            this.rbArtuhov.Checked = true;
            this.rbArtuhov.Location = new System.Drawing.Point(6, 19);
            this.rbArtuhov.Name = "rbArtuhov";
            this.rbArtuhov.Size = new System.Drawing.Size(182, 17);
            this.rbArtuhov.TabIndex = 3;
            this.rbArtuhov.TabStop = true;
            this.rbArtuhov.Text = "Артюхов Александр Сергеевич";
            this.rbArtuhov.UseVisualStyleBackColor = true;
            // 
            // rbSviatski
            // 
            this.rbSviatski.AutoSize = true;
            this.rbSviatski.Location = new System.Drawing.Point(5, 65);
            this.rbSviatski.Name = "rbSviatski";
            this.rbSviatski.Size = new System.Drawing.Size(183, 17);
            this.rbSviatski.TabIndex = 4;
            this.rbSviatski.Text = "Святский Алексей Николаевич";
            this.rbSviatski.UseVisualStyleBackColor = true;
            // 
            // rbKoshel
            // 
            this.rbKoshel.AutoSize = true;
            this.rbKoshel.Location = new System.Drawing.Point(6, 42);
            this.rbKoshel.Name = "rbKoshel";
            this.rbKoshel.Size = new System.Drawing.Size(153, 17);
            this.rbKoshel.TabIndex = 5;
            this.rbKoshel.TabStop = true;
            this.rbKoshel.Text = "Кошель Егор Викторович";
            this.rbKoshel.UseVisualStyleBackColor = true;
            // 
            // gbWaterers
            // 
            this.gbWaterers.Controls.Add(this.rbSviatski);
            this.gbWaterers.Controls.Add(this.rbArtuhov);
            this.gbWaterers.Controls.Add(this.rbKoshel);
            this.gbWaterers.Location = new System.Drawing.Point(6, 11);
            this.gbWaterers.Name = "gbWaterers";
            this.gbWaterers.Size = new System.Drawing.Size(313, 100);
            this.gbWaterers.TabIndex = 6;
            this.gbWaterers.TabStop = false;
            // 
            // bGrow
            // 
            this.bGrow.Location = new System.Drawing.Point(6, 149);
            this.bGrow.Name = "bGrow";
            this.bGrow.Size = new System.Drawing.Size(313, 39);
            this.bGrow.TabIndex = 7;
            this.bGrow.Text = "Полить дерево (+1 год)";
            this.bGrow.UseVisualStyleBackColor = true;
            this.bGrow.Click += new System.EventHandler(this.bGrow_Click);
            // 
            // gbAddNewTree
            // 
            this.gbAddNewTree.Controls.Add(this.bRefresh);
            this.gbAddNewTree.Controls.Add(this.bAddNewTree);
            this.gbAddNewTree.Controls.Add(this.lbCrownVolume);
            this.gbAddNewTree.Controls.Add(this.lbTrunkLength);
            this.gbAddNewTree.Controls.Add(this.lbAge);
            this.gbAddNewTree.Controls.Add(this.lbName);
            this.gbAddNewTree.Controls.Add(this.tbCrownVolume);
            this.gbAddNewTree.Controls.Add(this.tbTrunkLength);
            this.gbAddNewTree.Controls.Add(this.tbAge);
            this.gbAddNewTree.Controls.Add(this.tbName);
            this.gbAddNewTree.Location = new System.Drawing.Point(12, 12);
            this.gbAddNewTree.Name = "gbAddNewTree";
            this.gbAddNewTree.Size = new System.Drawing.Size(482, 138);
            this.gbAddNewTree.TabIndex = 9;
            this.gbAddNewTree.TabStop = false;
            this.gbAddNewTree.Text = "Добавление нового дерева";
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(308, 71);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(113, 46);
            this.bRefresh.TabIndex = 9;
            this.bRefresh.Text = "Обновить";
            this.bRefresh.UseVisualStyleBackColor = true;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // bAddNewTree
            // 
            this.bAddNewTree.Location = new System.Drawing.Point(308, 19);
            this.bAddNewTree.Name = "bAddNewTree";
            this.bAddNewTree.Size = new System.Drawing.Size(113, 46);
            this.bAddNewTree.TabIndex = 8;
            this.bAddNewTree.Text = "Добавить дерево";
            this.bAddNewTree.UseVisualStyleBackColor = true;
            this.bAddNewTree.Click += new System.EventHandler(this.bAddNewTree_Click);
            // 
            // lbCrownVolume
            // 
            this.lbCrownVolume.AutoSize = true;
            this.lbCrownVolume.Location = new System.Drawing.Point(6, 100);
            this.lbCrownVolume.Name = "lbCrownVolume";
            this.lbCrownVolume.Size = new System.Drawing.Size(80, 13);
            this.lbCrownVolume.TabIndex = 7;
            this.lbCrownVolume.Text = "Объем кроны:";
            // 
            // lbTrunkLength
            // 
            this.lbTrunkLength.AutoSize = true;
            this.lbTrunkLength.Location = new System.Drawing.Point(6, 74);
            this.lbTrunkLength.Name = "lbTrunkLength";
            this.lbTrunkLength.Size = new System.Drawing.Size(87, 13);
            this.lbTrunkLength.TabIndex = 6;
            this.lbTrunkLength.Text = "Длинна ствола:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(6, 48);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(52, 13);
            this.lbAge.TabIndex = 5;
            this.lbAge.Text = "Возраст:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 22);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Название:";
            // 
            // tbCrownVolume
            // 
            this.tbCrownVolume.Location = new System.Drawing.Point(127, 97);
            this.tbCrownVolume.Name = "tbCrownVolume";
            this.tbCrownVolume.Size = new System.Drawing.Size(83, 20);
            this.tbCrownVolume.TabIndex = 3;
            // 
            // tbTrunkLength
            // 
            this.tbTrunkLength.Location = new System.Drawing.Point(127, 71);
            this.tbTrunkLength.Name = "tbTrunkLength";
            this.tbTrunkLength.Size = new System.Drawing.Size(83, 20);
            this.tbTrunkLength.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(127, 45);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(83, 20);
            this.tbAge.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(127, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(83, 20);
            this.tbName.TabIndex = 0;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.button1);
            this.gbActions.Controls.Add(this.lbChoice);
            this.gbActions.Controls.Add(this.bGrow);
            this.gbActions.Controls.Add(this.gbWaterers);
            this.gbActions.Controls.Add(this.cbTreeName);
            this.gbActions.Location = new System.Drawing.Point(500, 12);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(325, 251);
            this.gbActions.TabIndex = 10;
            this.gbActions.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Вывести информацию о количестве поливов";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbChoice
            // 
            this.lbChoice.AutoSize = true;
            this.lbChoice.Location = new System.Drawing.Point(6, 125);
            this.lbChoice.Name = "lbChoice";
            this.lbChoice.Size = new System.Drawing.Size(109, 13);
            this.lbChoice.TabIndex = 9;
            this.lbChoice.Text = "Дерево для полива:";
            // 
            // dgvPersonsInfo
            // 
            this.dgvPersonsInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPersonsInfo.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonsInfo.ColumnHeadersHeight = 34;
            this.dgvPersonsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersonsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPersonsInfoArtuhov,
            this.dgvPersonsInfoKoshel,
            this.dgvPersonsInfoSviatski});
            this.dgvPersonsInfo.Location = new System.Drawing.Point(12, 206);
            this.dgvPersonsInfo.Name = "dgvPersonsInfo";
            this.dgvPersonsInfo.Size = new System.Drawing.Size(482, 57);
            this.dgvPersonsInfo.TabIndex = 8;
            // 
            // dgvPersonsInfoArtuhov
            // 
            this.dgvPersonsInfoArtuhov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPersonsInfoArtuhov.HeaderText = "Кол-во поливов Артюхов А.С.";
            this.dgvPersonsInfoArtuhov.Name = "dgvPersonsInfoArtuhov";
            this.dgvPersonsInfoArtuhov.Width = 146;
            // 
            // dgvPersonsInfoKoshel
            // 
            this.dgvPersonsInfoKoshel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPersonsInfoKoshel.HeaderText = "Кол-во поливов Кошель Е.В.";
            this.dgvPersonsInfoKoshel.Name = "dgvPersonsInfoKoshel";
            this.dgvPersonsInfoKoshel.Width = 142;
            // 
            // dgvPersonsInfoSviatski
            // 
            this.dgvPersonsInfoSviatski.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPersonsInfoSviatski.HeaderText = "Кол-во поливов Святский А.Н.";
            this.dgvPersonsInfoSviatski.Name = "dgvPersonsInfoSviatski";
            this.dgvPersonsInfoSviatski.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(837, 271);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.gbAddNewTree);
            this.Controls.Add(this.dgvPersonsInfo);
            this.Controls.Add(this.dgvTreeInfo);
            this.Name = "Form1";
            this.Text = "Growing tree 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeInfo)).EndInit();
            this.gbWaterers.ResumeLayout(false);
            this.gbWaterers.PerformLayout();
            this.gbAddNewTree.ResumeLayout(false);
            this.gbAddNewTree.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTreeName;
        private System.Windows.Forms.DataGridView dgvTreeInfo;
        private System.Windows.Forms.RadioButton rbArtuhov;
        private System.Windows.Forms.RadioButton rbSviatski;
        private System.Windows.Forms.RadioButton rbKoshel;
        private System.Windows.Forms.GroupBox gbWaterers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrunkLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCrownVolume;
        private System.Windows.Forms.Button bGrow;
        private System.Windows.Forms.GroupBox gbAddNewTree;
        private System.Windows.Forms.Button bAddNewTree;
        private System.Windows.Forms.Label lbCrownVolume;
        private System.Windows.Forms.Label lbTrunkLength;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbCrownVolume;
        private System.Windows.Forms.TextBox tbTrunkLength;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Label lbChoice;
        private System.Windows.Forms.DataGridView dgvPersonsInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPersonsInfoArtuhov;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPersonsInfoKoshel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPersonsInfoSviatski;
        private System.Windows.Forms.Button bRefresh;
    }
}
