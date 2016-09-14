using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public delegate void delegadoTimeUp( object sender, timeUpEventArgs e);

    public partial class UsrAlarma : UserControl
    {
        public event delegadoTimeUp TiempoAgotado;
        private bool _activada;

        public bool Activada
        {
            get { return _activada; }
            set
            { 
                _activada = value;
                if (_activada)
                {
                    this._fechaHoraAlarma = Convert.ToDateTime(this.txtFechaValidaExt1.Text);
                    this.tmrTimer.Enabled = true;                    
                    this.IniciarTemporizador();
                }
                else
                {
                    this.PararTemporizador();
                }

            }
        }

        private DateTime _fechaHoraAlarma;

        public DateTime FechaHoraAlarma
        {
            get { return _fechaHoraAlarma; }
            set { _fechaHoraAlarma = value; }
        }        
        
        public UsrAlarma()
        {
            InitializeComponent();

            this.tmrTimer.Tick += tmrTimer_Tick;
        }

        void tmrTimer_Tick(object sender, EventArgs e)
        {
            this.tmrTimer.Stop();
            this.TiempoAgotado(this, new timeUpEventArgs());
        }

        private void IniciarTemporizador() 
        {
            
            TimeSpan intervalo = this._fechaHoraAlarma - DateTime.Now;

            if (intervalo.Milliseconds > 0)
            {
                this.tmrTimer.Interval=(int) intervalo.TotalMilliseconds;
                this.tmrTimer.Start();
            }
            
        }

        private void PararTemporizador()
        {
            this.tmrTimer.Stop();

        }

        private void rdoFechaHoraAlarma_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFechaHoraAlarma.Checked)
            {
                this.txtFechaValidaExt1.Text = this._fechaHoraAlarma.ToString();
            }
            else
            {
                this.txtFechaValidaExt1.Text = DateTime.Now.ToString();

            }
        }

        

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Activada = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.PararTemporizador();
        }

       



        



       
    }
}
