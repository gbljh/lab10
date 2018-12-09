namespace Lab10
{
    partial class ArtistForm
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
            this.labelGenre = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.ArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxArtname = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 21);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "Жанр:";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ArtistBindingSource, "Genre", true));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(115, 18);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenre.TabIndex = 1;
            // 
            // ArtistBindingSource
            // 
            this.ArtistBindingSource.DataSource = typeof(LibArtist.Artist);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 188);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(149, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 78);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Ім\'я:";
            // 
            // textBoxArtname
            // 
            this.textBoxArtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArtistBindingSource, "ArtName", true));
            this.textBoxArtname.Location = new System.Drawing.Point(115, 75);
            this.textBoxArtname.Name = "textBoxArtname";
            this.textBoxArtname.Size = new System.Drawing.Size(121, 20);
            this.textBoxArtname.TabIndex = 3;
            this.textBoxArtname.Text = "Олексій";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ArtistBindingSource, "Country", true));
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(115, 45);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 2;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(12, 48);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(44, 13);
            this.labelCountry.TabIndex = 7;
            this.labelCountry.Text = "Країна:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArtistBindingSource, "Surname", true));
            this.textBoxSurname.Location = new System.Drawing.Point(115, 101);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(121, 20);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.Text = "Стокроцький";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 104);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(59, 13);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Прізвище:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 130);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(149, 13);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Кількість людей на концерті";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 156);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(75, 13);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Ціна конерту:";
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ArtistBindingSource, "Count", true));
            this.numericUpDownCount.Location = new System.Drawing.Point(181, 127);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownCount.TabIndex = 5;
            this.numericUpDownCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ArtistBindingSource, "Price", true));
            this.numericUpDownPrice.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPrice.Location = new System.Drawing.Point(181, 154);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownPrice.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownPrice.TabIndex = 6;
            this.numericUpDownPrice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxArtname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ArtistForm";
            this.Text = "Артист";
            ((System.ComponentModel.ISupportInitialize)(this.ArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxArtname;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.BindingSource ArtistBindingSource;
    }
}