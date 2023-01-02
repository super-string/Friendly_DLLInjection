namespace InjectorApp
{
    partial class InjectorForm
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
            this._buttonInject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonInject
            // 
            this._buttonInject.Location = new System.Drawing.Point(144, 66);
            this._buttonInject.Name = "_buttonInject";
            this._buttonInject.Size = new System.Drawing.Size(150, 46);
            this._buttonInject.TabIndex = 0;
            this._buttonInject.Text = "Inject";
            this._buttonInject.UseVisualStyleBackColor = true;
            this._buttonInject.Click += new System.EventHandler(this._buttonInject_Click);
            // 
            // InjectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 175);
            this.Controls.Add(this._buttonInject);
            this.Name = "InjectorForm";
            this.Text = "InjectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button _buttonInject;
    }
}