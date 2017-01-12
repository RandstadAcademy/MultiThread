using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        private Uri _WebAddress = new Uri( "http://www.libero.it");
        SynchronizationContext _SynCtx = null;

        public Form1()
        {
            InitializeComponent();

            _SynCtx = SynchronizationContext.Current;
        }

        private void SetText(byte[] bytes)
        {
            txtContent.Text = "";
            txtContent.Text = System.Text.ASCIIEncoding.ASCII.GetString( bytes);
        }
        private void SetText( string text)
        {
            txtContent.Text = "";
            txtContent.Text = text;
        }

        private void cmdGetWeb_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep( 5000);
            WebClient wcGet = new WebClient();
            byte[] wcBytes = wcGet.DownloadData(this._WebAddress);

            txtContent.Text = System.Text.ASCIIEncoding.ASCII.GetString(wcBytes);
        }

        private async void cmdGetWebAsync_Click(object sender, EventArgs e)
        {

            #region Asynchronous Method 1 - Legacy
            //Thread Th = new Thread(GetWebContent);
            //Th.Start();
            #endregion

            #region Asynchronous Method 2
            //Task<string> Th1 = new Task<string>(GetWebContent2);

            //Task T2 = Th1.ContinueWith((previousTask) =>
            //    {
            //        txtContent.Text = previousTask.Result;

            //    }, TaskScheduler.FromCurrentSynchronizationContext());

            //Th1.Start();
            #endregion


            WebClient wcGet = new WebClient();

            #region Asynchronous Method 3
            //wcGet.DownloadDataAsync( this._WebAddress);
            //wcGet.DownloadDataCompleted += WcGet_DownloadDataCompleted;
            #endregion

            #region Asynchronous Mehtod 4
            byte[] wcBytes = await wcGet.DownloadDataTaskAsync(this._WebAddress);
            SetText( wcBytes);
            #endregion

        }

        private void GetWebContent()
        {
            System.Threading.Thread.Sleep(5000);

            _SynCtx.Send( SetLabel, "Downloading");
            WebClient wcGet = new WebClient();
            byte[] wcBytes = wcGet.DownloadData(this._WebAddress);

            _SynCtx.Send( SetText, wcBytes);

            _SynCtx.Send(SetLabel, "Downloaded");
        }
        private string GetWebContent2()
        {
            WebClient wcGet = new WebClient();
            byte[] wcBytes = wcGet.DownloadData(this._WebAddress);

            return System.Text.ASCIIEncoding.ASCII.GetString( wcBytes);
        }

        private void SetLabel(object state)
        {
            lblWork.Text = (string)state;
        }

        private void SetText(object state)
        {
            SetText( (byte[])state);
        }

        private void WcGet_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            lock (txtContent)
            {
                SetText(e.Result);
            }
        }
    }
}
