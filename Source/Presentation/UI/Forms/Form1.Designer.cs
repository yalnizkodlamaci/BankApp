namespace BankApp.FormApp;

partial class Form1
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
        label3 = new Label();
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        label6 = new Label();
        label7 = new Label();
        textBox4 = new TextBox();
        label4 = new Label();
        label8 = new Label();
        button1 = new Button();
        button2 = new Button();
        pictureBox1 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.FlatStyle = FlatStyle.Popup;
        label3.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(41, 57);
        label3.Name = "label3";
        label3.Size = new Size(166, 28);
        label3.TabIndex = 18;
        label3.Text = "Mevcut Para :";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.FlatStyle = FlatStyle.Popup;
        label1.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(548, 249);
        label1.Name = "label1";
        label1.Size = new Size(119, 28);
        label1.TabIndex = 19;
        label1.Text = "Para Ekle";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.FlatStyle = FlatStyle.Popup;
        label2.Font = new Font("Lucida Bright", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(127, 249);
        label2.Name = "label2";
        label2.Size = new Size(157, 28);
        label2.TabIndex = 20;
        label2.Text = "Para Gönder";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(90, 289);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(231, 23);
        textBox1.TabIndex = 21;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(502, 289);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(231, 23);
        textBox2.TabIndex = 22;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(90, 345);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(231, 23);
        textBox3.TabIndex = 25;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.FlatStyle = FlatStyle.Popup;
        label6.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.Location = new Point(453, 297);
        label6.Name = "label6";
        label6.Size = new Size(43, 15);
        label6.TabIndex = 26;
        label6.Text = "Nakit ";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.FlatStyle = FlatStyle.Popup;
        label7.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label7.Location = new Point(366, 353);
        label7.Name = "label7";
        label7.Size = new Size(130, 15);
        label7.TabIndex = 27;
        label7.Text = "From Another Bank";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(502, 345);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(231, 23);
        textBox4.TabIndex = 28;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.FlatStyle = FlatStyle.Popup;
        label4.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.Location = new Point(41, 292);
        label4.Name = "label4";
        label4.Size = new Size(43, 15);
        label4.TabIndex = 29;
        label4.Text = "Nakit ";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.FlatStyle = FlatStyle.Popup;
        label8.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label8.Location = new Point(41, 353);
        label8.Name = "label8";
        label8.Size = new Size(34, 15);
        label8.TabIndex = 30;
        label8.Text = "Alan";
        // 
        // button1
        // 
        button1.Location = new Point(131, 392);
        button1.Name = "button1";
        button1.Size = new Size(153, 23);
        button1.TabIndex = 31;
        button1.Text = "Transfer This Bank";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(525, 392);
        button2.Name = "button2";
        button2.Size = new Size(194, 23);
        button2.TabIndex = 32;
        button2.Text = "Transfer from Outside Bank";
        button2.UseVisualStyleBackColor = true;
        // 
        // pictureBox1
        // 
        pictureBox1.BackgroundImage = Properties.Resources._20250730_0145_Şık_Y_Logo_simple_compose_01k1c5q78bfq999zbs951ket0z;
        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        pictureBox1.Location = new Point(471, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(284, 223);
        pictureBox1.TabIndex = 33;
        pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(800, 450);
        Controls.Add(pictureBox1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label8);
        Controls.Add(label4);
        Controls.Add(textBox4);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(label3);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label3;
    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Label label6;
    private Label label7;
    private TextBox textBox4;
    private Label label4;
    private Label label8;
    private Button button1;
    private Button button2;
    private PictureBox pictureBox1;
}
