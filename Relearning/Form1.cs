namespace Relearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// クリック時の処理
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
        /// マウスが載った時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_MouseHover(object sender, EventArgs e)
        {
            //MessageLabel.Text = "マウスが載りました";

        }
        /// <summary>
        /// マウスが離れた時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionButton_MouseLeave(object sender, EventArgs e)
        {
            var hello = "こんにちは";
            var goodNight = "こんばんは";

            MessageLabel.Text = hello + goodNight;
        }
    }
}