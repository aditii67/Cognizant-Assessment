namespace KafkaWindowsChat;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private Label lblMessage;
    private RichTextBox rtbMessage;
    private Button btnSend;
    private Button btnCancel;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblMessage = new Label();
        rtbMessage = new RichTextBox();
        btnSend = new Button();
        btnCancel = new Button();

        SuspendLayout();

        //
        // lblMessage
        //
        lblMessage.AutoSize = true;
        lblMessage.Location = new Point(70, 40);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new Size(170, 15);
        lblMessage.Text = "Please Enter your Message Here";

        //
        // rtbMessage
        //
        rtbMessage.Location = new Point(70, 70);
        rtbMessage.Name = "rtbMessage";
        rtbMessage.Size = new Size(360, 200);
        rtbMessage.TabIndex = 0;

        //
        // btnCancel
        //
        btnCancel.Location = new Point(130, 300);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(90, 35);
        btnCancel.TabIndex = 1;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;

        //
        // btnSend
        //
        btnSend.Location = new Point(310, 300);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(90, 35);
        btnSend.TabIndex = 2;
        btnSend.Text = "Send";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;
        

        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 420);

        Controls.Add(lblMessage);
        Controls.Add(rtbMessage);
        Controls.Add(btnCancel);
        Controls.Add(btnSend);

        Name = "Form1";
        Text = "Kafka Windows Chat";

        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
