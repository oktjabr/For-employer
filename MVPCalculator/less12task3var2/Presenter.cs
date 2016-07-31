using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less12task3var2
{
    class Presenter
    {
        MainWindow mainWindow;
        Model model;
        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.AddEvent += MainWindow_AddEvent;
            this.mainWindow.DivEvent += MainWindow_DivEvent;
            this.mainWindow.MulEvent += MainWindow_MulEvent;
            this.mainWindow.RezzEvent += MainWindow_RezzEvent;
            
        }

        private void MainWindow_Rezult(object sender, EventArgs e)
        {
           
        }

        private void MainWindow_RezzEvent(object sender, EventArgs e)
        {
            this.mainWindow.textBox2.Text = Convert.ToString(model.Rezz(Convert.ToDouble(mainWindow.textBox.Text),(Convert.ToDouble(mainWindow.textBox1.Text))));
        }

        private void MainWindow_MulEvent(object sender, EventArgs e)
        {
           this. mainWindow.textBox2.Text = Convert.ToString(model.Mull(Convert.ToDouble(mainWindow.textBox.Text), (Convert.ToDouble(mainWindow.textBox1.Text))));
        }

        private void MainWindow_DivEvent(object sender, EventArgs e)
        {
            this.mainWindow.textBox2.Text = Convert.ToString(model.Div(Convert.ToDouble(mainWindow.textBox.Text), (Convert.ToDouble(mainWindow.textBox1.Text))));
        }

        private void MainWindow_AddEvent(object sender, EventArgs e)
        {
            this.mainWindow.textBox2.Text = Convert.ToString(model.Add(Convert.ToDouble(mainWindow.textBox.Text), (Convert.ToDouble(mainWindow.textBox1.Text))));
        }
    }
}
