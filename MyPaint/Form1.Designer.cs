namespace MyPaint
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnBucket = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnPalette = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеВФорматеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеВФорматеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеВФорматеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изображениеВФорматеToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.другиеФорматыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйПросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соСканераИлиКамерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьПоЭлектроннойПрочтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.сделатьФономРабочегоСтолаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растянутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замоститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnText);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnRect);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnBucket);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRed);
            this.panel1.Controls.Add(this.btnPalette);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnBlack);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 114);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(122, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 45);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.White;
            this.btnText.Location = new System.Drawing.Point(12, 63);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(104, 45);
            this.btnText.TabIndex = 13;
            this.btnText.Text = "Текст";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.White;
            this.btnPencil.Location = new System.Drawing.Point(471, 12);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(75, 45);
            this.btnPencil.TabIndex = 12;
            this.btnPencil.Text = "Карандаш";
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.White;
            this.btnEllipse.Location = new System.Drawing.Point(471, 62);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(75, 45);
            this.btnEllipse.TabIndex = 11;
            this.btnEllipse.Text = "Круг";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.Color.White;
            this.btnRect.Location = new System.Drawing.Point(390, 62);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(75, 45);
            this.btnRect.TabIndex = 10;
            this.btnRect.Text = "Прямоугольник";
            this.btnRect.UseVisualStyleBackColor = false;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Location = new System.Drawing.Point(309, 62);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 45);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "Линия";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.BackColor = System.Drawing.Color.White;
            this.btnBucket.Location = new System.Drawing.Point(228, 62);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(75, 45);
            this.btnBucket.TabIndex = 8;
            this.btnBucket.Text = "Заливка";
            this.btnBucket.UseVisualStyleBackColor = false;
            this.btnBucket.Click += new System.EventHandler(this.btnBucket_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(390, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(177, 12);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(45, 45);
            this.btnRed.TabIndex = 6;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnPalette
            // 
            this.btnPalette.BackColor = System.Drawing.Color.White;
            this.btnPalette.Location = new System.Drawing.Point(228, 12);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(75, 45);
            this.btnPalette.TabIndex = 5;
            this.btnPalette.Text = "Палитра";
            this.btnPalette.UseVisualStyleBackColor = false;
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.White;
            this.btnEraser.Location = new System.Drawing.Point(309, 12);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(75, 45);
            this.btnEraser.TabIndex = 2;
            this.btnEraser.Text = "Ластик";
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(122, 12);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(49, 45);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Blue;
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1411, 441);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.главнаяToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1411, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripMenuItem1,
            this.печатьToolStripMenuItem,
            this.соСканераИлиКамерыToolStripMenuItem,
            this.отправитьПоЭлектроннойПрочтеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.сделатьФономРабочегоСтолаToolStripMenuItem,
            this.toolStripMenuItem3,
            this.свойстваToolStripMenuItem,
            this.toolStripMenuItem4,
            this.оПрограммеToolStripMenuItem,
            this.toolStripMenuItem5,
            this.выходToolStripMenuItem,
            this.toolStripMenuItem6});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изображениеВФорматеToolStripMenuItem,
            this.изображениеВФорматеToolStripMenuItem1,
            this.изображениеВФорматеToolStripMenuItem2,
            this.изображениеВФорматеToolStripMenuItem3,
            this.другиеФорматыToolStripMenuItem});
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // изображениеВФорматеToolStripMenuItem
            // 
            this.изображениеВФорматеToolStripMenuItem.Name = "изображениеВФорматеToolStripMenuItem";
            this.изображениеВФорматеToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.изображениеВФорматеToolStripMenuItem.Text = "Изображение в формате PNG";
            // 
            // изображениеВФорматеToolStripMenuItem1
            // 
            this.изображениеВФорматеToolStripMenuItem1.Name = "изображениеВФорматеToolStripMenuItem1";
            this.изображениеВФорматеToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
            this.изображениеВФорматеToolStripMenuItem1.Text = "Изображение в формате JPEG";
            // 
            // изображениеВФорматеToolStripMenuItem2
            // 
            this.изображениеВФорматеToolStripMenuItem2.Name = "изображениеВФорматеToolStripMenuItem2";
            this.изображениеВФорматеToolStripMenuItem2.Size = new System.Drawing.Size(239, 22);
            this.изображениеВФорматеToolStripMenuItem2.Text = "Изображение в формате BMP";
            // 
            // изображениеВФорматеToolStripMenuItem3
            // 
            this.изображениеВФорматеToolStripMenuItem3.Name = "изображениеВФорматеToolStripMenuItem3";
            this.изображениеВФорматеToolStripMenuItem3.Size = new System.Drawing.Size(239, 22);
            this.изображениеВФорматеToolStripMenuItem3.Text = "Изображение в формате GIF";
            // 
            // другиеФорматыToolStripMenuItem
            // 
            this.другиеФорматыToolStripMenuItem.Name = "другиеФорматыToolStripMenuItem";
            this.другиеФорматыToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.другиеФорматыToolStripMenuItem.Text = "Другие форматы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem1,
            this.параметрыСтраницыToolStripMenuItem,
            this.предварительныйПросмотрToolStripMenuItem});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // печатьToolStripMenuItem1
            // 
            this.печатьToolStripMenuItem1.Name = "печатьToolStripMenuItem1";
            this.печатьToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.печатьToolStripMenuItem1.Text = "Печать";
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы";
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            this.предварительныйПросмотрToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            this.предварительныйПросмотрToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.предварительныйПросмотрToolStripMenuItem.Text = "Предварительный просмотр";
            // 
            // соСканераИлиКамерыToolStripMenuItem
            // 
            this.соСканераИлиКамерыToolStripMenuItem.Name = "соСканераИлиКамерыToolStripMenuItem";
            this.соСканераИлиКамерыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.соСканераИлиКамерыToolStripMenuItem.Text = "Со сканера или камеры";
            // 
            // отправитьПоЭлектроннойПрочтеToolStripMenuItem
            // 
            this.отправитьПоЭлектроннойПрочтеToolStripMenuItem.Name = "отправитьПоЭлектроннойПрочтеToolStripMenuItem";
            this.отправитьПоЭлектроннойПрочтеToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.отправитьПоЭлектроннойПрочтеToolStripMenuItem.Text = "Отправить по электронной прочте";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 6);
            // 
            // сделатьФономРабочегоСтолаToolStripMenuItem
            // 
            this.сделатьФономРабочегоСтолаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.растянутьToolStripMenuItem,
            this.замоститьToolStripMenuItem,
            this.поЦентруToolStripMenuItem});
            this.сделатьФономРабочегоСтолаToolStripMenuItem.Name = "сделатьФономРабочегоСтолаToolStripMenuItem";
            this.сделатьФономРабочегоСтолаToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.сделатьФономРабочегоСтолаToolStripMenuItem.Text = "Сделать фоном рабочего стола";
            // 
            // растянутьToolStripMenuItem
            // 
            this.растянутьToolStripMenuItem.Name = "растянутьToolStripMenuItem";
            this.растянутьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.растянутьToolStripMenuItem.Text = "Растянуть ";
            // 
            // замоститьToolStripMenuItem
            // 
            this.замоститьToolStripMenuItem.Name = "замоститьToolStripMenuItem";
            this.замоститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.замоститьToolStripMenuItem.Text = "Замостить";
            // 
            // поЦентруToolStripMenuItem
            // 
            this.поЦентруToolStripMenuItem.Name = "поЦентруToolStripMenuItem";
            this.поЦентруToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поЦентруToolStripMenuItem.Text = "По центру ";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(263, 6);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(263, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(263, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(263, 6);
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(552, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ручка";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(552, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Кисть";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(633, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "Фломастер";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Безымянный-Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnPalette;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnBucket;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеВФорматеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изображениеВФорматеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изображениеВФорматеToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изображениеВФорматеToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem другиеФорматыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйПросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соСканераИлиКамерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьПоЭлектроннойПрочтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сделатьФономРабочегоСтолаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растянутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замоститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

