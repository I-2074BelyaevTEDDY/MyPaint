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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.соСканераЛиКамерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.сделатьФономРабочегоСтолаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растянутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замоститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пОЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button4);
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
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 142);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(790, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 45);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnOval_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(496, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 45);
            this.button3.TabIndex = 18;
            this.button3.Text = "Фломастер";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnMarker_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(910, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Кисть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(280, 93);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 45);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.White;
            this.btnText.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.Location = new System.Drawing.Point(174, 93);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(100, 45);
            this.btnText.TabIndex = 13;
            this.btnText.Text = "Текст";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.White;
            this.btnPencil.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPencil.Location = new System.Drawing.Point(600, 93);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(98, 45);
            this.btnPencil.TabIndex = 12;
            this.btnPencil.Text = "Карандаш";
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.White;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(790, 94);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(114, 45);
            this.btnEllipse.TabIndex = 11;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRect
            // 
            this.btnRect.BackColor = System.Drawing.Color.White;
            this.btnRect.Image = ((System.Drawing.Image)(resources.GetObject("btnRect.Image")));
            this.btnRect.Location = new System.Drawing.Point(910, 94);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(112, 45);
            this.btnRect.TabIndex = 10;
            this.btnRect.UseVisualStyleBackColor = false;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(704, 44);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(80, 92);
            this.btnLine.TabIndex = 9;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.BackColor = System.Drawing.Color.White;
            this.btnBucket.Image = ((System.Drawing.Image)(resources.GetObject("btnBucket.Image")));
            this.btnBucket.Location = new System.Drawing.Point(280, 43);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(210, 45);
            this.btnBucket.TabIndex = 8;
            this.btnBucket.UseVisualStyleBackColor = false;
            this.btnBucket.Click += new System.EventHandler(this.btnBucket_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(12, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(174, 43);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(45, 45);
            this.btnRed.TabIndex = 6;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnPalette
            // 
            this.btnPalette.BackColor = System.Drawing.Color.White;
            this.btnPalette.Image = ((System.Drawing.Image)(resources.GetObject("btnPalette.Image")));
            this.btnPalette.Location = new System.Drawing.Point(93, 43);
            this.btnPalette.Name = "btnPalette";
            this.btnPalette.Size = new System.Drawing.Size(75, 45);
            this.btnPalette.TabIndex = 5;
            this.btnPalette.UseVisualStyleBackColor = false;
            this.btnPalette.Click += new System.EventHandler(this.btnPalette_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.White;
            this.btnEraser.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEraser.Location = new System.Drawing.Point(496, 91);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(98, 45);
            this.btnEraser.TabIndex = 2;
            this.btnEraser.Text = "Ластик";
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(225, 43);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(49, 45);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Blue;
            this.trackBar1.Location = new System.Drawing.Point(12, 91);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(156, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.главнаяToolStripMenuItem,
            this.идToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 29);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripMenuItem1,
            this.печатьToolStripMenuItem,
            this.соСканераЛиКамерыToolStripMenuItem,
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem,
            this.toolStripMenuItem2,
            this.сделатьФономРабочегоСтолаToolStripMenuItem,
            this.toolStripMenuItem3,
            this.свойстваToolStripMenuItem,
            this.toolStripMenuItem4,
            this.оПрограммеToolStripMenuItem,
            this.toolStripMenuItem5,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.открытьToolStripMenuItem.Text = "Открыть ";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
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
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // изображениеВФорматеToolStripMenuItem
            // 
            this.изображениеВФорматеToolStripMenuItem.Name = "изображениеВФорматеToolStripMenuItem";
            this.изображениеВФорматеToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.изображениеВФорматеToolStripMenuItem.Text = "Изображение в формате PNG";
            // 
            // изображениеВФорматеToolStripMenuItem1
            // 
            this.изображениеВФорматеToolStripMenuItem1.Name = "изображениеВФорматеToolStripMenuItem1";
            this.изображениеВФорматеToolStripMenuItem1.Size = new System.Drawing.Size(342, 26);
            this.изображениеВФорматеToolStripMenuItem1.Text = "Изображение в формате JPEG";
            // 
            // изображениеВФорматеToolStripMenuItem2
            // 
            this.изображениеВФорматеToolStripMenuItem2.Name = "изображениеВФорматеToolStripMenuItem2";
            this.изображениеВФорматеToolStripMenuItem2.Size = new System.Drawing.Size(342, 26);
            this.изображениеВФорматеToolStripMenuItem2.Text = "Изображение в формате BMP";
            // 
            // изображениеВФорматеToolStripMenuItem3
            // 
            this.изображениеВФорматеToolStripMenuItem3.Name = "изображениеВФорматеToolStripMenuItem3";
            this.изображениеВФорматеToolStripMenuItem3.Size = new System.Drawing.Size(342, 26);
            this.изображениеВФорматеToolStripMenuItem3.Text = "Изображение в формате GIF";
            // 
            // другиеФорматыToolStripMenuItem
            // 
            this.другиеФорматыToolStripMenuItem.Name = "другиеФорматыToolStripMenuItem";
            this.другиеФорматыToolStripMenuItem.Size = new System.Drawing.Size(342, 26);
            this.другиеФорматыToolStripMenuItem.Text = "Другие форматы";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(343, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.печатьToolStripMenuItem1,
            this.параметрыСтраницыToolStripMenuItem,
            this.предварительныйПросмотрToolStripMenuItem});
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // печатьToolStripMenuItem1
            // 
            this.печатьToolStripMenuItem1.Name = "печатьToolStripMenuItem1";
            this.печатьToolStripMenuItem1.Size = new System.Drawing.Size(304, 26);
            this.печатьToolStripMenuItem1.Text = "Печать";
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы ";
            // 
            // предварительныйПросмотрToolStripMenuItem
            // 
            this.предварительныйПросмотрToolStripMenuItem.Name = "предварительныйПросмотрToolStripMenuItem";
            this.предварительныйПросмотрToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.предварительныйПросмотрToolStripMenuItem.Text = "Предварительный просмотр";
            // 
            // соСканераЛиКамерыToolStripMenuItem
            // 
            this.соСканераЛиКамерыToolStripMenuItem.Name = "соСканераЛиКамерыToolStripMenuItem";
            this.соСканераЛиКамерыToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.соСканераЛиКамерыToolStripMenuItem.Text = "Со сканера ли камеры";
            // 
            // отправитьПоЭлектроннойПочтеToolStripMenuItem
            // 
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Name = "отправитьПоЭлектроннойПочтеToolStripMenuItem";
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.отправитьПоЭлектроннойПочтеToolStripMenuItem.Text = "Отправить по электронной почте";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(343, 6);
            // 
            // сделатьФономРабочегоСтолаToolStripMenuItem
            // 
            this.сделатьФономРабочегоСтолаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.растянутьToolStripMenuItem,
            this.замоститьToolStripMenuItem,
            this.пОЦентруToolStripMenuItem});
            this.сделатьФономРабочегоСтолаToolStripMenuItem.Name = "сделатьФономРабочегоСтолаToolStripMenuItem";
            this.сделатьФономРабочегоСтолаToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.сделатьФономРабочегоСтолаToolStripMenuItem.Text = "Сделать фоном рабочего стола";
            // 
            // растянутьToolStripMenuItem
            // 
            this.растянутьToolStripMenuItem.Name = "растянутьToolStripMenuItem";
            this.растянутьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.растянутьToolStripMenuItem.Text = "Растянуть ";
            // 
            // замоститьToolStripMenuItem
            // 
            this.замоститьToolStripMenuItem.Name = "замоститьToolStripMenuItem";
            this.замоститьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.замоститьToolStripMenuItem.Text = "Замостить";
            // 
            // пОЦентруToolStripMenuItem
            // 
            this.пОЦентруToolStripMenuItem.Name = "пОЦентруToolStripMenuItem";
            this.пОЦентруToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.пОЦентруToolStripMenuItem.Text = "По центру";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(343, 6);
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(343, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(343, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // идToolStripMenuItem
            // 
            this.идToolStripMenuItem.Font = new System.Drawing.Font("Broadway", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.идToolStripMenuItem.Name = "идToolStripMenuItem";
            this.идToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.идToolStripMenuItem.Text = "Вид";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1251, 469);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint-Безымянный";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.ToolStripMenuItem соСканераЛиКамерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьПоЭлектроннойПочтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сделатьФономРабочегоСтолаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растянутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замоститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пОЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

