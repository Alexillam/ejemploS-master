namespace WinFormsApp4
{
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
            btnObtenerProducto = new Button();
            SuspendLayout();
            // 
            // btnObtenerProducto
            // 
            btnObtenerProducto.Location = new Point(332, 185);
            btnObtenerProducto.Name = "btnObtenerProducto";
            btnObtenerProducto.Size = new Size(156, 76);
            btnObtenerProducto.TabIndex = 0;
            btnObtenerProducto.Text = "ObtenerProducto";
            btnObtenerProducto.UseVisualStyleBackColor = true;
            btnObtenerProducto.Click += btnObtenerProducto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnObtenerProducto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnObtenerProducto;
    }
}
