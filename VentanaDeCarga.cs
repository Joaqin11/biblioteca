using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CopiaDeBiblio
{
    public partial class VentanaDeCarga : Form
    {
        public AutoCompleteStringCollection autoCompletDni;
        public AutoCompleteStringCollection autoCompletCodPat;
        public DateTime fechaDev;
        public VentanaDeCarga()
        {
            InitializeComponent();
            autoCompletDni = new AutoCompleteStringCollection();
            autoCompletCodPat = new AutoCompleteStringCollection();
            autoCompletDni = Form1.autoCompleteDni;
            autoCompletCodPat = Form1.autoCompleteCodPat;
        }

        private void VentanaDeCarga_Load(object sender, EventArgs e)
        {
            tbxBuscarDni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxBuscarDni.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxBuscarDni.AutoCompleteCustomSource = autoCompletDni;

            tbxBuscarCodPat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxBuscarCodPat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxBuscarCodPat.AutoCompleteCustomSource = autoCompletCodPat;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (DateTime.Now != monthCalendar1.SelectionRange.Start)
            {
                fechaDev = monthCalendar1.SelectionRange.Start;
            }
            else
            {
                //fechaDev = null en este caso tendria que estar igualado todo a cero!
            }
        }
    }
}
