namespace Motoreport
{
    partial class List_TRP
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
            this.MenuOP = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.GenRpt = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTurn = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInf = new System.Windows.Forms.ToolStripMenuItem();
            this.editTurn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchType = new System.Windows.Forms.ComboBox();
            this.ListRst = new System.Windows.Forms.ListBox();
            this.Grp_TRP = new System.Windows.Forms.GroupBox();
            this.Grp_TP = new System.Windows.Forms.GroupBox();
            this.ListTrP = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MenuOP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Grp_TRP.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOP
            // 
            this.MenuOP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.eToolStripMenuItem,
            this.exitMenu});
            this.MenuOP.Location = new System.Drawing.Point(0, 0);
            this.MenuOP.Name = "MenuOP";
            this.MenuOP.Size = new System.Drawing.Size(784, 24);
            this.MenuOP.TabIndex = 1;
            this.MenuOP.Text = "menuStrip2";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInfo,
            this.GenRpt,
            this.NewTurn});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // newInfo
            // 
            this.newInfo.Name = "newInfo";
            this.newInfo.Size = new System.Drawing.Size(159, 22);
            this.newInfo.Text = "Nuevo Informe";
            // 
            // GenRpt
            // 
            this.GenRpt.Name = "GenRpt";
            this.GenRpt.Size = new System.Drawing.Size(159, 22);
            this.GenRpt.Text = "Generar Reporte";
            // 
            // NewTurn
            // 
            this.NewTurn.Name = "NewTurn";
            this.NewTurn.Size = new System.Drawing.Size(159, 22);
            this.NewTurn.Text = "Nuevo Turno";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInf,
            this.editTurn});
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.eToolStripMenuItem.Text = "Editar";
            // 
            // editInf
            // 
            this.editInf.Name = "editInf";
            this.editInf.Size = new System.Drawing.Size(152, 22);
            this.editInf.Text = "Editar Informe";
            // 
            // editTurn
            // 
            this.editTurn.Name = "editTurn";
            this.editTurn.Size = new System.Drawing.Size(152, 22);
            this.editTurn.Text = "Editar Turno";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(41, 20);
            this.exitMenu.Text = "Salir";
            this.exitMenu.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Busqueda";
            // 
            // searchBox
            // 
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(333, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(425, 32);
            this.searchBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.ListRst);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // searchType
            // 
            this.searchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchType.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchType.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.searchType.FormattingEnabled = true;
            this.searchType.Location = new System.Drawing.Point(187, 50);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(140, 32);
            this.searchType.TabIndex = 5;
            this.searchType.ValueMember = "0";
            // 
            // ListRst
            // 
            this.ListRst.FormattingEnabled = true;
            this.ListRst.ItemHeight = 24;
            this.ListRst.Location = new System.Drawing.Point(6, 25);
            this.ListRst.Name = "ListRst";
            this.ListRst.Size = new System.Drawing.Size(733, 148);
            this.ListRst.TabIndex = 0;
            // 
            // Grp_TRP
            // 
            this.Grp_TRP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Grp_TRP.Controls.Add(this.ListTrP);
            this.Grp_TRP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grp_TRP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_TRP.Location = new System.Drawing.Point(19, 289);
            this.Grp_TRP.Name = "Grp_TRP";
            this.Grp_TRP.Size = new System.Drawing.Size(375, 235);
            this.Grp_TRP.TabIndex = 6;
            this.Grp_TRP.TabStop = false;
            this.Grp_TRP.Text = "Trabajos pendientes";
            // 
            // Grp_TP
            // 
            this.Grp_TP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Grp_TP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grp_TP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grp_TP.Location = new System.Drawing.Point(400, 289);
            this.Grp_TP.Name = "Grp_TP";
            this.Grp_TP.Size = new System.Drawing.Size(372, 261);
            this.Grp_TP.TabIndex = 7;
            this.Grp_TP.TabStop = false;
            this.Grp_TP.Text = "Turnos próximos";
            // 
            // ListTrP
            // 
            this.ListTrP.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListTrP.FormattingEnabled = true;
            this.ListTrP.ItemHeight = 24;
            this.ListTrP.Location = new System.Drawing.Point(6, 28);
            this.ListTrP.Name = "ListTrP";
            this.ListTrP.Size = new System.Drawing.Size(363, 196);
            this.ListTrP.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 530);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // List_TRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Grp_TP);
            this.Controls.Add(this.Grp_TRP);
            this.Controls.Add(this.searchType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuOP);
            this.Name = "List_TRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MotoReport";
            this.MenuOP.ResumeLayout(false);
            this.MenuOP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Grp_TRP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuOP;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInfo;
        private System.Windows.Forms.ToolStripMenuItem GenRpt;
        private System.Windows.Forms.ToolStripMenuItem NewTurn;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInf;
        private System.Windows.Forms.ToolStripMenuItem editTurn;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.ListBox ListRst;
        private System.Windows.Forms.GroupBox Grp_TRP;
        private System.Windows.Forms.GroupBox Grp_TP;
        private System.Windows.Forms.ListBox ListTrP;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

