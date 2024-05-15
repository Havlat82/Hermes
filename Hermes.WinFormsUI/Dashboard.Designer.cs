namespace Hermes.WinFormsUI
{
    partial class Dashboard
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
            formHeaderLabel = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            callApiButton = new Button();
            resultsText = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeaderLabel
            // 
            formHeaderLabel.AutoSize = true;
            formHeaderLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            formHeaderLabel.Location = new Point(12, 9);
            formHeaderLabel.Name = "formHeaderLabel";
            formHeaderLabel.Size = new Size(694, 60);
            formHeaderLabel.TabIndex = 0;
            formHeaderLabel.Text = "Hermes - A Simple PostMan Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(57, 91);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(77, 41);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API: ";
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(57, 135);
            apiText.Name = "apiText";
            apiText.Size = new Size(818, 47);
            apiText.TabIndex = 3;
            apiText.TextChanged += apiText_TextChanged;
            // 
            // callApiButton
            // 
            callApiButton.Location = new Point(873, 135);
            callApiButton.Name = "callApiButton";
            callApiButton.Size = new Size(100, 47);
            callApiButton.TabIndex = 4;
            callApiButton.Text = "GO!";
            callApiButton.UseVisualStyleBackColor = true;
            callApiButton.Click += callApiButton_Click;
            // 
            // resultsText
            // 
            resultsText.BackColor = Color.White;
            resultsText.BorderStyle = BorderStyle.FixedSingle;
            resultsText.Location = new Point(57, 260);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(916, 239);
            resultsText.TabIndex = 5;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.Transparent;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 535);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1021, 37);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(76, 31);
            systemStatus.Text = "Ready";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(57, 216);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(118, 41);
            resultsLabel.TabIndex = 7;
            resultsLabel.Text = "Results:";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1021, 572);
            Controls.Add(resultsLabel);
            Controls.Add(statusStrip);
            Controls.Add(resultsText);
            Controls.Add(callApiButton);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeaderLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Hermes - A Simple PostMan Clone";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeaderLabel;
        private Label apiLabel;
        private TextBox apiText;
        private Button callApiButton;
        private TextBox resultsText;
        private StatusStrip statusStrip;
        private Label resultsLabel;
        private ToolStripStatusLabel systemStatus;
    }
}
