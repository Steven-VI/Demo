using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    double timerTt1 = 10.0D;
    DateTime timeToLive;
    int cacheValue;
    Timer timer1;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        lblTimer.Text = $"Timer TTL {timerTt1} sec (Stopped)";

    }

    private void timer1_Tick(object sender, EventArgs e) {
        if (timerTt1 == 0)
            timerTt1 = 5;
        else
            timerTt1 -= 1;
        lblTimer.Text = $"Timer TTL {timerTt1} sec (Running)";
    }

    protected async Task<int> GetValue(){
        await Task.Delay(1000);
        Random r = new Random();
        cacheValue = r.Next();
        timeToLive = DateTime.Now.AddSeconds(timerTt1);
        timer1.Start();
        return cacheValue;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        int getal1 = int.Parse(entry1.Text);
        int getal2 = int.Parse(entry2.Text);

        char[] carray = entry3.Text.ToCharArray();

        StringBuilder reverse = new StringBuilder();
       
        for (int i = carray.Length; i >= 0; i--)
        {
            reverse.Append(carray[i]);
        }

        label3.Text = string.Concat("{1} {0}", reverse, (getal1 + getal2).ToString());
    }
}
