using System;
using Timer = System.Windows.Forms.Timer;

namespace Time
{
    public partial class Form1 : Form
    {
        private int secondsLeft = 100;  // 設定初始值為 100
        private Timer timer;  // 宣告計時器物件

        public Form1()
        {
            InitializeComponent(); // 初始化視窗元件
            InitializeTimer(); // 初始化計時器
            label1.Text = secondsLeft.ToString(); // 顯示初始倒數秒數
        }
        private void InitializeTimer()
        {
            timer = new Timer(); // 建立新的計時器物件
            timer.Interval = 1000; // 每秒觸發一次
            timer.Tick += timer1_Tick;  // 設定計時器觸發事件的處理函式
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsLeft--;  // 減少倒數秒數
            label1.Text = secondsLeft.ToString();

            if (secondsLeft <= 0)  // 如果倒數秒數小於等於 0，則停止計時器並彈出訊息框
            {
                timer.Stop();
                MessageBox.Show("時間到！");
            }
        }
        // 開始倒數計時的按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            secondsLeft = 100;  // 重設倒數秒數為初始值 100
            label1.Text = secondsLeft.ToString();  // 顯示初始倒數秒數
            timer.Start();  // 啟動計時器
        }
    }
}
