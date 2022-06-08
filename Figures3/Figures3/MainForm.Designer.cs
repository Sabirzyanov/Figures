/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 3"
    29.05.22
*/

namespace Figures3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.figuresList = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.loadBtn = new System.Windows.Forms.ToolStripButton();
            this.newBtn = new System.Windows.Forms.ToolStripButton();
            this.splitter = new System.Windows.Forms.Splitter();
            this.figureListLabel = new System.Windows.Forms.Label();
            this.colorDialogWindow = new System.Windows.Forms.ColorDialog();
            this.colorSelectBtn = new System.Windows.Forms.Button();
            this.selectedColor = new System.Windows.Forms.Label();
            this.penWidthLabel = new System.Windows.Forms.Label();
            this.penWidthInput = new System.Windows.Forms.TextBox();
            this.saveFileDialogWindow = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogWindow = new System.Windows.Forms.OpenFileDialog();
            this.debugLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // figuresList
            // 
            this.figuresList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figuresList.FormattingEnabled = true;
            this.figuresList.Items.AddRange(new object[] {
            "Line",
            "Triangle",
            "Rectangle",
            "Circle"});
            this.figuresList.Location = new System.Drawing.Point(657, 64);
            this.figuresList.Name = "figuresList";
            this.figuresList.Size = new System.Drawing.Size(133, 27);
            this.figuresList.TabIndex = 1;
            this.figuresList.SelectedIndexChanged += new System.EventHandler(this.figuresList_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.toolMenu);
            this.mainPanel.Controls.Add(this.splitter);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(651, 452);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // toolMenu
            // 
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBtn,
            this.loadBtn,
            this.newBtn});
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(646, 26);
            this.toolMenu.TabIndex = 1;
            this.toolMenu.Text = "toolStrip1";
            // 
            // saveBtn
            // 
            this.saveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(41, 23);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadBtn.Image")));
            this.loadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(43, 23);
            this.loadBtn.Text = "Load";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBtn.Image")));
            this.newBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(40, 23);
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(646, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 452);
            this.splitter.TabIndex = 0;
            this.splitter.TabStop = false;
            // 
            // figureListLabel
            // 
            this.figureListLabel.AutoSize = true;
            this.figureListLabel.Location = new System.Drawing.Point(657, 42);
            this.figureListLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.figureListLabel.Name = "figureListLabel";
            this.figureListLabel.Size = new System.Drawing.Size(87, 19);
            this.figureListLabel.TabIndex = 3;
            this.figureListLabel.Text = "Figure: None";
            // 
            // colorSelectBtn
            // 
            this.colorSelectBtn.Location = new System.Drawing.Point(657, 154);
            this.colorSelectBtn.Name = "colorSelectBtn";
            this.colorSelectBtn.Size = new System.Drawing.Size(123, 34);
            this.colorSelectBtn.TabIndex = 4;
            this.colorSelectBtn.Text = "Color select";
            this.colorSelectBtn.UseVisualStyleBackColor = true;
            this.colorSelectBtn.Click += new System.EventHandler(this.colorSelectBtn_Click);
            // 
            // selectedColor
            // 
            this.selectedColor.AutoSize = true;
            this.selectedColor.Location = new System.Drawing.Point(657, 132);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(131, 19);
            this.selectedColor.TabIndex = 5;
            this.selectedColor.Text = "Selected color: Black";
            // 
            // penWidthLabel
            // 
            this.penWidthLabel.AutoSize = true;
            this.penWidthLabel.Location = new System.Drawing.Point(662, 218);
            this.penWidthLabel.Name = "penWidthLabel";
            this.penWidthLabel.Size = new System.Drawing.Size(72, 19);
            this.penWidthLabel.TabIndex = 6;
            this.penWidthLabel.Text = "Pen width:";
            // 
            // penWidthInput
            // 
            this.penWidthInput.Location = new System.Drawing.Point(662, 240);
            this.penWidthInput.Name = "penWidthInput";
            this.penWidthInput.Size = new System.Drawing.Size(100, 26);
            this.penWidthInput.TabIndex = 7;
            // 
            // openFileDialogWindow
            // 
            this.openFileDialogWindow.FileName = "openFileDialog1";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(662, 299);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(50, 19);
            this.debugLabel.TabIndex = 8;
            this.debugLabel.Text = "Debug";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.penWidthInput);
            this.Controls.Add(this.penWidthLabel);
            this.Controls.Add(this.selectedColor);
            this.Controls.Add(this.colorSelectBtn);
            this.Controls.Add(this.figureListLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.figuresList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox figuresList;
        private Panel mainPanel;
        private Splitter splitter;
        private Label figureListLabel;
        private ColorDialog colorDialogWindow;
        private Button colorSelectBtn;
        private Label selectedColor;
        private Label penWidthLabel;
        private TextBox penWidthInput;
        private ToolStrip toolMenu;
        private ToolStripButton saveBtn;
        private ToolStripButton loadBtn;
        private ToolStripButton newBtn;
        private SaveFileDialog saveFileDialogWindow;
        private OpenFileDialog openFileDialogWindow;
        private Label debugLabel;
    }
}