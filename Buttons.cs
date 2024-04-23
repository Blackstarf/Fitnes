
namespace Fitnes
{
    public partial class Form1 : Form
    {
        Point lastpoint;
        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void CloseWindows(object sender, EventArgs e)
        {
            Close();
        }
        private void MinimizeWindows(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void PanelRegClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = true;
            paneldeleteclient.Visible = false;
            abonementpanel.Visible = false;
            panelchangeclient.Visible = false;
        }

        private void PanelShowClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = true;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = false;
            abonementpanel.Visible = false;
            btReadAll_Click(sender, e);
        }
        private void PanelShowAbonement(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = false;
            abonementpanel.Visible = true;
        }

        private void PanelChangeClient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = false;
            panelchangeclient.Visible = true;
            abonementpanel.Visible = false;
        }

        private void PanelDeleteclient(object sender, EventArgs e)
        {
            panelshowclient.Visible = false;
            panelregclient.Visible = false;
            paneldeleteclient.Visible = true;
            panelchangeclient.Visible = false;
            abonementpanel.Visible = false;
        }
    }
}