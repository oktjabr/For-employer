using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less12_Sekundomer
{
    class Presenter
    {
        
        Timer timer;
        MainWindow mainWindow;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.timer = new Timer();
            this.mainWindow.StartEvent += StartEventMethod;
            this.mainWindow.StopEvent += StopEventMethod;
            this.mainWindow.RessetEvent += RessetEventMethod;

            this.timer.Ticker += TickerMethod;
        }

        private void TickerMethod()
        {
            this.mainWindow.textBox.Text = this.timer.time.ToString();
            this.timer.Start(true);

        }

        private void RessetEventMethod(object sender, EventArgs e)
        {
            
        }

        private void StopEventMethod(object sender, EventArgs e)
        {
            this.timer.Start(false);
        }

        private void StartEventMethod(object sender, EventArgs e)
        {
            this.timer.Start(true);

        }
    }
}
