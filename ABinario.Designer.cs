namespace Arbol
{
    partial class ABinario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mostrarArbol = new TreeView();
            Generar = new Button();
            label1 = new Label();
            BRegresar = new Button();
            Adicion = new Button();
            Busqueda = new Button();
            Eliminacion = new Button();
            inOrden = new Button();
            opciones = new TextBox();
            preOrden = new Button();
            postOrden = new Button();
            resultados = new Label();
            SuspendLayout();
            // 
            // mostrarArbol
            // 
            mostrarArbol.Location = new Point(55, 102);
            mostrarArbol.Name = "mostrarArbol";
            mostrarArbol.Size = new Size(330, 298);
            mostrarArbol.TabIndex = 0;
            mostrarArbol.AfterSelect += treeView1_AfterSelect;
            // 
            // Generar
            // 
            Generar.Location = new Point(198, 61);
            Generar.Name = "Generar";
            Generar.Size = new Size(75, 23);
            Generar.TabIndex = 1;
            Generar.Text = "Generar";
            Generar.UseVisualStyleBackColor = true;
            Generar.Click += Generar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 65);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Arbol inicial: ";
            // 
            // BRegresar
            // 
            BRegresar.Location = new Point(70, 415);
            BRegresar.Name = "BRegresar";
            BRegresar.Size = new Size(75, 23);
            BRegresar.TabIndex = 3;
            BRegresar.Text = "Regresar";
            BRegresar.UseVisualStyleBackColor = true;
            BRegresar.Click += BRegresar_Click;
            // 
            // Adicion
            // 
            Adicion.Location = new Point(455, 102);
            Adicion.Name = "Adicion";
            Adicion.Size = new Size(75, 23);
            Adicion.TabIndex = 4;
            Adicion.Text = "Adicion";
            Adicion.UseVisualStyleBackColor = true;
            Adicion.Click += Adicion_Click;
            // 
            // Busqueda
            // 
            Busqueda.Location = new Point(685, 102);
            Busqueda.Name = "Busqueda";
            Busqueda.Size = new Size(75, 23);
            Busqueda.TabIndex = 5;
            Busqueda.Text = "Busqueda";
            Busqueda.UseVisualStyleBackColor = true;
            Busqueda.Click += Busqueda_Click;
            // 
            // Eliminacion
            // 
            Eliminacion.Location = new Point(566, 102);
            Eliminacion.Name = "Eliminacion";
            Eliminacion.Size = new Size(85, 23);
            Eliminacion.TabIndex = 6;
            Eliminacion.Text = "Eliminacion";
            Eliminacion.UseVisualStyleBackColor = true;
            Eliminacion.Click += Eliminacion_Click;
            // 
            // inOrden
            // 
            inOrden.Location = new Point(455, 142);
            inOrden.Name = "inOrden";
            inOrden.Size = new Size(75, 23);
            inOrden.TabIndex = 7;
            inOrden.Text = "inOrden";
            inOrden.UseVisualStyleBackColor = true;
            inOrden.Click += inOrden_Click;
            // 
            // opciones
            // 
            opciones.Location = new Point(551, 45);
            opciones.Name = "opciones";
            opciones.Size = new Size(100, 23);
            opciones.TabIndex = 8;
            // 
            // preOrden
            // 
            preOrden.Location = new Point(576, 142);
            preOrden.Name = "preOrden";
            preOrden.Size = new Size(75, 23);
            preOrden.TabIndex = 9;
            preOrden.Text = "PreOrden";
            preOrden.UseVisualStyleBackColor = true;
            preOrden.Click += preOrden_Click;
            // 
            // postOrden
            // 
            postOrden.Location = new Point(685, 142);
            postOrden.Name = "postOrden";
            postOrden.Size = new Size(75, 23);
            postOrden.TabIndex = 10;
            postOrden.Text = "PostOrden";
            postOrden.UseVisualStyleBackColor = true;
            postOrden.Click += postOrden_Click;
            // 
            // resultados
            // 
            resultados.AutoSize = true;
            resultados.Location = new Point(551, 180);
            resultados.Name = "resultados";
            resultados.Size = new Size(64, 15);
            resultados.TabIndex = 11;
            resultados.Text = "Resultados";
            // 
            // ABinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shadowtree;
            ClientSize = new Size(800, 450);
            Controls.Add(resultados);
            Controls.Add(postOrden);
            Controls.Add(preOrden);
            Controls.Add(opciones);
            Controls.Add(inOrden);
            Controls.Add(Eliminacion);
            Controls.Add(Busqueda);
            Controls.Add(Adicion);
            Controls.Add(BRegresar);
            Controls.Add(label1);
            Controls.Add(Generar);
            Controls.Add(mostrarArbol);
            Name = "ABinario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABinario";
            Load += ABinario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView mostrarArbol;
        private Button Generar;
        private Label label1;
        private Button BRegresar;
        private Button Adicion;
        private Button Busqueda;
        private Button Eliminacion;
        private Button inOrden;
        private TextBox opciones;
        private Button preOrden;
        private Button postOrden;
        private Label resultados;
    }
}