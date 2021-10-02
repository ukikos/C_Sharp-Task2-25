
namespace Task2_25
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openWithReplacementButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.replaceWordLabel = new System.Windows.Forms.Label();
            this.replaceWordTextBox = new System.Windows.Forms.TextBox();
            this.replaceByLabel = new System.Windows.Forms.Label();
            this.replaceByTextBox = new System.Windows.Forms.TextBox();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(776, 516);
            this.textBox.TabIndex = 0;
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.Location = new System.Drawing.Point(12, 552);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(174, 52);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "Открыть файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.Location = new System.Drawing.Point(596, 552);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(192, 52);
            this.saveFileButton.TabIndex = 2;
            this.saveFileButton.Text = "Сохранить как...";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openWithReplacementButton
            // 
            this.openWithReplacementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openWithReplacementButton.Location = new System.Drawing.Point(846, 286);
            this.openWithReplacementButton.Name = "openWithReplacementButton";
            this.openWithReplacementButton.Size = new System.Drawing.Size(286, 66);
            this.openWithReplacementButton.TabIndex = 3;
            this.openWithReplacementButton.Text = "Открыть с заменой";
            this.openWithReplacementButton.UseVisualStyleBackColor = true;
            this.openWithReplacementButton.Click += new System.EventHandler(this.openWithReplacementButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceButton.Location = new System.Drawing.Point(846, 192);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(286, 66);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Заменить";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // replaceWordLabel
            // 
            this.replaceWordLabel.AutoSize = true;
            this.replaceWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceWordLabel.Location = new System.Drawing.Point(842, 46);
            this.replaceWordLabel.Name = "replaceWordLabel";
            this.replaceWordLabel.Size = new System.Drawing.Size(85, 20);
            this.replaceWordLabel.TabIndex = 5;
            this.replaceWordLabel.Text = "Заменить";
            // 
            // replaceWordTextBox
            // 
            this.replaceWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceWordTextBox.Location = new System.Drawing.Point(846, 69);
            this.replaceWordTextBox.Name = "replaceWordTextBox";
            this.replaceWordTextBox.Size = new System.Drawing.Size(286, 26);
            this.replaceWordTextBox.TabIndex = 6;
            // 
            // replaceByLabel
            // 
            this.replaceByLabel.AutoSize = true;
            this.replaceByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceByLabel.Location = new System.Drawing.Point(842, 110);
            this.replaceByLabel.Name = "replaceByLabel";
            this.replaceByLabel.Size = new System.Drawing.Size(27, 20);
            this.replaceByLabel.TabIndex = 7;
            this.replaceByLabel.Text = "на";
            // 
            // replaceByTextBox
            // 
            this.replaceByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceByTextBox.Location = new System.Drawing.Point(846, 133);
            this.replaceByTextBox.Name = "replaceByTextBox";
            this.replaceByTextBox.Size = new System.Drawing.Size(286, 26);
            this.replaceByTextBox.TabIndex = 8;
            // 
            // overwriteButton
            // 
            this.overwriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overwriteButton.Location = new System.Drawing.Point(846, 376);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(286, 65);
            this.overwriteButton.TabIndex = 9;
            this.overwriteButton.Text = "Открыть с заменой и перезаписать";
            this.overwriteButton.UseVisualStyleBackColor = true;
            this.overwriteButton.Click += new System.EventHandler(this.overwriteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(298, 552);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(196, 52);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 616);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.overwriteButton);
            this.Controls.Add(this.replaceByTextBox);
            this.Controls.Add(this.replaceByLabel);
            this.Controls.Add(this.replaceWordTextBox);
            this.Controls.Add(this.replaceWordLabel);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.openWithReplacementButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openWithReplacementButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Label replaceWordLabel;
        private System.Windows.Forms.TextBox replaceWordTextBox;
        private System.Windows.Forms.Label replaceByLabel;
        private System.Windows.Forms.TextBox replaceByTextBox;
        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button saveButton;
    }
}

