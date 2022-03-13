
namespace CalculadoraForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.SalidaText = new System.Windows.Forms.TextBox();
            this.igual = new System.Windows.Forms.Button();
            this.BorrarTodo = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.Borrar1 = new System.Windows.Forms.Button();
            this.masmenos = new System.Windows.Forms.Button();
            this.Borrar2 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.fraccion = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.exponencial = new System.Windows.Forms.Button();
            this.dos = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.uno = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.siete = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.ocho = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.nueve = new System.Windows.Forms.Button();
            this.cuatro = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuVertical.BackColor = System.Drawing.Color.Black;
            this.MenuVertical.Controls.Add(this.Resultado);
            this.MenuVertical.Controls.Add(this.SalidaText);
            this.MenuVertical.Controls.Add(this.igual);
            this.MenuVertical.Controls.Add(this.BorrarTodo);
            this.MenuVertical.Controls.Add(this.cero);
            this.MenuVertical.Controls.Add(this.Modulo);
            this.MenuVertical.Controls.Add(this.punto);
            this.MenuVertical.Controls.Add(this.Borrar1);
            this.MenuVertical.Controls.Add(this.masmenos);
            this.MenuVertical.Controls.Add(this.Borrar2);
            this.MenuVertical.Controls.Add(this.suma);
            this.MenuVertical.Controls.Add(this.fraccion);
            this.MenuVertical.Controls.Add(this.tres);
            this.MenuVertical.Controls.Add(this.exponencial);
            this.MenuVertical.Controls.Add(this.dos);
            this.MenuVertical.Controls.Add(this.raiz);
            this.MenuVertical.Controls.Add(this.uno);
            this.MenuVertical.Controls.Add(this.dividir);
            this.MenuVertical.Controls.Add(this.resta);
            this.MenuVertical.Controls.Add(this.siete);
            this.MenuVertical.Controls.Add(this.seis);
            this.MenuVertical.Controls.Add(this.ocho);
            this.MenuVertical.Controls.Add(this.cinco);
            this.MenuVertical.Controls.Add(this.nueve);
            this.MenuVertical.Controls.Add(this.cuatro);
            this.MenuVertical.Controls.Add(this.multiplicar);
            this.MenuVertical.Location = new System.Drawing.Point(11, 11);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(416, 655);
            this.MenuVertical.TabIndex = 44;
            // 
            // Resultado
            // 
            this.Resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Resultado.BackColor = System.Drawing.Color.Black;
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Resultado.Location = new System.Drawing.Point(13, 88);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(392, 123);
            this.Resultado.TabIndex = 37;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // SalidaText
            // 
            this.SalidaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalidaText.BackColor = System.Drawing.Color.Black;
            this.SalidaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalidaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalidaText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SalidaText.Location = new System.Drawing.Point(13, 22);
            this.SalidaText.Multiline = true;
            this.SalidaText.Name = "SalidaText";
            this.SalidaText.ReadOnly = true;
            this.SalidaText.Size = new System.Drawing.Size(392, 51);
            this.SalidaText.TabIndex = 36;
            this.SalidaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SalidaText.TextChanged += new System.EventHandler(this.SalidaText_TextChanged);
            // 
            // igual
            // 
            this.igual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.igual.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.igual.Location = new System.Drawing.Point(306, 582);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(97, 65);
            this.igual.TabIndex = 34;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // BorrarTodo
            // 
            this.BorrarTodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrarTodo.BackColor = System.Drawing.SystemColors.InfoText;
            this.BorrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.BorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarTodo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BorrarTodo.Location = new System.Drawing.Point(115, 227);
            this.BorrarTodo.Name = "BorrarTodo";
            this.BorrarTodo.Size = new System.Drawing.Size(97, 65);
            this.BorrarTodo.TabIndex = 25;
            this.BorrarTodo.Text = "CE";
            this.BorrarTodo.UseVisualStyleBackColor = false;
            this.BorrarTodo.Click += new System.EventHandler(this.BorrarTodo_Click);
            // 
            // cero
            // 
            this.cero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cero.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cero.Location = new System.Drawing.Point(115, 582);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(97, 65);
            this.cero.TabIndex = 33;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // Modulo
            // 
            this.Modulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Modulo.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Modulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modulo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Modulo.Location = new System.Drawing.Point(18, 227);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(97, 65);
            this.Modulo.TabIndex = 22;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.Modulo_Click);
            // 
            // punto
            // 
            this.punto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.punto.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.punto.Location = new System.Drawing.Point(212, 582);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(97, 65);
            this.punto.TabIndex = 32;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // Borrar1
            // 
            this.Borrar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Borrar1.BackColor = System.Drawing.SystemColors.InfoText;
            this.Borrar1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Borrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Borrar1.Location = new System.Drawing.Point(212, 227);
            this.Borrar1.Name = "Borrar1";
            this.Borrar1.Size = new System.Drawing.Size(97, 65);
            this.Borrar1.TabIndex = 12;
            this.Borrar1.Text = "C";
            this.Borrar1.UseVisualStyleBackColor = false;
            this.Borrar1.Click += new System.EventHandler(this.Borrar1_Click);
            // 
            // masmenos
            // 
            this.masmenos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masmenos.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.masmenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masmenos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.masmenos.Location = new System.Drawing.Point(18, 582);
            this.masmenos.Name = "masmenos";
            this.masmenos.Size = new System.Drawing.Size(97, 65);
            this.masmenos.TabIndex = 31;
            this.masmenos.Text = "+/-";
            this.masmenos.UseVisualStyleBackColor = true;
            // 
            // Borrar2
            // 
            this.Borrar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Borrar2.BackColor = System.Drawing.SystemColors.InfoText;
            this.Borrar2.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.Borrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Borrar2.Location = new System.Drawing.Point(306, 227);
            this.Borrar2.Name = "Borrar2";
            this.Borrar2.Size = new System.Drawing.Size(97, 65);
            this.Borrar2.TabIndex = 13;
            this.Borrar2.Text = "BORRAR";
            this.Borrar2.UseVisualStyleBackColor = false;
            this.Borrar2.Click += new System.EventHandler(this.Borrar2_Click);
            // 
            // suma
            // 
            this.suma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.suma.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suma.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.suma.Location = new System.Drawing.Point(306, 511);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(97, 65);
            this.suma.TabIndex = 30;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // fraccion
            // 
            this.fraccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fraccion.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.fraccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fraccion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.fraccion.Location = new System.Drawing.Point(18, 298);
            this.fraccion.Name = "fraccion";
            this.fraccion.Size = new System.Drawing.Size(97, 65);
            this.fraccion.TabIndex = 14;
            this.fraccion.Text = "1/x";
            this.fraccion.UseVisualStyleBackColor = true;
            this.fraccion.Click += new System.EventHandler(this.fraccion_Click);
            // 
            // tres
            // 
            this.tres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tres.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.tres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tres.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.tres.Location = new System.Drawing.Point(212, 511);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(97, 65);
            this.tres.TabIndex = 29;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // exponencial
            // 
            this.exponencial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exponencial.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.exponencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exponencial.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.exponencial.Location = new System.Drawing.Point(115, 298);
            this.exponencial.Name = "exponencial";
            this.exponencial.Size = new System.Drawing.Size(97, 65);
            this.exponencial.TabIndex = 15;
            this.exponencial.Text = " X2";
            this.exponencial.UseVisualStyleBackColor = true;
            this.exponencial.Click += new System.EventHandler(this.exponencial_Click);
            // 
            // dos
            // 
            this.dos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dos.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.dos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dos.Location = new System.Drawing.Point(115, 511);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(97, 65);
            this.dos.TabIndex = 28;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.dos_Click);
            // 
            // raiz
            // 
            this.raiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.raiz.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiz.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.raiz.Location = new System.Drawing.Point(212, 298);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(97, 65);
            this.raiz.TabIndex = 16;
            this.raiz.Text = "RAIZ";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // uno
            // 
            this.uno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uno.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.uno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uno.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.uno.Location = new System.Drawing.Point(18, 511);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(97, 65);
            this.uno.TabIndex = 27;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.uno_Click);
            // 
            // dividir
            // 
            this.dividir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dividir.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dividir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dividir.Location = new System.Drawing.Point(306, 298);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(97, 65);
            this.dividir.TabIndex = 17;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // resta
            // 
            this.resta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resta.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.resta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resta.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.resta.Location = new System.Drawing.Point(306, 440);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(97, 65);
            this.resta.TabIndex = 26;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // siete
            // 
            this.siete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siete.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.siete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siete.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.siete.Location = new System.Drawing.Point(18, 369);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(97, 65);
            this.siete.TabIndex = 18;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.siete_Click);
            // 
            // seis
            // 
            this.seis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seis.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.seis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seis.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.seis.Location = new System.Drawing.Point(212, 440);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(97, 65);
            this.seis.TabIndex = 24;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // ocho
            // 
            this.ocho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ocho.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.ocho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocho.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ocho.Location = new System.Drawing.Point(115, 369);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(97, 65);
            this.ocho.TabIndex = 19;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ocho_Click);
            // 
            // cinco
            // 
            this.cinco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cinco.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cinco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinco.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cinco.Location = new System.Drawing.Point(115, 440);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(97, 65);
            this.cinco.TabIndex = 23;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // nueve
            // 
            this.nueve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nueve.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.nueve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nueve.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueve.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nueve.Location = new System.Drawing.Point(212, 369);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(97, 65);
            this.nueve.TabIndex = 20;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.nueve_Click);
            // 
            // cuatro
            // 
            this.cuatro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuatro.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.cuatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuatro.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.cuatro.Location = new System.Drawing.Point(18, 440);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(97, 65);
            this.cuatro.TabIndex = 11;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.cuatro_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplicar.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.multiplicar.Location = new System.Drawing.Point(306, 369);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(97, 65);
            this.multiplicar.TabIndex = 21;
            this.multiplicar.Text = "X";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(438, 677);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.TextBox SalidaText;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button BorrarTodo;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button Borrar1;
        private System.Windows.Forms.Button masmenos;
        private System.Windows.Forms.Button Borrar2;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button fraccion;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button exponencial;
        private System.Windows.Forms.Button dos;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button uno;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button siete;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button ocho;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button nueve;
        private System.Windows.Forms.Button cuatro;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.TextBox Resultado;
    }
}

