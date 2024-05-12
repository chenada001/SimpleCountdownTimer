using System;
using Timer = System.Windows.Forms.Timer;

namespace Time
{
    public partial class Form1 : Form
    {
        private int secondsLeft = 100;  // �]�w��l�Ȭ� 100
        private Timer timer;  // �ŧi�p�ɾ�����

        public Form1()
        {
            InitializeComponent(); // ��l�Ƶ�������
            InitializeTimer(); // ��l�ƭp�ɾ�
            label1.Text = secondsLeft.ToString(); // ��ܪ�l�˼Ƭ��
        }
        private void InitializeTimer()
        {
            timer = new Timer(); // �إ߷s���p�ɾ�����
            timer.Interval = 1000; // �C��Ĳ�o�@��
            timer.Tick += timer1_Tick;  // �]�w�p�ɾ�Ĳ�o�ƥ󪺳B�z�禡
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsLeft--;  // ��֭˼Ƭ��
            label1.Text = secondsLeft.ToString();

            if (secondsLeft <= 0)  // �p�G�˼Ƭ�Ƥp�󵥩� 0�A�h����p�ɾ��üu�X�T����
            {
                timer.Stop();
                MessageBox.Show("�ɶ���I");
            }
        }
        // �}�l�˼ƭp�ɪ����s
        private void button1_Click(object sender, EventArgs e)
        {
            secondsLeft = 100;  // ���]�˼Ƭ�Ƭ���l�� 100
            label1.Text = secondsLeft.ToString();  // ��ܪ�l�˼Ƭ��
            timer.Start();  // �Ұʭp�ɾ�
        }
    }
}
