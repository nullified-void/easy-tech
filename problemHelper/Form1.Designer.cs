namespace problemHelper
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
            this.components = new System.ComponentModel.Container();
            this.ProblemHeaderLabel = new System.Windows.Forms.Label();
            this.ProblemTextLabel = new System.Windows.Forms.Label();
            this.ProblemHeader = new System.Windows.Forms.TextBox();
            this.ProblemText = new System.Windows.Forms.TextBox();
            this.SendBTN = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.сообщитьОПроблемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПриложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProblemHeaderLabel
            // 
            this.ProblemHeaderLabel.AutoSize = true;
            this.ProblemHeaderLabel.Location = new System.Drawing.Point(113, 9);
            this.ProblemHeaderLabel.Name = "ProblemHeaderLabel";
            this.ProblemHeaderLabel.Size = new System.Drawing.Size(116, 13);
            this.ProblemHeaderLabel.TabIndex = 0;
            this.ProblemHeaderLabel.Text = "Заголовок проблемы";
            // 
            // ProblemTextLabel
            // 
            this.ProblemTextLabel.AutoSize = true;
            this.ProblemTextLabel.Location = new System.Drawing.Point(113, 48);
            this.ProblemTextLabel.Name = "ProblemTextLabel";
            this.ProblemTextLabel.Size = new System.Drawing.Size(132, 13);
            this.ProblemTextLabel.TabIndex = 1;
            this.ProblemTextLabel.Text = "Опишите вашу проблему";
            // 
            // ProblemHeader
            // 
            this.ProblemHeader.Location = new System.Drawing.Point(12, 25);
            this.ProblemHeader.Name = "ProblemHeader";
            this.ProblemHeader.Size = new System.Drawing.Size(313, 20);
            this.ProblemHeader.TabIndex = 2;
            // 
            // ProblemText
            // 
            this.ProblemText.Location = new System.Drawing.Point(12, 64);
            this.ProblemText.Multiline = true;
            this.ProblemText.Name = "ProblemText";
            this.ProblemText.Size = new System.Drawing.Size(313, 194);
            this.ProblemText.TabIndex = 2;
            // 
            // SendBTN
            // 
            this.SendBTN.Location = new System.Drawing.Point(136, 264);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(75, 23);
            this.SendBTN.TabIndex = 3;
            this.SendBTN.Text = "Отправить";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сообщитьОПроблемеToolStripMenuItem,
            this.закрытьПриложениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 48);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // сообщитьОПроблемеToolStripMenuItem
            // 
            this.сообщитьОПроблемеToolStripMenuItem.Name = "сообщитьОПроблемеToolStripMenuItem";
            this.сообщитьОПроблемеToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сообщитьОПроблемеToolStripMenuItem.Text = "Сообщить о проблеме";
            this.сообщитьОПроблемеToolStripMenuItem.Click += new System.EventHandler(this.сообщитьОПроблемеToolStripMenuItem_Click);
            // 
            // закрытьПриложениеToolStripMenuItem
            // 
            this.закрытьПриложениеToolStripMenuItem.Name = "закрытьПриложениеToolStripMenuItem";
            this.закрытьПриложениеToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.закрытьПриложениеToolStripMenuItem.Text = "Закрыть приложение";
            this.закрытьПриложениеToolStripMenuItem.Click += new System.EventHandler(this.закрытьПриложениеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 307);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.ProblemText);
            this.Controls.Add(this.ProblemHeader);
            this.Controls.Add(this.ProblemTextLabel);
            this.Controls.Add(this.ProblemHeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProblemHeaderLabel;
        private System.Windows.Forms.Label ProblemTextLabel;
        private System.Windows.Forms.TextBox ProblemHeader;
        private System.Windows.Forms.TextBox ProblemText;
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сообщитьОПроблемеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПриложениеToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

