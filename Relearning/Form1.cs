namespace Relearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// �N���b�N���̏���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_Click(object sender, EventArgs e)
        {
            var one = 1;
            //var two =2;
            //var three = 3;
            //var four = one + three;

            one++;
            //four++;
            //four--;

            MessageLabel.Text = one.ToString();

        }
        /// <summary>
        /// �}�E�X���ڂ������̃C�x���g
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_MouseHover(object sender, EventArgs e)
        {
            //MessageLabel.Text = "�}�E�X���ڂ�܂���";

        }
        /// <summary>
        /// �}�E�X�����ꂽ���̃C�x���g
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_MouseLeave(object sender, EventArgs e)
        {
            var hello = "����ɂ���";
            var goodNight = "����΂��";

            MessageLabel.Text = hello + goodNight;
        }
    }
}