
namespace eDnevnik
{
    partial class Odeljenje
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
            this.labelNaredba = new System.Windows.Forms.Label();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxSR = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelIndeks = new System.Windows.Forms.Label();
            this.labelRazred = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxIndeks = new System.Windows.Forms.TextBox();
            this.textBoxRazred = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxSmer = new System.Windows.Forms.ComboBox();
            this.labelSmer = new System.Windows.Forms.Label();
            this.comboBoxRazredni = new System.Windows.Forms.ComboBox();
            this.comboBoxGodina = new System.Windows.Forms.ComboBox();
            this.labelRazredni = new System.Windows.Forms.Label();
            this.labelGodina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNaredba
            // 
            this.labelNaredba.AutoSize = true;
            this.labelNaredba.BackColor = System.Drawing.Color.Transparent;
            this.labelNaredba.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelNaredba.Location = new System.Drawing.Point(127, 320);
            this.labelNaredba.Name = "labelNaredba";
            this.labelNaredba.Size = new System.Drawing.Size(121, 13);
            this.labelNaredba.TabIndex = 40;
            this.labelNaredba.Text = "Naredba za izvršavanje:";
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonEnd.FlatAppearance.BorderSize = 0;
            this.buttonEnd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEnd.Location = new System.Drawing.Point(533, 457);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(98, 28);
            this.buttonEnd.TabIndex = 39;
            this.buttonEnd.Text = ">>";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonForward.FlatAppearance.BorderSize = 0;
            this.buttonForward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForward.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForward.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonForward.Location = new System.Drawing.Point(429, 457);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(98, 28);
            this.buttonForward.TabIndex = 38;
            this.buttonForward.Text = ">";
            this.buttonForward.UseVisualStyleBackColor = false;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonBackward.FlatAppearance.BorderSize = 0;
            this.buttonBackward.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonBackward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonBackward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackward.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackward.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBackward.Location = new System.Drawing.Point(231, 457);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(98, 28);
            this.buttonBackward.TabIndex = 37;
            this.buttonBackward.Text = "<";
            this.buttonBackward.UseVisualStyleBackColor = false;
            this.buttonBackward.Click += new System.EventHandler(this.buttonBackward_Click);
            // 
            // buttonBegin
            // 
            this.buttonBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonBegin.FlatAppearance.BorderSize = 0;
            this.buttonBegin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonBegin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonBegin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBegin.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBegin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBegin.Location = new System.Drawing.Point(127, 457);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(98, 28);
            this.buttonBegin.TabIndex = 36;
            this.buttonBegin.Text = "<<";
            this.buttonBegin.UseVisualStyleBackColor = false;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxCommand.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBoxCommand.Location = new System.Drawing.Point(127, 346);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(504, 26);
            this.textBoxCommand.TabIndex = 35;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.buttonDelete.Location = new System.Drawing.Point(510, 380);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 37);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "OBRIŠI";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonUpdate.Location = new System.Drawing.Point(320, 380);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(121, 37);
            this.buttonUpdate.TabIndex = 33;
            this.buttonUpdate.Text = "IZMENI";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.buttonInsert.Location = new System.Drawing.Point(127, 378);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(121, 37);
            this.buttonInsert.TabIndex = 32;
            this.buttonInsert.Text = "UBACI";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxSR
            // 
            this.textBoxSR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxSR.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSR.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBoxSR.Location = new System.Drawing.Point(138, 12);
            this.textBoxSR.MaxLength = 20;
            this.textBoxSR.Name = "textBoxSR";
            this.textBoxSR.Size = new System.Drawing.Size(87, 30);
            this.textBoxSR.TabIndex = 44;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSearch.Image = global::eDnevnik.Properties.Resources.search_32;
            this.buttonSearch.Location = new System.Drawing.Point(15, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(38, 37);
            this.buttonSearch.TabIndex = 43;
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(193)))));
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonHelp.Location = new System.Drawing.Point(707, 12);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(81, 23);
            this.buttonHelp.TabIndex = 42;
            this.buttonHelp.Text = "POMOĆ";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // labelIndeks
            // 
            this.labelIndeks.AutoSize = true;
            this.labelIndeks.BackColor = System.Drawing.Color.Transparent;
            this.labelIndeks.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndeks.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelIndeks.Location = new System.Drawing.Point(123, 146);
            this.labelIndeks.Name = "labelIndeks";
            this.labelIndeks.Size = new System.Drawing.Size(68, 22);
            this.labelIndeks.TabIndex = 51;
            this.labelIndeks.Text = "Indeks";
            // 
            // labelRazred
            // 
            this.labelRazred.AutoSize = true;
            this.labelRazred.BackColor = System.Drawing.Color.Transparent;
            this.labelRazred.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazred.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelRazred.Location = new System.Drawing.Point(123, 110);
            this.labelRazred.Name = "labelRazred";
            this.labelRazred.Size = new System.Drawing.Size(73, 22);
            this.labelRazred.TabIndex = 50;
            this.labelRazred.Text = "Razred";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelID.Location = new System.Drawing.Point(473, 110);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 22);
            this.labelID.TabIndex = 49;
            this.labelID.Text = "ID";
            // 
            // textBoxIndeks
            // 
            this.textBoxIndeks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxIndeks.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndeks.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBoxIndeks.Location = new System.Drawing.Point(220, 143);
            this.textBoxIndeks.MaxLength = 20;
            this.textBoxIndeks.Name = "textBoxIndeks";
            this.textBoxIndeks.Size = new System.Drawing.Size(231, 30);
            this.textBoxIndeks.TabIndex = 48;
            // 
            // textBoxRazred
            // 
            this.textBoxRazred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxRazred.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRazred.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBoxRazred.Location = new System.Drawing.Point(220, 107);
            this.textBoxRazred.MaxLength = 20;
            this.textBoxRazred.Name = "textBoxRazred";
            this.textBoxRazred.Size = new System.Drawing.Size(231, 30);
            this.textBoxRazred.TabIndex = 47;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxID.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBoxID.Location = new System.Drawing.Point(510, 107);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(121, 30);
            this.textBoxID.TabIndex = 46;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxSmer
            // 
            this.comboBoxSmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.comboBoxSmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSmer.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSmer.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxSmer.FormattingEnabled = true;
            this.comboBoxSmer.Items.AddRange(new object[] {
            "Prirodni",
            "Informatički"});
            this.comboBoxSmer.Location = new System.Drawing.Point(220, 179);
            this.comboBoxSmer.Name = "comboBoxSmer";
            this.comboBoxSmer.Size = new System.Drawing.Size(231, 30);
            this.comboBoxSmer.TabIndex = 52;
            // 
            // labelSmer
            // 
            this.labelSmer.AutoSize = true;
            this.labelSmer.BackColor = System.Drawing.Color.Transparent;
            this.labelSmer.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmer.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelSmer.Location = new System.Drawing.Point(123, 182);
            this.labelSmer.Name = "labelSmer";
            this.labelSmer.Size = new System.Drawing.Size(56, 22);
            this.labelSmer.TabIndex = 53;
            this.labelSmer.Text = "Smer";
            // 
            // comboBoxRazredni
            // 
            this.comboBoxRazredni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.comboBoxRazredni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRazredni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRazredni.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRazredni.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxRazredni.FormattingEnabled = true;
            this.comboBoxRazredni.Location = new System.Drawing.Point(220, 215);
            this.comboBoxRazredni.Name = "comboBoxRazredni";
            this.comboBoxRazredni.Size = new System.Drawing.Size(231, 30);
            this.comboBoxRazredni.TabIndex = 54;
            // 
            // comboBoxGodina
            // 
            this.comboBoxGodina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.comboBoxGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGodina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGodina.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGodina.ForeColor = System.Drawing.Color.AliceBlue;
            this.comboBoxGodina.FormattingEnabled = true;
            this.comboBoxGodina.Items.AddRange(new object[] {
            "2019/20",
            "2020/21"});
            this.comboBoxGodina.Location = new System.Drawing.Point(220, 251);
            this.comboBoxGodina.Name = "comboBoxGodina";
            this.comboBoxGodina.Size = new System.Drawing.Size(231, 30);
            this.comboBoxGodina.TabIndex = 55;
            // 
            // labelRazredni
            // 
            this.labelRazredni.AutoSize = true;
            this.labelRazredni.BackColor = System.Drawing.Color.Transparent;
            this.labelRazredni.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazredni.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelRazredni.Location = new System.Drawing.Point(123, 218);
            this.labelRazredni.Name = "labelRazredni";
            this.labelRazredni.Size = new System.Drawing.Size(88, 22);
            this.labelRazredni.TabIndex = 56;
            this.labelRazredni.Text = "Razredni";
            // 
            // labelGodina
            // 
            this.labelGodina.AutoSize = true;
            this.labelGodina.BackColor = System.Drawing.Color.Transparent;
            this.labelGodina.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGodina.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelGodina.Location = new System.Drawing.Point(123, 254);
            this.labelGodina.Name = "labelGodina";
            this.labelGodina.Size = new System.Drawing.Size(73, 22);
            this.labelGodina.TabIndex = 57;
            this.labelGodina.Text = "Godina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "Razred";
            // 
            // textBoxSI
            // 
            this.textBoxSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxSI.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSI.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBoxSI.Location = new System.Drawing.Point(305, 12);
            this.textBoxSI.MaxLength = 20;
            this.textBoxSI.Name = "textBoxSI";
            this.textBoxSI.Size = new System.Drawing.Size(87, 30);
            this.textBoxSI.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(231, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 60;
            this.label2.Text = "Indeks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(398, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "Indeks";
            // 
            // textBoxSearchID
            // 
            this.textBoxSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.textBoxSearchID.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchID.ForeColor = System.Drawing.Color.AliceBlue;
            this.textBoxSearchID.Location = new System.Drawing.Point(472, 12);
            this.textBoxSearchID.MaxLength = 20;
            this.textBoxSearchID.Name = "textBoxSearchID";
            this.textBoxSearchID.Size = new System.Drawing.Size(87, 30);
            this.textBoxSearchID.TabIndex = 62;
            // 
            // Odeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(47)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.textBoxSearchID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGodina);
            this.Controls.Add(this.labelRazredni);
            this.Controls.Add(this.comboBoxGodina);
            this.Controls.Add(this.comboBoxRazredni);
            this.Controls.Add(this.labelSmer);
            this.Controls.Add(this.comboBoxSmer);
            this.Controls.Add(this.labelIndeks);
            this.Controls.Add(this.labelRazred);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxIndeks);
            this.Controls.Add(this.textBoxRazred);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxSR);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelNaredba);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBackward);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Odeljenje";
            this.Text = "Odeljenje";
            this.Load += new System.EventHandler(this.Odeljenje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNaredba;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxSR;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelIndeks;
        private System.Windows.Forms.Label labelRazred;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxIndeks;
        private System.Windows.Forms.TextBox textBoxRazred;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxSmer;
        private System.Windows.Forms.Label labelSmer;
        private System.Windows.Forms.ComboBox comboBoxRazredni;
        private System.Windows.Forms.ComboBox comboBoxGodina;
        private System.Windows.Forms.Label labelRazredni;
        private System.Windows.Forms.Label labelGodina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchID;
    }
}