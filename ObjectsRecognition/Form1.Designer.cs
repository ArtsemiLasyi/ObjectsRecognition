
namespace ObjectsRecognition
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbEntities = new System.Windows.Forms.PictureBox();
            this.bbGenerate = new System.Windows.Forms.Button();
            this.lbEntitiesNumber = new System.Windows.Forms.Label();
            this.lbClustersNumber = new System.Windows.Forms.Label();
            this.tbClustersNumber = new System.Windows.Forms.TextBox();
            this.tbEntitiesNumber = new System.Windows.Forms.TextBox();
            this.bbClear = new System.Windows.Forms.Button();
            this.lbAlgorithm = new System.Windows.Forms.Label();
            this.cbAlgorithm = new System.Windows.Forms.ComboBox();
            this.lbIteration = new System.Windows.Forms.Label();
            this.lbIterationValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntities)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEntities
            // 
            this.pbEntities.Location = new System.Drawing.Point(240, 2);
            this.pbEntities.Name = "pbEntities";
            this.pbEntities.Size = new System.Drawing.Size(1206, 770);
            this.pbEntities.TabIndex = 0;
            this.pbEntities.TabStop = false;
            // 
            // bbGenerate
            // 
            this.bbGenerate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bbGenerate.Location = new System.Drawing.Point(8, 236);
            this.bbGenerate.Name = "bbGenerate";
            this.bbGenerate.Size = new System.Drawing.Size(226, 36);
            this.bbGenerate.TabIndex = 1;
            this.bbGenerate.Text = "Сгенерировать";
            this.bbGenerate.UseVisualStyleBackColor = true;
            this.bbGenerate.Click += new System.EventHandler(this.bbGenerate_Click);
            // 
            // lbEntitiesNumber
            // 
            this.lbEntitiesNumber.AutoSize = true;
            this.lbEntitiesNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEntitiesNumber.Location = new System.Drawing.Point(8, 88);
            this.lbEntitiesNumber.Name = "lbEntitiesNumber";
            this.lbEntitiesNumber.Size = new System.Drawing.Size(206, 24);
            this.lbEntitiesNumber.TabIndex = 2;
            this.lbEntitiesNumber.Text = "Количество образов:";
            // 
            // lbClustersNumber
            // 
            this.lbClustersNumber.AutoSize = true;
            this.lbClustersNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClustersNumber.Location = new System.Drawing.Point(8, 157);
            this.lbClustersNumber.Name = "lbClustersNumber";
            this.lbClustersNumber.Size = new System.Drawing.Size(204, 24);
            this.lbClustersNumber.TabIndex = 3;
            this.lbClustersNumber.Text = "Количество классов:";
            // 
            // tbClustersNumber
            // 
            this.tbClustersNumber.Enabled = false;
            this.tbClustersNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbClustersNumber.Location = new System.Drawing.Point(8, 180);
            this.tbClustersNumber.Name = "tbClustersNumber";
            this.tbClustersNumber.Size = new System.Drawing.Size(226, 32);
            this.tbClustersNumber.TabIndex = 4;
            this.tbClustersNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbClustersNumber_KeyDown);
            this.tbClustersNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClustersNumber_KeyPress);
            // 
            // tbEntitiesNumber
            // 
            this.tbEntitiesNumber.Enabled = false;
            this.tbEntitiesNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEntitiesNumber.Location = new System.Drawing.Point(8, 111);
            this.tbEntitiesNumber.Name = "tbEntitiesNumber";
            this.tbEntitiesNumber.Size = new System.Drawing.Size(226, 32);
            this.tbEntitiesNumber.TabIndex = 5;
            this.tbEntitiesNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEntitiesNumber_KeyDown);
            this.tbEntitiesNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEntitiesNumber_KeyPress);
            // 
            // bbClear
            // 
            this.bbClear.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bbClear.Location = new System.Drawing.Point(8, 316);
            this.bbClear.Name = "bbClear";
            this.bbClear.Size = new System.Drawing.Size(226, 36);
            this.bbClear.TabIndex = 6;
            this.bbClear.Text = "Очистить";
            this.bbClear.UseVisualStyleBackColor = true;
            this.bbClear.Click += new System.EventHandler(this.bbClear_Click);
            // 
            // lbAlgorithm
            // 
            this.lbAlgorithm.AutoSize = true;
            this.lbAlgorithm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAlgorithm.Location = new System.Drawing.Point(8, 13);
            this.lbAlgorithm.Name = "lbAlgorithm";
            this.lbAlgorithm.Size = new System.Drawing.Size(105, 24);
            this.lbAlgorithm.TabIndex = 7;
            this.lbAlgorithm.Text = "Алгоритм:";
            // 
            // cbAlgorithm
            // 
            this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgorithm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbAlgorithm.FormattingEnabled = true;
            this.cbAlgorithm.Location = new System.Drawing.Point(8, 36);
            this.cbAlgorithm.Name = "cbAlgorithm";
            this.cbAlgorithm.Size = new System.Drawing.Size(226, 32);
            this.cbAlgorithm.TabIndex = 8;
            this.cbAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbAlgorithm_SelectedIndexChanged);
            // 
            // lbIteration
            // 
            this.lbIteration.AutoSize = true;
            this.lbIteration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIteration.Location = new System.Drawing.Point(8, 421);
            this.lbIteration.Name = "lbIteration";
            this.lbIteration.Size = new System.Drawing.Size(105, 24);
            this.lbIteration.TabIndex = 11;
            this.lbIteration.Text = "Итерация:";
            // 
            // lbIterationValue
            // 
            this.lbIterationValue.AutoSize = true;
            this.lbIterationValue.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIterationValue.Location = new System.Drawing.Point(116, 421);
            this.lbIterationValue.Name = "lbIterationValue";
            this.lbIterationValue.Size = new System.Drawing.Size(0, 24);
            this.lbIterationValue.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1428, 773);
            this.Controls.Add(this.lbIterationValue);
            this.Controls.Add(this.lbIteration);
            this.Controls.Add(this.cbAlgorithm);
            this.Controls.Add(this.lbAlgorithm);
            this.Controls.Add(this.bbClear);
            this.Controls.Add(this.tbEntitiesNumber);
            this.Controls.Add(this.tbClustersNumber);
            this.Controls.Add(this.lbClustersNumber);
            this.Controls.Add(this.lbEntitiesNumber);
            this.Controls.Add(this.bbGenerate);
            this.Controls.Add(this.pbEntities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Алгоритмы распознавания образов";
            ((System.ComponentModel.ISupportInitialize)(this.pbEntities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEntities;
        private System.Windows.Forms.Button bbGenerate;
        private System.Windows.Forms.Label lbEntitiesNumber;
        private System.Windows.Forms.Label lbClustersNumber;
        private System.Windows.Forms.TextBox tbClustersNumber;
        private System.Windows.Forms.TextBox tbEntitiesNumber;
        private System.Windows.Forms.Button bbClear;
        private System.Windows.Forms.Label lbAlgorithm;
        private System.Windows.Forms.ComboBox cbAlgorithm;
        private System.Windows.Forms.Label lbIteration;
        private System.Windows.Forms.Label lbIterationValue;
    }
}

