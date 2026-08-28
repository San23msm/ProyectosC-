using System;
using System.Drawing;
using System.Windows.Forms;

partial class Form1
{
    private Button btnSaludar;
    private Label lblMensaje;

    private void InitializeComponent()
    {
        this.btnSaludar = new Button();
        this.lblMensaje = new Label();

        this.Text = "Mi App en VS Code";
        this.Size = new Size(400, 300);
        this.StartPosition = FormStartPosition.CenterScreen;

        this.btnSaludar.Text = "Haz clic";
        this.btnSaludar.Location = new Point(150, 100);
        this.btnSaludar.Click += this.BtnSaludar_Click;

        this.lblMensaje.Text = "";
        this.lblMensaje.Location = new Point(150, 150);
        this.lblMensaje.AutoSize = true;

        this.Controls.Add(this.btnSaludar);
        this.Controls.Add(this.lblMensaje);
    }

    private void BtnSaludar_Click(object sender, EventArgs e)
    {
        this.lblMensaje.Text = "¡Hola desde VS Code!";
    }
}